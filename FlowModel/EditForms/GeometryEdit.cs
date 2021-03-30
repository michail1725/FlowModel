using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel.EditForms
{
    public partial class GeometryEdit : Form
    {
        public double w, h, l;
        public GeometryEdit()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            w = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            l = Convert.ToDouble(textBox4.Text);
            ActiveForm.DialogResult = DialogResult.OK;
            ActiveForm.Close();
        }
    }
}
