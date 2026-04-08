using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CreamInstaller.Utility;

/// <summary>
/// Persistent application settings stored as JSON in %AppData%\CreamInstaller\settings.json.
/// </summary>
internal sealed class AppSettings
{
    private static readonly string SettingsPath =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "CreamInstaller", "settings.json");

    private static AppSettings _current;
    internal static AppSettings Current => _current ??= Load();

    // ── Settings properties ────────────────────────────────────────────────────
    [JsonProperty]
    internal bool SortByName { get; set; } = false;

    [JsonProperty]
    internal bool RememberWindowPositions { get; set; } = true;

    [JsonProperty]
    internal int MainWindowX { get; set; } = -1;

    [JsonProperty]
    internal int MainWindowY { get; set; } = -1;

    [JsonProperty]
    internal int SelectWindowX { get; set; } = -1;

    [JsonProperty]
    internal int SelectWindowY { get; set; } = -1;

    [JsonProperty]
    internal int SelectWindowWidth { get; set; } = 600;

    [JsonProperty]
    internal int SelectWindowHeight { get; set; } = 400;

    [JsonProperty]
    internal DateTime? LastScanTime { get; set; } = null;

    [JsonProperty]
    internal bool DisclaimerShown { get; set; } = false;

    // ── Load / Save ────────────────────────────────────────────────────────────
    internal static AppSettings Load()
    {
        try
        {
            if (File.Exists(SettingsPath))
            {
                string json = File.ReadAllText(SettingsPath);
                AppSettings loaded = JsonConvert.DeserializeObject<AppSettings>(json);
                if (loaded is not null)
                    return loaded;
            }
        }
        catch
        {
            // ignored — fall through to defaults
        }
        return new AppSettings();
    }

    internal void Save()
    {
        try
        {
            string dir = Path.GetDirectoryName(SettingsPath);
            if (dir is not null && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            File.WriteAllText(SettingsPath, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
        catch
        {
            // ignored
        }
    }

    /// <summary>Saves the position and size of a form if RememberWindowPositions is enabled.</summary>
    internal void SaveFormState(Form form, bool saveSize = false)
    {
        if (!RememberWindowPositions || form is null) return;
        if (form.WindowState != FormWindowState.Normal) return;

        switch (form)
        {
            case Forms.MainForm:
                MainWindowX = form.Location.X;
                MainWindowY = form.Location.Y;
                break;
            case Forms.SelectForm:
                SelectWindowX = form.Location.X;
                SelectWindowY = form.Location.Y;
                if (saveSize)
                {
                    SelectWindowWidth  = form.Size.Width;
                    SelectWindowHeight = form.Size.Height;
                }
                break;
        }
        Save();
    }

    /// <summary>Restores the position (and optionally size) of a form.</summary>
    internal void RestoreFormState(Form form, bool restoreSize = false)
    {
        if (!RememberWindowPositions || form is null) return;

        int x = -1, y = -1, w = 0, h = 0;
        switch (form)
        {
            case Forms.MainForm:
                x = MainWindowX; y = MainWindowY;
                break;
            case Forms.SelectForm:
                x = SelectWindowX; y = SelectWindowY;
                w = SelectWindowWidth; h = SelectWindowHeight;
                break;
        }

        if (x < 0 || y < 0) return;

        form.StartPosition = FormStartPosition.Manual;
        form.Location      = new System.Drawing.Point(x, y);
        if (restoreSize && w > 200 && h > 100)
            form.Size = new System.Drawing.Size(w, h);
    }
}
