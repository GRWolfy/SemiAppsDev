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
   public partial class ProductCategory : Form
   {
      public ProductCategory()
      {
         InitializeComponent();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO productcategory(productcategoryname) VALUES('" + txtProductCategory.Text + "')";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Registration success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
            ViewCategory();
            tabControlCategory.SelectedIndex = 1;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
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
      
      private void ViewCategory()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT productcategoryid AS [ID], productcategoryname AS [CATEGORY NAME] FROM productcategory";
         Functions.Function.fill(Functions.Function.gen, dataGridCategory);
      }

      private void ProductCategory_Load(object sender, EventArgs e)
      {
         ViewCategory();
         btnUpdate.Enabled = false;
      }

      private void dataGridCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         txtId.Text = dataGridCategory[0, e.RowIndex].Value.ToString();
         txtProductCategory.Text = dataGridCategory[1, e.RowIndex].Value.ToString();
         btnSave.Enabled = false;
         tabControlCategory.SelectedIndex = 0;
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "UPDATE productcategory SET productcategoryname = '"+ txtProductCategory.Text +"' WHERE productcategoryid = '"+ txtId.Text +"' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewCategory();
            tabControlCategory.SelectedIndex = 1;
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
