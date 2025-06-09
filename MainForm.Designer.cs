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
            btnArchive.Location = new Point(485, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(134, 33);
            btnArchive.TabIndex = 0;
            btnArchive.Text = "ARCHIVE";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // lblMoon
            // 
            lblMoon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMoon.AutoSize = true;
            lblMoon.Location = new Point(3, 7);
            lblMoon.Name = "lblMoon";
            lblMoon.Size = new Size(129, 25);
            lblMoon.TabIndex = 1;
            lblMoon.Text = "Select Folder:";
            // 
            // txtFolder
            // 
            txtFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFolder.Location = new Point(3, 4);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(476, 31);
            txtFolder.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Dock = DockStyle.Fill;
            btnBrowse.Location = new Point(625, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(134, 32);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRestore
            // 
            btnRestore.Dock = DockStyle.Fill;
            btnRestore.Enabled = false;
            btnRestore.Location = new Point(625, 3);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(134, 33);
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
            cmbFolder.Location = new Point(138, 3);
            cmbFolder.Name = "cmbFolder";
            cmbFolder.Size = new Size(184, 33);
            cmbFolder.TabIndex = 7;
            cmbFolder.SelectedIndexChanged += cmbFolder_SelectedIndexChanged;
            // 
            // btnSaveFolder
            // 
            btnSaveFolder.Dock = DockStyle.Fill;
            btnSaveFolder.Location = new Point(485, 3);
            btnSaveFolder.Name = "btnSaveFolder";
            btnSaveFolder.Size = new Size(134, 32);
            btnSaveFolder.TabIndex = 8;
            btnSaveFolder.Text = "SAVE";
            btnSaveFolder.UseVisualStyleBackColor = true;
            btnSaveFolder.Click += btnSaveFolder_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(328, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(39, 33);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "✏️";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRemove.Location = new Point(463, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(39, 33);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "🗑️";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Location = new Point(720, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(39, 30);
            btnClear.TabIndex = 11;
            btnClear.Text = "❌";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDefaults
            // 
            btnDefaults.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDefaults.Font = new Font("Segoe UI", 8F);
            btnDefaults.Location = new Point(675, 3);
            btnDefaults.Name = "btnDefaults";
            btnDefaults.Size = new Size(39, 33);
            btnDefaults.TabIndex = 12;
            btnDefaults.Text = "🗄️";
            btnDefaults.UseVisualStyleBackColor = true;
            btnDefaults.Click += btnDefaults_Click;
            // 
            // btnLeft
            // 
            btnLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLeft.Enabled = false;
            btnLeft.Location = new Point(373, 3);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(39, 33);
            btnLeft.TabIndex = 13;
            btnLeft.Text = "◀";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRight.Enabled = false;
            btnRight.Location = new Point(418, 3);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(39, 33);
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
            lblStatus.Location = new Point(3, 3);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(71, 25);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "STATUS";
            // 
            // tableLayoutPanelFolder
            // 
            tableLayoutPanelFolder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelFolder.ColumnCount = 9;
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelFolder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelFolder.Controls.Add(lblMoon, 0, 0);
            tableLayoutPanelFolder.Controls.Add(cmbFolder, 1, 0);
            tableLayoutPanelFolder.Controls.Add(btnClear, 8, 0);
            tableLayoutPanelFolder.Controls.Add(btnRight, 4, 0);
            tableLayoutPanelFolder.Controls.Add(btnEdit, 2, 0);
            tableLayoutPanelFolder.Controls.Add(btnRemove, 5, 0);
            tableLayoutPanelFolder.Controls.Add(btnLeft, 3, 0);
            tableLayoutPanelFolder.Controls.Add(btnDefaults, 7, 0);
            tableLayoutPanelFolder.Location = new Point(48, 53);
            tableLayoutPanelFolder.Name = "tableLayoutPanelFolder";
            tableLayoutPanelFolder.RowCount = 1;
            tableLayoutPanelFolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFolder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelFolder.Size = new Size(762, 39);
            tableLayoutPanelFolder.TabIndex = 16;
            // 
            // chkSaveSettings
            // 
            chkSaveSettings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkSaveSettings.AutoSize = true;
            chkSaveSettings.Checked = true;
            chkSaveSettings.CheckState = CheckState.Checked;
            chkSaveSettings.Location = new Point(326, 3);
            chkSaveSettings.Name = "chkSaveSettings";
            chkSaveSettings.Size = new Size(147, 26);
            chkSaveSettings.TabIndex = 19;
            chkSaveSettings.Text = "Save Settings";
            chkSaveSettings.TextAlign = ContentAlignment.MiddleCenter;
            chkSaveSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelButtons1
            // 
            tableLayoutPanelButtons1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelButtons1.ColumnCount = 3;
            tableLayoutPanelButtons1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelButtons1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanelButtons1.Controls.Add(btnArchive, 1, 0);
            tableLayoutPanelButtons1.Controls.Add(btnRestore, 2, 0);
            tableLayoutPanelButtons1.Controls.Add(txtFolder, 0, 0);
            tableLayoutPanelButtons1.Location = new Point(48, 101);
            tableLayoutPanelButtons1.Name = "tableLayoutPanelButtons1";
            tableLayoutPanelButtons1.RowCount = 1;
            tableLayoutPanelButtons1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons1.Size = new Size(762, 39);
            tableLayoutPanelButtons1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.Controls.Add(btnSaveFolder, 1, 0);
            tableLayoutPanel1.Controls.Add(btnBrowse, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLastRow, 0, 0);
            tableLayoutPanel1.Location = new Point(48, 146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(762, 38);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLastRow
            // 
            tableLastRow.ColumnCount = 2;
            tableLastRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLastRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLastRow.Controls.Add(chkSaveSettings, 1, 0);
            tableLastRow.Controls.Add(lblStatus, 0, 0);
            tableLastRow.Dock = DockStyle.Fill;
            tableLastRow.Location = new Point(3, 3);
            tableLastRow.Name = "tableLastRow";
            tableLastRow.RowCount = 1;
            tableLastRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLastRow.Size = new Size(476, 32);
            tableLastRow.TabIndex = 19;
            // 
            // tableLayoutPanelAll
            // 
            tableLayoutPanelAll.ColumnCount = 3;
            tableLayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelAll.Controls.Add(tableLayoutPanel1, 1, 3);
            tableLayoutPanelAll.Controls.Add(tableLayoutPanelButtons1, 1, 2);
            tableLayoutPanelAll.Controls.Add(tableLayoutPanelFolder, 1, 1);
            tableLayoutPanelAll.Dock = DockStyle.Fill;
            tableLayoutPanelAll.Location = new Point(0, 0);
            tableLayoutPanelAll.Name = "tableLayoutPanelAll";
            tableLayoutPanelAll.RowCount = 5;
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelAll.Size = new Size(858, 236);
            tableLayoutPanelAll.TabIndex = 19;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 236);
            Controls.Add(tableLayoutPanelAll);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label lblStatus;
        private TableLayoutPanel tableLayoutPanelFolder;
        private TableLayoutPanel tableLayoutPanelButtons1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelAll;
        private CheckBox chkSaveSettings;
        private TableLayoutPanel tableLastRow;
    }
}
