using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace CreamInstaller.Utility;

internal static class IconGrabber
{
    internal const string SteamAppImagesPath = "https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/apps/";

    internal const string GoogleFaviconsApiUrl = "https://www.google.com/s2/favicons";

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool DestroyIcon(IntPtr hIcon);

    internal static Icon ToIcon(this Image image)
    {
        using Bitmap dialogIconBitmap = new(image, new(image.Width, image.Height));
        IntPtr hIcon = dialogIconBitmap.GetHicon();
        try
        {
            return (Icon)Icon.FromHandle(hIcon).Clone();
        }
        finally
        {
            DestroyIcon(hIcon);
        }
    }

    internal static string GetDomainFaviconUrl(string domain, int size = 16) => GoogleFaviconsApiUrl + $"?domain={domain}&sz={size}";

    internal static Image GetFileIconImage(this string path) => File.Exists(path) ? Icon.ExtractAssociatedIcon(path)?.ToBitmap() : null;

    internal static Image GetNotepadImage() => GetFileIconImage(Diagnostics.GetNotepadPath());

    internal static Image GetCommandPromptImage() => GetFileIconImage(Environment.SystemDirectory + @"\cmd.exe");

    internal static Image GetFileExplorerImage() => GetFileIconImage(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\explorer.exe");
}