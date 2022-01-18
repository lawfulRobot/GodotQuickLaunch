using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GodotQuickLaunch
{
    public partial class PinnedProjectsEditor : Form
    {
        private Form1 settings;
        public PinnedProjectsEditor(Form1 form1)
        {
            InitializeComponent();
            settings = form1;
            pinButton.Click += PinProject;
            unpinButton.Click += UnpinProject;
            FormClosing += OnPinnedProjectsEditorClosing;
        }

        private void UnpinProject(object sender, EventArgs e)
        {
            if (pinnedProjectsListBox.SelectedItem != null)
            {
                string selected = (string)pinnedProjectsListBox.SelectedItem;
                allProjectsListBox.Items.Add(selected);
                settings.allProjects.Add(selected);
                settings.pinnedProjects.Remove(selected);
                pinnedProjectsListBox.Items.Remove(selected);
                ReSortLists();
            }
        }

        private void PinProject(object sender, EventArgs e)
        {
            if(allProjectsListBox.SelectedItem != null)
            {
                string selected = (string)allProjectsListBox.SelectedItem;
                pinnedProjectsListBox.Items.Add(selected);
                settings.pinnedProjects.Add(selected);
                allProjectsListBox.Items.Remove(selected);
                settings.allProjects.Remove(selected);
                //ReSortLists();
            }
        }

        private void ReSortLists()
        {
            settings.allProjects.Sort();
            //settings.pinnedProjects.Sort();
            SetProjectsList();
        }

        public void SetProjectsList()
        {
            allProjectsListBox.Items.Clear();
            pinnedProjectsListBox.Items.Clear();
            pinnedProjectsListBox.Items.AddRange(settings.pinnedProjects.ToArray());
            allProjectsListBox.Items.AddRange(settings.allProjects.ToArray());
        }

        private void OnPinnedProjectsEditorClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                settings.SavePinnedProjects();
                Hide();
                e.Cancel = true;
            }
        }
    }
}
