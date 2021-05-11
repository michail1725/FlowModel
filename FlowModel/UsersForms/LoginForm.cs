using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using FlowModel.AdditionalForms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace FlowModel.UsersForms
{
   public partial class LoginForm : Form
   {
      static DataSet ds = new DataSet();
      DataTable table = new DataTable();
      static SQLiteDataAdapter adapter = new SQLiteDataAdapter();

      public LoginForm()
      {
         InitializeComponent();
      }

      private void button2_Click(object sender, EventArgs e)
      {
          AdminForm adminForm = new AdminForm();
          adminForm.Show();
      }

      private void button1_Click(object sender, EventArgs e)
      {
        ResearcherForm researcherForm = new ResearcherForm();
        researcherForm.Show();
      }

      private void loginButton_Click(object sender, EventArgs e)
      {
         using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=users.db"))
         {
            connection.Open();
            string role = "";
            string login = name.Text;
            string password = this.password.Text;
            SQLiteCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText =
               "Select role from users where login = '" + login + "' AND password = '" + password + "'";
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
               if (reader.HasRows) // если есть данные
               {
                  while (reader.Read())
                  {
                     var dbRole = reader.GetValue(0);
                     role = dbRole.ToString();
                     break;
                  }
               }
            }

            connection.Close();
            if (role == "admin")
            {
               AdminForm formAdmin = new AdminForm();
               formAdmin.Show();
            }
            else if (role == "research")
            {
               ResearcherForm formResearcher = new ResearcherForm();
               formResearcher.Show();
            }
            else
            {
               MessageBox.Show("Ошибка! Логин или пароль введен неверно!", "Ошибка", MessageBoxButtons.OK);
            }


         }
      }
   }
}
