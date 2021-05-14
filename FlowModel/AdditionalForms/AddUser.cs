using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel.AdditionalForms
{
   public partial class AddUser : Form
   {
      static DataSet ds = new DataSet();
      static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
      public AddUser()
      {
         InitializeComponent();
      }

      private void add_Click(object sender, EventArgs e)
      {

         string loginUser = Login.Text;
         string passwordUser = Password.Text;
         string choosenRole = UserRole.Text;
         if (choosenRole == "Администратор")
         {
            choosenRole = "admin";
         }
         else
         {
            choosenRole = "research";
         }
         string cmd = "Insert into users (login, password, role) values ('" + loginUser + "','" + passwordUser + "','" + choosenRole + "')";
         openDatabase(cmd);
         MessageBox.Show("Пользователь добавлен!", "Успех", MessageBoxButtons.OK);
      }

      public void openDatabase(string cmd)
      {
         try
         {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source = users.db"))
            {
               ds = requestAnswer(cmd);
            }
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
            throw;
         }
      }

      public static DataSet requestAnswer(string cmd)
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
   }
}
