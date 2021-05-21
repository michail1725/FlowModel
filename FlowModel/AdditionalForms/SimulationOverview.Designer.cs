
namespace FlowModel.AdditionalForms
{
    partial class SimulationOverview
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.GetReport = new System.Windows.Forms.Button();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.label8 = new System.Windows.Forms.Label();
         this.X_coordinateBox = new System.Windows.Forms.TextBox();
         this.Y_coordinateBox = new System.Windows.Forms.TextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.calc_time_label = new System.Windows.Forms.Label();
         this.eta_chart = new System.Windows.Forms.Button();
         this.temp_chart = new System.Windows.Forms.Button();
         this.label12 = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.label14 = new System.Windows.Forms.Label();
         this.calc_mem_label = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.ColumnHeadersVisible = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridView1.Location = new System.Drawing.Point(12, 520);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.ReadOnly = true;
         this.dataGridView1.RowHeadersVisible = false;
         this.dataGridView1.RowHeadersWidth = 100;
         this.dataGridView1.RowTemplate.Height = 40;
         this.dataGridView1.Size = new System.Drawing.Size(770, 150);
         this.dataGridView1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 502);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(365, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Результаты расчета параметров состояний объекта по длине канала:";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.GetReport);
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.label6);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Location = new System.Drawing.Point(805, 502);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(286, 168);
         this.groupBox1.TabIndex = 3;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Критериальные показатели объекта:";
         // 
         // GetReport
         // 
         this.GetReport.Location = new System.Drawing.Point(135, 137);
         this.GetReport.Name = "GetReport";
         this.GetReport.Size = new System.Drawing.Size(145, 23);
         this.GetReport.TabIndex = 4;
         this.GetReport.Text = "Создать отчет";
         this.GetReport.UseVisualStyleBackColor = true;
         this.GetReport.Click += new System.EventHandler(this.GetReport_Click);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(11, 108);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(31, 13);
         this.label7.TabIndex = 5;
         this.label7.Text = "none";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(10, 72);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(31, 13);
         this.label6.TabIndex = 4;
         this.label6.Text = "none";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(10, 36);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(31, 13);
         this.label5.TabIndex = 3;
         this.label5.Text = "none";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(7, 89);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(137, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "Вязкость продукта(Па*с):";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(7, 53);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(143, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Температура продукта(°C):";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(7, 18);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(145, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Производительность(кг/ч):";
         // 
         // chart1
         // 
         chartArea1.AxisX.Minimum = 0D;
         chartArea1.Name = "ChartArea1";
         this.chart1.ChartAreas.Add(chartArea1);
         this.chart1.Location = new System.Drawing.Point(15, 12);
         this.chart1.Name = "chart1";
         this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
         series1.BorderWidth = 4;
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series1.Name = "Температура";
         series2.BorderWidth = 4;
         series2.ChartArea = "ChartArea1";
         series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series2.LabelBorderWidth = 2;
         series2.Name = "Вязкость";
         this.chart1.Series.Add(series1);
         this.chart1.Series.Add(series2);
         this.chart1.Size = new System.Drawing.Size(1076, 454);
         this.chart1.TabIndex = 4;
         this.chart1.Text = "chart1";
         this.chart1.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.ViewCoordinates);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(18, 477);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(17, 13);
         this.label8.TabIndex = 5;
         this.label8.Text = "X:";
         // 
         // X_coordinateBox
         // 
         this.X_coordinateBox.Location = new System.Drawing.Point(38, 472);
         this.X_coordinateBox.Name = "X_coordinateBox";
         this.X_coordinateBox.Size = new System.Drawing.Size(47, 20);
         this.X_coordinateBox.TabIndex = 6;
         this.X_coordinateBox.Text = "0";
         // 
         // Y_coordinateBox
         // 
         this.Y_coordinateBox.Location = new System.Drawing.Point(114, 472);
         this.Y_coordinateBox.Name = "Y_coordinateBox";
         this.Y_coordinateBox.Size = new System.Drawing.Size(47, 20);
         this.Y_coordinateBox.TabIndex = 8;
         this.Y_coordinateBox.Text = "0";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(91, 477);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(17, 13);
         this.label9.TabIndex = 7;
         this.label9.Text = "Y:";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(815, 486);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(107, 13);
         this.label10.TabIndex = 9;
         this.label10.Text = "Время вычислений:";
         // 
         // calc_time_label
         // 
         this.calc_time_label.AutoSize = true;
         this.calc_time_label.Location = new System.Drawing.Point(928, 486);
         this.calc_time_label.Name = "calc_time_label";
         this.calc_time_label.Size = new System.Drawing.Size(21, 13);
         this.calc_time_label.TabIndex = 10;
         this.calc_time_label.Text = "мс";
         // 
         // eta_chart
         // 
         this.eta_chart.Location = new System.Drawing.Point(601, 469);
         this.eta_chart.Name = "eta_chart";
         this.eta_chart.Size = new System.Drawing.Size(110, 25);
         this.eta_chart.TabIndex = 11;
         this.eta_chart.Text = "Вязкость";
         this.eta_chart.UseVisualStyleBackColor = true;
         this.eta_chart.Click += new System.EventHandler(this.eta_chart_Click);
         // 
         // temp_chart
         // 
         this.temp_chart.Location = new System.Drawing.Point(475, 469);
         this.temp_chart.Name = "temp_chart";
         this.temp_chart.Size = new System.Drawing.Size(110, 25);
         this.temp_chart.TabIndex = 12;
         this.temp_chart.Text = "Температура";
         this.temp_chart.UseVisualStyleBackColor = true;
         this.temp_chart.Click += new System.EventHandler(this.temp_chart_Click);
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.BackColor = System.Drawing.Color.White;
         this.label12.Location = new System.Drawing.Point(472, 444);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(168, 13);
         this.label12.TabIndex = 13;
         this.label12.Text = "Координата по длине канала, м";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.BackColor = System.Drawing.Color.White;
         this.label13.Location = new System.Drawing.Point(35, 208);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(22, 13);
         this.label13.TabIndex = 14;
         this.label13.Text = "+   ";
         // 
         // label14
         // 
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(815, 469);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(103, 13);
         this.label14.TabIndex = 15;
         this.label14.Text = "Затрачено памяти:";
         // 
         // calc_mem_label
         // 
         this.calc_mem_label.AutoSize = true;
         this.calc_mem_label.Location = new System.Drawing.Point(928, 469);
         this.calc_mem_label.Name = "calc_mem_label";
         this.calc_mem_label.Size = new System.Drawing.Size(22, 13);
         this.calc_mem_label.TabIndex = 16;
         this.calc_mem_label.Text = "Мб";
         // 
         // SimulationOverview
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightBlue;
         this.ClientSize = new System.Drawing.Size(1103, 682);
         this.Controls.Add(this.calc_mem_label);
         this.Controls.Add(this.label14);
         this.Controls.Add(this.label13);
         this.Controls.Add(this.label12);
         this.Controls.Add(this.temp_chart);
         this.Controls.Add(this.eta_chart);
         this.Controls.Add(this.calc_time_label);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.Y_coordinateBox);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.X_coordinateBox);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.chart1);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dataGridView1);
         this.MaximumSize = new System.Drawing.Size(1119, 721);
         this.MinimumSize = new System.Drawing.Size(1119, 721);
         this.Name = "SimulationOverview";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "SimulationOverview";
         this.Load += new System.EventHandler(this.SimulationOverview_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox X_coordinateBox;
        private System.Windows.Forms.TextBox Y_coordinateBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label calc_time_label;
        private System.Windows.Forms.Button eta_chart;
        private System.Windows.Forms.Button temp_chart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label calc_mem_label;
    }
}