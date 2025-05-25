namespace SaveFolders
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnArchive = new Button();
            lblMoon = new Label();
            txtFolder = new TextBox();
            btnBrowse = new Button();
            btnRestore = new Button();
            cmbFolder = new ComboBox();
            btnSaveFolder = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(350, 221);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(227, 57);
            btnArchive.TabIndex = 0;
            btnArchive.Text = "ARCHIVE";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnSaveMoon_Click;
            // 
            // lblMoon
            // 
            lblMoon.AutoSize = true;
            lblMoon.Location = new Point(68, 60);
            lblMoon.Name = "lblMoon";
            lblMoon.Size = new Size(117, 25);
            lblMoon.TabIndex = 1;
            lblMoon.Text = "Select Folder:";
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(63, 138);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(477, 31);
            txtFolder.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(690, 138);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(583, 221);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(219, 57);
            btnRestore.TabIndex = 6;
            btnRestore.Text = "RESTORE";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // cmbFolder
            // 
            cmbFolder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFolder.FormattingEnabled = true;
            cmbFolder.Location = new Point(191, 57);
            cmbFolder.Name = "cmbFolder";
            cmbFolder.Size = new Size(195, 33);
            cmbFolder.TabIndex = 7;
            cmbFolder.SelectedIndexChanged += cmbFolder_SelectedIndexChanged;
            // 
            // btnSaveFolder
            // 
            btnSaveFolder.Location = new Point(572, 138);
            btnSaveFolder.Name = "btnSaveFolder";
            btnSaveFolder.Size = new Size(112, 34);
            btnSaveFolder.TabIndex = 8;
            btnSaveFolder.Text = "SAVE";
            btnSaveFolder.UseVisualStyleBackColor = true;
            btnSaveFolder.Click += btnSaveFolder_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(392, 55);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(54, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "✏️";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(452, 55);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(65, 34);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "🗑️";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(523, 55);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(59, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "❌";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 333);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnSaveFolder);
            Controls.Add(cmbFolder);
            Controls.Add(btnRestore);
            Controls.Add(btnBrowse);
            Controls.Add(txtFolder);
            Controls.Add(lblMoon);
            Controls.Add(btnArchive);
            Name = "MainForm";
            Text = "SAVE Moon";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArchive;
        private Label lblMoon;
        private TextBox txtFolder;
        private Button btnBrowse;
        private Button btnRestore;
        private ComboBox cmbFolder;
        private Button btnSaveFolder;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnClear;
    }
}
