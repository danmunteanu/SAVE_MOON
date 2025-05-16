namespace SAVE_GAMES
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
            btnArchiveFolder = new Button();
            lblMoon = new Label();
            txtFolder = new TextBox();
            btnLoadMoon = new Button();
            btnBrowse = new Button();
            btnExperimental = new Button();
            SuspendLayout();
            // 
            // btnArchiveFolder
            // 
            btnArchiveFolder.Location = new Point(53, 229);
            btnArchiveFolder.Name = "btnArchiveFolder";
            btnArchiveFolder.Size = new Size(683, 57);
            btnArchiveFolder.TabIndex = 0;
            btnArchiveFolder.Text = "ARCHIVE FOLDER";
            btnArchiveFolder.UseVisualStyleBackColor = true;
            btnArchiveFolder.Click += btnSaveMoon_Click;
            // 
            // lblMoon
            // 
            lblMoon.AutoSize = true;
            lblMoon.Location = new Point(51, 122);
            lblMoon.Name = "lblMoon";
            lblMoon.Size = new Size(117, 25);
            lblMoon.TabIndex = 1;
            lblMoon.Text = "Select Folder:";
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(53, 162);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(565, 31);
            txtFolder.TabIndex = 2;
            // 
            // btnLoadMoon
            // 
            btnLoadMoon.Location = new Point(53, 50);
            btnLoadMoon.Name = "btnLoadMoon";
            btnLoadMoon.Size = new Size(322, 34);
            btnLoadMoon.TabIndex = 3;
            btnLoadMoon.Text = "LOAD MOON FOLDER";
            btnLoadMoon.UseVisualStyleBackColor = true;
            btnLoadMoon.Click += btnLoadMoon_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(624, 160);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnExperimental
            // 
            btnExperimental.Location = new Point(414, 50);
            btnExperimental.Name = "btnExperimental";
            btnExperimental.Size = new Size(322, 34);
            btnExperimental.TabIndex = 5;
            btnExperimental.Text = "LOAD EXPERIMENTAL";
            btnExperimental.UseVisualStyleBackColor = true;
            btnExperimental.Click += btnExperimental_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 533);
            Controls.Add(btnExperimental);
            Controls.Add(btnBrowse);
            Controls.Add(btnLoadMoon);
            Controls.Add(txtFolder);
            Controls.Add(lblMoon);
            Controls.Add(btnArchiveFolder);
            Name = "MainForm";
            Text = "SAVE Moon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArchiveFolder;
        private Label lblMoon;
        private TextBox txtFolder;
        private Button btnLoadMoon;
        private Button btnBrowse;
        private Button btnExperimental;
    }
}
