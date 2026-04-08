using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CreamInstaller.Components;

/// <summary>
/// A custom owner-drawn button with dark theme, rounded corners,
/// and smooth hover/pressed state transitions.
/// </summary>
internal class DarkButton : Button
{
    private bool _hovered;
    private bool _pressed;

    /// <summary>When true, uses Accent fill. When false, uses Surface (outline style).</summary>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    internal bool IsAccent { get; set; } = true;

    internal DarkButton()
    {
        SetStyle(ControlStyles.UserPaint
               | ControlStyles.AllPaintingInWmPaint
               | ControlStyles.OptimizedDoubleBuffer
               | ControlStyles.ResizeRedraw, true);
        FlatStyle   = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor   = ThemeManager.Background;
        ForeColor   = ThemeManager.TextPrimary;
        Font        = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
        Cursor      = Cursors.Hand;
        UseCompatibleTextRendering = false;
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        _hovered = true;
        Invalidate();
        base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        _hovered = false;
        Invalidate();
        base.OnMouseLeave(e);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left) { _pressed = true; Invalidate(); }
        base.OnMouseDown(e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        _pressed = false;
        Invalidate();
        base.OnMouseUp(e);
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
        Invalidate();
        base.OnEnabledChanged(e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode     = SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        Rectangle bounds = new(0, 0, Width - 1, Height - 1);
        ThemeManager.DrawButton(g, bounds, Text, Font, Enabled, _hovered, _pressed, IsAccent);

        // Focus rectangle
        if (Focused && ShowFocusCues)
        {
            Rectangle focusRect = new(2, 2, Width - 5, Height - 5);
            using Pen focusPen = new(Color.FromArgb(100, ThemeManager.AccentHover), 1f) { DashStyle = DashStyle.Dot };
            using GraphicsPath fp = ThemeManager.RoundedRect(focusRect, ThemeManager.CornerRadius - 1);
            g.DrawPath(focusPen, fp);
        }
    }
}
