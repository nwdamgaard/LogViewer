﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LogViewer
{
    public partial class yAxisPage : UserControl
    {
        private Series series;

        private Form1 mainWindow;

        public yAxisPage(Form1 mainWindow)
        {
            this.mainWindow = mainWindow;
            series = new Series();
            series.ChartType = mainWindow.chartType;

            InitializeComponent();

            scaleDropdown.SelectedIndex = 0;
            series.Tag = scaleFactorBox.Value;

            Dock = DockStyle.Fill;
            LoadedLog.LoadedFile += file_loaded;
            update_list(variablesList);
        }

        public Series getSeries()
        {
            return series;
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

        public void generatePoints()
        {
            ListBox xAxisList = (ListBox)mainWindow.Controls.Find("xAxisList", true).First();

            if (variablesList.SelectedIndex == -1) return; //don't generate any points if nothing's selected
            if (xAxisList.SelectedItem == null) return;

            string name = LoadedLog.columns[variablesList.SelectedIndex];
            double scaleFactor = getScaleFactor();
            bool onLeft = getScale();

            series.Points.Clear();
            for (int i = 0; i < LoadedLog.log[name].Count; i++)
            {
                double y = LoadedLog.log[name][i] * scaleFactor;
                double x = LoadedLog.log[xAxisList.SelectedItem.ToString()][i];
                series.Points.AddXY(x, y);
            }
        }

        private void variablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newTitle = LoadedLog.columns[variablesList.SelectedIndex];

            TabPage parent = (TabPage)Parent;
            parent.Text = newTitle;
            series.Name = newTitle;

            generatePoints();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            TabPage tabPage = (TabPage)Parent;
            TabControl tabControl = (TabControl)tabPage.Parent;
            tabControl.Controls.Remove(tabPage);

            Chart chart = (Chart)mainWindow.Controls.Find("chart1", true).First();
            chart.Series.Remove(series);
        }

        private void scaleFactorBox_ValueChanged(object sender, EventArgs e)
        {
            series.Tag = scaleFactorBox.Value;
            generatePoints();
        }

        private void scaleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool onLeft = getScale();
            series.YAxisType = onLeft ? AxisType.Primary : AxisType.Secondary;
            generatePoints();
        }
    }
}