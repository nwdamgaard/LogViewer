using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogViewer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.csv_delimeter.Equals(""))
            {
                csvSeparatorToggle.Checked = true;
            } else
            {
                csvSeparatorToggle.Checked = false;
                csvSeparatorBox.Text = Properties.Settings.Default.csv_delimeter;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void csvSeparatorToggle_CheckedChanged(object sender, EventArgs e)
        {
            csvSeparatorBox.Enabled = !csvSeparatorToggle.Checked;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.csv_delimeter = csvSeparatorToggle.Checked ? "" : csvSeparatorBox.Text;

            Properties.Settings.Default.Save();
        }
    }
}
