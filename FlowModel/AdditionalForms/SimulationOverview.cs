using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }
        public void Simulation() {
            double gamma, ae, F, q_gamma,q_alpha;
            F = 0.125 * Math.Pow(obj.canal.heiht / obj.canal.width,2) - 0.625 * (obj.canal.heiht / obj.canal.width) + 1.0;
            q_ch = F * obj.canal.width * obj.canal.cap.vu * obj.canal.heiht / 2.0;
            gamma = obj.canal.cap.vu / obj.canal.heiht;
            q_gamma = obj.canal.width * obj.canal.heiht * obj.material.mu0 * Math.Pow(gamma, obj.material.n - 1.0);
            q_alpha = obj.canal.width * obj.material.alpha_u * (1.0 / obj.material.b + obj.material.tr - obj.canal.cap.tu);
            eta_ch = new List<double>();
            t_ch = new List<double>();
            dataGridView1.Columns.Add("param_name", "param_name");
            dataGridView1.Rows.Add(3);
            dataGridView1.Rows[0].Cells[0].Value = "z";
            dataGridView1.Rows[1].Cells[0].Value = "t";
            dataGridView1.Rows[2].Cells[0].Value = "eta";
            for (double z = 0.0; z < obj.canal.length; z += obj.step) { 
                ae = ((obj.material.b*q_gamma + obj.canal.width * obj.material.alpha_u)/(obj.material.b*q_alpha))*(1.0 - Math.Exp(-(z* obj.material.b*q_alpha/(obj.material.ro*obj.material.c*q_ch))))+ Math.Exp(obj.material.b*(obj.material.t0 - obj.material.tr - (z*q_alpha/(obj.material.ro* obj.material.c*q_ch))));
                t_ch.Add(Math.Round(obj.material.tr + 1.0 * Math.Log(ae) / obj.material.b,2));
                eta_ch.Add(Math.Round(obj.material.mu0 * Math.Exp(-obj.material.b * (t_ch[t_ch.Count - 1] - obj.material.tr)),2));
                dataGridView1.Columns.Add(t_ch.Count.ToString(), t_ch.Count.ToString());
                dataGridView1.Rows[0].Cells[t_ch.Count].Value = Math.Round(z,GetDecimalDigitsCount(obj.step));
                dataGridView1.Rows[1].Cells[t_ch.Count].Value = t_ch[t_ch.Count - 1];
                dataGridView1.Rows[2].Cells[t_ch.Count].Value = eta_ch[t_ch.Count - 1];
            }
            ae = ((obj.material.b * q_gamma + obj.canal.width * obj.material.alpha_u) / (obj.material.b * q_alpha)) * (1.0 - Math.Exp(-(obj.canal.length * obj.material.b * q_alpha / (obj.material.ro * obj.material.c * q_ch)))) + Math.Exp(obj.material.b * (obj.material.t0 - obj.material.tr - (obj.canal.length * q_alpha / (obj.material.ro * obj.material.c * q_ch))));
            t_ch.Add(Math.Round(obj.material.tr + 1.0 * Math.Log(ae) / obj.material.b, 2));
            eta_ch.Add(Math.Round(obj.material.mu0 * Math.Exp(-obj.material.b * (t_ch[t_ch.Count - 1] - obj.material.tr)), 2));
            dataGridView1.Columns.Add(t_ch.Count.ToString(), t_ch.Count.ToString());
            dataGridView1.Rows[0].Cells[t_ch.Count].Value = obj.canal.length;
            dataGridView1.Rows[1].Cells[t_ch.Count].Value = t_ch[t_ch.Count - 1];
            dataGridView1.Rows[2].Cells[t_ch.Count].Value = eta_ch[t_ch.Count - 1];
            eta_prod = eta_ch[eta_ch.Count - 1];
            t_prod = t_ch[t_ch.Count - 1];
            label5.Text = q_ch.ToString();
            label6.Text = t_prod.ToString();
            label7.Text = eta_prod.ToString();
        }
        static int GetDecimalDigitsCount(double number)
        {
            string[] str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." }).Split('.');
            return str.Length == 2 ? str[1].Length : 0;
        }
    }
}
