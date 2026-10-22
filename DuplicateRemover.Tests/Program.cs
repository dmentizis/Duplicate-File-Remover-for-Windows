using DuplicateRemover;
using DuplicateRemover.Objects;
using System.Reflection;

internal static class Program
{
    private static int checks;
    private static void Check(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
        checks++;
        Console.WriteLine($"PASS {message}");
    }
    private static void MustThrow<T>(Action action, string message) where T : Exception
    {
        try { action(); } catch (T) { Check(true, message); return; }
        throw new Exception(message);
    }
    [STAThread]
    private static void Main()
    {
        string root = Path.Combine(Path.GetTempPath(), "DuplicateRemoverTests-" + Guid.NewGuid());
        Directory.CreateDirectory(root);
        try
        {
            string a = Path.Combine(root, "a.txt"), b = Path.Combine(root, "b.bin");
            File.WriteAllText(a, "identical"); File.WriteAllText(b, "identical");
            Directory.CreateDirectory(Path.Combine(root, "nested"));
            string c = Path.Combine(root, "nested", "c.txt");
            File.WriteAllText(c, "identical"); File.WriteAllText(Path.Combine(root, "single.txt"), "single");
            File.WriteAllText(Path.Combine(root, "empty1"), ""); File.WriteAllText(Path.Combine(root, "empty2"), "");
            var updates = new List<ScanProgress>();
            var result = LogicMethods.Scan(root, true, default, updates.Add, _ => { });
            Check(result.Found == 6 && result.Files.Count == 3, "Recursive content grouping, including empty files and different extensions");
            Check(LogicMethods.Scan(root, false, default, _ => { }, _ => { }).Found == 5, "Folder-only scan excludes subfolders");
            Check(updates.Last().Completed == 6, "Progress reaches all files");
            using (var cancellation = new CancellationTokenSource())
            {
                cancellation.Cancel();
                MustThrow<OperationCanceledException>(() => LogicMethods.Scan(root, true, cancellation.Token, _ => { }, _ => { }), "Cancellation during discovery");
            }
            string large = Path.Combine(root, "large");
            File.WriteAllBytes(large, new byte[3 * 1024 * 1024]);
            using (var cancellation = new CancellationTokenSource())
                MustThrow<OperationCanceledException>(() => LogicMethods.ComputeFileHash(large, cancellation.Token, (_, _) => cancellation.Cancel()), "Cancellation inside a large file");
            var group = result.Files.Single(g => g.Paths.Contains(a));
            var plan = LogicMethods.PlanAutoClean([group]);
            Check(plan.Count == 2 && plan.All(r => r.KeepPath == a && r.Path != a), "Auto clean preserves first sorted path");
            File.WriteAllText(a, "changed");
            MustThrow<IOException>(() => LogicMethods.ExecuteDelete(plan[0]), "Changed keeper prevents deletion");
            Check(File.Exists(b), "Target survives failed keeper validation");
            File.WriteAllText(a, "identical"); File.WriteAllText(b, "changed");
            MustThrow<IOException>(() => LogicMethods.ExecuteDelete(plan[0]), "Changed target prevents deletion");
            File.WriteAllText(b, "identical");
            foreach (var request in LogicMethods.PlanKeep(group, c)) LogicMethods.ExecuteDelete(request);
            Check(File.Exists(c) && !File.Exists(a) && !File.Exists(b) && group.Paths.SequenceEqual([c]), "Keep selected retains exactly the selected instance and updates model");
            LogicMethods.ExecuteDelete(new(group, c, null));
            Check(!File.Exists(c) && group.Paths.Count == 0, "Delete selected removes a single instance");
            var empty = result.Files.Single(g => g.Paths.Count == 2);
            foreach (var request in LogicMethods.PlanAutoClean([empty])) LogicMethods.ExecuteDelete(request);
            Check(empty.Paths.Count == 1 && File.Exists(empty.Paths[0]), "Auto clean executes without deleting the last copy");

            ApplicationConfiguration.Initialize();
            using var form = new Form1();
            form.CreateControl();
            form.PerformLayout();
            T Field<T>(string name) => (T)typeof(Form1).GetField(name, BindingFlags.NonPublic | BindingFlags.Instance)!.GetValue(form)!;
            Check(!Field<Button>("cancel").Enabled && !Field<Button>("autoClean").Enabled, "Idle form disables unavailable actions");
            typeof(Form1).GetField("_files", BindingFlags.NonPublic | BindingFlags.Instance)!.SetValue(form, new List<UniqueFile> { empty, new() { Hash = "test", Paths = ["one", "two"] } });
            typeof(Form1).GetMethod("RefreshResults", BindingFlags.NonPublic | BindingFlags.Instance)!.Invoke(form, null);
            Check(Field<ListBox>("files").Items.Count == 2 && Field<ListBox>("paths").Items.Count == 1, "Selecting a group automatically displays paths");
            Field<ComboBox>("filter").SelectedIndex = 1;
            Check(Field<ListBox>("files").Items.Count == 1 && Field<ListBox>("paths").Items.Count == 2, "Duplicates filter and paths");
            Field<ComboBox>("filter").SelectedIndex = 2;
            Check(Field<ListBox>("files").Items.Count == 1 && Field<ListBox>("paths").Items.Count == 1, "Single-instance filter and paths");
            void Invoke(string name, params object[] args) => typeof(Form1).GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance)!.Invoke(form, args);
            var folderInput = Field<TextBox>("directory");
            Check(!Field<Button>("scan").Enabled && !Field<Button>("saveLog").Enabled && !Field<Button>("clearLog").Enabled,
                "Empty folder and log disable scan and log actions");
            folderInput.Text = root;
            Check(Field<Button>("scan").Enabled, "Valid typed folder enables scanning");
            folderInput.Text = Path.Combine(root, "missing");
            Check(!Field<Button>("scan").Enabled, "Invalid folder disables scanning");
            folderInput.Text = root;
            Field<RichTextBox>("log").Text = "Test activity";
            Check(Field<Button>("saveLog").Enabled && Field<Button>("clearLog").Enabled, "Log actions enabled only with content");
            Check(Field<Button>("deleteSelected").Enabled && Field<Button>("openFolder").Enabled && !Field<Button>("keepSelected").Enabled,
                "Single instance allows open/delete but disables duplicate cleanup");
            var cts = new CancellationTokenSource();
            typeof(Form1).GetField("_cancellation", BindingFlags.NonPublic | BindingFlags.Instance)!.SetValue(form, cts);
            Invoke("SetBusy", true);
            Check(new[] { "browse", "scan", "autoClean", "keepFirst", "keepSelected", "deleteSelected", "openFolder", "saveLog", "clearLog" }
                .All(name => !Field<Button>(name).Enabled) && Field<Button>("cancel").Enabled,
                "Scanning disables unavailable actions and enables cancellation");
            cts.Cancel(); Invoke("UpdateActions");
            Check(!Field<Button>("cancel").Enabled, "Cancellation cannot be requested twice");
            typeof(Form1).GetField("_cancellation", BindingFlags.NonPublic | BindingFlags.Instance)!.SetValue(form, null);
            cts.Dispose();
            Invoke("UpdateActions");
            Check(!Field<Button>("cancel").Enabled, "Cleanup does not offer unsupported cancellation");
            Invoke("SetBusy", false);
            Check(Field<Button>("scan").Enabled && Field<Button>("openFolder").Enabled && !Field<Button>("cancel").Enabled,
                "Completion restores valid actions");
            Field<RichTextBox>("log").Clear();
            Check(!Field<Button>("saveLog").Enabled && !Field<Button>("clearLog").Enabled, "Clearing log disables log actions");
            Check(form.Icon != null && form.Icon.Width > 0, "Original form icon loads from resources");
            void LayoutTree(Control control)
            {
                control.PerformLayout();
                foreach (Control child in control.Controls) LayoutTree(child);
            }
            LayoutTree(form);
            Check(folderInput.Parent!.ClientSize.Height >= folderInput.PreferredHeight + folderInput.Parent.Padding.Vertical &&
                folderInput.Bottom <= folderInput.Parent.ClientSize.Height - folderInput.Parent.Padding.Bottom,
                "Folder input leaves room for its text and bottom border");
            form.Scale(new System.Drawing.SizeF(1.5f, 1.5f));
            LayoutTree(form);
            Check(folderInput.Bottom <= folderInput.Parent.ClientSize.Height - folderInput.Parent.Padding.Bottom,
                "Folder input remains inside its border when scaled");
            Console.WriteLine($"All {checks} checks passed.");
        }
        finally { Directory.Delete(root, true); }
    }
}
