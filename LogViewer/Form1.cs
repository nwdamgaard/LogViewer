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

            //disable secondary Y axis: simplicity first, flexibility later
            secondaryYAxisToolStripMenuItem.Checked = false;
            secondaryYAxisToolStripMenuItem_Click(secondaryYAxisToolStripMenuItem, null);
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

        private void clear_points()
        {
            chart1.Series.FindByName("primary").Points.Clear();
            chart1.Series.FindByName("secondary").Points.Clear();
        }

        private void file_loaded()
        {
            update_list(xAxisList);
            update_list(yAxisList);
            update_list(yAxisListOther);
            clear_points();
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

            Console.WriteLine("updating graph...");

            //generate series for primary Y-axis
            double miny = double.PositiveInfinity;
            double maxy = double.NegativeInfinity;
            chart1.Series.FindByName("primary").Points.Clear();
            for(int i = 0; i < LoadedLog.log[LoadedLog.columns[0]].Count; i++)
            {
                double x = LoadedLog.log[xAxisList.SelectedItem.ToString()][i];
                double y = LoadedLog.log[yAxisList.SelectedItem.ToString()][i];
                chart1.Series.FindByName("primary").Points.AddXY(x, y);
                miny = Math.Min(y, miny);
                maxy = Math.Max(y, maxy);
            }
            chart1.ChartAreas.First().AxisY.Maximum = maxy;
            chart1.ChartAreas.First().AxisY.Minimum = miny;

            if (yAxisListOther.SelectedItem != null && secondaryYAxisToolStripMenuItem.Checked)
            {
                miny = double.PositiveInfinity;
                maxy = double.NegativeInfinity;
                //generate series for secondary Y-axis
                chart1.Series.FindByName("secondary").Points.Clear();
                for (int i = 0; i < LoadedLog.log[LoadedLog.columns[0]].Count; i++)
                {
                    double x = LoadedLog.log[xAxisList.SelectedItem.ToString()][i];
                    double y = LoadedLog.log[yAxisListOther.SelectedItem.ToString()][i];
                    miny = Math.Min(miny, y);
                    maxy = Math.Max(maxy, y);
                    chart1.Series.FindByName("secondary").Points.AddXY(x, y);
                }
                chart1.ChartAreas.First().AxisY2.Title = yAxisListOther.SelectedItem.ToString();
                chart1.ChartAreas.First().AxisY2.Enabled = AxisEnabled.True;
                chart1.ChartAreas.First().AxisY2.Maximum = maxy;
                chart1.ChartAreas.First().AxisY2.Minimum = miny;
            } else
            {
                chart1.Series.FindByName("secondary").Points.Clear();
                chart1.ChartAreas.First().AxisY2.Title = "";
                chart1.ChartAreas.First().AxisY2.Enabled = AxisEnabled.False;
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
            chart1.Series.FindByName("primary").ChartType = SeriesChartType.Line;
            chart1.Series.FindByName("secondary").ChartType = SeriesChartType.Line;
        }

        private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_graph_type((ToolStripMenuItem)sender);
            chart1.Series.FindByName("primary").ChartType = SeriesChartType.Point;
            chart1.Series.FindByName("secondary").ChartType = SeriesChartType.Point;
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

        private void secondaryYAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            
            if(item.Checked)
            {
                tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[2].Height = 33;
            }
            else
            {
                tableLayoutPanel1.RowStyles[2].Height = 0;
            }

            update_graph();
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart1.HitTest(e.X, e.Y);
            if(result.ChartElementType == ChartElementType.DataPoint)
            {
                //show data point info
                dataPointInfoPopup.Show();

                //move data point info to mouse position
                Point location = MousePosition;
                location.Offset(new Point(5, 0));

                if(PointToClient(location).X + dataPointInfoPopup.Width > Width) //if the popup hangs off the screen, put it to the left of the cursor
                {
                    location.Offset(new Point(-10 - dataPointInfoPopup.Width, 0));
                }

                dataPointInfoPopup.Location = PointToClient(location);

                //fill labels
                DataPoint point = result.Series.Points.ElementAt(result.PointIndex);
                string xTitle = result.ChartArea.AxisX.Title;
                string yTitle = result.Series.YAxisType == AxisType.Primary ? result.ChartArea.AxisY.Title : result.ChartArea.AxisY2.Title;
                xcoordLabel.Text = xTitle + ": " + point.XValue.ToString();
                ycoordLabel.Text = yTitle + ": " + point.YValues.First().ToString();

            } else
            {
                dataPointInfoPopup.Hide();
            }
        }
    }
}
