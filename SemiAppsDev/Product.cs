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
      private string collector = Login.setfirstname + " " + Login.setlastname;

      public Product()
      {
         InitializeComponent();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO product(productcategoryid, productname, price, stockonhand, productdateencoded, productencodedby, reorderstock) VALUES('" + txtCategoryID.Text + "', '" + txtProductname.Text + "', '" + txtPrice.Text + "', '" + txtStockonHand.Text + "', '" + dateTimePicker.Value.Date.ToString("yyyy-MM-dd") + "', '" + txtClerkname.Text + "', 0); INSERT INTO inventorydetails(productid, stockout, totalsales, inventorydate, inventoryencodedby) VALUES((SELECT productid FROM product WHERE productname = '" + txtProductname.Text + "'), 0, 0, '" + dateTimePicker.Value.Date.ToString("yyyy-MM-dd") + "', '" + txtClerkname.Text + "') ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Product saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
            ViewProducts();
            Clear();
            tabControlProduct.SelectedIndex = 2;
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
         txtClerkname.Text = collector;
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
            Functions.Function.gen = "SELECT * FROM productcategory WHERE productcategoryname = '"+ cmbCategory.Text +"' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
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
         Functions.Function.gen = "SELECT productcategory.productcategoryid AS [CATEGORY ID], productcategory.productcategoryname AS [PRODUCT NAME], product.productid AS [PRODUCT ID], product.productname AS [PRODUCT NAME],product.price AS [PRICE], product.stockonhand AS [STOCK ON HAND], product.productdateencoded AS [DATE], product.productencodedby AS [ENCODED BY] FROM productcategory INNER JOIN product ON productcategory.productcategoryid = product.productcategoryid";
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
         btnUpdate.Enabled = true;
         btnSave.Enabled = false;
         tabControlProduct.SelectedIndex = 0;
         txtClerkname.Text = collector;
      }

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "UPDATE product SET productcategoryid = '" + txtCategoryID.Text + "', productname = '" + txtProductname.Text + "', price = '" + txtPrice.Text + "', stockonhand = '" + txtStockonHand.Text + "', productdateencoded = '" + dateTimePicker.Value.Date + "', productencodedby = '" + txtClerkname.Text + "' WHERE productid = '" + txtProductID.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViewProducts();
            Clear();
            tabControlProduct.SelectedIndex = 2;
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void Clear()
      {
         txtCategoryID.Clear();
         txtClerkname.Clear();
         txtPrice.Clear();
         txtProductID.Clear();
         txtProductname.Clear();
         txtStockonHand.Clear();
      }
   }
}
