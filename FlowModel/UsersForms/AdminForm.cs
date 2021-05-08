using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FlowModel.AdditionalForms
{
   public partial class AdminForm : Form
   {
      DataTable table = new DataTable();
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

      private void currentTable_SelectedIndexChanged(object sender, EventArgs e)
      {
         choosenTable = currentTable.Text;
         if (choosenTable == "Материалы") 
            choosenTable = "Material";
         else if (choosenTable == "Свойства")
            choosenTable = "Properties";
         else
            choosenTable = "PropertieValue";
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
         string command = "Insert into Material Values (" + materialId.Text + ", '" + materialName.Text + "');";
         requestAnswer(command);
         //openDatabase(command);
         command = "SELECT * FROM Material";
         openDatabase(command);
      }
   }
}
