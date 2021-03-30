using System;
using System.Windows.Forms;
using FlowModel.AdditionalForms;
using FlowModel.Objects;
using FlowModel.EditForms;

namespace FlowModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeMaterial_Click(object sender, EventArgs e)
        {
            GetTypeOfMaterial getTypeOfMaterial = new GetTypeOfMaterial();
            
            if (getTypeOfMaterial.ShowDialog() == DialogResult.OK)
            {
                SimulationObject.material = new Material();
                SimulationObject.material.alpha_u = getTypeOfMaterial.alpha_u;
                SimulationObject.material.b = getTypeOfMaterial.b;
                SimulationObject.material.c = getTypeOfMaterial.c;
                SimulationObject.material.material_name = getTypeOfMaterial.name;
                SimulationObject.material.mu0 = getTypeOfMaterial.mu0;
                SimulationObject.material.n = getTypeOfMaterial.n;
                SimulationObject.material.ro = getTypeOfMaterial.ro;
                SimulationObject.material.t0 = getTypeOfMaterial.t0;
                SimulationObject.material.tr = getTypeOfMaterial.tr;
                textBox1.Text = SimulationObject.material.material_name;
            };
        }

        private void ChangeGeometry_Click(object sender, EventArgs e)
        {
            GeometryEdit geometryEdit = new GeometryEdit();
            if (geometryEdit.ShowDialog() == DialogResult.OK)
            {
                Cap tempCap = new Cap();
                if (SimulationObject.canal?.cap != null) {
                    
                    tempCap = SimulationObject.canal.cap;
                }
                SimulationObject.canal = new Canal();
                SimulationObject.canal.cap = tempCap;
                SimulationObject.canal.width = geometryEdit.w;
                SimulationObject.canal.heiht = geometryEdit.h;
                SimulationObject.canal.length = geometryEdit.l;
                textBox2.Text = SimulationObject.canal.width.ToString();
                textBox3.Text = SimulationObject.canal.heiht.ToString();
                textBox4.Text = SimulationObject.canal.length.ToString();
            }
        }

        private void ChangeU_Click(object sender, EventArgs e)
        {
            UParamsEdit uParamsEdit = new UParamsEdit();
            if (uParamsEdit.ShowDialog() == DialogResult.OK)
            {
                if (SimulationObject.canal == null) {
                    SimulationObject.canal = new Canal();
                }
                SimulationObject.canal.cap = new Cap();
                SimulationObject.canal.cap.tu = uParamsEdit.tu;
                SimulationObject.canal.cap.vu = uParamsEdit.vu;
                textBox5.Text = SimulationObject.canal.cap.tu.ToString();
                textBox6.Text = SimulationObject.canal.cap.vu.ToString();
            }
        }

        private void ChangeMathParams_Click(object sender, EventArgs e)
        {
            MathParamsEdit mathParamsEdit = new MathParamsEdit();
            if (mathParamsEdit.ShowDialog() == DialogResult.OK)
            {
                SimulationObject.step = mathParamsEdit.step;
                textBox7.Text = SimulationObject.step.ToString();
            }
        }

        private void StartCalc_Click(object sender, EventArgs e)
        {
            SimulationOverview simulationOverview = new SimulationOverview();
            simulationOverview.ShowDialog();
        }
    }
}
