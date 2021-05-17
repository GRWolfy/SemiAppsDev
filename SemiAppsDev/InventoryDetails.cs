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
         ViewInventoryDetails();
      }

      private void ViewInventoryDetails()
      {
         Connection.Connection.DB();
         Functions.Function.gen = "SELECT inventorydetails.inventoryid AS [INVENTORY ID], product.productname AS [PRODUCT NAME], product.price AS [PRICE], product.stockonhand AS [STOCK ON HAND], productcategory.productcategoryname AS [CATEGORY NAME],  inventorydetails.stockout AS [STOCK OUT], product.reorderstock AS [REORDER STOCK], inventorydetails.totalsales AS [TOTAL SALES], inventorydetails.inventorydate [INVENTORY DATE], inventorydetails.inventoryencodedby AS [INVENTORY ENCODED BY] FROM inventorydetails INNER JOIN product ON inventorydetails.productid = product.productid INNER JOIN productcategory ON product.productcategoryid = productcategory.productcategoryid";
         Functions.Function.fill(Functions.Function.gen, dataGridInventory);
      }

      private void StockChecker(int stock, int productid)
      {
         if (stock <= 100)
         {
            setproductid = productid;
            setstockonhand = stock;
            //txtStockout.Enabled = false;
            var msg = MessageBox.Show("Stocks are available for  Restock! Stock-outs are no longer permitted.", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
               var reorder = new Reorder();
               reorder.Show();
               Hide();
            }
         }
      }

      private void dataGridInventory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
         int productid = 0;
         string sproductid = "";
         string categoryid = "";

         var product = new Product();
         product.txtInventoryId.Text = dataGridInventory[0, e.RowIndex].Value.ToString();
         product.txtProductname.Text = dataGridInventory[1, e.RowIndex].Value.ToString();  
         product.txtPrice.Text = dataGridInventory[2, e.RowIndex].Value.ToString();
         product.txtStockonHand.Text = dataGridInventory[3, e.RowIndex].Value.ToString();
         product.txtProductID.Text = sproductid;
         product.txtCategoryID.Text = categoryid;
         product.cmbCategory.Text = dataGridInventory[4, e.RowIndex].Value.ToString();
         product.dateTimePicker.Value = Convert.ToDateTime(dataGridInventory[8, e.RowIndex].Value.ToString());
         product.txtEncoder.Text = dataGridInventory[9, e.RowIndex].Value.ToString();

         product.txtStockonHand.Enabled = false;

         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT productid, productcategoryid FROM product WHERE productname = '" + product.txtProductname.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               productid = Convert.ToInt32(Functions.Function.reader["productid"].ToString());
               sproductid = Functions.Function.reader["productid"].ToString();
               categoryid = Functions.Function.reader["productcategoryid"].ToString();
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

         StockChecker(Convert.ToInt32(product.txtStockonHand.Text), productid);
         product.Show();
         Hide();
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {
         try
         {
            Functions.Function.gen = "SELECT * FROM product WHERE productname LIKE '" + txtSearch.Text + "%' OR productdateencoded LIKE '" + txtSearch.Text + "%' OR productid LIKE '" + txtSearch.Text + "%' OR productcategoryid LIKE '" + txtSearch.Text + "%' OR productencodedby LIKE '" + txtSearch.Text + "%' ";
            Functions.Function.fill(Functions.Function.gen, dataGridInventory);
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
