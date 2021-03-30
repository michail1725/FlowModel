using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel.AdditionalForms
{
    public partial class GetTypeOfMaterial : Form
    {
        public string name;
        public double t0, b,tr,n,alpha_u, ro, c, mu0;

        private void GotDensity(object sender, EventArgs e)
        {
            ro = Convert.ToDouble(comboBox2.Text);
            t0 = 145.0;
            b = 0.05;
            tr = 165.0;
            n = 0.28;
            alpha_u = 400.0;
            c = 2500.0;
            mu0 = 12000;
        }

        private void GotMaterialName(object sender, EventArgs e)
        {
            name = comboBox1.Text;
        }

        private void AcceptTypeOfMaterial_Click(object sender, EventArgs e)
        {
            ActiveForm.DialogResult = DialogResult.OK;
            ActiveForm.Close();
        }

        public GetTypeOfMaterial()
        {
            InitializeComponent();
            
        }
    }
}
