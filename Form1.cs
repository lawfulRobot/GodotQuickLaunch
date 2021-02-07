using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Drawing;

namespace GodotQuickLaunch
{
    public partial class Form1 : Form
    {
        private const string RegistryValueProjectsDirectory = "ProjectsDirectory";
        private const string RegistryKeyAppName             = "GodotQuickLaunch";
        private const string RegistryValueRunOnStartup      = "RunOnStartup";
        private const string RegistryValueShowIcons         = "ShowIcons";
        private const string RegistryValueGodotPath         = "GodotPath";

        private string projectsDirectory = "";
        private string godotPath         = "";

        private bool showIcons = false;
        private bool isInitialStartup = true;

        public Form1()
        {
            InitializeComponent();
            exitButton.Click += Exit;
            saveButton.Click += Save;
            closeButton.Click += CloseForm;
            browseProjectsDirectoryButton.Click += BrowseProjectsDirectory;
            browseGodotPathButton.Click += BrowseGodotPath;
            // Get saved data from registry
            RegistryKey savedData = Registry.CurrentUser.OpenSubKey(RegistryKeyAppName);
            if(savedData != null)
            {
                if (savedData.GetValue(RegistryValueRunOnStartup) != null)
                {
                    runOnStartupCheckBox.Checked = Convert.ToBoolean(savedData.GetValue(RegistryValueRunOnStartup));
                }
                if (savedData.GetValue(RegistryValueShowIcons) != null)
                {
                    showIcons = Convert.ToBoolean(savedData.GetValue(RegistryValueShowIcons));
                    showIconsCheckBox.Checked = showIcons;
                    trayContextMenuStrip.ShowImageMargin = showIcons;
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
                //WindowState = FormWindowState.Minimized;
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
                        {
                            Image projectIcon = null;
                            if(showIcons)
                            {
                                // Find the project icon
                                // Read the project.godot file and find the line containing "config/icon"
                                using (System.IO.StreamReader file = new System.IO.StreamReader(dirs[i] + @"\project.godot"))
                                {
                                    string line = "";
                                    while ((line = file.ReadLine()) != null)
                                    {
                                        if (line.Contains("config/icon"))
                                        {
                                            // Remove quotes from the path
                                            line = line.Replace("\"", "");
                                            /*** 
                                             The icon path in the project.godot file starts with "res://"
                                             Split it at "/" and return 3 elements in the array
                                             Example, full line (after removing quotes) is: config/icon=res://icon.png
                                             And it splits into config , icon=res: and /icon.png
                                             The last element combined with dirs[i] gives us the full path to the image
                                             Replace "/" with "\" just for consistency not really needed
                                            ***/
                                            string[] splitIconPath = line.Split(new char[1] {'/'}, 3);
                                            string iconPath = dirs[i] + splitIconPath[splitIconPath.Length - 1].Replace('/', '\\');
                                            // Load the icon from the path
                                            projectIcon = Image.FromFile(iconPath);
                                            break;
                                        }
                                    }

                                }
                            }
                            trayContextMenuStrip.Items.Add(projectName, projectIcon, OpenProject);
                        }
                    }
                }
                trayContextMenuStrip.Items.Add(new ToolStripSeparator());
            }
            // Add context menu strip items for launch godot, open project folder, settings and exit
            if(!string.IsNullOrWhiteSpace(godotPath))
            {
                trayContextMenuStrip.Items.Add("Launch Godot", null, RunGodot);
            }
            if(!string.IsNullOrWhiteSpace(projectsDirectory))
            {
                trayContextMenuStrip.Items.Add("Open Projects Folder", null, OpenProjectsFolder);
            }
            trayContextMenuStrip.Items.Add("Settings", null, OpenSettings);
            trayContextMenuStrip.Items.Add("Exit", null, Exit);
        }

        // Add a slash at the end of the projects path if there isn't one
        private string FormatPath(string p) => p.EndsWith(@"\") ? p : p + @"\";


        private void OpenProject(object sender, EventArgs e)
        {
            // If a path to Godot exists start a process with it
            if (!string.IsNullOrWhiteSpace(godotPath))
            {
                // Wrap the project path in quotes in case there are spaces
                // Passing a path with spaces as an argument to Godot doesn't work and just launches the project picker instead
                string path = "\"" + projectsDirectory + sender.ToString() + @"\project.godot" + "\"";
                ProcessStartInfo startInfo = new ProcessStartInfo(godotPath)
                {
                    Arguments = path
                };
                Process.Start(startInfo);
            }
            // Otherwise run project.godot with the default program associated with .godot files
            else
            {
                Process.Start(projectsDirectory + sender.ToString() + @"\project.godot");
            }
        }

        private void RunGodot(object sender, EventArgs e) => Process.Start(godotPath);

        private void OpenProjectsFolder(object sender, EventArgs e) => Process.Start(projectsDirectory);

        private void Exit(object sender, EventArgs e) => Application.Exit();

        private void OpenSettings(object sender, EventArgs e)
        {
            projectsDirectoryTextBox.Text = projectsDirectory;
            godotPathTextBox.Text = godotPath;
            WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }


        private void TrayContextMenuStrip_Opening(object sender, CancelEventArgs e) => SetupProjectsList();

        private void Save(object sender, EventArgs e)
        {
            projectsDirectory = projectsDirectoryTextBox.Text;
            godotPath = godotPathTextBox.Text;
            showIcons = showIconsCheckBox.Checked;
            trayContextMenuStrip.ShowImageMargin = showIcons;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(RegistryKeyAppName, RegistryKeyPermissionCheck.ReadWriteSubTree);
            if(registryKey == null)
            {
                registryKey = Registry.CurrentUser.CreateSubKey(RegistryKeyAppName, RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            registryKey.SetValue(RegistryValueProjectsDirectory, projectsDirectory);
            registryKey.SetValue(RegistryValueRunOnStartup, runOnStartupCheckBox.Checked);
            registryKey.SetValue(RegistryValueGodotPath, godotPath);
            registryKey.SetValue(RegistryValueShowIcons, showIcons);
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

        private void CloseForm(object sender, EventArgs e) => Hide();

        private void BrowseProjectsDirectory(object sender, EventArgs e)
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

        private void BrowseGodotPath(object sender, EventArgs e)
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

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (isInitialStartup)
            {
                // This puts the application in the background
                // This is done here because Hide() cannot be called in the constructor and the app
                // shows up as a foreground app in task manager and also appears when alt-tabbing
                // Side effect is the form flashes for a brief moment  ¯\_(ツ)_/¯
                isInitialStartup = false;
                Hide();
            }
        }
    }
}