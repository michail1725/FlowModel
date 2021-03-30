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
    public partial class MathParamsEdit : Form
    {
        public double step;
        public MathParamsEdit()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            step = Convert.ToDouble(textBox1.Text);
            ActiveForm.DialogResult = DialogResult.OK;
            ActiveForm.Close();
        }
    }
}
