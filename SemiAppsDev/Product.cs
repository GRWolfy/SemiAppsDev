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
   public partial class Product : Form
   {
      public Product()
      {
         InitializeComponent();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         var collector = Login.setfirstname + " " + Login.setlastname;

         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO product(productcategoryid, productname, price, stockonhand, productdateencoded, productencodedby, reorderstock) VALUES('" + txtCategoryID.Text + "', '" + txtProductname.Text + "', '" + txtPrice.Text + "', '" + txtStockonHand.Text + "', '" + dateTimePicker.Value.Date + "', '" + collector + "', '"+ txtReorder.Text +"') ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Product saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
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

      private void btnInventory_Click(object sender, EventArgs e)
      {
         var inventory = new InventoryDetails();
         inventory.Show();
         Hide();
      }

      private void btnProduct_Click(object sender, EventArgs e)
      {
         var product = new Product();
         product.Show();
         Hide();
      }

      private void Product_Load(object sender, EventArgs e)
      {
         btnUpdate.Enabled = false;
         setComboBox();
         ViewProducts();
      }

      private void setComboBox()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT * FROM productcategory";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            DataTable dt = new DataTable();
            SqlDataAdapter data = null;
            data = new SqlDataAdapter(Functions.Function.command);
            data.Fill(dt);
            cmbCategory.DisplayMember = "productcategoryname";
            cmbCategory.ValueMember = "productcategoryid";
            cmbCategory.DataSource = dt;
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT * FROM productcategory productcategoryname = '"+ cmbCategory.Text +"' ";
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.Read())
            {
               txtCategoryID.Text = Functions.Function.reader[0].ToString();
               Functions.Function.reader.Close();
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void ViewProducts()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT productcategory.productcategoryid AS [CATEGORY ID], productcategory.productcategoryname AS [PRODUCT NAME], product.productid AS [PRODUCT ID], product.productname AS [PRODUCT NAME],product.price AS [PRICE], product.stockonhand AS [STOCK ON HAND], product.productdateencoded AS [DATE], product.productencodedby AS [ENCODED BY], product.reorderstock AS [REORDER STOCK] FROM productcategory INNER JOIN product ON productcategory.productcategoryid = product.productcategoryid";
         Functions.Function.fill(Functions.Function.gen, dataGridProduct);
      }

      private void dataGridProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         txtCategoryID.Text = dataGridProduct.CurrentRow.Cells[0].Value.ToString();
         cmbCategory.Text = dataGridProduct.CurrentRow.Cells[1].Value.ToString();
         txtProductID.Text = dataGridProduct.CurrentRow.Cells[2].Value.ToString();
         txtProductname.Text = dataGridProduct.CurrentRow.Cells[3].Value.ToString();
         txtPrice.Text = dataGridProduct.CurrentRow.Cells[4].Value.ToString();
         txtStockonHand.Text = dataGridProduct.CurrentRow.Cells[5].Value.ToString();
         dateTimePicker.Value = Convert.ToDateTime(dataGridProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
         txtReorder.Text = dataGridProduct.CurrentRow.Cells[8].Value.ToString();
         btnUpdate.Enabled = true;
         btnSave.Enabled = false;
         tabControlProduct.SelectedIndex = 0;
      }
   }
}
