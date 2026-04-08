using System.ComponentModel;
using System.Windows.Forms;
using CreamInstaller.Components;

namespace CreamInstaller.Forms
{
    partial class MainForm
    {
        private IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerLabel       = new System.Windows.Forms.Label();
            this.progressLabel     = new System.Windows.Forms.Label();
            this.updateButton      = new DarkButton();
            this.ignoreButton      = new DarkButton();
            this.progressBar       = new DarkProgressBar();
            this.changelogTreeView = new CustomTreeView();
            this.SuspendLayout();

            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize  = false;
            this.headerLabel.Dock      = System.Windows.Forms.DockStyle.None;
            this.headerLabel.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = CreamInstaller.Components.ThemeManager.Accent;
            this.headerLabel.Location  = new System.Drawing.Point(12, 12);
            this.headerLabel.Name      = "headerLabel";
            this.headerLabel.Size      = new System.Drawing.Size(380, 24);
            this.headerLabel.Text      = "CreamInstaller";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // progressLabel
            // 
            this.progressLabel.AutoEllipsis = true;
            this.progressLabel.Font         = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLabel.ForeColor    = CreamInstaller.Components.ThemeManager.TextSecondary;
            this.progressLabel.Location     = new System.Drawing.Point(12, 44);
            this.progressLabel.Margin       = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.progressLabel.Name         = "progressLabel";
            this.progressLabel.Size         = new System.Drawing.Size(218, 18);
            this.progressLabel.Text         = "Checking for updates . . .";

            // 
            // updateButton  (accent)
            //
            this.updateButton.Anchor      = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Enabled     = false;
            this.updateButton.IsAccent    = true;
            this.updateButton.Location    = new System.Drawing.Point(317, 40);
            this.updateButton.Margin      = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.updateButton.Name        = "updateButton";
            this.updateButton.Size        = new System.Drawing.Size(75, 26);
            this.updateButton.TabIndex    = 2;
            this.updateButton.Text        = "Update";

            // 
            // ignoreButton  (outline / surface)
            //
            this.ignoreButton.Anchor      = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreButton.Enabled     = false;
            this.ignoreButton.IsAccent    = false;
            this.ignoreButton.Location    = new System.Drawing.Point(236, 40);
            this.ignoreButton.Margin      = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ignoreButton.Name        = "ignoreButton";
            this.ignoreButton.Size        = new System.Drawing.Size(75, 26);
            this.ignoreButton.TabIndex    = 1;
            this.ignoreButton.Text        = "Ignore";
            this.ignoreButton.Click      += new System.EventHandler(this.OnIgnore);

            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 72);
            this.progressBar.Name     = "progressBar";
            this.progressBar.Size     = new System.Drawing.Size(380, 22);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible  = false;

            // 
            // changelogTreeView
            // 
            this.changelogTreeView.BackColor  = CreamInstaller.Components.ThemeManager.Background;
            this.changelogTreeView.ForeColor  = CreamInstaller.Components.ThemeManager.TextPrimary;
            this.changelogTreeView.DrawMode   = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.changelogTreeView.Location   = new System.Drawing.Point(12, 102);
            this.changelogTreeView.Margin     = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.changelogTreeView.Name       = "changelogTreeView";
            this.changelogTreeView.Size       = new System.Drawing.Size(380, 179);
            this.changelogTreeView.Sorted     = true;
            this.changelogTreeView.TabIndex   = 5;
            this.changelogTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize            = true;
            this.AutoSizeMode        = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor           = CreamInstaller.Components.ThemeManager.Background;
            this.ClientSize          = new System.Drawing.Size(404, 293);
            this.Controls.Add(this.changelogTreeView);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.headerLabel);
            this.DoubleBuffered  = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "MainForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "MainForm";
            this.Load           += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
        }

        #endregion

        private Label           headerLabel;
        private Label           progressLabel;
        private DarkButton      updateButton;
        private DarkButton      ignoreButton;
        private DarkProgressBar progressBar;
        private CustomTreeView  changelogTreeView;
    }
}
