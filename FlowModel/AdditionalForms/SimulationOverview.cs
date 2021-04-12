﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using obj = FlowModel.Objects.SimulationObject;

namespace FlowModel.AdditionalForms
{
    public partial class SimulationOverview : Form
    {
        public double q_ch, eta_prod, t_prod;
        public List<double> eta_ch;
        public List<double> t_ch;
        //public List<double> z_param;
        public SimulationOverview()
        {
            InitializeComponent();
            Simulation();
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.MouseWheel += chart1_MouseWheel;
        }

        private void eta_chart_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Enabled = false;
            chart1.Series[1].Enabled = true;
            chart1.ChartAreas[0].AxisY.Minimum = eta_ch[eta_ch.Count - 1] - 10;
            chart1.ChartAreas[0].AxisY.Maximum = eta_ch[0] + 10;
        }

        private void temp_chart_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Enabled = false;
            chart1.Series[0].Enabled = true;
            chart1.ChartAreas[0].AxisY.Minimum = t_ch[0] - 10;
            chart1.ChartAreas[0].AxisY.Maximum = t_ch[t_ch.Count - 1] + 10;
        }

        private void all_chart_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Enabled = true;
            chart1.Series[0].Enabled = true;
            if (t_ch[0] < eta_ch[eta_ch.Count - 1])
            {
                chart1.ChartAreas[0].AxisY.Minimum = t_ch[0] - 10;
            }
            else {
                chart1.ChartAreas[0].AxisY.Minimum = eta_ch[eta_ch.Count - 1] - 10;
            }
            if (t_ch[t_ch.Count - 1] < eta_ch[0])
            {
                chart1.ChartAreas[0].AxisY.Maximum = eta_ch[0] + 10;
            }
            else {
                chart1.ChartAreas[0].AxisY.Maximum = t_ch[0] + 10;
            }
        }

        private void ViewCoordinates(object sender, System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs e)
        {
            var area = chart1.ChartAreas[0];

            // Его относительные координаты (в процентах от размеров Chart)
            var areaPosition = area.Position;

            // Переводим в абсолютные
            var areaRect = new RectangleF(areaPosition.X * chart1.Width / 100, areaPosition.Y * chart1.Height / 100,
                areaPosition.Width * chart1.Width / 100, areaPosition.Height * chart1.Height / 100);

            // Область построения (в процентах от размеров area)
            var innerPlot = area.InnerPlotPosition;

            double x = area.AxisX.Minimum +
                        (area.AxisX.Maximum - area.AxisX.Minimum) * (e.X - areaRect.Left - innerPlot.X * areaRect.Width / 100) /
                        (innerPlot.Width * areaRect.Width / 100);
            double y = area.AxisY.Maximum -
                        (area.AxisY.Maximum - area.AxisY.Minimum) * (e.Y - areaRect.Top - innerPlot.Y * areaRect.Height / 100) /
                        (innerPlot.Height * areaRect.Height / 100);
            Y_coordinateBox.Text = Math.Round(y,2).ToString();
            X_coordinateBox.Text = Math.Round(x,2).ToString();
        }

        public void Simulation() {
            Stopwatch stopwatch = new Stopwatch();
            // Запускаем внутренний таймер объекта Stopwatch
            stopwatch.Start();
            // Останавливаем внутренний таймер объекта Stopwatch
            
            double gamma, ae, F, q_gamma,q_alpha;
            F = 0.125 * Math.Pow(obj.canal.heiht / obj.canal.width,2) - 0.625 * (obj.canal.heiht / obj.canal.width) + 1.0;
            q_ch = F * obj.canal.width * obj.canal.cap.vu * obj.canal.heiht / 2.0;
            gamma = obj.canal.cap.vu / obj.canal.heiht;
            q_gamma = obj.canal.width * obj.canal.heiht * obj.material.mu0 * Math.Pow(gamma, obj.material.n + 1.0);
            q_alpha = obj.canal.width * obj.material.alpha_u * (1.0 / obj.material.b + obj.material.tr - obj.canal.cap.tu);
            eta_ch = new List<double>();
            t_ch = new List<double>();
            dataGridView1.Columns.Add("param_name", "param_name");
            dataGridView1.Rows.Add(2);
            dataGridView1.Rows[0].Cells[0].Value = "Координата канала";
            dataGridView1.Rows[1].Cells[0].Value = "Температура";
            dataGridView1.Rows[2].Cells[0].Value = "Вязкость";
            for (double z = 0.0; Math.Round(z,GetDecimalDigitsCount(obj.step)) < obj.canal.length; z += obj.step) { 
                ae = ((obj.material.b*q_gamma + obj.canal.width * obj.material.alpha_u)/(obj.material.b*q_alpha))*(1.0 - Math.Exp(-(z* obj.material.b*q_alpha/(obj.material.ro*obj.material.c*q_ch))))+ Math.Exp(obj.material.b*(obj.material.t0 - obj.material.tr - (z*q_alpha/(obj.material.ro* obj.material.c*q_ch))));
                t_ch.Add(Math.Round(obj.material.tr + 1.0 * Math.Log(ae) / obj.material.b,2));
                eta_ch.Add(Math.Round(Math.Pow(gamma,obj.material.n-1)*obj.material.mu0 * Math.Exp(-obj.material.b * (t_ch[t_ch.Count - 1] - obj.material.tr)),1));
                dataGridView1.Columns.Add(t_ch.Count.ToString(), t_ch.Count.ToString());
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].FillWeight = 1;
                dataGridView1.Rows[0].Cells[t_ch.Count].Value = Math.Round(z,GetDecimalDigitsCount(obj.step));
                chart1.Series[0].Points.AddXY(z, t_ch[t_ch.Count - 1]);
                chart1.Series[1].Points.AddXY(z, eta_ch[t_ch.Count - 1]);
                dataGridView1.Rows[1].Cells[t_ch.Count].Value = t_ch[t_ch.Count - 1];
                dataGridView1.Rows[2].Cells[t_ch.Count].Value = eta_ch[t_ch.Count - 1];
            }
            ae = ((obj.material.b * q_gamma + obj.canal.width * obj.material.alpha_u) / (obj.material.b * q_alpha)) * (1.0 - Math.Exp(-(obj.canal.length * obj.material.b * q_alpha / (obj.material.ro * obj.material.c * q_ch)))) + Math.Exp(obj.material.b * (obj.material.t0 - obj.material.tr - (obj.canal.length * q_alpha / (obj.material.ro * obj.material.c * q_ch))));
            t_ch.Add(Math.Round(obj.material.tr + 1.0 * Math.Log(ae) / obj.material.b, 2));
            eta_ch.Add(Math.Round(Math.Pow(gamma, obj.material.n - 1) * obj.material.mu0 * Math.Exp(-obj.material.b * (t_ch[t_ch.Count - 1] - obj.material.tr)), 1));
            dataGridView1.Columns.Add(t_ch.Count.ToString(), t_ch.Count.ToString());
            chart1.Series[0].Points.AddXY(obj.canal.length, t_ch[t_ch.Count - 1]);
            chart1.Series[1].Points.AddXY(obj.canal.length, eta_ch[t_ch.Count - 1]);
            dataGridView1.Rows[0].Cells[t_ch.Count].Value = obj.canal.length;
            dataGridView1.Rows[1].Cells[t_ch.Count].Value = t_ch[t_ch.Count - 1];
            dataGridView1.Rows[2].Cells[t_ch.Count].Value = eta_ch[t_ch.Count - 1];
            eta_prod = eta_ch[eta_ch.Count - 1];
            t_prod = t_ch[t_ch.Count - 1];
            label5.Text = Math.Round(q_ch*3600*1380).ToString();
            label6.Text = t_prod.ToString();
            label7.Text = eta_prod.ToString();
            stopwatch.Stop();
            if (t_ch[0] < eta_ch[eta_ch.Count - 1])
            {
                chart1.ChartAreas[0].AxisY.Minimum = t_ch[0] - 10;
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Minimum = eta_ch[eta_ch.Count - 1] - 10;
            }
            if (t_ch[t_ch.Count - 1] < eta_ch[0])
            {
                chart1.ChartAreas[0].AxisY.Maximum = eta_ch[0] + 10;
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Maximum = t_ch[0] + 10;
            }
            label11.Text = stopwatch.ElapsedMilliseconds.ToString() + " мс";
        }
        static int GetDecimalDigitsCount(double number)
        {
            string[] str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." }).Split('.');
            return str.Length == 2 ? str[1].Length : 0;
        }
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart1.ChartAreas[0].AxisX;
            var yAxis = chart1.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
    }
    
}