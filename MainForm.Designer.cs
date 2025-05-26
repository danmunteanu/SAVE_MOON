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
            btnDefaults = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            SuspendLayout();
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(548, 135);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(133, 36);
            btnArchive.TabIndex = 0;
            btnArchive.Text = "ARCHIVE";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnSaveMoon_Click;
            // 
            // lblMoon
            // 
            lblMoon.AutoSize = true;
            lblMoon.Location = new Point(33, 64);
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
            txtFolder.Size = new Size(459, 31);
            txtFolder.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(690, 135);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(123, 36);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRestore
            // 
            btnRestore.Enabled = false;
            btnRestore.Location = new Point(181, 185);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(125, 34);
            btnRestore.TabIndex = 6;
            btnRestore.Text = "RESTORE";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // cmbFolder
            // 
            cmbFolder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFolder.FormattingEnabled = true;
            cmbFolder.Location = new Point(156, 61);
            cmbFolder.Name = "cmbFolder";
            cmbFolder.Size = new Size(195, 33);
            cmbFolder.TabIndex = 7;
            cmbFolder.SelectedIndexChanged += cmbFolder_SelectedIndexChanged;
            // 
            // btnSaveFolder
            // 
            btnSaveFolder.Location = new Point(63, 185);
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
            btnEdit.Location = new Point(357, 60);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(54, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "✏️";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(616, 59);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(65, 34);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "🗑️";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(687, 59);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(59, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "❌";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDefaults
            // 
            btnDefaults.Font = new Font("Segoe UI", 8F);
            btnDefaults.Location = new Point(752, 61);
            btnDefaults.Name = "btnDefaults";
            btnDefaults.Size = new Size(50, 34);
            btnDefaults.TabIndex = 12;
            btnDefaults.Text = "D";
            btnDefaults.UseVisualStyleBackColor = true;
            btnDefaults.Click += btnDefaults_Click;
            // 
            // btnLeft
            // 
            btnLeft.Enabled = false;
            btnLeft.Location = new Point(422, 60);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(47, 34);
            btnLeft.TabIndex = 13;
            btnLeft.Text = "◀";
            btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            btnRight.Enabled = false;
            btnRight.Location = new Point(475, 60);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(47, 34);
            btnRight.TabIndex = 14;
            btnRight.Text = "▶";
            btnRight.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 333);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(btnDefaults);
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
        private Button btnDefaults;
        private Button btnLeft;
        private Button btnRight;
    }
}
