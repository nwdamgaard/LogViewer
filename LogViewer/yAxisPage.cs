using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogViewer
{
    public partial class yAxisPage : UserControl
    {
        private Form1 mainWindow;

        public yAxisPage(Form1 mainWindow)
        {
            this.mainWindow = mainWindow;

            InitializeComponent();

            scaleDropdown.SelectedIndex = 0;

            Dock = DockStyle.Fill;
            LoadedLog.LoadedFile += file_loaded;
            update_list(variablesList);

            variablesList.SelectedIndexChanged += mainWindow.update_graph;
        }

        public double getScaleFactor()
        {
            return (double)scaleFactorBox.Value;
        }

        //returns true for left and false for right
        public bool getScale()
        {
            if("Left".Equals((string)scaleDropdown.SelectedItem))
            {
                return true;
            }

            return false;
        }

        private void file_loaded()
        {
            update_list(variablesList);
        }

        private void update_list(ListBox list)
        {
            if (LoadedLog.columns == null)
                return;

            list.ClearSelected();
            list.BeginUpdate();
            list.Items.Clear();

            string[] columns = LoadedLog.columns;
            foreach (string col in columns)
            {
                list.Items.Add(col);
            }
            list.EndUpdate();
            list.Refresh();
        }

        private void variablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newTitle = LoadedLog.columns[variablesList.SelectedIndex];

            TabPage parent = (TabPage)Parent;
            parent.Text = newTitle;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            TabPage tabPage = (TabPage)Parent;
            TabControl tabControl = (TabControl)tabPage.Parent;
            tabControl.Controls.Remove(tabPage);

            mainWindow.update_graph();
        }

        private void scaleFactorBox_ValueChanged(object sender, EventArgs e)
        {
            mainWindow.update_graph();
        }

        private void scaleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainWindow.update_graph();
        }
    }
}
