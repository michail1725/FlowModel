using System;
using System.Drawing;
using System.Windows.Forms;
using FlowModel.AdditionalForms;
using FlowModel.Objects;

namespace FlowModel
{
   public partial class ResearcherForm : Form
   {


      public ResearcherForm()
      {
         InitializeComponent();
         MaterialName.SelectedIndex = 0;
         dataGridView1.Rows.Add("Плотность", "кг/м^3", "1380");
         dataGridView1.Rows.Add("Удельная теплоемкость", "Дж/(кг·°С)", "2500");
         dataGridView1.Rows.Add("Температура плавления", "°С", "145");
         dataGridView1.Rows.Add("Эмперические коэффиценты","Единица измерения","Значение");
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].MinimumHeight = 50;
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].ReadOnly = true;
         dataGridView1.Rows.Add("Температура приведения", "°С", "165");
         dataGridView1.Rows.Add("Коэффициент консистенции приведения", "Па·с^n", "12000");
         dataGridView1.Rows.Add("Температурный коэффициент вязкости", "1/°С", "0,05");
         dataGridView1.Rows.Add("Индекс течения", "-", "0,28");
         dataGridView1.Rows.Add("Коэффициент теплоотдачи крышки", "Вт/(м^2·°С)", "400");
      }

      

      private void StartCalc_Click(object sender, EventArgs e)
      {
         try
         {
            double val;
            for (int i = 1; i < 8; i++)
            {
                    if (i != 3)
                    {
                        if (Double.TryParse(dataGridView1[2, i].Value.ToString(), out val))
                        {
                            double tmp = Convert.ToDouble(dataGridView1[2, i].Value.ToString());
                            if (tmp < 0)
                            {
                                throw new Exception("Вы ввели отрицательное число!\nПроверьте столбец значений на присутствие таковых!");
                            }
                        }
                        else
                        {
                            throw new Exception("Вы ввели текст!\nПроверьте столбец значений на присутствие текста!");
                        }
                    }
            }
            StartCalc.Enabled = true;
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         SimulationObject.material = new Material();
         SimulationObject.material.alpha_u = Convert.ToDouble(dataGridView1.Rows[8].Cells[2].Value);
         SimulationObject.material.b = Convert.ToDouble(dataGridView1.Rows[6].Cells[2].Value);
         SimulationObject.material.c = Convert.ToDouble(dataGridView1.Rows[1].Cells[2].Value);
         SimulationObject.material.material_name = MaterialName.Text;
         SimulationObject.material.mu0 = Convert.ToDouble(dataGridView1.Rows[5].Cells[2].Value);
         SimulationObject.material.n = Convert.ToDouble(dataGridView1.Rows[7].Cells[2].Value);
         SimulationObject.material.ro = Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value);
         SimulationObject.material.t0 = Convert.ToDouble(dataGridView1.Rows[2].Cells[2].Value);
         SimulationObject.material.tr = Convert.ToDouble(dataGridView1.Rows[4].Cells[2].Value);
         SimulationObject.canal = new Canal();
         SimulationObject.canal.width = Convert.ToDouble(Width.Text);
         SimulationObject.canal.heiht = Convert.ToDouble(Depth.Text);
         SimulationObject.canal.length = Convert.ToDouble(Lenght.Text);
         SimulationObject.canal.cap = new Cap();
         SimulationObject.canal.cap.tu = Convert.ToDouble(CapTemperature.Text);
         SimulationObject.canal.cap.vu = Convert.ToDouble(CapSpeed.Text);
         SimulationObject.step = Convert.ToDouble(Step.Text);
         SimulationOverview simulationOverview = new SimulationOverview();
         simulationOverview.ShowDialog();
      }


      // область проверок данных

      private void widthChanged(object sender, EventArgs e)
      {
         try
         {
            Width.BackColor = Color.White;
            StartCalc.Enabled = true;
            double val;


            if (Double.TryParse(Width.Text, out val))
            {
            }
            else
            {
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }

            double tmp = Convert.ToDouble(Width.Text);

            if (tmp < 0)
            {
               throw new Exception("Вы ввели отрицательное число!");
            }

            if (tmp > 250)
            {
               throw new Exception("Ширина канала слишком большая!");
            }

         }
         catch (Exception ex)
         {
            StartCalc.Enabled = false;
            Width.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void depthChanged(object sender, EventArgs e)
      {
         try
         {
            Depth.BackColor = Color.White;
            double val;
            StartCalc.Enabled = true;

            if (Double.TryParse(Depth.Text, out val))
            {
            }
            else
            {
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }

            double tmp = Convert.ToDouble(Depth.Text);

            if (tmp < 0)
            {
               throw new Exception("Вы ввели отрицательное число!");
            }

            if (tmp > 250)
            {
               throw new Exception("Глубина канала слишком большая!");
            }

         }
         catch (Exception ex)
         {
            StartCalc.Enabled = false;
            Depth.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void lenghtChanged(object sender, EventArgs e)
      {
         try
         {
            Lenght.BackColor = Color.White;
            double val;
            StartCalc.Enabled = true;

            if (Double.TryParse(Lenght.Text, out val))
            {
            }
            else
            {
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }

            double tmp = Convert.ToDouble(Lenght.Text);

            if (tmp < 0)
            {
               throw new Exception("Вы ввели отрицательное число!");
            }

            if (tmp > 250)
            {
               throw new Exception("Длина канала слишком большая!");
            }

         }
         catch (Exception ex)
         {
            StartCalc.Enabled = false;
            Lenght.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void capTempChanged(object sender, EventArgs e)
      {
         try
         {
            CapTemperature.BackColor = Color.White;
            double val;


            if (Double.TryParse(CapTemperature.Text, out val))
            {
            }
            else
            {
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }

            double tmp = Convert.ToDouble(CapTemperature.Text);

            if (tmp < 0)
            {
               throw new Exception("Вы ввели отрицательное число!");
            }

            if (tmp < 100)  //пока что не знаю, но стоит сделать сравнение с температурой плавления маетриала конкретного
            {
               throw new Exception("Температура крышки слишком маленькая!");
            }
            if (tmp > 1500)  
            {
               throw new Exception("Температура крышки слишком большая!");
            }

         }
         catch (Exception ex)
         {
            StartCalc.Enabled = false;
            CapTemperature.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void capSpeedChanged(object sender, EventArgs e)
      {
         try
         {
            CapSpeed.BackColor = Color.White;
            double val;
            StartCalc.Enabled = true;

            if (Double.TryParse(CapSpeed.Text, out val))
            {
            }
            else
            {
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }

            double tmp = Convert.ToDouble(CapSpeed.Text);

            if (tmp < 0)
            {
               throw new Exception("Вы ввели отрицательное число!");
            }

            if (tmp < 0.1)
            {
               throw new Exception("Скорость крышки слишком маленькая!");
            }
        

         }
         catch (Exception ex)
         {
            StartCalc.Enabled = false;
            CapSpeed.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void stepChanged(object sender, EventArgs e)
      {
         try
         {
            Step.BackColor = Color.White;
            double val;
            StartCalc.Enabled = true;

            if (Double.TryParse(Step.Text, out val))
            {
            }
            else
            {
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }

            double tmp = Convert.ToDouble(Step.Text);

            if (tmp < 0)
            {
               throw new Exception("Вы ввели отрицательное число!");
            }

            if (tmp > Convert.ToDouble(Lenght.Text))
            {
               throw new Exception("Шаг не может превышать длину канала!");
            }


         }
         catch (Exception ex)
         {
            StartCalc.Enabled = false;
            Step.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}
