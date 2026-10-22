using DuplicateRemover.Controls;

namespace DuplicateRemover;

partial class Form1
{
    private TextBox directory = null!;
    private Button browse = null!, scan = null!, cancel = null!, autoClean = null!, keepSelected = null!, keepFirst = null!, deleteSelected = null!, openFolder = null!, saveLog = null!, clearLog = null!;
    private CheckBox subfolders = null!;
    private ComboBox filter = null!;
    private ListBox files = null!, paths = null!;
    private Label summary = null!, status = null!, hash = null!;
    private ProgressBar progress = null!;
    private RichTextBox log = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) { _worker.Dispose(); _cancellation?.Dispose(); }
        base.Dispose(disposing);
    }

    private static Button ActionButton(string text, EventHandler action, bool primary = false)
    {
        var button = new RoundedButton { Text = text, AutoSize = true, MinimumSize = new Size(100, 34), FlatStyle = FlatStyle.Flat,
            Padding = new Padding(8, 3, 8, 3), Margin = new Padding(0, 3, 8, 3),
            BackColor = primary ? AppTheme.Accent : AppTheme.Button,
            ForeColor = AppTheme.Text };
        button.FlatAppearance.BorderColor = AppTheme.Border;
        button.Click += action;
        return button;
    }

    private static FlowLayoutPanel Toolbar(params Control[] controls)
    {
        var panel = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink, Margin = Padding.Empty, WrapContents = true };
        panel.Controls.AddRange(controls);
        return panel;
    }

    private void InitializeComponent()
    {
        SuspendLayout();
        Text = "Duplicate File Remover";
        Icon = (Icon)new System.ComponentModel.ComponentResourceManager(typeof(Form1)).GetObject("$this.Icon");
        Font = new Font("Segoe UI", 10);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1180, 800);
        MinimumSize = new Size(1000, 720);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = AppTheme.Background;
        ForeColor = AppTheme.Text;
        var root = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(20), ColumnCount = 1, RowCount = 8 };
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        foreach (var height in new float[] { 46, 46, 44, 32 }) root.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
        root.RowStyles[2] = new RowStyle(SizeType.AutoSize);
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 54));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
        root.Controls.Add(new Label { Text = "Duplicate File Remover", Font = new Font("Segoe UI Semibold", 22), AutoSize = true }, 0, 0);
        directory = new TextBox { BorderStyle = BorderStyle.None, Dock = DockStyle.Fill, PlaceholderText = "Choose or enter a folder…", AccessibleName = "Folder path" };
        browse = ActionButton("Browse…", Browse);
        var folderRow = new TableLayoutPanel { Dock = DockStyle.Fill, Margin = Padding.Empty, ColumnCount = 2, RowCount = 1 };
        folderRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        folderRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        folderRow.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        folderRow.Controls.Add(new RoundedSurface(directory) { Padding = new Padding(8, 5, 8, 5) }, 0, 0); folderRow.Controls.Add(browse, 1, 0);
        root.Controls.Add(folderRow, 0, 1);
        subfolders = new CheckBox { Text = "Include subfolders", Checked = true, AutoSize = true, Margin = new Padding(6, 10, 20, 0) };
        scan = ActionButton("Scan files", StartScan, true);
        cancel = ActionButton("Cancel scan", (_, _) => { _cancellation?.Cancel(); UpdateActions(); status.Text = "Cancelling scan…"; });
        cancel.Enabled = false;
        root.Controls.Add(Toolbar(scan, cancel, subfolders), 0, 2);
        summary = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
        root.Controls.Add(summary, 0, 3);
        var results = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1 };
        results.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42));
        results.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58));
        var left = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 3, ColumnCount = 1, Padding = new Padding(0, 0, 10, 0) };
        left.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); left.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); left.RowStyles.Add(new RowStyle(SizeType.Absolute, 44));
        filter = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, FlatStyle = FlatStyle.Flat, BackColor = AppTheme.Surface, ForeColor = AppTheme.Text, Width = 240, AccessibleName = "Filter file groups" };
        filter.Items.AddRange(["All distinct files", "Duplicates only", "Single instances only"]); filter.SelectedIndex = 0;
        filter.SelectedIndexChanged += (_, _) => RefreshResults();
        files = new ListBox { Dock = DockStyle.Fill, IntegralHeight = false, HorizontalScrollbar = true, BorderStyle = BorderStyle.None, AccessibleName = "File groups" };
        files.SelectedIndexChanged += (_, _) => ShowPaths();
        autoClean = ActionButton("Auto clean all groups", async (_, _) => await DeleteAsync(LogicMethods.PlanAutoClean(_files), "Keep the first sorted path for every distinct file."));
        left.Controls.Add(filter, 0, 0); left.Controls.Add(new RoundedSurface(files), 0, 1); left.Controls.Add(Toolbar(autoClean), 0, 2);
        var right = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 4, ColumnCount = 1 };
        right.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); right.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); right.RowStyles.Add(new RowStyle(SizeType.Absolute, 32)); right.RowStyles.Add(new RowStyle(SizeType.Absolute, 84));
        right.Controls.Add(new Label { Text = "FILE LOCATIONS • sorted by full path", AutoSize = true, Padding = new Padding(0, 5, 0, 0) }, 0, 0);
        paths = new ListBox { Dock = DockStyle.Fill, IntegralHeight = false, HorizontalScrollbar = true, BorderStyle = BorderStyle.None, AccessibleName = "Full file paths" };
        paths.SelectedIndexChanged += (_, _) => UpdateActions();
        hash = new Label { Dock = DockStyle.Fill, AutoEllipsis = true, Font = new Font("Consolas", 8), TextAlign = ContentAlignment.MiddleLeft };
        keepFirst = ActionButton("Keep first path", async (_, _) => { if (SelectedGroup is { } g) await DeleteAsync(LogicMethods.PlanKeep(g, g.Paths.OrderBy(p => p, LogicMethods.PathComparer).First()), "Keep the first sorted path for this file."); });
        keepSelected = ActionButton("Keep only selected", async (_, _) => { if (SelectedGroup is { } g && paths.SelectedItem is string p) await DeleteAsync(LogicMethods.PlanKeep(g, p), "Delete every other copy of this file."); });
        deleteSelected = ActionButton("Delete selected path", async (_, _) => { if (SelectedGroup is { } g && paths.SelectedItem is string p) await DeleteAsync([new(g, p, null)], "Delete only the selected file path."); });
        openFolder = ActionButton("Open in Explorer", OpenSelectedFolder);
        right.Controls.Add(new RoundedSurface(paths), 0, 1); right.Controls.Add(hash, 0, 2); right.Controls.Add(Toolbar(openFolder, keepFirst, keepSelected, deleteSelected), 0, 3);
        results.Controls.Add(left, 0, 0); results.Controls.Add(right, 1, 0); root.Controls.Add(results, 0, 4);
        var progressRow = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2, ColumnCount = 1 };
        status = new Label { Text = "Ready. Choose a folder and scan its file contents.", Dock = DockStyle.Fill, AutoEllipsis = true };
        progress = new ProgressBar { Dock = DockStyle.Fill, Height = 16 };
        progressRow.Controls.Add(status, 0, 0); progressRow.Controls.Add(progress, 0, 1); root.Controls.Add(progressRow, 0, 5);
        saveLog = ActionButton("Save log…", SaveLog);
        clearLog = ActionButton("Clear log", (_, _) => log.Clear());
        root.Controls.Add(Toolbar(new Label { Text = "ACTIVITY", AutoSize = true, Margin = new Padding(0, 10, 16, 0) }, saveLog, clearLog), 0, 6);
        log = new RichTextBox { Dock = DockStyle.Fill, ReadOnly = true, BackColor = AppTheme.Surface, BorderStyle = BorderStyle.None, Font = new Font("Consolas", 9), DetectUrls = false };
        root.Controls.Add(new RoundedSurface(log), 0, 7);
        Controls.Add(root);
        ResumeLayout(true);
    }
}
