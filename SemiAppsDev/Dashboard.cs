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
   public partial class Dashboard : Form
   {
      int categoryid = 0;   

      public Dashboard()
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

      private void viewByCategory()
      {
         Connection.Connection.DB();
         //Functions.Function.gen = "SELECT productcategory.productcategoryname AS [CATEGORY NAME], product.productname AS [PRODUCT NAME], product.price AS [PRICE] FROM productcategory INNER JOIN product ON product.productcategoryid = productcategory.productcategoryid WHERE productcategory.productcategoryid = '"+ txtCategoryID.Text +"' ";
         Functions.Function.gen = "SELECT productcategory.productcategoryname AS [CATEGORY NAME], product.productname AS [PRODUCT NAME],product.price AS [PRICE], product.stockonhand AS [STOCK ON HAND], product.productdateencoded AS [DATE], product.productencodedby AS [ENCODED BY] FROM productcategory INNER JOIN product ON productcategory.productcategoryid = product.productcategoryid WHERE productcategory.productcategoryid = '" + txtCategoryID.Text + "' ";
         Functions.Function.fill(Functions.Function.gen, dataGridCategory);
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
      /*
      - [ ] Overall-Total  product 
      - [ ] Overall-Stock on hand  
      - [ ] Overall-Stock out  
      - [ ] Overall-Total Sales
       */
      private void Dashboard_Load(object sender, EventArgs e)
      {
         setComboBox();
         viewByCategory();
         displayTotalProduct();
         displayStockonHand();
         displayTotalSales();
         displayStockout();
      }

      private void displayStockout()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT SUM(stockout) AS total FROM inventorydetails INNER JOIN product ON product.productid = inventorydetails.productid WHERE product.productcategoryid = '"+ txtCategoryID.Text +"'  ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               lblStockOut.Text = (Functions.Function.reader["total"].ToString());
            }
         }

         catch (Exception ex)
         {
            Connection.Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
      }

      private void displayTotalSales()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT SUM(totalsales) AS [total] FROM inventorydetails INNER JOIN product ON product.productid = inventorydetails.productid WHERE product.productcategoryid = '"+ txtCategoryID.Text +"' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               string s = (Functions.Function.reader["total"].ToString());
               lblTotalSales.Text = Decimal.Parse(s).ToString("N2");
            }
         }

         catch (Exception ex)
         {
            Connection.Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
      }

      private void displayStockonHand()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT SUM(stockonhand) AS [total] FROM product WHERE productcategoryid = '"+ txtCategoryID.Text +"' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               lblStockonHand.Text = (Functions.Function.reader["total"].ToString());
            }
         }

         catch (Exception ex)
         {
            Connection.Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
      }

      private void displayTotalProduct()
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT COUNT(*) AS [total] FROM product INNER JOIN productcategory ON product.productcategoryid = productcategory.productcategoryid WHERE product.productcategoryid = '"+ txtCategoryID.Text +"' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.HasRows)
            {
               Functions.Function.reader.Read();
               lblTotalProduct.Text = (Functions.Function.reader["total"].ToString());
            }
         }

         catch (Exception ex)
         {
            Connection.Connection.con.Close();
            MessageBox.Show(ex.Message);
         }
      }

      private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "SELECT * FROM productcategory WHERE productcategoryname = '" + cmbCategory.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.reader = Functions.Function.command.ExecuteReader();

            if (Functions.Function.reader.Read())
            {
               txtCategoryID.Text = Functions.Function.reader[0].ToString();
               categoryid = Convert.ToInt32(Functions.Function.reader[0].ToString());
               viewByCategory();
               displayTotalProduct();
               displayStockonHand();
               displayTotalSales();
               displayStockout();
               Functions.Function.reader.Close();
            }
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
/*
 Create Dashboard, OK
 Registration for inventory clerk, OK
 Login, OK
 Product Category, OK
 Product and Inventory details FORMS. OK
 */