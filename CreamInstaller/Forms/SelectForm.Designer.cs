using System.ComponentModel;
using System.Windows.Forms;
using CreamInstaller.Components;

namespace CreamInstaller.Forms
{
    partial class SelectForm
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
            this.installButton         = new DarkButton();
            this.cancelButton          = new DarkButton();
            this.programsGroupBox      = new System.Windows.Forms.GroupBox();
            this.koaloaderFlowPanel    = new System.Windows.Forms.FlowLayoutPanel();
            this.koaloaderAllCheckBox  = new System.Windows.Forms.CheckBox();
            this.noneFoundLabel        = new System.Windows.Forms.Label();
            this.blockedGamesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.blockedGamesCheckBox  = new System.Windows.Forms.CheckBox();
            this.blockProtectedHelpButton = new DarkButton();
            this.selectionTreeView     = new CreamInstaller.Components.CustomTreeView();
            this.allCheckBoxLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.allCheckBox           = new System.Windows.Forms.CheckBox();
            this.progressBar           = new DarkProgressBar();
            this.progressLabel         = new System.Windows.Forms.Label();
            this.searchTextBox         = new System.Windows.Forms.TextBox();
            this.scanButton            = new DarkButton();
            this.uninstallButton       = new DarkButton();
            this.progressLabelGames    = new System.Windows.Forms.Label();
            this.progressLabelDLCs     = new System.Windows.Forms.Label();
            this.sortCheckBox          = new System.Windows.Forms.CheckBox();
            this.saveButton            = new DarkButton();
            this.loadButton            = new DarkButton();
            this.resetKoaloaderButton  = new DarkButton();
            this.resetButton           = new DarkButton();
            this.saveKoaloaderButton   = new DarkButton();
            this.loadKoaloaderButton   = new DarkButton();
            this.statusStrip           = new System.Windows.Forms.StatusStrip();
            this.statusLabelGames      = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelSep        = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelDLCs       = new System.Windows.Forms.ToolStripStatusLabel();
            this.programsGroupBox.SuspendLayout();
            this.koaloaderFlowPanel.SuspendLayout();
            this.blockedGamesFlowPanel.SuspendLayout();
            this.allCheckBoxLayoutPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // installButton
            // 
            this.installButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.installButton.AutoSize     = true;
            this.installButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.installButton.Enabled      = false;
            this.installButton.IsAccent     = true;
            this.installButton.Location     = new System.Drawing.Point(418, 332);
            this.installButton.Name         = "installButton";
            this.installButton.Padding      = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.installButton.Size         = new System.Drawing.Size(154, 26);
            this.installButton.TabIndex     = 10000;
            this.installButton.Text         = "Generate and Install";
            this.installButton.Click       += new System.EventHandler(this.OnInstall);

            // 
            // cancelButton
            // 
            this.cancelButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.AutoSize     = true;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.IsAccent     = false;
            this.cancelButton.Location     = new System.Drawing.Point(12, 332);
            this.cancelButton.Name         = "cancelButton";
            this.cancelButton.Padding      = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.cancelButton.Size         = new System.Drawing.Size(81, 26);
            this.cancelButton.TabIndex     = 10004;
            this.cancelButton.Text         = "Cancel";
            this.cancelButton.Click       += new System.EventHandler(this.OnCancel);

            // 
            // programsGroupBox
            // 
            this.programsGroupBox.Anchor    = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programsGroupBox.BackColor = CreamInstaller.Components.ThemeManager.Background;
            this.programsGroupBox.Controls.Add(this.koaloaderFlowPanel);
            this.programsGroupBox.Controls.Add(this.noneFoundLabel);
            this.programsGroupBox.Controls.Add(this.blockedGamesFlowPanel);
            this.programsGroupBox.Controls.Add(this.selectionTreeView);
            this.programsGroupBox.Controls.Add(this.allCheckBoxLayoutPanel);
            this.programsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programsGroupBox.ForeColor = CreamInstaller.Components.ThemeManager.TextSecondary;
            this.programsGroupBox.Location  = new System.Drawing.Point(12, 44);
            this.programsGroupBox.Name      = "programsGroupBox";
            this.programsGroupBox.Size      = new System.Drawing.Size(560, 209);
            this.programsGroupBox.TabIndex  = 8;
            this.programsGroupBox.TabStop   = false;
            this.programsGroupBox.Text      = "Programs / Games";

            // 
            // koaloaderFlowPanel
            // 
            this.koaloaderFlowPanel.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.koaloaderFlowPanel.AutoSize     = true;
            this.koaloaderFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.koaloaderFlowPanel.BackColor    = CreamInstaller.Components.ThemeManager.Background;
            this.koaloaderFlowPanel.Controls.Add(this.koaloaderAllCheckBox);
            this.koaloaderFlowPanel.Location     = new System.Drawing.Point(430, -1);
            this.koaloaderFlowPanel.Margin       = new System.Windows.Forms.Padding(0);
            this.koaloaderFlowPanel.Name         = "koaloaderFlowPanel";
            this.koaloaderFlowPanel.Size         = new System.Drawing.Size(73, 19);
            this.koaloaderFlowPanel.TabIndex     = 10005;
            this.koaloaderFlowPanel.WrapContents = false;

            // 
            // koaloaderAllCheckBox
            // 
            this.koaloaderAllCheckBox.Anchor    = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.koaloaderAllCheckBox.BackColor = CreamInstaller.Components.ThemeManager.Background;
            this.koaloaderAllCheckBox.Checked   = true;
            this.koaloaderAllCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.koaloaderAllCheckBox.Enabled   = false;
            this.koaloaderAllCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.koaloaderAllCheckBox.ForeColor = CreamInstaller.Components.ThemeManager.TextPrimary;
            this.koaloaderAllCheckBox.Location  = new System.Drawing.Point(2, 0);
            this.koaloaderAllCheckBox.Margin    = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.koaloaderAllCheckBox.Name      = "koaloaderAllCheckBox";
            this.koaloaderAllCheckBox.Size      = new System.Drawing.Size(71, 19);
            this.koaloaderAllCheckBox.TabIndex  = 4;
            this.koaloaderAllCheckBox.Text      = "Koaloader";
            this.koaloaderAllCheckBox.CheckedChanged += new System.EventHandler(this.OnKoaloaderAllCheckBoxChanged);

            // 
            // noneFoundLabel
            // 
            this.noneFoundLabel.BackColor  = CreamInstaller.Components.ThemeManager.Background;
            this.noneFoundLabel.Dock       = System.Windows.Forms.DockStyle.Fill;
            this.noneFoundLabel.ForeColor  = CreamInstaller.Components.ThemeManager.TextSecondary;
            this.noneFoundLabel.Location   = new System.Drawing.Point(3, 19);
            this.noneFoundLabel.Name       = "noneFoundLabel";
            this.noneFoundLabel.Size       = new System.Drawing.Size(554, 187);
            this.noneFoundLabel.TabIndex   = 1002;
            this.noneFoundLabel.Text       = "No applicable programs nor games were found on your computer!";
            this.noneFoundLabel.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;
            this.noneFoundLabel.Visible    = false;

            // 
            // blockedGamesFlowPanel
            // 
            this.blockedGamesFlowPanel.Anchor       = System.Windows.Forms.AnchorStyles.Top;
            this.blockedGamesFlowPanel.AutoSize     = true;
            this.blockedGamesFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.blockedGamesFlowPanel.BackColor    = CreamInstaller.Components.ThemeManager.Background;
            this.blockedGamesFlowPanel.Controls.Add(this.blockedGamesCheckBox);
            this.blockedGamesFlowPanel.Controls.Add(this.blockProtectedHelpButton);
            this.blockedGamesFlowPanel.Location     = new System.Drawing.Point(125, -1);
            this.blockedGamesFlowPanel.Margin       = new System.Windows.Forms.Padding(0);
            this.blockedGamesFlowPanel.Name         = "blockedGamesFlowPanel";
            this.blockedGamesFlowPanel.Size         = new System.Drawing.Size(162, 20);
            this.blockedGamesFlowPanel.TabIndex     = 1005;
            this.blockedGamesFlowPanel.WrapContents = false;

            // 
            // blockedGamesCheckBox
            // 
            this.blockedGamesCheckBox.BackColor  = CreamInstaller.Components.ThemeManager.Background;
            this.blockedGamesCheckBox.Checked    = true;
            this.blockedGamesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blockedGamesCheckBox.Enabled    = false;
            this.blockedGamesCheckBox.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.blockedGamesCheckBox.ForeColor  = CreamInstaller.Components.ThemeManager.TextPrimary;
            this.blockedGamesCheckBox.Location   = new System.Drawing.Point(2, 0);
            this.blockedGamesCheckBox.Margin     = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.blockedGamesCheckBox.Name       = "blockedGamesCheckBox";
            this.blockedGamesCheckBox.Size       = new System.Drawing.Size(140, 20);
            this.blockedGamesCheckBox.TabIndex   = 1;
            this.blockedGamesCheckBox.Text       = "Block Protected Games";
            this.blockedGamesCheckBox.CheckedChanged += new System.EventHandler(this.OnBlockProtectedGamesCheckBoxChanged);

            // 
            // blockProtectedHelpButton
            // 
            this.blockProtectedHelpButton.Enabled  = false;
            this.blockProtectedHelpButton.IsAccent = false;
            this.blockProtectedHelpButton.Font     = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blockProtectedHelpButton.Location = new System.Drawing.Point(142, 0);
            this.blockProtectedHelpButton.Margin   = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.blockProtectedHelpButton.Name     = "blockProtectedHelpButton";
            this.blockProtectedHelpButton.Size     = new System.Drawing.Size(19, 19);
            this.blockProtectedHelpButton.TabIndex = 2;
            this.blockProtectedHelpButton.Text     = "?";
            this.blockProtectedHelpButton.Click   += new System.EventHandler(this.OnBlockProtectedGamesHelpButtonClicked);

            // 
            // selectionTreeView
            // 
            this.selectionTreeView.BackColor   = CreamInstaller.Components.ThemeManager.Background;
            this.selectionTreeView.ForeColor   = CreamInstaller.Components.ThemeManager.TextPrimary;
            this.selectionTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectionTreeView.CheckBoxes  = true;
            this.selectionTreeView.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.selectionTreeView.DrawMode    = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.selectionTreeView.Enabled     = false;
            this.selectionTreeView.FullRowSelect = true;
            this.selectionTreeView.Location    = new System.Drawing.Point(3, 19);
            this.selectionTreeView.Name        = "selectionTreeView";
            this.selectionTreeView.Size        = new System.Drawing.Size(554, 187);
            this.selectionTreeView.Sorted      = true;
            this.selectionTreeView.TabIndex    = 1001;

            // 
            // allCheckBoxLayoutPanel
            // 
            this.allCheckBoxLayoutPanel.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allCheckBoxLayoutPanel.AutoSize     = true;
            this.allCheckBoxLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allCheckBoxLayoutPanel.BackColor    = CreamInstaller.Components.ThemeManager.Background;
            this.allCheckBoxLayoutPanel.Controls.Add(this.allCheckBox);
            this.allCheckBoxLayoutPanel.Location     = new System.Drawing.Point(520, -1);
            this.allCheckBoxLayoutPanel.Margin       = new System.Windows.Forms.Padding(0);
            this.allCheckBoxLayoutPanel.Name         = "allCheckBoxLayoutPanel";
            this.allCheckBoxLayoutPanel.Size         = new System.Drawing.Size(34, 19);
            this.allCheckBoxLayoutPanel.TabIndex     = 1006;
            this.allCheckBoxLayoutPanel.WrapContents = false;

            // 
            // allCheckBox
            // 
            this.allCheckBox.Anchor    = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allCheckBox.BackColor = CreamInstaller.Components.ThemeManager.Background;
            this.allCheckBox.Checked   = true;
            this.allCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allCheckBox.Enabled   = false;
            this.allCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allCheckBox.ForeColor = CreamInstaller.Components.ThemeManager.TextPrimary;
            this.allCheckBox.Location  = new System.Drawing.Point(2, 0);
            this.allCheckBox.Margin    = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.allCheckBox.Name      = "allCheckBox";
            this.allCheckBox.Size      = new System.Drawing.Size(32, 19);
            this.allCheckBox.TabIndex  = 4;
            this.allCheckBox.Text      = "All";
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.OnAllCheckBoxChanged);

            // 
            // searchTextBox  (NEW - game filter)
            //
            this.searchTextBox.Anchor      = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor   = CreamInstaller.Components.ThemeManager.Surface;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font        = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.ForeColor   = CreamInstaller.Components.ThemeManager.TextPrimary;
            this.searchTextBox.Location    = new System.Drawing.Point(12, 16);
            this.searchTextBox.Name        = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search games . . .";
            this.searchTextBox.Size        = new System.Drawing.Size(560, 23);
            this.searchTextBox.TabIndex    = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.OnSearchTextChanged);

            // 
            // progressBar
            // 
            this.progressBar.Anchor   = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 273);
            this.progressBar.Name     = "progressBar";
            this.progressBar.Size     = new System.Drawing.Size(560, 22);
            this.progressBar.TabIndex = 9;

            // 
            // progressLabel
            // 
            this.progressLabel.Anchor   = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.AutoEllipsis = true;
            this.progressLabel.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLabel.ForeColor = CreamInstaller.Components.ThemeManager.TextSecondary;
            this.progressLabel.Location = new System.Drawing.Point(12, 231);
            this.progressLabel.Name     = "progressLabel";
            this.progressLabel.Size     = new System.Drawing.Size(560, 15);
            this.progressLabel.Text     = "Gathering and caching your applicable games and their DLCs . . . 0%";

            // 
            // scanButton
            // 
            this.scanButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scanButton.AutoSize     = true;
            this.scanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scanButton.Enabled      = false;
            this.scanButton.IsAccent     = false;
            this.scanButton.Location     = new System.Drawing.Point(238, 332);
            this.scanButton.Name         = "scanButton";
            this.scanButton.Padding      = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.scanButton.Size         = new System.Drawing.Size(82, 26);
            this.scanButton.TabIndex     = 10002;
            this.scanButton.Text         = "Rescan";
            this.scanButton.Click       += new System.EventHandler(this.OnScan);

            // 
            // uninstallButton
            // 
            this.uninstallButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uninstallButton.AutoSize     = true;
            this.uninstallButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uninstallButton.Enabled      = false;
            this.uninstallButton.IsAccent     = false;
            this.uninstallButton.Location     = new System.Drawing.Point(326, 332);
            this.uninstallButton.Name         = "uninstallButton";
            this.uninstallButton.Padding      = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.uninstallButton.Size         = new System.Drawing.Size(91, 26);
            this.uninstallButton.TabIndex     = 10001;
            this.uninstallButton.Text         = "Uninstall";
            this.uninstallButton.Click       += new System.EventHandler(this.OnUninstall);

            // 
            // progressLabelGames
            // 
            this.progressLabelGames.Anchor   = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabelGames.AutoEllipsis = true;
            this.progressLabelGames.Font     = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLabelGames.ForeColor = CreamInstaller.Components.ThemeManager.TextDisabled;
            this.progressLabelGames.Location = new System.Drawing.Point(12, 246);
            this.progressLabelGames.Name     = "progressLabelGames";
            this.progressLabelGames.Size     = new System.Drawing.Size(560, 12);
            this.progressLabelGames.TabIndex = 11;

            // 
            // progressLabelDLCs
            // 
            this.progressLabelDLCs.Anchor   = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabelDLCs.AutoEllipsis = true;
            this.progressLabelDLCs.Font     = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLabelDLCs.ForeColor = CreamInstaller.Components.ThemeManager.TextDisabled;
            this.progressLabelDLCs.Location = new System.Drawing.Point(12, 258);
            this.progressLabelDLCs.Name     = "progressLabelDLCs";
            this.progressLabelDLCs.Size     = new System.Drawing.Size(560, 12);
            this.progressLabelDLCs.TabIndex = 12;

            // 
            // sortCheckBox
            // 
            this.sortCheckBox.Anchor    = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortCheckBox.AutoSize  = true;
            this.sortCheckBox.BackColor = CreamInstaller.Components.ThemeManager.Background;
            this.sortCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortCheckBox.ForeColor = CreamInstaller.Components.ThemeManager.TextPrimary;
            this.sortCheckBox.Location  = new System.Drawing.Point(120, 335);
            this.sortCheckBox.Margin    = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.sortCheckBox.Name      = "sortCheckBox";
            this.sortCheckBox.Size      = new System.Drawing.Size(104, 20);
            this.sortCheckBox.TabIndex  = 10003;
            this.sortCheckBox.Text      = "Sort By Name";
            this.sortCheckBox.CheckedChanged += new System.EventHandler(this.OnSortCheckBoxChanged);

            // 
            // saveButton
            // 
            this.saveButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.AutoSize     = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Enabled      = false;
            this.saveButton.IsAccent     = false;
            this.saveButton.Location     = new System.Drawing.Point(424, 302);
            this.saveButton.Name         = "saveButton";
            this.saveButton.Size         = new System.Drawing.Size(70, 26);
            this.saveButton.TabIndex     = 10006;
            this.saveButton.Text         = "Save DLC";
            this.saveButton.Click       += new System.EventHandler(this.OnSaveDlc);

            // 
            // loadButton
            // 
            this.loadButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.AutoSize     = true;
            this.loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadButton.Enabled      = false;
            this.loadButton.IsAccent     = false;
            this.loadButton.Location     = new System.Drawing.Point(500, 302);
            this.loadButton.Name         = "loadButton";
            this.loadButton.Size         = new System.Drawing.Size(72, 26);
            this.loadButton.TabIndex     = 10005;
            this.loadButton.Text         = "Load DLC";
            this.loadButton.Click       += new System.EventHandler(this.OnLoadDlc);

            // 
            // resetKoaloaderButton
            // 
            this.resetKoaloaderButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetKoaloaderButton.AutoSize     = true;
            this.resetKoaloaderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetKoaloaderButton.Enabled      = false;
            this.resetKoaloaderButton.IsAccent     = false;
            this.resetKoaloaderButton.Location     = new System.Drawing.Point(12, 302);
            this.resetKoaloaderButton.Name         = "resetKoaloaderButton";
            this.resetKoaloaderButton.Size         = new System.Drawing.Size(105, 26);
            this.resetKoaloaderButton.TabIndex     = 10010;
            this.resetKoaloaderButton.Text         = "Reset Koaloader";
            this.resetKoaloaderButton.Click       += new System.EventHandler(this.OnResetKoaloader);

            // 
            // resetButton
            // 
            this.resetButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.AutoSize     = true;
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.Enabled      = false;
            this.resetButton.IsAccent     = false;
            this.resetButton.Location     = new System.Drawing.Point(344, 302);
            this.resetButton.Name         = "resetButton";
            this.resetButton.Size         = new System.Drawing.Size(74, 26);
            this.resetButton.TabIndex     = 10007;
            this.resetButton.Text         = "Reset DLC";
            this.resetButton.Click       += new System.EventHandler(this.OnResetDlc);

            // 
            // saveKoaloaderButton
            // 
            this.saveKoaloaderButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveKoaloaderButton.AutoSize     = true;
            this.saveKoaloaderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveKoaloaderButton.Enabled      = false;
            this.saveKoaloaderButton.IsAccent     = false;
            this.saveKoaloaderButton.Location     = new System.Drawing.Point(123, 302);
            this.saveKoaloaderButton.Name         = "saveKoaloaderButton";
            this.saveKoaloaderButton.Size         = new System.Drawing.Size(101, 26);
            this.saveKoaloaderButton.TabIndex     = 10009;
            this.saveKoaloaderButton.Text         = "Save Koaloader";
            this.saveKoaloaderButton.Click       += new System.EventHandler(this.OnSaveKoaloader);

            // 
            // loadKoaloaderButton
            // 
            this.loadKoaloaderButton.Anchor       = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadKoaloaderButton.AutoSize     = true;
            this.loadKoaloaderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadKoaloaderButton.Enabled      = false;
            this.loadKoaloaderButton.IsAccent     = false;
            this.loadKoaloaderButton.Location     = new System.Drawing.Point(230, 302);
            this.loadKoaloaderButton.Name         = "loadKoaloaderButton";
            this.loadKoaloaderButton.Size         = new System.Drawing.Size(103, 26);
            this.loadKoaloaderButton.TabIndex     = 10008;
            this.loadKoaloaderButton.Text         = "Load Koaloader";
            this.loadKoaloaderButton.Click       += new System.EventHandler(this.OnLoadKoaloader);

            // 
            // statusStrip
            // 
            this.statusStrip.BackColor  = CreamInstaller.Components.ThemeManager.Surface;
            this.statusStrip.Dock       = System.Windows.Forms.DockStyle.Bottom;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.statusLabelGames,
                this.statusLabelSep,
                this.statusLabelDLCs });
            this.statusStrip.Name       = "statusStrip";
            this.statusStrip.Size       = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex   = 20000;

            // 
            // statusLabelGames
            // 
            this.statusLabelGames.ForeColor   = CreamInstaller.Components.ThemeManager.TextSecondary;
            this.statusLabelGames.Name        = "statusLabelGames";
            this.statusLabelGames.Text        = "Ready";

            // 
            // statusLabelSep
            // 
            this.statusLabelSep.ForeColor     = CreamInstaller.Components.ThemeManager.Border;
            this.statusLabelSep.Name          = "statusLabelSep";
            this.statusLabelSep.Text          = " | ";

            // 
            // statusLabelDLCs
            // 
            this.statusLabelDLCs.ForeColor    = CreamInstaller.Components.ThemeManager.TextSecondary;
            this.statusLabelDLCs.Name         = "statusLabelDLCs";
            this.statusLabelDLCs.Text         = "";

            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = CreamInstaller.Components.ThemeManager.Background;
            this.ClientSize          = new System.Drawing.Size(584, 385);
            this.Controls.Add(this.loadKoaloaderButton);
            this.Controls.Add(this.saveKoaloaderButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resetKoaloaderButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.sortCheckBox);
            this.Controls.Add(this.progressLabelDLCs);
            this.Controls.Add(this.progressLabelGames);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.programsGroupBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered  = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox     = false;
            this.MinimizeBox     = true;
            this.MinimumSize     = new System.Drawing.Size(600, 420);
            this.Name            = "SelectForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.Manual;
            this.Text            = "SelectForm";
            this.Load           += new System.EventHandler(this.OnLoad);
            this.ResizeEnd      += new System.EventHandler(this.OnResizeEnd);
            this.programsGroupBox.ResumeLayout(false);
            this.programsGroupBox.PerformLayout();
            this.koaloaderFlowPanel.ResumeLayout(false);
            this.blockedGamesFlowPanel.ResumeLayout(false);
            this.allCheckBoxLayoutPanel.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DarkButton      installButton;
        private DarkButton      cancelButton;
        private System.Windows.Forms.GroupBox programsGroupBox;
        private DarkProgressBar progressBar;
        private System.Windows.Forms.Label    progressLabel;
        private System.Windows.Forms.CheckBox allCheckBox;
        private DarkButton      scanButton;
        private System.Windows.Forms.Label    noneFoundLabel;
        private CustomTreeView  selectionTreeView;
        private System.Windows.Forms.CheckBox blockedGamesCheckBox;
        private DarkButton      blockProtectedHelpButton;
        private System.Windows.Forms.FlowLayoutPanel blockedGamesFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel allCheckBoxLayoutPanel;
        private DarkButton      uninstallButton;
        private System.Windows.Forms.Label    progressLabelGames;
        private System.Windows.Forms.Label    progressLabelDLCs;
        private System.Windows.Forms.CheckBox sortCheckBox;
        private System.Windows.Forms.FlowLayoutPanel koaloaderFlowPanel;
        private System.Windows.Forms.CheckBox koaloaderAllCheckBox;
        private DarkButton      saveButton;
        private DarkButton      loadButton;
        private DarkButton      resetKoaloaderButton;
        private DarkButton      resetButton;
        private DarkButton      saveKoaloaderButton;
        private DarkButton      loadKoaloaderButton;
        private System.Windows.Forms.TextBox         searchTextBox;
        private System.Windows.Forms.StatusStrip     statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelGames;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSep;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelDLCs;
    }
}
