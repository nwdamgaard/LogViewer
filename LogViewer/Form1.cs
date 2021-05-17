using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace LogViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadedLog.LoadedFile += file_loaded;
        }

        private void update_list(ListBox list)
        {
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

        private void file_loaded()
        {
            update_list(xAxisList);
            update_list(yAxisList);
        }

        private void toolBar_file_open_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    LoadedLog.loadFile(file);
                }
                catch (IOException)
                {
                }
            }
        }

        private void update_graph()
        {
            if(xAxisList.SelectedItem == null)
            {
                return;
            }
            if (yAxisList.SelectedItem == null)
            {
                return;
            }

            chart1.Series.First().Points.Clear();
            for(int i = 0; i < LoadedLog.log[LoadedLog.columns[0]].Count; i++)
            {
                double x = LoadedLog.log[xAxisList.SelectedItem.ToString()][i];
                double y = LoadedLog.log[yAxisList.SelectedItem.ToString()][i];
                chart1.Series.First().Points.AddXY(x, y);
            }

            chart1.ChartAreas.First().AxisX.Title = xAxisList.SelectedItem.ToString();
            chart1.ChartAreas.First().AxisY.Title = yAxisList.SelectedItem.ToString();

            chart1.DataBind();
            chart1.Update();
        }

        private void AxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_graph();
        }

        private void select_graph_type(ToolStripMenuItem item_to_select)
        {
            foreach(ToolStripMenuItem item in typeToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }

            item_to_select.Checked = true;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_graph_type((ToolStripMenuItem)sender);
            chart1.Series.First().ChartType = SeriesChartType.Line;
        }
                private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_graph_type((ToolStripMenuItem)sender);
            chart1.Series.First().ChartType = SeriesChartType.Point;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.First().AxisX.ScaleView.ZoomReset(0);
            chart1.ChartAreas.First().AxisY.ScaleView.ZoomReset(0);
        }

        private void lockZoom_menuItem(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.Checked = !menuItem.Checked;

            if(menuItem.Name.Equals("lockXToolStripMenuItem"))
            {
                chart1.ChartAreas.First().CursorX.IsUserSelectionEnabled = !menuItem.Checked;
            }
            else if(menuItem.Name.Equals("lockYToolStripMenuItem"))
            {
                chart1.ChartAreas.First().CursorY.IsUserSelectionEnabled = !menuItem.Checked;
            }
        }
    }
}
