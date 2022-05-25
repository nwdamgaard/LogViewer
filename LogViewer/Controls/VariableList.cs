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

        public void SelectItem(string item)
        {
            if(listBox.Items.Count >= 0)
            {
                waitingToSelect = item;
                return;
            }

            listBox.SelectedItem = item;
        }

        private void VariableList_Load(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            foreach (string variable in LoadedLog.columns)
            {
                listBox.Items.Add(variable);
            }

            if (waitingToSelect != "")
            {
                listBox.SelectedItem = waitingToSelect;
                waitingToSelect = "";
            }
        }

        private string waitingToSelect = "";
    }
}
