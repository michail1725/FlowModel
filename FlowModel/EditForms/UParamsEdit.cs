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
    public partial class UParamsEdit : Form
    {
        public double vu, tu;
        public UParamsEdit()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            vu = Convert.ToDouble(textBox1.Text);
            tu = Convert.ToDouble(textBox2.Text);
            ActiveForm.DialogResult = DialogResult.OK;
            ActiveForm.Close();
        }
    }
}
