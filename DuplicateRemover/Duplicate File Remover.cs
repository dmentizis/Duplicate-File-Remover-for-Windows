using DuplicateRemover.Objects;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Security.Policy;

namespace DuplicateRemover
{
    public partial class Form1 : Form
    {
        #region Private properties
        private string? _directory = null;
        private string[]? _fileDirectories = null;
        private List<UniqueFile> _files = new List<UniqueFile>();
        #endregion

        #region ScanOptions
        private bool _scanSubFolders = false;
        #endregion
        public Form1()
        {
            InitializeComponent();

            btnScanFolderAndSubfolders.Enabled = false;
            btnScanFolderOnly.Enabled = false;
            lblTotalFilesNumber.Text = string.Empty;
            lblUniqueFilesNumber.Text = string.Empty;
        }

        #region FormControls
        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                _directory = folderDlg.SelectedPath;
                txbDirectory.Text = _directory;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            if (_directory != null && txbDirectory.Text != string.Empty)
            {
                btnScanFolderAndSubfolders.Enabled = true;
                btnScanFolderOnly.Enabled = true;
            }
        }
        private void btnScanFolderOnly_Click(object sender, EventArgs e)
        {
            try
            {
                _files.Clear();
                lbUniqueFiles.Items.Clear();

                _fileDirectories = null;
                lbPaths.Items.Clear();

                lblTotalFilesNumber.Text = string.Empty;
                lblUniqueFilesNumber.Text = string.Empty;

                if (!string.IsNullOrEmpty(_directory))
                {
                    _scanSubFolders = false;
                    //ScanFolder();
                    //Background Worker Implementation
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        private void btnScanFolderAndSubfolders_Click(object sender, EventArgs e)
        {
            try
            {
                _files.Clear();
                lbUniqueFiles.Items.Clear();

                _fileDirectories = null;
                lbPaths.Items.Clear();

                lblTotalFilesNumber.Text = string.Empty;
                lblUniqueFilesNumber.Text = string.Empty;

                if (!string.IsNullOrEmpty(_directory))
                {
                    _scanSubFolders = true;
                    //ScanFolder();
                    //Background Worker Implementation
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnShowFilePaths_Click(object sender, EventArgs e)
        {
            lbPaths.Items.Clear();
            if (lbUniqueFiles.SelectedItem != null && _files != null)
            {

                UniqueFile file = _files.First(f => f.Hash == lbUniqueFiles.SelectedItem.ToString());

                if (file != null)
                {
                    lbPaths.Items.AddRange(file.Paths.ToArray());
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        #endregion

        #region UI Manipulation
        public void AppendTextToLogger(string text, Color? color = null, FontStyle? fontStyle = null, float? fontSize = null)
        {
            if (rtbLogger.InvokeRequired)
            {
                rtbLogger.Invoke(new Action<string, Color?, FontStyle?, float?>(AppendTextToLogger), text, color, fontStyle, fontSize);
            }
            else
            {
                // Set the default color if none is provided
                Color textColor = color ?? rtbLogger.ForeColor;

                // Create a new font based on the provided parameters
                Font currentFont = rtbLogger.Font;
                FontStyle style = fontStyle ?? currentFont.Style;
                float size = fontSize ?? currentFont.Size;
                Font newFont = new Font(currentFont.FontFamily, size, style);

                // Save the current selection start and length
                int selectionStart = rtbLogger.TextLength;
                int selectionLength = text.Length;

                // Append the text
                rtbLogger.AppendText(text + Environment.NewLine);

                // Apply the color and font to the appended text
                rtbLogger.Select(selectionStart, selectionLength);
                rtbLogger.SelectionColor = textColor;
                rtbLogger.SelectionFont = newFont;

                // Deselect the text
                rtbLogger.SelectionLength = 0;

                // Scroll to the caret
                rtbLogger.ScrollToCaret();
            }
        }

        public void AddItemToUniqueFiles(string item)
        {
            if (lbUniqueFiles.InvokeRequired)
            {
                lbUniqueFiles.Invoke(new Action<string>(AddItemToUniqueFiles), item);
            }
            else
            {
                lbUniqueFiles.Items.Add(item);
                // Ensure the last added item is visible
                lbUniqueFiles.TopIndex = lbUniqueFiles.Items.Count - 1;
            }
        }

        public void AddItemToPaths(string item)
        {
            if (lbPaths.InvokeRequired)
            {
                lbPaths.Invoke(new Action<string>(AddItemToPaths), item);
            }
            else
            {
                lbPaths.Items.Add(item);
                // Ensure the last added item is visible
                lbPaths.TopIndex = lbPaths.Items.Count - 1;
            }
        }

        public void UpdateTotalFilesNumber(string text)
        {
            if (lblTotalFilesNumber.InvokeRequired)
            {
                lblTotalFilesNumber.Invoke(new Action<string>(UpdateTotalFilesNumber), text);
            }
            else
            {
                lblTotalFilesNumber.Text = text;
            }
        }

        public void UpdateUniqueFilesNumber(string text)
        {
            if (lblUniqueFilesNumber.InvokeRequired)
            {
                lblUniqueFilesNumber.Invoke(new Action<string>(UpdateUniqueFilesNumber), text);
            }
            else
            {
                lblUniqueFilesNumber.Text = text;
            }
        }
        #endregion
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        #region Logic Methods
        public void ScanFolder()
        {
            if (!string.IsNullOrWhiteSpace(_directory))
            {
                if (!Directory.Exists(_directory))
                {
                    throw new Exception("Directory does no longer exist");
                }

                try
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        AppendTextToLogger("Looking for files...");
                        if (_scanSubFolders)
                        {
                            _fileDirectories = Directory.GetFiles(_directory, "*", SearchOption.AllDirectories);

                        }
                        else
                        {
                            _fileDirectories = Directory.GetFiles(_directory);
                        }
                        AppendTextToLogger($"Files found: {_fileDirectories.Length}");
                    }
                    else
                    {
                        AppendTextToLogger("Operation Cancelled", Color.Red);
                        throw new Exception("Operation Cancelled");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                if (_fileDirectories == null)
                {
                    AppendTextToLogger("No Files Found is directory", Color.Red);
                    return;
                }

                foreach (string fileDir in _fileDirectories)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        try
                        {
                            using (var md5 = MD5.Create())
                            {
                                using (var stream = File.OpenRead(fileDir))
                                {
                                    AppendTextToLogger($"Hashing file: {fileDir}");
                                    var hash = md5.ComputeHash(stream);
                                    string fileHash = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                                    UniqueFile? existingEntry = null;
                                    try
                                    {
                                        existingEntry = _files.First(f => f.Hash == fileHash);
                                    }
                                    catch
                                    {
                                        existingEntry = null;
                                    }
                                    if (existingEntry == null)
                                    {
                                        UniqueFile newUniqueFile = new UniqueFile { Hash = fileHash };
                                        newUniqueFile.Hash = fileHash;
                                        newUniqueFile.Paths.Add(fileDir);
                                        _files.Add(newUniqueFile);
                                    }
                                    else
                                    {
                                        existingEntry.Paths.Add(fileDir);
                                    }
                                    AppendTextToLogger($"{fileDir} hashed successfully!", Color.Green);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            AppendTextToLogger(ex.Message, Color.Red);
                        }
                    }
                    else
                    {
                        AppendTextToLogger("Operation Cancelled!", Color.Red);
                        break;
                    }
                }

                //lbUniqueFiles.Items.AddRange(_files);
                //foreach (string file in files)
                //{
                //    lbUniqueFiles.Items.Add(file);
                //}

                //Alternative Iteration
                //foreach (string file in Directory.EnumerateFiles(_directory))
                //{
                //    lbUniqueFiles.Items.Add(file);
                //}

            }
            int fileFirectories = 0;
            if (_fileDirectories != null)
            {
                fileFirectories = _fileDirectories.Length;
            }
            AppendTextToLogger($"Operation Complete! Total files Found: {fileFirectories} Unique Files: {_files.Count}", Color.Blue, FontStyle.Bold);

            foreach (UniqueFile file in _files)
            {
                AddItemToUniqueFiles(file.Hash);
                //lbUniqueFiles.Items.Add(file.Hash);
            }

            if (_fileDirectories != null)
            {
                UpdateTotalFilesNumber(_fileDirectories.Length.ToString());
                //lblTotalFilesNumber.Text = _fileDirectories.Length.ToString();
            }
            //lblUniqueFilesNumber.Text = _files.Count.ToString();
            UpdateUniqueFilesNumber(_files.Count.ToString());
        }

        public void DeleteFile(string FilePath)
        {
            AppendTextToLogger($"Deleting {FilePath}...");
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                AppendTextToLogger("Delete Successful", Color.Green);
            }
            else
            {
                AppendTextToLogger($"Error: File not found", Color.Red);
            }
        }

        public void DeleteFiles(List<String> Files)
        {
            foreach (string file in Files)
            {
                AppendTextToLogger($"Deleting {file}...");
                if (File.Exists(file))
                {
                    File.Delete(file);
                    AppendTextToLogger("Delete Successful", Color.Green);
                }
                else
                {
                    AppendTextToLogger($"Error: File not found", Color.Red);
                }
            }
        }
        #endregion

        #region Background
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            AppendTextToLogger("Scanning folder...", null, FontStyle.Bold);
            ScanFolder();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Operation was cancelled.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("An error occurred: " + e.Error.Message);
            }
            else
            {
                MessageBox.Show("Operation completed successfully.");
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void btnShowDuplicates_Click(object sender, EventArgs e)
        {
            if (btnShowDuplicates.Enabled)
            {
                if (_files.Count > 0)
                {
                    lbUniqueFiles.Items.Clear();

                    foreach (var file in _files)
                    {
                        if (file.Paths.Count > 1)
                        {
                            AddItemToUniqueFiles(file.Hash);
                        }
                    }
                }
            }
        }
    }
}