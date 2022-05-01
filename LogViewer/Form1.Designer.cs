namespace LogViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolBar = new System.Windows.Forms.MenuStrip();
            this.toolBar_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addYAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.xAxisList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yAxisTabs = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataPointInfoPopup = new System.Windows.Forms.FlowLayoutPanel();
            this.xcoordLabel = new System.Windows.Forms.Label();
            this.ycoordLabel = new System.Windows.Forms.Label();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.dataPointInfoPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBar_file,
            this.graphToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1031, 24);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "menuStrip1";
            // 
            // toolBar_file
            // 
            this.toolBar_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBar_file_open});
            this.toolBar_file.Name = "toolBar_file";
            this.toolBar_file.Size = new System.Drawing.Size(37, 20);
            this.toolBar_file.Text = "File";
            // 
            // toolBar_file_open
            // 
            this.toolBar_file_open.Name = "toolBar_file_open";
            this.toolBar_file_open.Size = new System.Drawing.Size(180, 22);
            this.toolBar_file_open.Text = "Open...";
            this.toolBar_file_open.Click += new System.EventHandler(this.toolBar_file_open_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.addYAxisToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.pointsToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.lineToolStripMenuItem.Text = "Lines";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.Checked = true;
            this.pointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.pointsToolStripMenuItem_Click);
            // 
            // addYAxisToolStripMenuItem
            // 
            this.addYAxisToolStripMenuItem.Name = "addYAxisToolStripMenuItem";
            this.addYAxisToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addYAxisToolStripMenuItem.Text = "Add Y Axis";
            this.addYAxisToolStripMenuItem.Click += new System.EventHandler(this.addYAxisToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockXToolStripMenuItem,
            this.lockYToolStripMenuItem,
            this.zoomToFitToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // lockXToolStripMenuItem
            // 
            this.lockXToolStripMenuItem.Name = "lockXToolStripMenuItem";
            this.lockXToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.lockXToolStripMenuItem.Text = "Lock X";
            this.lockXToolStripMenuItem.Click += new System.EventHandler(this.lockZoom_menuItem);
            // 
            // lockYToolStripMenuItem
            // 
            this.lockYToolStripMenuItem.Checked = true;
            this.lockYToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lockYToolStripMenuItem.Name = "lockYToolStripMenuItem";
            this.lockYToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.lockYToolStripMenuItem.Text = "Lock Y";
            this.lockYToolStripMenuItem.Click += new System.EventHandler(this.lockZoom_menuItem);
            // 
            // zoomToFitToolStripMenuItem
            // 
            this.zoomToFitToolStripMenuItem.Name = "zoomToFitToolStripMenuItem";
            this.zoomToFitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.zoomToFitToolStripMenuItem.Text = "Zoom to Fit";
            this.zoomToFitToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 497);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.xAxisList);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.yAxisTabs);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(219, 497);
            this.splitContainer2.SplitterDistance = 149;
            this.splitContainer2.TabIndex = 0;
            // 
            // xAxisList
            // 
            this.xAxisList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xAxisList.FormattingEnabled = true;
            this.xAxisList.Location = new System.Drawing.Point(0, 17);
            this.xAxisList.Name = "xAxisList";
            this.xAxisList.Size = new System.Drawing.Size(219, 132);
            this.xAxisList.TabIndex = 11;
            this.xAxisList.SelectedIndexChanged += new System.EventHandler(this.AxisList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "X Axis";
            // 
            // yAxisTabs
            // 
            this.yAxisTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yAxisTabs.Location = new System.Drawing.Point(0, 0);
            this.yAxisTabs.Name = "yAxisTabs";
            this.yAxisTabs.SelectedIndex = 0;
            this.yAxisTabs.Size = new System.Drawing.Size(219, 344);
            this.yAxisTabs.TabIndex = 1;
            this.yAxisTabs.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "To get started, go to Graph->Add Y Axis";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(155, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "primary";
            series1.XValueMember = "X";
            series1.YValueMembers = "Y";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "secondary";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(808, 497);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseUp);
            // 
            // dataPointInfoPopup
            // 
            this.dataPointInfoPopup.AutoSize = true;
            this.dataPointInfoPopup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataPointInfoPopup.Controls.Add(this.xcoordLabel);
            this.dataPointInfoPopup.Controls.Add(this.ycoordLabel);
            this.dataPointInfoPopup.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.dataPointInfoPopup.Location = new System.Drawing.Point(155, 121);
            this.dataPointInfoPopup.Margin = new System.Windows.Forms.Padding(10);
            this.dataPointInfoPopup.Name = "dataPointInfoPopup";
            this.dataPointInfoPopup.Size = new System.Drawing.Size(62, 26);
            this.dataPointInfoPopup.TabIndex = 4;
            this.dataPointInfoPopup.Visible = false;
            this.dataPointInfoPopup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // xcoordLabel
            // 
            this.xcoordLabel.AutoSize = true;
            this.xcoordLabel.Location = new System.Drawing.Point(3, 0);
            this.xcoordLabel.Name = "xcoordLabel";
            this.xcoordLabel.Size = new System.Drawing.Size(56, 13);
            this.xcoordLabel.TabIndex = 0;
            this.xcoordLabel.Text = "hello there";
            this.xcoordLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // ycoordLabel
            // 
            this.ycoordLabel.AutoSize = true;
            this.ycoordLabel.Location = new System.Drawing.Point(3, 13);
            this.ycoordLabel.Name = "ycoordLabel";
            this.ycoordLabel.Size = new System.Drawing.Size(35, 13);
            this.ycoordLabel.TabIndex = 1;
            this.ycoordLabel.Text = "label3";
            this.ycoordLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 521);
            this.Controls.Add(this.dataPointInfoPopup);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolBar);
            this.MainMenuStrip = this.toolBar;
            this.Name = "Form1";
            this.Text = "Log Viewer";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.dataPointInfoPopup.ResumeLayout(false);
            this.dataPointInfoPopup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip toolBar;
        private System.Windows.Forms.ToolStripMenuItem toolBar_file;
        private System.Windows.Forms.ToolStripMenuItem toolBar_file_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToFitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel dataPointInfoPopup;
        private System.Windows.Forms.Label xcoordLabel;
        private System.Windows.Forms.Label ycoordLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox xAxisList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl yAxisTabs;
        private System.Windows.Forms.ToolStripMenuItem addYAxisToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

