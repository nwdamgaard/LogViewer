namespace LogViewer
{
    partial class FilterEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.greaterThanCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lessThanCheckBox = new System.Windows.Forms.CheckBox();
            this.okayButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.greaterThanTextBox = new System.Windows.Forms.NumericUpDown();
            this.lessThanTextBox = new System.Windows.Forms.NumericUpDown();
            this.variableList1 = new LogViewer.VariableList();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greaterThanTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessThanTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.variableList1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable to filter";
            // 
            // greaterThanCheckBox
            // 
            this.greaterThanCheckBox.AutoSize = true;
            this.greaterThanCheckBox.Location = new System.Drawing.Point(20, 3);
            this.greaterThanCheckBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.greaterThanCheckBox.Name = "greaterThanCheckBox";
            this.greaterThanCheckBox.Size = new System.Drawing.Size(88, 17);
            this.greaterThanCheckBox.TabIndex = 0;
            this.greaterThanCheckBox.Text = "Greater than:";
            this.greaterThanCheckBox.UseVisualStyleBackColor = true;
            this.greaterThanCheckBox.CheckedChanged += new System.EventHandler(this.greaterThanCheckBox_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.greaterThanCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.greaterThanTextBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 26);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.lessThanCheckBox);
            this.flowLayoutPanel2.Controls.Add(this.lessThanTextBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 26);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lessThanCheckBox
            // 
            this.lessThanCheckBox.AutoSize = true;
            this.lessThanCheckBox.Location = new System.Drawing.Point(20, 3);
            this.lessThanCheckBox.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.lessThanCheckBox.MinimumSize = new System.Drawing.Size(88, 0);
            this.lessThanCheckBox.Name = "lessThanCheckBox";
            this.lessThanCheckBox.Size = new System.Drawing.Size(88, 17);
            this.lessThanCheckBox.TabIndex = 0;
            this.lessThanCheckBox.Text = "Less than:";
            this.lessThanCheckBox.UseVisualStyleBackColor = true;
            this.lessThanCheckBox.CheckedChanged += new System.EventHandler(this.lessThanCheckBox_CheckedChanged);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(148, 3);
            this.okayButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(75, 23);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.okayButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 237);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(243, 46);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panel1.Size = new System.Drawing.Size(243, 92);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // greaterThanTextBox
            // 
            this.greaterThanTextBox.DecimalPlaces = 2;
            this.greaterThanTextBox.Location = new System.Drawing.Point(114, 3);
            this.greaterThanTextBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.greaterThanTextBox.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.greaterThanTextBox.Name = "greaterThanTextBox";
            this.greaterThanTextBox.Size = new System.Drawing.Size(120, 20);
            this.greaterThanTextBox.TabIndex = 2;
            // 
            // lessThanTextBox
            // 
            this.lessThanTextBox.DecimalPlaces = 2;
            this.lessThanTextBox.Location = new System.Drawing.Point(114, 3);
            this.lessThanTextBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.lessThanTextBox.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.lessThanTextBox.Name = "lessThanTextBox";
            this.lessThanTextBox.Size = new System.Drawing.Size(120, 20);
            this.lessThanTextBox.TabIndex = 1;
            // 
            // variableList1
            // 
            this.variableList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableList1.Location = new System.Drawing.Point(3, 16);
            this.variableList1.Name = "variableList1";
            this.variableList1.Size = new System.Drawing.Size(237, 127);
            this.variableList1.TabIndex = 0;
            // 
            // FilterEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilterEditor";
            this.Text = "Edit Filter";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greaterThanTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessThanTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private VariableList variableList1;
        private System.Windows.Forms.CheckBox greaterThanCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox lessThanCheckBox;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown greaterThanTextBox;
        private System.Windows.Forms.NumericUpDown lessThanTextBox;
    }
}