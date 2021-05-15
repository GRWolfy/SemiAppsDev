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
   public partial class Login : Form
   {
      public static string setfirstname = "";
      public static string setlastname = "";
      public static int setclerkid = 0;

      public Login()
      {
         InitializeComponent();
      }

      private void btnLoginSave_Click_1(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT * FROM inventoryclerk WHERE firstname = '" + txtfirstname.Text + "' AND lastname = '" + txtlastname.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               MessageBox.Show("Login success.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Functions.Function.reader.Read();
               setfirstname = Functions.Function.reader["firstName"].ToString();
               setlastname = Functions.Function.reader["lastName"].ToString();
               setclerkid = Convert.ToInt32(Functions.Function.reader["clerkid"]);

               var dashboard = new Dashboard();
               dashboard.Show();
               Hide();
            }
            else
            {
               MessageBox.Show("Incorrect username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         var register = new Register();
         register.Show();
         Hide();
      }
   }
}
