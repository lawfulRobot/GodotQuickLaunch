
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
            this.editPinnedProjectsButton = new System.Windows.Forms.Button();
            this.browseProjectsDirectoryButton = new System.Windows.Forms.Button();
            this.godotPathLabel = new System.Windows.Forms.Label();
            this.godotPathTextBox = new System.Windows.Forms.TextBox();
            this.browseGodotPathButton = new System.Windows.Forms.Button();
            this.showIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.trayContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.trayContextMenuStrip.Name = "taskbarContextMenuStrip";
            this.trayContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.trayContextMenuStrip.Size = new System.Drawing.Size(61, 10);
            this.trayContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.TrayContextMenuStrip_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
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
            // 
            // runOnStartupCheckBox
            // 
            this.runOnStartupCheckBox.AutoSize = true;
            this.runOnStartupCheckBox.Location = new System.Drawing.Point(289, 94);
            this.runOnStartupCheckBox.Name = "runOnStartupCheckBox";
            this.runOnStartupCheckBox.Size = new System.Drawing.Size(131, 17);
            this.runOnStartupCheckBox.TabIndex = 5;
            this.runOnStartupCheckBox.Text = "Run on system startup";
            this.runOnStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // editPinnedProjectsButton
            // 
            this.editPinnedProjectsButton.Location = new System.Drawing.Point(88, 106);
            this.editPinnedProjectsButton.Name = "editPinnedProjectsButton";
            this.editPinnedProjectsButton.Size = new System.Drawing.Size(111, 23);
            this.editPinnedProjectsButton.TabIndex = 7;
            this.editPinnedProjectsButton.Text = "Edit Pinned Projects";
            this.editPinnedProjectsButton.UseVisualStyleBackColor = true;
            // 
            // browseProjectsDirectoryButton
            // 
            this.browseProjectsDirectoryButton.Location = new System.Drawing.Point(347, 23);
            this.browseProjectsDirectoryButton.Name = "browseProjectsDirectoryButton";
            this.browseProjectsDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.browseProjectsDirectoryButton.TabIndex = 8;
            this.browseProjectsDirectoryButton.Text = "Browse...";
            this.browseProjectsDirectoryButton.UseVisualStyleBackColor = true;
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
            // browseGodotPathButton
            // 
            this.browseGodotPathButton.Location = new System.Drawing.Point(347, 62);
            this.browseGodotPathButton.Name = "browseGodotPathButton";
            this.browseGodotPathButton.Size = new System.Drawing.Size(75, 23);
            this.browseGodotPathButton.TabIndex = 11;
            this.browseGodotPathButton.Text = "Browse...";
            this.browseGodotPathButton.UseVisualStyleBackColor = true;
            // 
            // showIconsCheckBox
            // 
            this.showIconsCheckBox.AutoSize = true;
            this.showIconsCheckBox.Location = new System.Drawing.Point(289, 117);
            this.showIconsCheckBox.Name = "showIconsCheckBox";
            this.showIconsCheckBox.Size = new System.Drawing.Size(116, 17);
            this.showIconsCheckBox.TabIndex = 5;
            this.showIconsCheckBox.Text = "Show project icons";
            this.showIconsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 141);
            this.Controls.Add(this.browseGodotPathButton);
            this.Controls.Add(this.godotPathTextBox);
            this.Controls.Add(this.godotPathLabel);
            this.Controls.Add(this.browseProjectsDirectoryButton);
            this.Controls.Add(this.editPinnedProjectsButton);
            this.Controls.Add(this.showIconsCheckBox);
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
            this.Activated += new System.EventHandler(this.Form1_Activated);
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
        private System.Windows.Forms.Button editPinnedProjectsButton;
        private System.Windows.Forms.Button browseProjectsDirectoryButton;
        private System.Windows.Forms.Label godotPathLabel;
        private System.Windows.Forms.TextBox godotPathTextBox;
        private System.Windows.Forms.Button browseGodotPathButton;
        private System.Windows.Forms.CheckBox showIconsCheckBox;
    }
}

