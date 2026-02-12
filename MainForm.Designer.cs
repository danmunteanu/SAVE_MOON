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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnArchive = new Button();
            lblSelect = new Label();
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
            lblStatus = new Label();
            tableLayoutPanelFolder = new TableLayoutPanel();
            chkSaveSettings = new CheckBox();
            tableLayoutPanelButtons1 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLastRow = new TableLayoutPanel();
            tableLayoutPanelAll = new TableLayoutPanel();
            tableLayoutPanelFolder.SuspendLayout();
            tableLayoutPanelButtons1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLastRow.SuspendLayout();
            tableLayoutPanelAll.SuspendLayout();
            SuspendLayout();
            // 
            // btnArchive
            // 
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Location = new Point(386, 3);
            btnArchive.Margin = new Padding(2, 3, 2, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(108, 35);
            btnArchive.TabIndex = 0;
            btnArchive.Text = "ARCHIVE";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // lblSelect
            // 
            lblSelect.Anchor = AnchorStyles.Left;
            lblSelect.AutoSize = true;
            lblSelect.Location = new Point(2, 10);
            lblSelect.Margin = new Padding(2, 0, 2, 0);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(98, 20);
            lblSelect.TabIndex = 1;
            lblSelect.Text = "Select Folder:";
            // 
            // txtFolder
            // 
            txtFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFolder.Location = new Point(2, 7);
            txtFolder.Margin = new Padding(2, 3, 2, 3);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(380, 27);
            txtFolder.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Dock = DockStyle.Fill;
            btnBrowse.Location = new Point(498, 3);
            btnBrowse.Margin = new Padding(2, 3, 2, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(108, 35);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRestore
            // 
            btnRestore.Dock = DockStyle.Fill;
            btnRestore.Enabled = false;
            btnRestore.Location = new Point(498, 3);
            btnRestore.Margin = new Padding(2, 3, 2, 3);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(108, 35);
            btnRestore.TabIndex = 6;
            btnRestore.Text = "RESTORE";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // cmbFolder
            // 
            cmbFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbFolder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFolder.FormattingEnabled = true;
            cmbFolder.Location = new Point(111, 6);
            cmbFolder.Margin = new Padding(2, 3, 2, 3);
            cmbFolder.Name = "cmbFolder";
            cmbFolder.Size = new Size(167, 28);
            cmbFolder.TabIndex = 7;
            cmbFolder.SelectedIndexChanged += cmbFolder_SelectedIndexChanged;
            // 
            // btnSaveFolder
            // 
            btnSaveFolder.Dock = DockStyle.Fill;
            btnSaveFolder.Location = new Point(386, 3);
            btnSaveFolder.Margin = new Padding(2, 3, 2, 3);
            btnSaveFolder.Name = "btnSaveFolder";
            btnSaveFolder.Size = new Size(108, 35);
            btnSaveFolder.TabIndex = 8;
            btnSaveFolder.Text = "SAVE";
            btnSaveFolder.UseVisualStyleBackColor = true;
            btnSaveFolder.Click += btnSaveFolder_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(282, 3);
            btnEdit.Margin = new Padding(2, 3, 2, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(34, 35);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "✏️";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Fill;
            btnRemove.Location = new Point(394, 3);
            btnRemove.Margin = new Padding(2, 3, 2, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(33, 35);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "🗑️";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(573, 3);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(33, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "❌";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDefaults
            // 
            btnDefaults.Dock = DockStyle.Fill;
            btnDefaults.Font = new Font("Segoe UI", 8F);
            btnDefaults.Location = new Point(536, 3);
            btnDefaults.Margin = new Padding(2, 3, 2, 3);
            btnDefaults.Name = "btnDefaults";
            btnDefaults.Size = new Size(33, 35);
            btnDefaults.TabIndex = 12;
            btnDefaults.Text = "🗄️";
            btnDefaults.UseVisualStyleBackColor = true;
            btnDefaults.Click += btnDefaults_Click;
            // 
            // btnLeft
            // 
            btnLeft.Dock = DockStyle.Fill;
            btnLeft.Enabled = false;
            btnLeft.Location = new Point(320, 3);
            btnLeft.Margin = new Padding(2, 3, 2, 3);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(33, 35);
            btnLeft.TabIndex = 13;
            btnLeft.Text = "◀";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Dock = DockStyle.Fill;
            btnRight.Enabled = false;
            btnRight.Location = new Point(357, 3);
            btnRight.Margin = new Padding(2, 3, 2, 3);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(33, 35);
            btnRight.TabIndex = 14;
            btnRight.Text = "▶";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(2, 7);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(58, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "STATUS";
            // 
            // tableLayoutPanelFolder
            // 
            tableLayoutPanelFolder.ColumnCount = 9;
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanelFolder.Controls.Add(lblSelect, 0, 0);
            tableLayoutPanelFolder.Controls.Add(cmbFolder, 1, 0);
            tableLayoutPanelFolder.Controls.Add(btnClear, 8, 0);
            tableLayoutPanelFolder.Controls.Add(btnRight, 4, 0);
            tableLayoutPanelFolder.Controls.Add(btnEdit, 2, 0);
            tableLayoutPanelFolder.Controls.Add(btnRemove, 5, 0);
            tableLayoutPanelFolder.Controls.Add(btnLeft, 3, 0);
            tableLayoutPanelFolder.Controls.Add(btnDefaults, 7, 0);
            tableLayoutPanelFolder.Dock = DockStyle.Fill;
            tableLayoutPanelFolder.Location = new Point(39, 34);
            tableLayoutPanelFolder.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanelFolder.Name = "tableLayoutPanelFolder";
            tableLayoutPanelFolder.RowCount = 1;
            tableLayoutPanelFolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFolder.Size = new Size(608, 41);
            tableLayoutPanelFolder.TabIndex = 16;
            // 
            // chkSaveSettings
            // 
            chkSaveSettings.Anchor = AnchorStyles.Left;
            chkSaveSettings.AutoSize = true;
            chkSaveSettings.Checked = true;
            chkSaveSettings.CheckState = CheckState.Checked;
            chkSaveSettings.ImageAlign = ContentAlignment.MiddleLeft;
            chkSaveSettings.Location = new Point(249, 5);
            chkSaveSettings.Margin = new Padding(2, 3, 2, 3);
            chkSaveSettings.Name = "chkSaveSettings";
            chkSaveSettings.Size = new Size(119, 24);
            chkSaveSettings.TabIndex = 19;
            chkSaveSettings.Text = "Save Settings";
            chkSaveSettings.TextAlign = ContentAlignment.MiddleCenter;
            chkSaveSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelButtons1
            // 
            tableLayoutPanelButtons1.ColumnCount = 3;
            tableLayoutPanelButtons1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanelButtons1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanelButtons1.Controls.Add(btnArchive, 1, 0);
            tableLayoutPanelButtons1.Controls.Add(btnRestore, 2, 0);
            tableLayoutPanelButtons1.Controls.Add(txtFolder, 0, 0);
            tableLayoutPanelButtons1.Dock = DockStyle.Fill;
            tableLayoutPanelButtons1.Location = new Point(39, 94);
            tableLayoutPanelButtons1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanelButtons1.Name = "tableLayoutPanelButtons1";
            tableLayoutPanelButtons1.RowCount = 1;
            tableLayoutPanelButtons1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons1.Size = new Size(608, 41);
            tableLayoutPanelButtons1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.Controls.Add(btnSaveFolder, 1, 0);
            tableLayoutPanel1.Controls.Add(btnBrowse, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLastRow, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(39, 154);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(608, 41);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLastRow
            // 
            tableLastRow.ColumnCount = 2;
            tableLastRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLastRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tableLastRow.Controls.Add(chkSaveSettings, 1, 0);
            tableLastRow.Controls.Add(lblStatus, 0, 0);
            tableLastRow.Dock = DockStyle.Fill;
            tableLastRow.Location = new Point(2, 3);
            tableLastRow.Margin = new Padding(2, 3, 2, 3);
            tableLastRow.Name = "tableLastRow";
            tableLastRow.RowCount = 1;
            tableLastRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLastRow.Size = new Size(380, 35);
            tableLastRow.TabIndex = 19;
            // 
            // tableLayoutPanelAll
            // 
            tableLayoutPanelAll.ColumnCount = 3;
            tableLayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanelAll.Controls.Add(tableLayoutPanel1, 1, 6);
            tableLayoutPanelAll.Controls.Add(tableLayoutPanelButtons1, 1, 4);
            tableLayoutPanelAll.Controls.Add(tableLayoutPanelFolder, 1, 2);
            tableLayoutPanelAll.Dock = DockStyle.Fill;
            tableLayoutPanelAll.Location = new Point(0, 0);
            tableLayoutPanelAll.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanelAll.Name = "tableLayoutPanelAll";
            tableLayoutPanelAll.RowCount = 9;
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelAll.Size = new Size(686, 229);
            tableLayoutPanelAll.TabIndex = 19;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 229);
            Controls.Add(tableLayoutPanelAll);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "Save Moon Folders";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            tableLayoutPanelFolder.ResumeLayout(false);
            tableLayoutPanelFolder.PerformLayout();
            tableLayoutPanelButtons1.ResumeLayout(false);
            tableLayoutPanelButtons1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLastRow.ResumeLayout(false);
            tableLastRow.PerformLayout();
            tableLayoutPanelAll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnArchive;
        private Label lblSelect;
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
        private Label lblStatus;
        private TableLayoutPanel tableLayoutPanelFolder;
        private TableLayoutPanel tableLayoutPanelButtons1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelAll;
        private CheckBox chkSaveSettings;
        private TableLayoutPanel tableLastRow;
    }
}
