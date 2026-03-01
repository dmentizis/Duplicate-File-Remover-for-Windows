using DuplicateRemover.Objects;
using System.ComponentModel;

namespace DuplicateRemover
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        #region Form properties
        private string? _directory = null;
        private List<UniqueFile> uniqueFiles = new();
        private List<PhysicalFile> physicalFiles = new();
        private enum States { ReadyToScan, Scanning, ReadyToClean, Cleaning };
        public string? Directory
        {
            get { return _directory; }
            set
            {
                _directory = value;
                OnPropertyChanged("Directory");
            }
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
        public MainForm()
        {
            InitializeComponent();
            txbDirectory.DataBindings.Add("Text", this, "Directory", false, DataSourceUpdateMode.OnPropertyChanged);
            //btnScanFolderOnly.Enabled = string.IsNullOrWhiteSpace(_directory);

            uniqueFiles.Add(new UniqueFile() { Hash = "Hash1", Paths = new List<string>() { "Path1", "Path2" } });
            uniqueFiles.Add(new UniqueFile() { Hash = "Hash2", Paths = new List<string>() { "Path3" } });
            bsUniqueFiles.DataSource = uniqueFiles;
            dgUniqueFiles.Refresh();
            dgUniqueFiles.RefreshEdit();

            physicalFiles.Add(new PhysicalFile() { Hash = "Hash1", Path = "Path1" });
            physicalFiles.Add(new PhysicalFile() { Hash = "Hash1", Path = "Path2" });
            physicalFiles.Add(new PhysicalFile() { Hash = "Hash2", Path = "Path3" });
            physicalFiles.Add(new PhysicalFile() { Hash = "Hash3", Path = "Path4" });
            bsPhysicalFiles.DataSource = physicalFiles;
            dgPhysicalFiles.Refresh();
            dgPhysicalFiles.RefreshEdit();
        }

        #region Form Events
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
                cbIncludeSubfolders.Enabled = true;
                btnScan.Enabled = true;
            }
        }

        private void btnShowFilePaths_Click(object sender, EventArgs e)
        {

        }

        private void txbDirectory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnScanFolderOnly_Click(object sender, EventArgs e)
        {
            //BindingList<UniqueFile> files = new BindingList<UniqueFile>();
            //bsUniqueFiles.DataSource = files;
            //dgUniqueFiles.DataSource = bsUniqueFiles;
            bsUniqueFiles.Clear();
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
