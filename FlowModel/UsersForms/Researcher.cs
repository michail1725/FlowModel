using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using FlowModel.AdditionalForms;
using FlowModel.Objects;
using System.Linq;
using System.Collections.Generic;

namespace FlowModel
{
    public partial class ResearcherForm : Form
    {
        bool isFine = true;
        static DataTable table = new DataTable();
        static DataSet ds = new DataSet();
        static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        delegate bool IsEqual(string x);
        private bool IsLoad = false;
        Dictionary<string, double> props;
        public ResearcherForm()
        {
            InitializeComponent();
        }

        public static DataSet requestAnswer(string cmd)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = FlowModelDatabase.db"))
            {
                Connect.Open();
                adapter = new SQLiteDataAdapter(cmd, Connect);
                Connect.Close();
                ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }

        public static DataTable requestAnswer(string cmd, string tmp)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = FlowModelDatabase.db"))
            {
                Connect.Open();
                adapter = new SQLiteDataAdapter(cmd, Connect);
                Connect.Close();
                table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        private void StartCalc_Click(object sender, EventArgs e)
        {
            isFine = true;
            try
            {
                lenghtChanged();
                widthChanged();
                depthChanged();
                capSpeedChanged();
                capTempChanged();
                stepChanged();
                if (!isFine)
                {
                    return;
                }
                double val;

                //for (int i = 1; i < 8; i++)
                //{
                //    if (i != 3)
                //    {
                //        if (Double.TryParse(dataGridView1[2, i].Value.ToString(), out val))
                //        {
                //            double tmp = Convert.ToDouble(dataGridView1[2, i].Value.ToString());
                //            if (tmp < 0)
                //            {
                //                throw new Exception("Вы ввели отрицательное число!\nПроверьте столбец значений на присутствие таковых!");
                //            }
                //        }
                //        else
                //        {
                //            throw new Exception("Вы ввели текст!\nПроверьте столбец значений на присутствие текста!");
                //        }
                //    }
                //}
                foreach (DataGridViewRow row in dataGridView1.Rows) {
                    if (row.Cells[0].Value != null) {
                        props.Add(row.Cells[0].Value.ToString(), Convert.ToDouble(row.Cells[2].Value));
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
            SimulationObject.material.alpha_u = ThisProp(x => x == "Коэффициент теплоотдачи крышки");
            SimulationObject.material.b = ThisProp(x => x == "Температурный коэффициент вязкости");
            SimulationObject.material.c = ThisProp(x => x == "Удельная теплоемкость");
            SimulationObject.material.material_name = MaterialName.Text;
            SimulationObject.material.mu0 = ThisProp(x => x == "Коэффициент консистенции приведения");
            SimulationObject.material.n = ThisProp(x => x == "Индекс течения");
            SimulationObject.material.ro = ThisProp(x => x == "Плотность");
            SimulationObject.material.t0 = ThisProp(x => x == "Температура плавления");
            SimulationObject.material.tr = ThisProp(x => x == "Температура приведения");
            SimulationObject.canal = new Canal();
            SimulationObject.canal.width = Convert.ToDouble(Width.Text);
            SimulationObject.canal.height = Convert.ToDouble(Depth.Text);
            SimulationObject.canal.length = Convert.ToDouble(Lenght.Text);
            SimulationObject.canal.cap = new Cap();
            SimulationObject.canal.cap.tu = Convert.ToDouble(CapTemperature.Text);
            SimulationObject.canal.cap.vu = Convert.ToDouble(CapSpeed.Text);
            SimulationObject.step = Convert.ToDouble(Step.Text);
            SimulationOverview simulationOverview = new SimulationOverview();
            simulationOverview.ShowDialog();
        }

        double ThisProp(IsEqual func){
            foreach (var prop in props) {
                if (func(prop.Key)) {
                    return prop.Value;
                }
            }
            return 0;
        }
      // область проверок данных

      private void widthChanged()
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

            if (tmp <= 0)
            {
               throw new Exception("Ширина канала должна быть больше нуля!");
            }

            if (tmp > 250)
            {
               throw new Exception("Ширина канала слишком большая!");
            }

         }
         catch (Exception ex)
         {
            isFine = false;
            //StartCalc.Enabled = false;
            Width.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void depthChanged()
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

            if (tmp <= 0)
            {
               throw new Exception("Глубина канала должна быть больше нуля!");
            }

            if (tmp > 250)
            {
               throw new Exception("Глубина канала слишком большая!");
            }

         }
         catch (Exception ex)
         {
            isFine = false;
            //StartCalc.Enabled = false;
            Depth.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void lenghtChanged()
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

            if (tmp <= 0)
            {
               throw new Exception("Длина канала должна быть больше нуля!");
            }

            if (tmp > 250)
            {
               throw new Exception("Длина канала слишком большая!");
            }

         }
         catch (Exception ex)
         {
            isFine = false;
            //StartCalc.Enabled = false;
            Lenght.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void capTempChanged()
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

            if (tmp <= 0)
            {
               throw new Exception("Температура крышки должна быть больше нуля!");
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
            isFine = false;
            //StartCalc.Enabled = false;
            CapTemperature.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void capSpeedChanged()
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

            if (tmp <= 0)
            {
               throw new Exception("Скорость крышки должна быть больше нуля!");
            }

            if (tmp < 0.1)
            {
               throw new Exception("Скорость крышки слишком маленькая!");
            }


         }
         catch (Exception ex)
         {
            isFine = false;
            //StartCalc.Enabled = false;
            CapSpeed.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void stepChanged()
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

            if (tmp <= 0)
            {
               throw new Exception("Шаг по длине канала должна быть больше нуля!");
            }

            if (tmp > Convert.ToDouble(Lenght.Text))
            {
               throw new Exception("Шаг не может превышать длину канала!");
            }


         }
         catch (Exception ex)
         {
            isFine = false;
            //StartCalc.Enabled = false;
            Step.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void GotMaterial(object sender, EventArgs e)
      {
         if (IsLoad)
         {
            dataGridView1.Rows.Clear();
            try
            {
                props = new Dictionary<string,double>();
               //dataGridView1.Rows.Clear();
               string command = $"SELECT idMaterial FROM Material WHere name = '{MaterialName.Text}'";
               int id_mat = Convert.ToInt32(requestAnswer(command, "1").Rows[0].ItemArray[0]);
               command =
                  $"SELECT idMaterial,idProperties,Value FROM Material_has_properties where idMaterial = {id_mat}";
               DataTable table1 = requestAnswer(command, "1");
               for (int i = 0; i < table1.Rows.Count; i++)
               {
                  string prop_name;
                  string value, unit;
                  command =
                     $"SELECT PropertiesName, Unit FROM Properties Where idProperties = '{table1.Rows[i].ItemArray[1]}'";
                  DataTable temp_table = requestAnswer(command, "1");
                  prop_name = temp_table.Rows[0].ItemArray[0].ToString();
                  unit = temp_table.Rows[0].ItemArray[1].ToString();
                  //command = $"SELECT Value FROM Material_has_value Where idValue = '{table1.Rows[i].ItemArray[2]}'";
                  //temp_table = requestAnswer(command, "1");
                  value = table1.Rows[i].ItemArray[2].ToString();
                  dataGridView1.Rows.Add(prop_name, unit, value);
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Для данного материала отсутствуют свойства!\nОбратитесь к администартору!", "Ошибка",
                  MessageBoxButtons.OK);
               
            }
         }

         //dataGridView1.Rows.Add("Плотность", "кг/м^3", "1380");
         //dataGridView1.Rows.Add("Удельная теплоемкость", "Дж/(кг·°С)", "2500");
         //dataGridView1.Rows.Add("Температура плавления", "°С", "145");
         //dataGridView1.Rows.Add("Эмперические коэффиценты", "Единица измерения", "Значение");
         //dataGridView1.Rows[dataGridView1.Rows.Count - 2].MinimumHeight = 50;
         //dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].ReadOnly = true;
         //dataGridView1.Rows.Add("Температура приведения", "°С", "165");
         //dataGridView1.Rows.Add("Коэффициент консистенции приведения", "Па·с^n", "12000");
         //dataGridView1.Rows.Add("Температурный коэффициент вязкости", "1/°С", "0,05");
         //dataGridView1.Rows.Add("Индекс течения", "-", "0,28");
         //dataGridView1.Rows.Add("Коэффициент теплоотдачи крышки", "Вт/(м^2·°С)", "400");
      }

      

      private void ResearcherForm_Load_1(object sender, EventArgs e)
      {
         string command = "SELECT name FROM Material";
         MaterialName.DataSource = requestAnswer(command, "1");
         MaterialName.DisplayMember = "name";
         IsLoad = true;
      }
   }
}
