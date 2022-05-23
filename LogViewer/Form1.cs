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
        public SeriesChartType chartType = SeriesChartType.Point;

        public Form1()
        {
            InitializeComponent();

            LoadedLog.LoadedFile += file_loaded;
            LoadedLog.RequestUpdateConfig += update_config;
            LoadedLog.NewConfigLoaded += load_from_config;
        }
        
        private void load_from_config()
        {
            //clear_points();

            // select the correct x axis
            int xAxisIndex = Array.IndexOf(LoadedLog.columns, LoadedLog.config.xAxisVariable);
            if (xAxisIndex == -1)
            {
                Utils.userError("The currently loaded file does not contain a variable called \"" + LoadedLog.config.xAxisVariable + "\".");
                return;
            }
            xAxisList.SelectedIndex = xAxisIndex;

            // setup y axes
            foreach (yAxisConfig axisConfig in LoadedLog.config.yAxes)
            {
                int axisIndex = Array.IndexOf(LoadedLog.columns, axisConfig.selectedVariable);
                if (axisIndex == -1)
                {
                    Utils.userError("The currently loaded file does not contain a variable called \"" + axisConfig.selectedVariable + "\". This y-axis will be skipped.");
                    continue;
                }
                axisConfig.selectedVariableIndex = axisIndex;

                // ***** excerpt from another function to create the new page *******
                TabPage newPage = new TabPage("New Y Axis");
                yAxisPage axisPage = yAxisTabs.TabCount == 1 ? new yAxisPage(this, 1) : new yAxisPage(this);
                chart1.Series.Add(axisPage.getSeries());
                newPage.Controls.Add(axisPage);
                yAxisTabs.TabPages.Add(newPage);

                if (yAxisTabs.TabCount == 1)
                {
                    yAxisTabs.Visible = true;
                }
                // ********************************************

                axisPage.load_config(axisConfig);
            }


        }

        private void update_config()
        {
            LoadedLog.config.xAxisVariable = xAxisList.SelectedIndex == -1 ? "" : LoadedLog.columns[xAxisList.SelectedIndex];
            LoadedLog.config.graphType = get_chart_type();
            
            LoadedLog.config.yAxes = new List<yAxisConfig>();
            foreach(TabPage page in yAxisTabs.Controls)
            {
                yAxisPage axisPage = (yAxisPage)page.Controls[0];
                LoadedLog.config.yAxes.Add(axisPage.config);
            }

            Console.WriteLine("Form1: Updated config.");
        }

        private void update_list(ListBox list)
        {
            list.ClearSelected();
            list.BeginUpdate();
            list.Items.Clear();

            foreach (string col in LoadedLog.columns)
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

        private SeriesChartType get_chart_type()
        {
            if(pointsToolStripMenuItem.Checked)
            {
                return SeriesChartType.Point;
            }

            if(lineToolStripMenuItem.Checked)
            {
                return SeriesChartType.Line;
            }

            Console.WriteLine("get_chart_type(): something really screwed up");
            return SeriesChartType.Point;
        }

        private void AxisList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(TabPage page in yAxisTabs.Controls) //loop through each Y axis and regenerate their points with the new X-axis
            {
                yAxisPage axisPage = (yAxisPage)page.Controls[0];
                axisPage.generatePoints();
            }
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
            foreach(Series series in chart1.Series)
            {
                chartType = SeriesChartType.Line;
                series.ChartType = SeriesChartType.Line;
            }
        }

        private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_graph_type((ToolStripMenuItem)sender);
            foreach (Series series in chart1.Series)
            {
                chartType = SeriesChartType.Point;
                series.ChartType = SeriesChartType.Point;
            }
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

        private void addYAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newPage = new TabPage("New Y Axis");
            yAxisPage axisPage = yAxisTabs.TabCount == 1 ? new yAxisPage(this, 1) : new yAxisPage(this);
            chart1.Series.Add(axisPage.getSeries());
            newPage.Controls.Add(axisPage);
            yAxisTabs.TabPages.Add(newPage);

            if (yAxisTabs.TabCount == 1)
            {
                yAxisTabs.Visible = true;
            }
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            chart1.Visible = false;
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            chart1.Visible = true;
        }

        private bool mouseDown = false;
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) return; //zooming was really slow because of all the hit tests running

            HitTestResult result = chart1.HitTest(e.X, e.Y);
            if(result.ChartElementType == ChartElementType.DataPoint)
            {
                //show data point info
                dataPointInfoPopup.Show();

                //fill labels
                DataPoint point = result.Series.Points.ElementAt(result.PointIndex);
                double scaleFactor = (double)(decimal)result.Series.Tag; //scale factor is stored in the Series.Tag property
                string xText = (string)xAxisList.SelectedItem;
                string yText = result.Series.LegendText;
                xcoordLabel.Text = xText + ": " + point.XValue.ToString();
                ycoordLabel.Text = yText + ": " + (point.YValues.First() / scaleFactor).ToString();

                //move data point info to mouse position
                Point location = MousePosition;
                location.Offset(new Point(5, 0));

                //if the popup hangs off the screen, put it to the left of the cursor
                if (PointToClient(location).X + dataPointInfoPopup.Width + 10 >= Width)  // add 10 to account for the margin in dataPointInfoPopup
                {
                    location.Offset(new Point(-10 - dataPointInfoPopup.Width, 0));
                }

                dataPointInfoPopup.Location = PointToClient(location);

            } else
            {
                dataPointInfoPopup.Hide();
            }
        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            dataPointInfoPopup.Visible = false;
        }

        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void saveGraphConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string filepath = saveFileDialog1.FileName;
                LoadedLog.saveConfig(filepath);
            }
        }

        private void openGraphConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files|*.json";
            dialog.FileName = "";
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string file = dialog.FileName;
                LoadedLog.loadConfig(file);
            }
        }
    }
}
