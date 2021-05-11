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
   }
}
