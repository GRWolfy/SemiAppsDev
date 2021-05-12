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

      private void btnDashboard_Click(object sender, EventArgs e)
      {
         var dashboard = new Dashboard();
         dashboard.Show();
         Hide();
      }

      private void btnRegister_Click(object sender, EventArgs e)
      {
         var register = new Register();
         register.Show();
         Hide();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         var login = new Login();
         login.Show();
         Hide();
      }

      private void btnCategory_Click(object sender, EventArgs e)
      {
         var category = new ProductCategory();
         category.Show();
         Hide();
      }

      private void Product_Click(object sender, EventArgs e)
      {
         var product = new Product();
         product.Show();
         Hide();
      }

      private void btnInventory_Click(object sender, EventArgs e)
      {
         var inventory = new InventoryDetails();
         inventory.Show();
         Hide();
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
   }
}
