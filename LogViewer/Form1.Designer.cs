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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolBar = new System.Windows.Forms.MenuStrip();
            this.toolBar_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.secondaryYAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.xAxisList = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.yAxisList = new System.Windows.Forms.ListBox();
            this.otherYaxisLabel = new System.Windows.Forms.Label();
            this.yAxisListOther = new System.Windows.Forms.ListBox();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBar_file,
            this.graphToolStripMenuItem,
            this.zoomToolStripMenuItem});
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
            this.toolBar_file_open.Size = new System.Drawing.Size(112, 22);
            this.toolBar_file_open.Text = "Open...";
            this.toolBar_file_open.Click += new System.EventHandler(this.toolBar_file_open_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.secondaryYAxisToolStripMenuItem});
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
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineToolStripMenuItem.Text = "Lines";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.Checked = true;
            this.pointsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.pointsToolStripMenuItem_Click);
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
            this.lockXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lockXToolStripMenuItem.Text = "Lock X";
            this.lockXToolStripMenuItem.Click += new System.EventHandler(this.lockZoom_menuItem);
            // 
            // lockYToolStripMenuItem
            // 
            this.lockYToolStripMenuItem.Checked = true;
            this.lockYToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lockYToolStripMenuItem.Name = "lockYToolStripMenuItem";
            this.lockYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lockYToolStripMenuItem.Text = "Lock Y";
            this.lockYToolStripMenuItem.Click += new System.EventHandler(this.lockZoom_menuItem);
            // 
            // zoomToFitToolStripMenuItem
            // 
            this.zoomToFitToolStripMenuItem.Name = "zoomToFitToolStripMenuItem";
            this.zoomToFitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 497);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 2;
            // 
            // secondaryYAxisToolStripMenuItem
            // 
            this.secondaryYAxisToolStripMenuItem.Checked = true;
            this.secondaryYAxisToolStripMenuItem.CheckOnClick = true;
            this.secondaryYAxisToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.secondaryYAxisToolStripMenuItem.Name = "secondaryYAxisToolStripMenuItem";
            this.secondaryYAxisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondaryYAxisToolStripMenuItem.Text = "Secondary Y Axis";
            this.secondaryYAxisToolStripMenuItem.Click += new System.EventHandler(this.secondaryYAxisToolStripMenuItem_Click);
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
            chartArea8.AxisX.Title = "X Axis";
            chartArea8.AxisY.Title = "Y Axis";
            chartArea8.AxisY2.MajorGrid.Enabled = false;
            chartArea8.CursorX.IsUserSelectionEnabled = true;
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.Legend = "Legend1";
            series15.Name = "primary";
            series15.XValueMember = "X";
            series15.YValueMembers = "Y";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series16.Legend = "Legend1";
            series16.Name = "secondary";
            series16.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(808, 497);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xAxisList);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 159);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "X Axis";
            // 
            // xAxisList
            // 
            this.xAxisList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xAxisList.FormattingEnabled = true;
            this.xAxisList.Location = new System.Drawing.Point(0, 17);
            this.xAxisList.Name = "xAxisList";
            this.xAxisList.Size = new System.Drawing.Size(213, 142);
            this.xAxisList.TabIndex = 9;
            this.xAxisList.SelectedIndexChanged += new System.EventHandler(this.AxisList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.yAxisList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 159);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.yAxisListOther);
            this.panel4.Controls.Add(this.otherYaxisLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 161);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Left Y Axis";
            // 
            // yAxisList
            // 
            this.yAxisList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yAxisList.FormattingEnabled = true;
            this.yAxisList.Location = new System.Drawing.Point(0, 18);
            this.yAxisList.Name = "yAxisList";
            this.yAxisList.Size = new System.Drawing.Size(213, 141);
            this.yAxisList.TabIndex = 12;
            this.yAxisList.SelectedIndexChanged += new System.EventHandler(this.AxisList_SelectedIndexChanged);
            // 
            // otherYaxisLabel
            // 
            this.otherYaxisLabel.BackColor = System.Drawing.SystemColors.Window;
            this.otherYaxisLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otherYaxisLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherYaxisLabel.Location = new System.Drawing.Point(0, 0);
            this.otherYaxisLabel.Name = "otherYaxisLabel";
            this.otherYaxisLabel.Size = new System.Drawing.Size(213, 18);
            this.otherYaxisLabel.TabIndex = 13;
            this.otherYaxisLabel.Text = "Right Y Axis";
            // 
            // yAxisListOther
            // 
            this.yAxisListOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yAxisListOther.FormattingEnabled = true;
            this.yAxisListOther.Location = new System.Drawing.Point(0, 18);
            this.yAxisListOther.Name = "yAxisListOther";
            this.yAxisListOther.Size = new System.Drawing.Size(213, 143);
            this.yAxisListOther.TabIndex = 14;
            this.yAxisListOther.SelectedIndexChanged += new System.EventHandler(this.AxisList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 521);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolBar);
            this.MainMenuStrip = this.toolBar;
            this.Name = "Form1";
            this.Text = "Log Viewer";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem secondaryYAxisToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox xAxisList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox yAxisList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox yAxisListOther;
        private System.Windows.Forms.Label otherYaxisLabel;
    }
}

