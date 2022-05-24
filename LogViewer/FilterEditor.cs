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
    public partial class FilterEditor : Form
    {
        public FilterEditor()
        {
            InitializeComponent();
        }

        public Filter GetFilter()
        {
            Filter filter = new Filter();
            filter.variableName = variableList1.VariableName();
            
            if(greaterThanCheckBox.Checked)
            {
                filter.greaterThan = greaterThanTextBox.Value;
            }

            if(lessThanCheckBox.Checked)
            {
                filter.lessThan = lessThanTextBox.Value;
            }

            return filter;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void greaterThanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            greaterThanTextBox.Enabled = greaterThanCheckBox.Checked;
        }

        private void lessThanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lessThanTextBox.Enabled = lessThanCheckBox.Checked;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
