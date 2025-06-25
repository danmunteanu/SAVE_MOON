using System.IO.Compression;
using SAVE_FOLDERS;

namespace SaveFolders
{
    public partial class MainForm : Form
    {
        private List<SaveFolderInfo> mFolders = new();
        private EditorFolderName mEditorFolderName = new();

        /*
         * Registers default folders for the application.
         * You might want to adjust this to your needs
         */
        private void RegisterFolders()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string localLowPath = Path.Combine(userProfile, "AppData", "LocalLow");
            string folderMoon = Path.Combine(localLowPath, "Moon Studios");

            //  Moon Studios folder
            mFolders.Add(new(folderMoon, "MoonStudios"));

            //  Experimental folder (for urgentdev_v2)
            string folderExperimental = @"c:\urgentdev_v2\resources\views\pages\experimental\";
            mFolders.Add(new(folderExperimental, "experimental"));

            if (cmbFolder.Items.Count > 0)
                txtFolder.Text = mFolders[cmbFolder.SelectedIndex].Path;
        }

        public MainForm()
        {
            InitializeComponent();

            //  Load folders from settings
            mFolders = SettingsManager.LoadFolderList();

            //  Clear status
            UpdateStatus(string.Empty);

            //  Load default folders
            //RegisterFolders();

            //  mFolders -> cmbFolders
            LoadFolders();

            //  Set last selected index
            int selIndex = SettingsManager.Settings.SelectedFolderIndex;
            if (selIndex != -1 && selIndex >= 0 && selIndex < cmbFolder.Items.Count)
                cmbFolder.SelectedIndex = selIndex;

            UpdateUI();

            this.CenterToParent();
        }

        private void UpdateStatus(string status)
        {
            lblStatus.Text = status;
        }

        private void UpdateUI()
        {
            int idx = cmbFolder.SelectedIndex;

            bool hasFolders = cmbFolder.Items.Count > 0;

            btnEdit.Enabled = idx != -1;

            bool hasLeft = hasFolders && idx > 0;
            bool hasRight = hasFolders && idx < cmbFolder.Items.Count - 1;

            btnLeft.Enabled = hasLeft;
            btnRight.Enabled = hasRight;
        }

        private void LoadFolders(bool clearFolders = true)
        {
            //  Loads mFolders into cmbFolders

            if (clearFolders)
                cmbFolder.Items.Clear();

            for (int idx = 0; idx < mFolders.Count; idx++)
            {
                cmbFolder.Items.Add(mFolders.ElementAt(idx).Label);
            }
            if (cmbFolder.Items.Count > 0)
                cmbFolder.SelectedIndex = 0;
        }

        private void SaveSettings()
        {
            SettingsManager.SaveFolderList(mFolders);
            SettingsManager.Settings.SelectedFolderIndex = cmbFolder.SelectedIndex;
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
                throw new DirectoryNotFoundException("Source directory does not exist: " + sourceDirName);

            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destDirName);

            foreach (FileInfo file in dir.GetFiles())
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            int idx = cmbFolder.SelectedIndex;
            if (idx == -1)
                return;

            string folder = mFolders[idx].Path;
            string archiveName = mFolders[idx].Label;

            if (!Directory.Exists(folder))
            {
                MessageBox.Show($"The folder \"{folder}\" was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {

                string timestamp = DateTime.Now.ToString("yyyy-MM-dd");
                saveDialog.Filter = "ZIP archive (*.zip)|*.zip";

                saveDialog.Title = "{archiveName} Archive";
                saveDialog.FileName = $"{archiveName}_{timestamp}.zip";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationZipPath = saveDialog.FileName;
                    try
                    {
                        string tempRoot = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                        string tempFolder = Path.Combine(tempRoot, $"{archiveName}");

                        btnArchive.Enabled = false;

                        DirectoryCopy(folder, tempFolder, true);
                        ZipFile.CreateFromDirectory(tempRoot, destinationZipPath);
                        Directory.Delete(tempRoot, true);

                        btnArchive.Enabled = true;
                        UpdateStatus("Archive saved successfully");
                    }
                    catch (Exception ex)
                    {
                        UpdateStatus("Error archiving folder.");
                        MessageBox.Show("Error archiving folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    UpdateStatus("Archiving cancelled.");
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = folderDialog.SelectedPath;
                    UpdateStatus("Folder selected.");
                }
                else
                {
                    UpdateStatus("Browse cancelled.");
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            int idx = cmbFolder.SelectedIndex;
            if (idx == -1)
                return;

            string restoreToFolder = mFolders[idx].Path;

            // Define the restore folder (make sure this is set elsewhere or hardcoded here)
            //string restoreToFolder = @"c:\Users\Dan Beton\OneDrive\Desktop\TEMP\"; // replace with your actual folder path

            // Ensure the restore folder exists; create if it doesn't
            if (!Directory.Exists(restoreToFolder))
                Directory.CreateDirectory(restoreToFolder);

            // Open file dialog to select a .zip file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ZIP files (*.zip)|*.zip";
                openFileDialog.Title = "Select a ZIP file to restore";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Extract the selected zip file to the restore folder
                        ZipFile.ExtractToDirectory(openFileDialog.FileName, restoreToFolder, overwriteFiles: true);

                        MessageBox.Show("Restore completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"IO error during extraction: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (UnauthorizedAccessException uaEx)
                    {
                        MessageBox.Show($"Access error during extraction: {uaEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (chkSaveSettings.Checked)
                SaveSettings();
        }

        private void cmbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFolder.SelectedIndex == -1)
                return;

            int idx = cmbFolder.SelectedIndex;

            if (idx >= 0 && idx < mFolders.Count)
            {
                txtFolder.Text = mFolders.ElementAt(cmbFolder.SelectedIndex).Path;
                UpdateUI();
            }
        }

        private void btnSaveFolder_Click(object sender, EventArgs e)
        {
            string path = txtFolder.Text;
            bool exists = mFolders.Any(f => string.Equals(f.Path, path, StringComparison.OrdinalIgnoreCase));
            if (!exists)
            {
                //  Add it
                string desc = Path.GetFileName(path);
                mFolders.Add(new SaveFolderInfo(path, desc));
                cmbFolder.Items.Add(desc);

                cmbFolder.SelectedIndex = cmbFolder.Items.Count - 1;

                UpdateStatus("Folder added.");
            }
            else
            {
                UpdateStatus("Folder already exists.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbFolder.SelectedIndex == -1)
                return;

            int idx = cmbFolder.SelectedIndex;

            if (idx >= 0 && idx < mFolders.Count)
            {
                var result = MessageBox.Show(
                    string.Format("Are you sure you want to delete \"{0}\"?", mFolders.ElementAt(idx).Label),
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    mFolders.RemoveAt(idx);
                    cmbFolder.Items.RemoveAt(idx);

                    if (cmbFolder.Items.Count > 0)
                        cmbFolder.SelectedIndex = 0;

                    UpdateStatus("Folder removed.");
                    UpdateUI();
                }
                else
                {
                    UpdateStatus("Folder was not removed.");
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    "Are you sure you want to clear all folders?",
                    "Confirm Clear",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                mFolders.Clear();
                cmbFolder.Items.Clear();

                UpdateStatus("Folders cleared.");
                UpdateUI();
            }
            else
            {
                UpdateStatus("Folders not cleared.");
            }
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    "Are you sure you want to load default folders?",
                    "Confirm Defaults",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                mFolders.Clear();
                cmbFolder.Items.Clear();

                RegisterFolders();
                LoadFolders();

                UpdateStatus("Loaded default folders");
                UpdateUI();
            }
            else
            {
                UpdateStatus("Default folders not loaded.");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int idx = cmbFolder.SelectedIndex;
            if (idx == -1)
                return;

            int count = cmbFolder.Items.Count;

            if (count > 0 && idx < count - 1)
                cmbFolder.SelectedIndex++;

            UpdateUI();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int idx = cmbFolder.SelectedIndex;
            if (idx == -1)
                return;

            if (cmbFolder.Items.Count > 0)
                cmbFolder.SelectedIndex--;

            UpdateUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idx = cmbFolder.SelectedIndex;
            if (idx == -1) return;

            if (!(idx >= 0 && idx < mFolders.Count))
                return;

            mEditorFolderName.FolderName = mFolders.ElementAt(idx).Label;
            if (mEditorFolderName.ShowDialog() == DialogResult.OK)
            {
                mFolders.ElementAt(idx).Label = mEditorFolderName.InputValue;
                cmbFolder.Items[idx] = mEditorFolderName.InputValue;
            }
        }
    }
}
