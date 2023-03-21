namespace DISS_1SEM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.time_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start1_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Simulations = new System.Windows.Forms.Label();
            this.stop1_button = new System.Windows.Forms.Button();
            this.continue1_button = new System.Windows.Forms.Button();
            this.start2_button = new System.Windows.Forms.Button();
            this.stop2_button = new System.Windows.Forms.Button();
            this.stop3_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Replications = new System.Windows.Forms.Label();
            this.probability_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.probability_label = new System.Windows.Forms.Label();
            this.terminate_button = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability_chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_chart
            // 
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisY.IsMarginVisible = false;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.time_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.time_chart.Legends.Add(legend3);
            this.time_chart.Location = new System.Drawing.Point(12, 96);
            this.time_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.time_chart.Name = "time_chart";
            this.time_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "waiting time";
            this.time_chart.Series.Add(series3);
            this.time_chart.Size = new System.Drawing.Size(1152, 294);
            this.time_chart.TabIndex = 0;
            this.time_chart.Text = "chart1";
            // 
            // start1_button
            // 
            this.start1_button.Location = new System.Drawing.Point(396, 20);
            this.start1_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start1_button.Name = "start1_button";
            this.start1_button.Size = new System.Drawing.Size(112, 53);
            this.start1_button.TabIndex = 1;
            this.start1_button.Text = "START";
            this.start1_button.UseVisualStyleBackColor = true;
            this.start1_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(945, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Waiting time:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "";
            // 
            // Simulations
            // 
            this.Simulations.AutoSize = true;
            this.Simulations.Location = new System.Drawing.Point(15, 31);
            this.Simulations.Name = "Simulations";
            this.Simulations.Size = new System.Drawing.Size(82, 16);
            this.Simulations.TabIndex = 4;
            this.Simulations.Text = "Replications";
            // 
            // stop1_button
            // 
            this.stop1_button.Location = new System.Drawing.Point(513, 20);
            this.stop1_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop1_button.Name = "stop1_button";
            this.stop1_button.Size = new System.Drawing.Size(112, 53);
            this.stop1_button.TabIndex = 5;
            this.stop1_button.Text = "STOP";
            this.stop1_button.UseVisualStyleBackColor = true;
            this.stop1_button.Click += new System.EventHandler(this.stop1_button_Click);
            // 
            // continue1_button
            // 
            this.continue1_button.Location = new System.Drawing.Point(631, 20);
            this.continue1_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.continue1_button.Name = "continue1_button";
            this.continue1_button.Size = new System.Drawing.Size(112, 53);
            this.continue1_button.TabIndex = 6;
            this.continue1_button.Text = "CONTINUE";
            this.continue1_button.UseVisualStyleBackColor = true;
            this.continue1_button.Click += new System.EventHandler(this.continue1_button_Click);
            // 
            // start2_button
            // 
            this.start2_button.Location = new System.Drawing.Point(395, 22);
            this.start2_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start2_button.Name = "start2_button";
            this.start2_button.Size = new System.Drawing.Size(112, 53);
            this.start2_button.TabIndex = 7;
            this.start2_button.Text = "START";
            this.start2_button.UseVisualStyleBackColor = true;
            this.start2_button.Click += new System.EventHandler(this.start2_button_Click);
            // 
            // stop2_button
            // 
            this.stop2_button.Location = new System.Drawing.Point(512, 22);
            this.stop2_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop2_button.Name = "stop2_button";
            this.stop2_button.Size = new System.Drawing.Size(112, 53);
            this.stop2_button.TabIndex = 8;
            this.stop2_button.Text = "STOP";
            this.stop2_button.UseVisualStyleBackColor = true;
            this.stop2_button.Click += new System.EventHandler(this.stop2_button_Click);
            // 
            // stop3_button
            // 
            this.stop3_button.Location = new System.Drawing.Point(629, 22);
            this.stop3_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop3_button.Name = "stop3_button";
            this.stop3_button.Size = new System.Drawing.Size(112, 53);
            this.stop3_button.TabIndex = 9;
            this.stop3_button.Text = "CONTINUE";
            this.stop3_button.UseVisualStyleBackColor = true;
            this.stop3_button.Click += new System.EventHandler(this.stop3_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Tag = "";
            // 
            // Replications
            // 
            this.Replications.AutoSize = true;
            this.Replications.Location = new System.Drawing.Point(13, 32);
            this.Replications.Name = "Replications";
            this.Replications.Size = new System.Drawing.Size(82, 16);
            this.Replications.TabIndex = 11;
            this.Replications.Text = "Replications";
            // 
            // probability_chart
            // 
            chartArea4.AxisX.IsStartedFromZero = false;
            chartArea4.AxisY.IsMarginVisible = false;
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.Name = "ChartArea1";
            this.probability_chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.probability_chart.Legends.Add(legend4);
            this.probability_chart.Location = new System.Drawing.Point(7, 87);
            this.probability_chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.probability_chart.Name = "probability_chart";
            this.probability_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "probability";
            this.probability_chart.Series.Add(series4);
            this.probability_chart.Size = new System.Drawing.Size(1153, 322);
            this.probability_chart.TabIndex = 12;
            this.probability_chart.Text = "chart2";
            // 
            // probability_label
            // 
            this.probability_label.AutoSize = true;
            this.probability_label.Location = new System.Drawing.Point(1044, 41);
            this.probability_label.Name = "probability_label";
            this.probability_label.Size = new System.Drawing.Size(107, 16);
            this.probability_label.TabIndex = 13;
            this.probability_label.Text = "probability_label";
            // 
            // terminate_button
            // 
            this.terminate_button.BackColor = System.Drawing.Color.Red;
            this.terminate_button.Location = new System.Drawing.Point(1065, 833);
            this.terminate_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.terminate_button.Name = "terminate_button";
            this.terminate_button.Size = new System.Drawing.Size(112, 53);
            this.terminate_button.TabIndex = 14;
            this.terminate_button.Text = "END";
            this.terminate_button.UseVisualStyleBackColor = false;
            this.terminate_button.Click += new System.EventHandler(this.terminate_button_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(1055, 38);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(69, 16);
            this.time_label.TabIndex = 15;
            this.time_label.Text = "time_label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(944, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Probability:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.time_label);
            this.groupBox1.Controls.Add(this.Simulations);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.start1_button);
            this.groupBox1.Controls.Add(this.stop1_button);
            this.groupBox1.Controls.Add(this.continue1_button);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1168, 384);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.stop3_button);
            this.groupBox2.Controls.Add(this.probability_label);
            this.groupBox2.Controls.Add(this.stop2_button);
            this.groupBox2.Controls.Add(this.probability_chart);
            this.groupBox2.Controls.Add(this.start2_button);
            this.groupBox2.Controls.Add(this.Replications);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(11, 404);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1167, 416);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 900);
            this.Controls.Add(this.terminate_button);
            this.Controls.Add(this.time_chart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.time_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability_chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart time_chart;
        private System.Windows.Forms.Button start1_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Simulations;
        private System.Windows.Forms.Button stop1_button;
        private System.Windows.Forms.Button continue1_button;
        private System.Windows.Forms.Button start2_button;
        private System.Windows.Forms.Button stop2_button;
        private System.Windows.Forms.Button stop3_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Replications;
        private System.Windows.Forms.DataVisualization.Charting.Chart probability_chart;
        private System.Windows.Forms.Label probability_label;
        private System.Windows.Forms.Button terminate_button;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

