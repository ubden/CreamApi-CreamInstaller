using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CreamInstaller.Forms;

namespace CreamInstaller.Components;

internal class CustomForm : Form
{
    internal const short SWP_NOACTIVATE = 0x0010;
    internal const short SWP_SHOWWINDOW = 0x0040;
    internal const short SWP_NOMOVE     = 0x0002;
    internal const short SWP_NOSIZE     = 0x0001;

    internal static readonly nint HWND_NOTOPMOST = new(-2);
    internal static readonly nint HWND_TOPMOST   = new(-1);

    // ── DWM: dark title bar ───────────────────────────────────────────────────
    // ANTIVIRUS FALSE POSITIVE WARNING:
    // DwmSetWindowAttribute is a Windows API used only to enable the dark mode title
    // bar (DWMWA_USE_IMMERSIVE_DARK_MODE = 20) on this application's own window.
    // This is standard Windows 10/11 dark-mode UI integration.
    [DllImport("dwmapi.dll", SetLastError = false)]
    [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    private static extern int DwmSetWindowAttribute(nint hwnd, int attr, ref int attrValue, int attrSize);

    internal CustomForm()
    {
        Icon       = Properties.Resources.Icon;
        KeyPreview = true;
        KeyPress  += OnKeyPress;
        ResizeRedraw = true;
        HelpButton   = true;
        HelpButtonClicked += OnHelpButtonClicked;
    }

    internal CustomForm(IWin32Window owner) : this()
    {
        if (owner is not Form form) return;
        Owner = form;
        InheritLocation(form);
        SizeChanged += (_, _) => InheritLocation(form);
        form.Activated += OnActivation;
        FormClosing    += (_, _) => form.Activated -= OnActivation;
        TopLevel = true;
    }

    // Double-buffering for all controls
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x02; // WS_EX_COMPOSITED
            return cp;
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);

        // Enable dark title bar on Windows 10 20H1+ and Windows 11
        int dark = 1;
        _ = DwmSetWindowAttribute(Handle, 20 /* DWMWA_USE_IMMERSIVE_DARK_MODE */, ref dark, sizeof(int));

        // Apply dark theme to this form and all its controls
        BackColor = ThemeManager.Background;
        ForeColor = ThemeManager.TextPrimary;
        ThemeManager.Apply(this);
    }

    // ── Help button → comprehensive Help & Disclaimer dialog ─────────────────
    private void OnHelpButtonClicked(object sender, EventArgs args)
    {
        using DialogForm helpDialog = new(this);
        helpDialog.HelpButton = false;

        string repo        = $"https://github.com/{Program.RepositoryOwner}/{Program.RepositoryName}";
        string acidicoala  = "https://github.com/acidicoala";
        string discussions = Program.CommunityDiscussions;
        string forum       = Program.CommunityForum;
        string abuse       = Program.AbuseEmail;
        string donate      = Program.DonateUrl;

        _ = helpDialog.Show(SystemIcons.Information,
            $"CreamInstaller v{Program.Version.Split('+')[0]}  —  Help & Disclaimer\n"
          + "----------------------------------------------------------------\n"
          + "\n"
          + "[!] DISCLAIMER\n"
          + "This software is an open-source project developed for the community\n"
          + "and is NOT affiliated with any organization or institution.\n"
          + "It is shared purely for EDUCATIONAL PURPOSES and software development\n"
          + "testing. This software is NOT intended for production use.\n"
          + "We strongly recommend purchasing professionally licensed software.\n"
          + "\n"
          + "----------------------------------------------------------------\n"
          + "\n"
          + "[S] ANTIVIRUS / FALSE POSITIVE WARNING\n"
          + "All software that modifies or interacts with DLL files may be flagged\n"
          + "by antivirus programs. The ENTIRE PROJECT IS OPEN SOURCE — no\n"
          + "encrypted or obfuscated code is included. If flagged, it is a false\n"
          + "positive. This software is FOR EXPERIENCED USERS ONLY.\n"
          + "\n"
          + "----------------------------------------------------------------\n"
          + "\n"
          + "[=] LEGAL RESPONSIBILITY\n"
          + "By using this software, you agree that ALL RESPONSIBILITY LIES WITH\n"
          + "YOU, THE USER. The platform and its contributors provide this software\n"
          + "\"as is\", without any warranty of any kind, express or implied.\n"
          + "USE AT YOUR OWN RISK.\n"
          + "\n"
          + "----------------------------------------------------------------\n"
          + "\n"
          + "[i] ABOUT\n"
          + "Automatically finds all installed Steam, Epic and Ubisoft games with\n"
          + "their DLC-related DLL locations, parses SteamCMD / Steam Store /\n"
          + "Epic Games Store for DLCs, then provides a graphical interface for\n"
          + "maintenance of DLC unlockers.\n"
          + "\n"
          + $"Utilizes [Koaloader]({acidicoala}/Koaloader), [SmokeAPI]({acidicoala}/SmokeAPI),\n"
          + $"[ScreamAPI]({acidicoala}/ScreamAPI), [Uplay R1 Unlocker]({acidicoala}/UplayR1Unlocker)\n"
          + $"and [Uplay R2 Unlocker]({acidicoala}/UplayR2Unlocker) by [acidicoala]({acidicoala}).\n"
          + "\n"
          + "----------------------------------------------------------------\n"
          + "\n"
          + "[C] COMMUNITY SUPPORT  (NO OFFICIAL SUPPORT IS PROVIDED)\n"
          + $"  - GitHub Discussions : [{discussions}]({discussions})\n"
          + $"  - ubden Forum        : [{forum}]({forum})\n"
          + "\n"
          + "----------------------------------------------------------------\n"
          + "\n"
          + $"  Report abuse / misuse : [{abuse}](mailto:{abuse})\n"
          + $"  Support the community : [{donate}]({donate})\n"
          + $"  Source code           : [{repo}]({repo})\n");
    }

    private void OnActivation(object sender, EventArgs args) => Activate();

    // ANTIVIRUS FALSE POSITIVE WARNING:
    // SetWindowPos is imported from user32.dll to bring this application's own window
    // to the front without stealing focus (SWP_NOACTIVATE). Standard WinForms technique.
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    private static extern void SetWindowPos(nint hWnd, nint hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

    internal void BringToFrontWithoutActivation()
    {
        bool topMost = TopMost;
        SetWindowPos(Handle, HWND_TOPMOST,   0, 0, 0, 0, SWP_NOACTIVATE | SWP_SHOWWINDOW | SWP_NOMOVE | SWP_NOSIZE);
        if (!topMost)
            SetWindowPos(Handle, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE | SWP_SHOWWINDOW | SWP_NOMOVE | SWP_NOSIZE);
    }

    internal void InheritLocation(Form fromForm)
    {
        if (fromForm is null) return;
        int X = fromForm.Location.X + fromForm.Size.Width  / 2 - Size.Width  / 2;
        int Y = fromForm.Location.Y + fromForm.Size.Height / 2 - Size.Height / 2;
        Location = new(X, Y);
    }

    // ANTIVIRUS FALSE POSITIVE WARNING:
    // Shift+S captures only this application's own window area via CopyFromScreen and
    // copies it to the clipboard as a bitmap — a built-in debug screenshot helper.
    // It is NOT a keylogger and reads nothing outside this window.
    private void OnKeyPress(object s, KeyPressEventArgs e)
    {
        if (e.KeyChar != 'S') return; // Shift + S
        UpdateBounds();
        Rectangle bounds = Bounds;
        using Bitmap bitmap = new(Size.Width - 14, Size.Height - 7);
        using Graphics graphics = Graphics.FromImage(bitmap);
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        using EncoderParameters encoding  = new(1);
        using EncoderParameter encoderParam = new(Encoder.Quality, 100L);
        encoding.Param[0] = encoderParam;
        graphics.CopyFromScreen(new(bounds.Left + 7, bounds.Top), Point.Empty,
            new(Size.Width - 14, Size.Height - 7));
        Clipboard.SetImage(bitmap);
        e.Handled = true;
    }
}
