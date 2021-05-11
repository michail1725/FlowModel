using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FlowModel.AdditionalForms
{
   public partial class AdminForm : Form
   {
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

      private void currentTable_SelectedIndexChanged(object sender, EventArgs e)
      {
         choosenTable = currentTable.Text;
         if (choosenTable == "Материалы") 
            choosenTable = "Material";
         else if (choosenTable == "Свойства")
            choosenTable = "Properties";
         else if (choosenTable == "Значения")
            choosenTable = "PropertieValue";
         else
            choosenTable = "Material_has_properties";
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
      }

      private void button1_Click(object sender, EventArgs e)
      {
         int idMat = Convert.ToInt32(requestAnswer("SELECT idMaterial FROM Material WHERE name = '" + getMaterialName.Text + "'", "1").Rows[0].ItemArray[0]);
         string command = "Insert into Properties (PropertiesName, unit) Values ('" + propertyName.Text +
                          "','" + propertyUnit.Text + "');";
         requestAnswer(command);
         command = "SELECT PropertiesName FROM Properties";
         getPropertyNameForValue.DataSource = requestAnswer(command, "1");
         getPropertyNameForValue.DisplayMember = "PropertiesName";
         //int idProp = Convert.ToInt32(requestAnswer("SELECT idProperty FROM Properties WHERE name = '" + getMaterialName.Text + "'", "1").Rows[0].ItemArray[0]);
         //command = "Insert into Material_has_properties (idMaterial, idProperties) values ('" + idMat +"','" +  ;
      }

      private void AdminForm_Load(object sender, EventArgs e)
      {
         string command = "SELECT name FROM Material";
         getMaterialName.DataSource = requestAnswer(command, "1");
         getMaterialName.DisplayMember = "name";
         getMaterialNameForValue.DataSource = requestAnswer(command, "1");
         getMaterialNameForValue.DisplayMember = "name";
         command = "SELECT PropertiesName FROM Properties";
         getPropertyNameForValue.DataSource = requestAnswer(command, "1");
         getPropertyNameForValue.DisplayMember = "PropertiesName";
      }

      private void addValue_Click(object sender, EventArgs e)
      {
         int idProp = Convert.ToInt32(requestAnswer("SELECT idProperties FROM Properties WHERE PropertiesName = '" + getPropertyNameForValue.Text + "'", "1").Rows[0].ItemArray[0]);
         int idMat = Convert.ToInt32(requestAnswer("SELECT idMaterial FROM Material WHERE name = '" + getMaterialNameForValue.Text + "'", "1").Rows[0].ItemArray[0]);
         string command = "INSERT INTO PropertieValue (value) VALUES ('" + propertyValue.Text +"');";
         requestAnswer(command);
         command = "SELECT PropertiesName FROM Properties";
         getPropertyNameForValue.DataSource = requestAnswer(command, "1");
         getPropertyNameForValue.DisplayMember = "PropertiesName";
         int idValue = Convert.ToInt32(requestAnswer("SELECT MAX (idValue) FROM PropertieValue", "1").Rows[0].ItemArray[0]);
         command = "INSERT INTO Material_has_properties values ('" + idMat + "','" + idProp + "','" + idValue + "');";
         requestAnswer(command);
      }
   }
}
