using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace FlowModel.AdditionalForms
{
   public partial class AdminForm : Form
   {
      bool isFine = true;
      static DataTable table = new DataTable();
      static DataSet ds = new DataSet();
      static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
      static string choosenTable = "";

      public AdminForm()
      {
         InitializeComponent();
      }

      private void makeRequest_Click(object sender, EventArgs e)
      {
         try
         {
            string command = SQlrequest.Text;
            requestAnswer(command);
            command = "SELECT * FROM "+ choosenTable; //нужна текущая таблица 
            openDatabase(command);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      public void openDatabase(string cmd)
      {
         using (SQLiteConnection Connect = new SQLiteConnection("Data Source = FlowModelDatabase.db"))
         {
            ds = requestAnswer(cmd);
            dataTable.DataSource = ds.Tables[0];
            //dataTable.Columns["id"].ReadOnly = true;
         }
      }

      public void openDatabaseUsers(string cmd)
      {
         using (SQLiteConnection Connect = new SQLiteConnection("Data Source = users.db"))
         {
            ds = requestAnswerUsers(cmd);
            dataTable.DataSource = ds.Tables[0];
            //dataTable.Columns["id"].ReadOnly = true;
         }
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

      public static DataSet requestAnswerUsers(string cmd)
      {
         using (SQLiteConnection Connect = new SQLiteConnection("Data Source = users.db"))
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

      private void currentTable_SelectedIndexChanged(object sender, EventArgs e)
      {
         choosenTable = currentTable.Text;
         if (choosenTable == "Материалы") 
            choosenTable = "Material";
         else if (choosenTable == "Свойства")
            choosenTable = "Properties";
         else if (choosenTable == "Таблица связи")
            choosenTable = "Material_has_properties";
         else
         {
            try
            {
               string command = "SELECT * FROM users";
               openDatabaseUsers(command);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

            choosenTable = "users";
            return;
         }


         try
         {
            string command = SQlrequest.Text;
            requestAnswer(command);
            command = "SELECT * FROM " + choosenTable; //нужна текущая таблица 
            openDatabase(command);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void addMaterial_Click(object sender, EventArgs e)
      {
         string command = "Insert into Material (name) Values ('" + materialName.Text + "');";
         requestAnswer(command);
         //openDatabase(command);
         command = "SELECT * FROM Material";
         openDatabase(command);
         MessageBox.Show("Запись добавлена!");
      }

      private void button1_Click(object sender, EventArgs e)
      {
         string command = "Insert into Properties (PropertiesName, unit) Values ('" + propertyName.Text +
                          "','" + propertyUnit.Text + "');";
         requestAnswer(command);
         command = "SELECT PropertiesName FROM Properties";
         getPropertyNameForValue.DataSource = requestAnswer(command, "1");
         getPropertyNameForValue.DisplayMember = "PropertiesName";
         MessageBox.Show("Запись добавлена!");
      }

      private void AdminForm_Load(object sender, EventArgs e)
      {
         string command = "SELECT name FROM Material";
         getMaterialNameForValue.DataSource = requestAnswer(command, "1");
         getMaterialNameForValue.DisplayMember = "name";
         command = "SELECT PropertiesName FROM Properties";
         getPropertyNameForValue.DataSource = requestAnswer(command, "1");
         getPropertyNameForValue.DisplayMember = "PropertiesName";
      }

      private void addValue_Click(object sender, EventArgs e)
      {
         isFine = true;
         checkValue();
         propertyValue.Text = propertyValue.Text.Replace(",", ".");
         if (!isFine)
            return;
         int idProp = Convert.ToInt32(requestAnswer("SELECT idProperties FROM Properties WHERE PropertiesName = '" + getPropertyNameForValue.Text + "'", "1").Rows[0].ItemArray[0]);
         int idMat = Convert.ToInt32(requestAnswer("SELECT idMaterial FROM Material WHERE name = '" + getMaterialNameForValue.Text + "'", "1").Rows[0].ItemArray[0]);
         //string command = "INSERT INTO PropertieValue (value) VALUES ('" + propertyValue.Text +"');";
         //requestAnswer(command);
         string command = "SELECT PropertiesName FROM Properties";
         getPropertyNameForValue.DataSource = requestAnswer(command, "1");
         getPropertyNameForValue.DisplayMember = "PropertiesName";
         //int idValue = Convert.ToInt32(requestAnswer("SELECT MAX (idValue) FROM PropertieValue", "1").Rows[0].ItemArray[0]);
         string Value = propertyValue.Text;
         command = "INSERT INTO Material_has_properties values ('" + idMat + "','" + idProp + "','" + Value + "');";
         requestAnswer(command);
         MessageBox.Show("Запись добавлена!");
      }

      private void NewUser_Click(object sender, EventArgs e)
      {
        AddUser addUser = new AddUser();
        addUser.Show();
      }

      private void checkValue()
      {
         try
         {
            
            propertyValue.BackColor = Color.White;
            double val;


            if (Double.TryParse(propertyValue.Text, out val))
            {
            }
            else
            {
               throw new Exception("Вы ввели текст!\nПрограмный комплекс принимает только числа!");
            }

            double tmp = Convert.ToDouble(propertyValue.Text);

            if (tmp <= 0)
            {
               throw new Exception("Значение должно быть больше нуля!");
            }

            
            if (tmp > 20000)
            {
               throw new Exception("Значение слишком большое!");
            }

         }
         catch (Exception ex)
         {
            isFine = false;
            //StartCalc.Enabled = false;
            propertyValue.BackColor = Color.Red;
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}
