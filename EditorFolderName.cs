using System.ComponentModel;

namespace SAVE_FOLDERS
{
    public partial class EditorFolderName : Form
    {
        private TextBox txtFolderName;
        public string InputValue { get; private set; } = string.Empty;
        
        [DefaultValue("")]
        public string FolderName
        {
            get => txtFolderName.Text;
            set => txtFolderName.Text = value;
        }

        public EditorFolderName()
        {
            InitializeComponent();

            this.Text = "Enter a Value";
            this.ClientSize = new System.Drawing.Size(280, 120); // Set client size, not full height
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            var label = new Label
            {
                Text = "Folder Name:",
                Left = 10,
                Top = 10,
                Width = 260
            };

            txtFolderName = new TextBox
            {
                Left = 10,
                Top = 35,
                Width = 260
            };

            var buttonSave = new Button
            {
                Text = "SAVE",
                Left = 105,
                Top = 70,
                Width = 75,
                Height = 45
            };
            buttonSave.Click += Save_Click;

            var buttonCancel = new Button
            {
                Text = "CANCEL",
                Left = 185,
                Top = 70,
                Width = 85,
                Height = 45
            };
            buttonCancel.Click += (sender, e) => this.DialogResult = DialogResult.Cancel;

            this.Controls.Add(label);
            this.Controls.Add(txtFolderName);
            this.Controls.Add(buttonSave);
            this.Controls.Add(buttonCancel);
        }

        private void Save_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFolderName.Text))
            {
                MessageBox.Show("Value cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InputValue = txtFolderName.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
