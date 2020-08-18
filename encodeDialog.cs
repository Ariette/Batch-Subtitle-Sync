using System;
using System.Windows.Forms;

namespace BatchSubtitleSync
{
    public partial class encodeDialog : Form
    {
        public encodeDialog(string encoding, bool nofallback, bool ansi)
        {
            InitializeComponent();

            // Load data from MainWindow
            comboBox.Text = encoding;
            fallBack.Checked = nofallback;
            saveANSI.Checked = ansi;

            // Add event
            comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex == 5)
            {
                comboBox.Items.Clear();
                comboBox.DropDownStyle = ComboBoxStyle.Simple;
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Value = comboBox.SelectedItem != null ? comboBox.SelectedItem.ToString() : comboBox.Text;
            this.NoFallback = fallBack.Checked;
            this.ANSI = saveANSI.Checked;
        }

        public string Value { get; set; }
        public bool NoFallback { get; set; }
        public bool ANSI { get; set; }

    }
}
