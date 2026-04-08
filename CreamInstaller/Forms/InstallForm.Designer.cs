using System.ComponentModel;
using System.Windows.Forms;
using CreamInstaller.Components;

namespace CreamInstaller.Forms
{
    sealed partial class InstallForm
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is not null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.userProgressBar  = new DarkProgressBar();
            this.userInfoLabel    = new System.Windows.Forms.Label();
            this.acceptButton     = new DarkButton();
            this.retryButton      = new DarkButton();
            this.cancelButton     = new DarkButton();
            this.logTextBox       = new System.Windows.Forms.RichTextBox();
            this.reselectButton   = new DarkButton();
            this.exportLogButton  = new DarkButton();
            this.SuspendLayout();

            // 
            // userProgressBar
            // 
            this.userProgressBar.Anchor   = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userProgressBar.Location = new System.Drawing.Point(12, 30);
            this.userProgressBar.Name     = "userProgressBar";
            this.userProgressBar.Size     = new System.Drawing.Size(760, 22);
            this.userProgressBar.TabIndex = 1;

            // 
            // userInfoLabel
            // 
            this.userInfoLabel.Anchor      = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoLabel.AutoEllipsis = true;
            this.userInfoLabel.Font        = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userInfoLabel.ForeColor   = CreamInstaller.Components.ThemeManager.TextSecondary;
            this.userInfoLabel.Location    = new System.Drawing.Point(12, 10);
            this.userInfoLabel.Name        = "userInfoLabel";
            this.userInfoLabel.Size        = new System.Drawing.Size(760, 18);
            this.userInfoLabel.TabIndex    = 2;
            this.userInfoLabel.Text        = "Loading . . . ";

            // 
            // logTextBox
            // 
            this.logTextBox.Anchor       = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.BackColor    = CreamInstaller.Components.ThemeManager.LogBg;
            this.logTextBox.BorderStyle  = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.Font         = new System.Drawing.Font("Cascadia Mono", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logTextBox.ForeColor    = CreamInstaller.Components.ThemeManager.TextPrimary;
            this.logTextBox.HideSelection = false;
            this.logTextBox.Location     = new System.Drawing.Point(12, 58);
            this.logTextBox.Name         = "logTextBox";
            this.logTextBox.ReadOnly     = true;
            this.logTextBox.ScrollBars   = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logTextBox.Size         = new System.Drawing.Size(760, 460);
            this.logTextBox.TabIndex     = 4;
            this.logTextBox.TabStop      = false;
            this.logTextBox.Text         = "";

            // 
            // cancelButton
            // 
            this.cancelButton.Anchor    = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.IsAccent  = false;
            this.cancelButton.Location  = new System.Drawing.Point(12, 528);
            this.cancelButton.Name      = "cancelButton";
            this.cancelButton.Size      = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex  = 1;
            this.cancelButton.Text      = "Cancel";
            this.cancelButton.Click    += new System.EventHandler(this.OnCancel);

            // 
            // exportLogButton  (NEW)
            // 
            this.exportLogButton.Anchor   = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportLogButton.Enabled  = false;
            this.exportLogButton.IsAccent = false;
            this.exportLogButton.Location = new System.Drawing.Point(93, 528);
            this.exportLogButton.Name     = "exportLogButton";
            this.exportLogButton.Size     = new System.Drawing.Size(90, 26);
            this.exportLogButton.TabIndex = 5;
            this.exportLogButton.Text     = "Export Log";
            this.exportLogButton.Click   += new System.EventHandler(this.OnExportLog);

            // 
            // reselectButton
            // 
            this.reselectButton.Anchor    = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reselectButton.IsAccent  = false;
            this.reselectButton.Location  = new System.Drawing.Point(410, 528);
            this.reselectButton.Name      = "reselectButton";
            this.reselectButton.Size      = new System.Drawing.Size(200, 26);
            this.reselectButton.TabIndex  = 2;
            this.reselectButton.Text      = "Reselect Programs / Games";
            this.reselectButton.Click    += new System.EventHandler(this.OnReselect);

            // 
            // retryButton
            // 
            this.retryButton.Anchor    = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.retryButton.Enabled   = false;
            this.retryButton.IsAccent  = false;
            this.retryButton.Location  = new System.Drawing.Point(616, 528);
            this.retryButton.Name      = "retryButton";
            this.retryButton.Size      = new System.Drawing.Size(75, 26);
            this.retryButton.TabIndex  = 3;
            this.retryButton.Text      = "Retry";
            this.retryButton.Click    += new System.EventHandler(this.OnRetry);

            // 
            // acceptButton  (accent)
            // 
            this.acceptButton.Anchor    = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Enabled   = false;
            this.acceptButton.IsAccent  = true;
            this.acceptButton.Location  = new System.Drawing.Point(697, 528);
            this.acceptButton.Name      = "acceptButton";
            this.acceptButton.Size      = new System.Drawing.Size(75, 26);
            this.acceptButton.TabIndex  = 4;
            this.acceptButton.Text      = "OK";
            this.acceptButton.Click    += new System.EventHandler(this.OnAccept);

            // 
            // InstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = CreamInstaller.Components.ThemeManager.Background;
            this.ClientSize          = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.reselectButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.exportLogButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.userProgressBar);
            this.Controls.Add(this.userInfoLabel);
            this.DoubleBuffered  = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.MinimumSize     = new System.Drawing.Size(800, 400);
            this.Name            = "InstallForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.Manual;
            this.Text            = "InstallForm";
            this.Load           += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
        }

        #endregion

        private DarkProgressBar userProgressBar;
        private System.Windows.Forms.Label userInfoLabel;
        private DarkButton      acceptButton;
        private DarkButton      retryButton;
        private DarkButton      cancelButton;
        private DarkButton      exportLogButton;
        private System.Windows.Forms.RichTextBox logTextBox;
        private DarkButton      reselectButton;
    }
}
