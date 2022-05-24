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
    public partial class VariableList : UserControl
    {
        public VariableList()
        {
            InitializeComponent();
        }

        public string VariableName()
        {
            return (string)listBox.SelectedItem;
        }

        private void VariableList_Load(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (string variable in LoadedLog.columns)
            {
                listBox.Items.Add(variable);
            }
        }
    }
}
