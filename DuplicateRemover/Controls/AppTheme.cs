using System.Drawing.Drawing2D;

namespace DuplicateRemover.Controls;

internal static class AppTheme
{
    internal static readonly Color Background = Color.FromArgb(24, 29, 38);
    internal static readonly Color Surface = Color.FromArgb(33, 41, 54);
    internal static readonly Color Button = Color.FromArgb(46, 58, 76);
    internal static readonly Color Border = Color.FromArgb(73, 88, 110);
    internal static readonly Color Text = Color.FromArgb(230, 237, 246);
    internal static readonly Color Muted = Color.FromArgb(164, 181, 202);
    internal static readonly Color Accent = Color.FromArgb(65, 112, 220);

    internal static GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
    {
        var path = new GraphicsPath();
        int diameter = Math.Max(1, Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height)));
        path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
        path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();
        return path;
    }
}

internal sealed class RoundedButton : Button
{
    private bool _hovered;
    private bool _pressed;

    public RoundedButton()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        UseVisualStyleBackColor = false;
    }

    protected override void OnMouseEnter(EventArgs e) { _hovered = true; Invalidate(); base.OnMouseEnter(e); }
    protected override void OnMouseLeave(EventArgs e) { _hovered = _pressed = false; Invalidate(); base.OnMouseLeave(e); }
    protected override void OnMouseDown(MouseEventArgs e) { _pressed = e.Button == MouseButtons.Left; Invalidate(); base.OnMouseDown(e); }
    protected override void OnMouseUp(MouseEventArgs e) { _pressed = false; Invalidate(); base.OnMouseUp(e); }
    protected override void OnKeyDown(KeyEventArgs e) { if (e.KeyCode == Keys.Space) { _pressed = true; Invalidate(); } base.OnKeyDown(e); }
    protected override void OnKeyUp(KeyEventArgs e) { _pressed = false; Invalidate(); base.OnKeyUp(e); }
    protected override void OnLostFocus(EventArgs e) { _pressed = false; Invalidate(); base.OnLostFocus(e); }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.Clear(Parent?.BackColor ?? AppTheme.Background);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        if (Width < 2 || Height < 2) return;
        using var outline = AppTheme.RoundedRectangle(new Rectangle(0, 0, Width - 1, Height - 1), LogicalToDeviceUnits(8));
        Color fill = !Enabled ? AppTheme.Surface : _pressed ? ControlPaint.Dark(BackColor, .12f) : _hovered ? ControlPaint.Light(BackColor, .12f) : BackColor;
        using var brush = new SolidBrush(fill);
        using var border = new Pen(Focused ? AppTheme.Muted : AppTheme.Border);
        e.Graphics.FillPath(brush, outline);
        e.Graphics.DrawPath(border, outline);
        TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, Enabled ? ForeColor : AppTheme.Muted,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
        if (Focused && ShowFocusCues)
            ControlPaint.DrawFocusRectangle(e.Graphics, Rectangle.Inflate(ClientRectangle, -5, -5), ForeColor, fill);
    }
}

internal sealed class RoundedSurface : Panel
{
    internal RoundedSurface(Control content)
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
        Dock = DockStyle.Fill;
        Padding = new Padding(8);
        content.Dock = content is TextBox ? DockStyle.None : DockStyle.Fill;
        content.BackColor = AppTheme.Surface;
        content.ForeColor = AppTheme.Text;
        Controls.Add(content);
    }

    public override Size GetPreferredSize(Size proposedSize)
    {
        if (Controls.Count == 1 && Controls[0] is TextBox textBox)
            return new Size(textBox.PreferredSize.Width + Padding.Horizontal,
                textBox.PreferredHeight + Padding.Vertical);
        return base.GetPreferredSize(proposedSize);
    }

    protected override void OnLayout(LayoutEventArgs e)
    {
        base.OnLayout(e);
        if (Controls.Count == 1 && Controls[0] is TextBox textBox)
        {
            // Single-line native text boxes keep their preferred height; reserve room
            // for both rounded borders instead of squeezing them into a fixed row.
            int height = textBox.PreferredHeight;
            textBox.SetBounds(Padding.Left, Math.Max(Padding.Top, (ClientSize.Height - height) / 2),
                Math.Max(0, ClientSize.Width - Padding.Horizontal), height);
        }
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (Width < 2 || Height < 2) return;
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var outline = AppTheme.RoundedRectangle(new Rectangle(0, 0, Width - 1, Height - 1), LogicalToDeviceUnits(8));
        using var brush = new SolidBrush(AppTheme.Surface);
        using var pen = new Pen(AppTheme.Border);
        e.Graphics.FillPath(brush, outline);
        e.Graphics.DrawPath(pen, outline);
    }
}
