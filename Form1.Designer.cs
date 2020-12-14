
namespace GodotQuickLaunch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.projectsDirectoryLabel = new System.Windows.Forms.Label();
            this.projectsDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.runOnStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.browseProjectsDirectoryButton = new System.Windows.Forms.Button();
            this.godotPathLabel = new System.Windows.Forms.Label();
            this.godotPathTextBox = new System.Windows.Forms.TextBox();
            this.godotPathBrowseButton = new System.Windows.Forms.Button();
            this.trayContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.trayContextMenuStrip.Name = "taskbarContextMenuStrip";
            this.trayContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.trayContextMenuStrip.ShowImageMargin = false;
            this.trayContextMenuStrip.Size = new System.Drawing.Size(156, 32);
            this.trayContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.TrayContextMenuStrip_Opening);
            this.trayContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TrayContextMenuStrip_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayContextMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Godot Quick Launch";
            this.notifyIcon1.Visible = true;
            // 
            // projectsDirectoryLabel
            // 
            this.projectsDirectoryLabel.AutoSize = true;
            this.projectsDirectoryLabel.Location = new System.Drawing.Point(12, 9);
            this.projectsDirectoryLabel.Name = "projectsDirectoryLabel";
            this.projectsDirectoryLabel.Size = new System.Drawing.Size(138, 13);
            this.projectsDirectoryLabel.TabIndex = 1;
            this.projectsDirectoryLabel.Text = "Godot Projects Root Folder:";
            // 
            // projectsDirectoryTextBox
            // 
            this.projectsDirectoryTextBox.Location = new System.Drawing.Point(15, 25);
            this.projectsDirectoryTextBox.Name = "projectsDirectoryTextBox";
            this.projectsDirectoryTextBox.Size = new System.Drawing.Size(326, 20);
            this.projectsDirectoryTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 106);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // runOnStartupCheckBox
            // 
            this.runOnStartupCheckBox.AutoSize = true;
            this.runOnStartupCheckBox.Location = new System.Drawing.Point(291, 110);
            this.runOnStartupCheckBox.Name = "runOnStartupCheckBox";
            this.runOnStartupCheckBox.Size = new System.Drawing.Size(131, 17);
            this.runOnStartupCheckBox.TabIndex = 5;
            this.runOnStartupCheckBox.Text = "Run on system startup";
            this.runOnStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(88, 106);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 106);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // browseProjectsDirectoryButton
            // 
            this.browseProjectsDirectoryButton.Location = new System.Drawing.Point(347, 23);
            this.browseProjectsDirectoryButton.Name = "browseProjectsDirectoryButton";
            this.browseProjectsDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.browseProjectsDirectoryButton.TabIndex = 8;
            this.browseProjectsDirectoryButton.Text = "Browse...";
            this.browseProjectsDirectoryButton.UseVisualStyleBackColor = true;
            this.browseProjectsDirectoryButton.Click += new System.EventHandler(this.BrowseProjectsDirectoryButton_Click);
            // 
            // godotPathLabel
            // 
            this.godotPathLabel.AutoSize = true;
            this.godotPathLabel.Location = new System.Drawing.Point(12, 48);
            this.godotPathLabel.Name = "godotPathLabel";
            this.godotPathLabel.Size = new System.Drawing.Size(64, 13);
            this.godotPathLabel.TabIndex = 9;
            this.godotPathLabel.Text = "Godot Path:";
            // 
            // godotPathTextBox
            // 
            this.godotPathTextBox.Location = new System.Drawing.Point(15, 64);
            this.godotPathTextBox.Name = "godotPathTextBox";
            this.godotPathTextBox.Size = new System.Drawing.Size(326, 20);
            this.godotPathTextBox.TabIndex = 10;
            // 
            // godotPathBrowseButton
            // 
            this.godotPathBrowseButton.Location = new System.Drawing.Point(347, 62);
            this.godotPathBrowseButton.Name = "godotPathBrowseButton";
            this.godotPathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.godotPathBrowseButton.TabIndex = 11;
            this.godotPathBrowseButton.Text = "Browse...";
            this.godotPathBrowseButton.UseVisualStyleBackColor = true;
            this.godotPathBrowseButton.Click += new System.EventHandler(this.GodotPathBrowseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 141);
            this.Controls.Add(this.godotPathBrowseButton);
            this.Controls.Add(this.godotPathTextBox);
            this.Controls.Add(this.godotPathLabel);
            this.Controls.Add(this.browseProjectsDirectoryButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.runOnStartupCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.projectsDirectoryTextBox);
            this.Controls.Add(this.projectsDirectoryLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 180);
            this.Name = "Form1";
            this.Text = "Godot Quick Launch";
            this.trayContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label projectsDirectoryLabel;
        private System.Windows.Forms.TextBox projectsDirectoryTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox runOnStartupCheckBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button browseProjectsDirectoryButton;
        private System.Windows.Forms.Label godotPathLabel;
        private System.Windows.Forms.TextBox godotPathTextBox;
        private System.Windows.Forms.Button godotPathBrowseButton;
    }
}

