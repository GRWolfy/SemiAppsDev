using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemiAppsDev
{
   public partial class Register : Form
   {
      public Register()
      {
         InitializeComponent();
      }

      private void btnRegisterSave_Click_1(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO inventoryclerk(firstname, lastname) VALUES('" + txtFirstname.Text + "', '" + txtLastname.Text + "') ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();

            var login = new Login();
            login.Show();
            Hide();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnBack_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }
   }
}
