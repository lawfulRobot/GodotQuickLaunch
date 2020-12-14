using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace GodotQuickLaunch
{
    public partial class Form1 : Form
    {
        private const string RegistryValueProjectsDirectory = "ProjectsDirectory";
        private const string RegistryKeyAppName             = "GodotQuickLaunch";
        private const string RegistryValueRunOnStartup      = "RunOnStartup";
        private const string RegistryValueGodotPath         = "GodotPath";

        private string projectsDirectory = "";
        private string godotPath         = "";

        public Form1()
        {
            InitializeComponent();

            // Get saved data from registry
            RegistryKey savedData = Registry.CurrentUser.OpenSubKey(RegistryKeyAppName);
            if(savedData != null)
            {
                if (savedData.GetValue(RegistryValueRunOnStartup) != null)
                {
                    runOnStartupCheckBox.Checked = Convert.ToBoolean(savedData.GetValue(RegistryValueRunOnStartup));
                }
                string savedGodotPath = (string)savedData.GetValue(RegistryValueGodotPath);
                if (!string.IsNullOrWhiteSpace(savedGodotPath))
                {
                    godotPath = savedGodotPath;
                    godotPathTextBox.Text = savedGodotPath;
                }
                string savedProjectsPath = (string)savedData.GetValue(RegistryValueProjectsDirectory);
                if (!string.IsNullOrWhiteSpace(savedProjectsPath))
                {
                    projectsDirectory = savedProjectsPath;
                    projectsDirectoryTextBox.Text = savedProjectsPath;
                }
                
                savedData.Close();
                WindowState = FormWindowState.Minimized;
            }
            SetupProjectsList();
            ShowInTaskbar = false;
        }

        private void SetupProjectsList()
        {
            trayContextMenuStrip.Items.Clear();
            // Check if projects path is assigned
            if(!string.IsNullOrWhiteSpace(projectsDirectory))
            {
                projectsDirectory = FormatPath(projectsDirectory);
                // Get all the folders in projects path
                string[] dirs = Directory.GetDirectories(projectsDirectory, "*", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < dirs.Length; i++)
                {
                    // Split the path
                    string[] splitPath = dirs[i].Split('\\');
                    // Get project folder name
                    string projectName = splitPath[splitPath.Length - 1];
                    // Ignore folders starting with a dot
                    if (!projectName.StartsWith("."))
                    {
                        // Verify that the folder is a Godot project by checking if a project.godot file exists inside and add an entry to the context menu strip
                        if(File.Exists(dirs[i] + @"\project.godot"))
                            trayContextMenuStrip.Items.Add(projectName);
                    }
                }
                trayContextMenuStrip.Items.Add(new ToolStripSeparator());
            }
            // Add context menu strip items for launch godot, settings and exit
            if(!string.IsNullOrWhiteSpace(godotPathTextBox.Text))
            {
                trayContextMenuStrip.Items.Add("Launch Godot");
            }
            trayContextMenuStrip.Items.Add("Settings");
            trayContextMenuStrip.Items.Add("Exit");
        }

        // Add a slash at the end of the projects path if there isn't one
        private string FormatPath(string p) => p.EndsWith(@"\") ? p : p + @"\";

        private void TrayContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text.ToLower())
            {
                case "exit":
                    Application.Exit();
                    break;
                case "settings":
                    OpenSettings();
                    break;
                case "launch godot":
                    RunGodot();
                    break;
                default:
                    // If a path to Godot exists start a process with it
                    if(!string.IsNullOrWhiteSpace(godotPath))
                    {
                        // Wrap the project path in quotes in case there are spaces
                        // Passing a path with spaces as an argument to Godot doesn't work and just launches the project picker instead
                        string path = "\"" + projectsDirectory + e.ClickedItem.Text + @"\project.godot" + "\"";
                        ProcessStartInfo startInfo = new ProcessStartInfo(godotPath)
                        {
                            Arguments = path
                        };
                        Process.Start(startInfo);
                    }
                    // Otherwise run project.godot with the default program associated with .godot files
                    else
                    {
                        Process.Start(projectsDirectory + e.ClickedItem.Text + @"\project.godot");
                    }
                    break;
            }
        }

        private void RunGodot()
        {
            Process.Start(godotPath);
        }


        private void OpenSettings()
        {
            projectsDirectoryTextBox.Text = projectsDirectory;
            godotPathTextBox.Text = godotPath;
            WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }
        private void TrayContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            SetupProjectsList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            projectsDirectory = projectsDirectoryTextBox.Text;
            godotPath = godotPathTextBox.Text;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(RegistryKeyAppName, RegistryKeyPermissionCheck.ReadWriteSubTree);
            if(registryKey == null)
            {
                registryKey = Registry.CurrentUser.CreateSubKey(RegistryKeyAppName, RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            registryKey.SetValue(RegistryValueProjectsDirectory, projectsDirectory);
            registryKey.SetValue(RegistryValueRunOnStartup, runOnStartupCheckBox.Checked);
            registryKey.SetValue(RegistryValueGodotPath, godotPath);
            registryKey.Close();
            SetRunOnStartup();
        }

        private void SetRunOnStartup()
        {
            // Open the Run registry key
            RegistryKey runKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if(runOnStartupCheckBox.Checked)
            {
                // Create a value GodotQuickLaunch and set it to the executable path and windows will run it on startup
                runKey.SetValue(RegistryKeyAppName, Application.ExecutablePath.ToString());
            }
            else
            {
                // Remove the GodotQuickLaunch value from the Run key if it exists
                if(runKey.GetValue(RegistryKeyAppName) != null)
                    runKey.DeleteValue(RegistryKeyAppName);
            }
            runKey.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BrowseProjectsDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                Description = "Select Godot projects root folder"
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                projectsDirectoryTextBox.Text = FormatPath(folderBrowserDialog.SelectedPath);
            }
        }

        private void GodotPathBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Godot editor path",
                Filter = "Godot Editor | godot*.exe|exe files |*.exe"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedExecutableName = FileVersionInfo.GetVersionInfo(openFileDialog.FileName).ProductName;
                if(selectedExecutableName != "Godot Engine")
                {
                    if(MessageBox.Show("The selected executable does not appear to be Godot. Do you want to select it anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        godotPathTextBox.Text = openFileDialog.FileName;
                    }
                }
                else
                {
                    godotPathTextBox.Text = openFileDialog.FileName;
                }
            }
        }
    }
}