using System.IO.Compression;

namespace SaveFolders
{
    public partial class MainForm : Form
    {
        List<SaveFolderInfo> mFolders = new();

        //private List<(string, string)> mFolders = new();

        private int mSelectedFolderIndex = -1;

        private void RegisterFolders()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string localLowPath = Path.Combine(userProfile, "AppData", "LocalLow");
            string folderMoon = Path.Combine(localLowPath, "Moon Studios");

            mFolders.Add(new(folderMoon, "MoonStudios"));

            string folderExperimental = @"c:\urgentdev_v2\resources\views\pages\experimental\";
            mFolders.Add(new(folderExperimental, "experimental"));

            mSelectedFolderIndex = 0;
            txtFolder.Text = mFolders[mSelectedFolderIndex].Path;
        }

        public MainForm()
        {
            InitializeComponent();

            LoadSettings();

            RegisterFolders();

            for (int idx = 0; idx < mFolders.Count; idx++)
            {
                cmbFolder.Items.Add(mFolders.ElementAt(idx).Desc);
            }
            if (cmbFolder.Items.Count > 0)
                cmbFolder.SelectedIndex = 0;



            this.CenterToParent();
        }

        private void SaveSettings()
        {
            SettingsManager.SaveFolderList(mFolders);
        }

        private void LoadSettings()
        {
            mFolders = SettingsManager.LoadFolderList();
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

        private void btnSaveMoon_Click(object sender, EventArgs e)
        {
            string folder = mFolders[mSelectedFolderIndex].Path;
            string archiveName = mFolders[mSelectedFolderIndex].Desc;

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
                        MessageBox.Show("Archive saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error archiving folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoadMoon_Click(object sender, EventArgs e)
        {
            mSelectedFolderIndex = 0;
            txtFolder.Text = mFolders[mSelectedFolderIndex].Path;
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
                }
            }
        }

        private void btnExperimental_Click(object sender, EventArgs e)
        {
            mSelectedFolderIndex = 1;
            txtFolder.Text = mFolders[mSelectedFolderIndex].Path;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string restoreToFolder = mFolders[mSelectedFolderIndex].Path;

            // Define the restore folder (make sure this is set elsewhere or hardcoded here)
            //string restoreToFolder = @"c:\Users\Dan Beton\OneDrive\Desktop\TEMP\"; // replace with your actual folder path

            // Ensure the restore folder exists; create if it doesn't
            if (!Directory.Exists(restoreToFolder))
            {
                Directory.CreateDirectory(restoreToFolder);
            }

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
            SaveSettings();
        }

        private void cmbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFolder.SelectedIndex == -1)
                return;

            int idx = cmbFolder.SelectedIndex;

            if (idx >= 0 && idx < mFolders.Count)
                txtFolder.Text = mFolders.ElementAt(cmbFolder.SelectedIndex).Path;

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
                    string.Format("Are you sure you want to delete \"{0}\"?", mFolders.ElementAt(idx).Desc),
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
                }
                else
                {
                    // Cancelled
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    "Are you sure you want to delete all folders?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                mFolders.Clear();
                cmbFolder.Items.Clear();
            }
            else
            {
                // Cancelled
            }
        }
    }
}
