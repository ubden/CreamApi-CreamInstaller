using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CreamInstaller.Components;

/// <summary>
/// Owner-drawn progress bar with a gradient fill, rounded corners,
/// and an optional animated shimmer effect.
/// </summary>
internal sealed class DarkProgressBar : ProgressBar
{
    private readonly Timer _shimmerTimer;
    private int _shimmerOffset;

    internal DarkProgressBar()
    {
        SetStyle(ControlStyles.UserPaint
               | ControlStyles.AllPaintingInWmPaint
               | ControlStyles.OptimizedDoubleBuffer, true);

        _shimmerTimer = new Timer { Interval = 30 };
        _shimmerTimer.Tick += (_, _) =>
        {
            _shimmerOffset = (_shimmerOffset + 4) % Math.Max(1, Width);
            Invalidate();
        };
    }

    // Start shimmer when at 0 (indeterminate-like) or actively progressing
    private void UpdateShimmer()
    {
        bool active = Value > 0 && Value < Maximum;
        if (active && !_shimmerTimer.Enabled)  _shimmerTimer.Start();
        if (!active && _shimmerTimer.Enabled)  _shimmerTimer.Stop();
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        // PBM_SETPOS (0x402) or PBM_DELTAPOS (0x403) sent when Value changes
        if (m.Msg is 0x402 or 0x403 or 0x404 or 0x406)
        {
            UpdateShimmer();
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle bg = new(0, 0, Width - 1, Height - 1);
        using GraphicsPath bgPath = ThemeManager.RoundedRect(bg, ThemeManager.CornerRadius);
        using SolidBrush bgBrush  = new(ThemeManager.Surface);
        g.FillPath(bgBrush, bgPath);

        using Pen borderPen = new(ThemeManager.Border, 1f);
        g.DrawPath(borderPen, bgPath);

        if (Maximum <= 0) return;

        int fillWidth = (int)((double)Value / Maximum * (Width - 2));
        if (fillWidth <= 0) return;

        Rectangle fillRect = new(1, 1, fillWidth, Height - 3);
        using GraphicsPath fillPath = ThemeManager.RoundedRect(fillRect, ThemeManager.CornerRadius - 1);

        using LinearGradientBrush fillBrush = new(
            fillRect.IsEmpty ? new Rectangle(0, 0, 1, 1) : fillRect,
            ThemeManager.Accent,
            ThemeManager.AccentHover,
            LinearGradientMode.Horizontal);
        g.FillPath(fillBrush, fillPath);

        // Shimmer overlay
        if (_shimmerTimer.Enabled && fillWidth > 20)
        {
            int sw = Math.Min(60, fillWidth);
            int sx = _shimmerOffset % (fillWidth + sw) - sw;
            Rectangle shimmerRect = new(1 + sx, 1, sw, Height - 3);
            shimmerRect.Intersect(fillRect);
            if (shimmerRect.Width > 0)
            {
                using LinearGradientBrush shimmer = new(
                    new Rectangle(1 + sx, 1, sw + 1, Height - 3),
                    Color.FromArgb(0, Color.White),
                    Color.FromArgb(50, Color.White),
                    LinearGradientMode.Horizontal);
                shimmer.SetBlendTriangularShape(0.5f);
                g.FillRectangle(shimmer, shimmerRect);
            }
        }

        // Percentage text
        if (Value > 0 && Height >= 16)
        {
            string pct = $"{(int)((double)Value / Maximum * 100)}%";
            using Font f = new("Segoe UI", 7.5f, FontStyle.Bold, GraphicsUnit.Point);
            TextRenderer.DrawText(g, pct, f, bg, ThemeManager.TextPrimary,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing) _shimmerTimer.Dispose();
        base.Dispose(disposing);
    }
}
