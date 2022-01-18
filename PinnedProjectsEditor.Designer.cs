
namespace GodotQuickLaunch
{
    partial class PinnedProjectsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinnedProjectsEditor));
            this.pinButton = new System.Windows.Forms.Button();
            this.allProjectsListBox = new System.Windows.Forms.ListBox();
            this.pinnedProjectsListBox = new System.Windows.Forms.ListBox();
            this.unpinButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pinButton
            // 
            this.pinButton.Location = new System.Drawing.Point(139, 44);
            this.pinButton.Name = "pinButton";
            this.pinButton.Size = new System.Drawing.Size(75, 23);
            this.pinButton.TabIndex = 1;
            this.pinButton.Text = "Pin >>";
            this.pinButton.UseVisualStyleBackColor = true;
            // 
            // allProjectsListBox
            // 
            this.allProjectsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.allProjectsListBox.FormattingEnabled = true;
            this.allProjectsListBox.Location = new System.Drawing.Point(12, 25);
            this.allProjectsListBox.Name = "allProjectsListBox";
            this.allProjectsListBox.Size = new System.Drawing.Size(120, 368);
            this.allProjectsListBox.TabIndex = 2;
            // 
            // pinnedProjectsListBox
            // 
            this.pinnedProjectsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pinnedProjectsListBox.FormattingEnabled = true;
            this.pinnedProjectsListBox.Location = new System.Drawing.Point(220, 25);
            this.pinnedProjectsListBox.Name = "pinnedProjectsListBox";
            this.pinnedProjectsListBox.Size = new System.Drawing.Size(120, 368);
            this.pinnedProjectsListBox.TabIndex = 2;
            // 
            // unpinButton
            // 
            this.unpinButton.Location = new System.Drawing.Point(139, 73);
            this.unpinButton.Name = "unpinButton";
            this.unpinButton.Size = new System.Drawing.Size(75, 23);
            this.unpinButton.TabIndex = 1;
            this.unpinButton.Text = "<< Unpin";
            this.unpinButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pinned Projects";
            // 
            // PinnedProjectsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinnedProjectsListBox);
            this.Controls.Add(this.allProjectsListBox);
            this.Controls.Add(this.unpinButton);
            this.Controls.Add(this.pinButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 2048);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 450);
            this.Name = "PinnedProjectsEditor";
            this.Text = "Pinned Projects Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pinButton;
        private System.Windows.Forms.ListBox allProjectsListBox;
        private System.Windows.Forms.ListBox pinnedProjectsListBox;
        private System.Windows.Forms.Button unpinButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}