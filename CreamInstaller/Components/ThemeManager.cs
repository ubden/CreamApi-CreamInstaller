using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CreamInstaller.Components;

internal static class ThemeManager
{
    // ── Color Palette ──────────────────────────────────────────────────────────
    internal static readonly Color Background    = Color.FromArgb(18,  18,  28);   // #12121C
    internal static readonly Color Surface       = Color.FromArgb(26,  26,  40);   // #1A1A28
    internal static readonly Color SurfaceHover  = Color.FromArgb(34,  34,  54);   // #222236
    internal static readonly Color Border        = Color.FromArgb(45,  45,  70);   // #2D2D46
    internal static readonly Color Accent        = Color.FromArgb(99,  102, 241);  // #6366F1 indigo
    internal static readonly Color AccentHover   = Color.FromArgb(129, 140, 248);  // #818CF8
    internal static readonly Color AccentPressed = Color.FromArgb(79,  70,  229);  // #4F46E5
    internal static readonly Color TextPrimary   = Color.FromArgb(240, 240, 255);  // #F0F0FF
    internal static readonly Color TextSecondary = Color.FromArgb(148, 148, 185);  // #9494B9
    internal static readonly Color TextDisabled  = Color.FromArgb(135, 135, 170); // #8787AA  (brighter for dark bg)
    internal static readonly Color Success       = Color.FromArgb(34,  197, 94);   // #22C55E
    internal static readonly Color Warning       = Color.FromArgb(251, 191, 36);   // #FBBF24
    internal static readonly Color Error         = Color.FromArgb(239, 68,  68);   // #EF4444
    internal static readonly Color LogBg         = Color.FromArgb(12,  12,  20);   // #0C0C14

    // ── Corner Radius ──────────────────────────────────────────────────────────
    internal const int CornerRadius = 6;

    // ── Apply theme recursively to all controls ────────────────────────────────
    internal static void Apply(Control root)
    {
        ApplySingle(root);
        foreach (Control child in root.Controls)
            Apply(child);
    }

    private static void ApplySingle(Control c)
    {
        c.BackColor = c switch
        {
            GroupBox        => Background,
            FlowLayoutPanel => Background,   // must be before Panel
            Panel           => Background,
            RichTextBox     => LogBg,
            TextBox         => Surface,
            TreeView        => Background,
            StatusStrip     => Surface,
            _               => Background
        };

        c.ForeColor = (!c.Enabled) ? TextDisabled : TextPrimary;

        switch (c)
        {
            case ProgressBar pb:
                // DarkProgressBar handles its own painting; skip default coloring
                break;

            case TreeView tv:
                tv.BackColor  = Background;
                tv.ForeColor  = TextPrimary;
                tv.BorderStyle = BorderStyle.None;
                break;

            case TextBox tb:
                tb.BackColor  = Surface;
                tb.ForeColor  = TextPrimary;
                tb.BorderStyle = BorderStyle.FixedSingle;
                break;

            case RichTextBox rtb:
                rtb.BackColor = LogBg;
                rtb.ForeColor = TextPrimary;
                rtb.BorderStyle = BorderStyle.None;
                break;

            case GroupBox gb:
                gb.ForeColor = TextSecondary;
                gb.Paint    += PaintGroupBox;
                break;

            case StatusStrip ss:
                ss.BackColor  = Surface;
                ss.ForeColor  = TextSecondary;
                ss.RenderMode = ToolStripRenderMode.ManagerRenderMode;
                ToolStripManager.Renderer = new DarkToolStripRenderer();
                break;

            case CheckBox cb:
                cb.FlatStyle = FlatStyle.Flat;
                cb.FlatAppearance.BorderColor = cb.Enabled ? Color.FromArgb(99, 102, 241) : Border;
                cb.FlatAppearance.CheckedBackColor = Accent;
                cb.FlatAppearance.MouseOverBackColor = SurfaceHover;
                cb.FlatAppearance.BorderSize = 1;
                // FlatStyle.Flat ignores ForeColor when disabled; keep it light via EnabledChanged
                cb.ForeColor = cb.Enabled ? TextPrimary : TextDisabled;
                cb.EnabledChanged += (s, _) =>
                {
                    if (s is not CheckBox c) return;
                    c.ForeColor = c.Enabled ? TextPrimary : TextDisabled;
                    c.FlatAppearance.BorderColor = c.Enabled ? Color.FromArgb(99, 102, 241) : Border;
                };
                break;
        }
    }

    // ── GroupBox custom paint (dark border + label, no full clear to preserve child controls) ─
    private static void PaintGroupBox(object sender, PaintEventArgs e)
    {
        if (sender is not GroupBox gb) return;
        Graphics g = e.Graphics;

        // Fill only the interior area (below the title strip) — do NOT clear the full
        // GroupBox which would paint over header-area child controls (checkboxes etc.)
        using SolidBrush bgBrush = new(Background);
        int titleHeight = string.IsNullOrEmpty(gb.Text) ? 0 : (int)g.MeasureString(gb.Text, gb.Font).Height;
        int headerH = Math.Max(titleHeight, 20);
        // Fill content area below the header strip
        g.FillRectangle(bgBrush, 0, headerH, gb.Width, gb.Height - headerH);
        // Fill the thin strip on each side of the title text (left of it and right of it)
        SizeF textSize = string.IsNullOrEmpty(gb.Text) ? SizeF.Empty : g.MeasureString(gb.Text, gb.Font);
        if (!string.IsNullOrEmpty(gb.Text))
        {
            g.FillRectangle(bgBrush, 0, 0, 8, headerH);
            g.FillRectangle(bgBrush, 8 + (int)textSize.Width + 4, 0, gb.Width - (8 + (int)textSize.Width + 4), headerH);
        }
        else
        {
            g.FillRectangle(bgBrush, 0, 0, gb.Width, headerH);
        }

        // Border
        using Pen borderPen = new(Border, 1);
        int borderOffset = string.IsNullOrEmpty(gb.Text) ? 0 : headerH / 2;
        Rectangle rect = new(0, borderOffset, gb.Width - 1, gb.Height - 1 - borderOffset);
        g.DrawRectangle(borderPen, rect);

        // Title text
        if (!string.IsNullOrEmpty(gb.Text))
        {
            using SolidBrush textBrush = new(TextSecondary);
            g.DrawString(gb.Text, gb.Font, textBrush, 10, (headerH - textSize.Height) / 2f);
        }
    }

    // ── Rounded rectangle helper ───────────────────────────────────────────────
    internal static GraphicsPath RoundedRect(Rectangle bounds, int radius)
    {
        int d = radius * 2;
        GraphicsPath path = new();
        path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
        path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
        path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }

    // ── Draw accent-filled button ──────────────────────────────────────────────
    internal static void DrawButton(Graphics g, Rectangle bounds, string text, Font font,
        bool enabled, bool hovered, bool pressed, bool isAccent = true)
    {
        g.SmoothingMode     = SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        Color fill = !enabled  ? Color.FromArgb(40, 40, 60) :
                     pressed   ? AccentPressed :
                     hovered   ? AccentHover   :
                     isAccent  ? Accent        : Surface;

        Color border = !enabled ? Border :
                       hovered || pressed ? AccentHover : Accent;

        Color textColor = !enabled ? TextDisabled : TextPrimary;

        using GraphicsPath path = RoundedRect(bounds, CornerRadius);
        using SolidBrush fillBrush = new(fill);
        g.FillPath(fillBrush, path);

        using Pen pen = new(border, 1f);
        g.DrawPath(pen, path);

        TextRenderer.DrawText(g, text, font, bounds, textColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
    }

    // ── Dark ToolStrip renderer (for StatusStrip) ──────────────────────────────
    private sealed class DarkToolStripRenderer : ToolStripProfessionalRenderer
    {
        public DarkToolStripRenderer() : base(new DarkColorTable()) { }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
            => e.Graphics.Clear(Surface);

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            using Pen pen = new(Border);
            e.Graphics.DrawLine(pen, 0, 0, 0, e.Item.Height);
        }
    }

    private sealed class DarkColorTable : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin   => Surface;
        public override Color ToolStripGradientMiddle  => Surface;
        public override Color ToolStripGradientEnd     => Surface;
        public override Color StatusStripGradientBegin => Surface;
        public override Color StatusStripGradientEnd   => Surface;
    }
}
