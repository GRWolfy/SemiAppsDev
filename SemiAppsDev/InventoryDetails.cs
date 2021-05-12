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
   public partial class InventoryDetails : Form
   {
      private string name = Login.setfirstname + " " + Login.setlastname;
      public static int setproductid = 0;
      public static int setstockonhand = 0;

      public InventoryDetails()
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

      private void InventoryDetails_Load(object sender, EventArgs e)
      {
         ViewInvetory();
      }

      private void ViewInvetory()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT productcategory.productcategoryid AS [CATEGORY ID], productcategory.productcategoryname AS [PRODUCT NAME], product.productid AS [PRODUCT ID], product.productname AS [PRODUCT NAME],product.price AS [PRICE], product.stockonhand AS [STOCK ON HAND], product.productdateencoded AS [DATE], product.productencodedby AS [ENCODED BY] FROM productcategory INNER JOIN product ON productcategory.productcategoryid = product.productcategoryid";
         Functions.Function.fill(Functions.Function.gen, dataGridProduct);
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         int totalsales = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtStockout.Text);
         int stockonhand = Convert.ToInt32(txtStockonHand.Text) - Convert.ToInt32(txtStockout.Text);

         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "INSERT INTO inventorydetails(productid, stockout, totalsales, inventorydate, inventorycodedby) VALUES('" + txtProductID.Text + "', '" + txtStockout.Text + "', '"+ totalsales +"', '" + DateTime.Now.ToString("dd-MM-yyyy") + "', '"+ name + "'); UPDATE product SET stockonhand = '" + stockonhand + "' WHERE productid = '" + txtProductID.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControlInvetory.SelectedIndex = 1;
            Connection.Connection.con.Close();

         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
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
         //btnSave.Enabled = false;
         tabControlInvetory.SelectedIndex = 0;
         StockChecker(Convert.ToInt32(txtStockonHand.Text), Convert.ToInt32(txtProductID.Text));
      }

      private void StockChecker(int stock, int productid)
      {
         if (stock <= 100)
         {
            setproductid = productid;
            setstockonhand = stock;
            txtStockout.Enabled = false;
            MessageBox.Show("Stocks are available for  Restock! Stock-outs are no longer permitted.", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var reorder = new Reorder();
            reorder.Show();
            Hide();
         }
      }
   }
}
