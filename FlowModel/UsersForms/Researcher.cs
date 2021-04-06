using System;
using System.Windows.Forms;
using FlowModel.AdditionalForms;
using FlowModel.Objects;

namespace FlowModel
{
    public partial class Form1 : Form
    {
        public double t0, b, tr, n, alpha_u, ro, c, mu0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            dataGridView1.Rows.Add("Плотность","кг/м3","1380");
            dataGridView1.Rows.Add("Удельная теплоемкость", "Дж/(кг·°С)", "2500");
            dataGridView1.Rows.Add("Температура плавления", "°С", "145");
            dataGridView1.Rows.Add("Температура приведения", "°С", "165");
            dataGridView1.Rows.Add("Коэффициент консистенции приведения", "Па·с^n", "12000");
            dataGridView1.Rows.Add("Температурный коэффициент вязкости", "1/°С", "0,05");
            dataGridView1.Rows.Add("Индекс течения", "-", "0,28");
            dataGridView1.Rows.Add("Коэффициент теплоотдачи крышки", "Вт/(м2·°С)", "400");
        }

       
        private void StartCalc_Click(object sender, EventArgs e)
        {
            SimulationObject.material = new Material();
            SimulationObject.material.alpha_u = Convert.ToDouble(dataGridView1.Rows[7].Cells[2].Value);
            SimulationObject.material.b = Convert.ToDouble(dataGridView1.Rows[5].Cells[2].Value);
            SimulationObject.material.c = Convert.ToDouble(dataGridView1.Rows[1].Cells[2].Value);
            SimulationObject.material.material_name = comboBox1.Text;
            SimulationObject.material.mu0 = Convert.ToDouble(dataGridView1.Rows[4].Cells[2].Value);
            SimulationObject.material.n = Convert.ToDouble(dataGridView1.Rows[6].Cells[2].Value);
            SimulationObject.material.ro = Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value);
            SimulationObject.material.t0 = Convert.ToDouble(dataGridView1.Rows[2].Cells[2].Value);
            SimulationObject.material.tr = Convert.ToDouble(dataGridView1.Rows[3].Cells[2].Value);
            SimulationObject.canal = new Canal();
            SimulationObject.canal.width = Convert.ToDouble(textBox2.Text);
            SimulationObject.canal.heiht = Convert.ToDouble(textBox3.Text);
            SimulationObject.canal.length = Convert.ToDouble(textBox4.Text);
            SimulationObject.canal.cap = new Cap();
            SimulationObject.canal.cap.tu = Convert.ToDouble(textBox5.Text);
            SimulationObject.canal.cap.vu = Convert.ToDouble(textBox6.Text);
            SimulationObject.step = Convert.ToDouble(textBox7.Text);
            SimulationOverview simulationOverview = new SimulationOverview();
            simulationOverview.ShowDialog();
        }
    }
}
