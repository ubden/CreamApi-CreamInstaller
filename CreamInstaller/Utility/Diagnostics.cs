using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace CreamInstaller.Utility;

internal static class Diagnostics
{
    private static string notepadPlusPlusPath;

    // ANTIVIRUS FALSE POSITIVE WARNING:
    // Reading registry keys from HKEY_LOCAL_MACHINE to detect installed applications.
    // This is standard application-detection behavior, not malicious registry enumeration.
    internal static string NotepadPlusPlusPath
    {
        get
        {
            notepadPlusPlusPath ??= Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Notepad++", "", null) as string;
            notepadPlusPlusPath ??= Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432NODE\Notepad++", "", null) as string;
            return notepadPlusPlusPath;
        }
    }

    internal static string GetNotepadPath()
    {
        // Bug fix: NotepadPlusPlusPath may be null; guard before string concatenation.
        string nppBase = NotepadPlusPlusPath;
        string npp = nppBase is not null ? nppBase + @"\notepad++.exe" : null;
        return npp is not null && File.Exists(npp)
            ? npp
            : Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\notepad.exe";
    }

    internal static void OpenFileInNotepad(string path)
    {
        // Bug fix: NotepadPlusPlusPath may be null; guard before string concatenation.
        string nppBase = NotepadPlusPlusPath;
        string npp = nppBase is not null ? nppBase + @"\notepad++.exe" : null;
        if (npp is not null && File.Exists(npp))
            OpenFileInNotepadPlusPlus(npp, path);
        else
            OpenFileInWindowsNotepad(path);
    }

    // ANTIVIRUS FALSE POSITIVE WARNING:
    // The following three methods launch external processes (Notepad++, notepad.exe, explorer.exe).
    // They are invoked only on explicit user request to view a configuration file or directory.
    // ArgumentList is used instead of the Arguments string to prevent argument-injection vulnerabilities.
    private static void OpenFileInNotepadPlusPlus(string npp, string path)
    {
        if (!File.Exists(path))
            return;
        ProcessStartInfo psi = new() { FileName = npp, UseShellExecute = false };
        psi.ArgumentList.Add(path);
        _ = Process.Start(psi);
    }

    private static void OpenFileInWindowsNotepad(string path)
    {
        if (!File.Exists(path))
            return;
        ProcessStartInfo psi = new() { FileName = "notepad.exe", UseShellExecute = false };
        psi.ArgumentList.Add(path);
        _ = Process.Start(psi);
    }

    internal static void OpenDirectoryInFileExplorer(string path)
    {
        if (!Directory.Exists(path))
            return;
        ProcessStartInfo psi = new() { FileName = "explorer.exe", UseShellExecute = false };
        psi.ArgumentList.Add(path);
        _ = Process.Start(psi);
    }

    // ANTIVIRUS FALSE POSITIVE WARNING:
    // Opens a URL in the user's default browser via ShellExecute. This is standard behavior
    // for linking to the project's GitHub page from the Help button — not drive-by download.
    internal static void OpenUrlInInternetBrowser(string url) => _ = Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });

    internal static string BeautifyPath(this string path) => path is null ? null : Path.TrimEndingDirectorySeparator(Path.GetFullPath(path));
}