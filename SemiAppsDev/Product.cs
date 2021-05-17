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
            Functions.Function.gen = "INSERT INTO product(productcategoryid, productname, price, stockonhand, productdateencoded, productencodedby, reorderstock) VALUES('" + txtCategoryID.Text + "', '" + txtProductname.Text + "', '" + txtPrice.Text + "', '" + txtStockonHand.Text + "', '" + dateTimePicker.Value.Date.ToString("yyyy-MM-dd") + "', '" + txtEncoder.Text + "', 0);  INSERT INTO inventorydetails(productid, stockout, totalsales, inventorydate, inventoryencodedby) VALUES((SELECT productid FROM product WHERE productname = '"+ txtProductname.Text +"'), 0, 0, '"+ dateTimePicker.Value.Date.ToString("yyyy-MM-dd") + "', '"+ txtEncoder.Text +"') ";
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
         setComboBox();
         txtEncoder.Text = collector;
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

      private void btnUpdate_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "UPDATE product SET productcategoryid = '" + txtCategoryID.Text + "', productname = '" + txtProductname.Text + "', price = '" + txtPrice.Text + "', stockonhand = '" + txtStockonHand.Text + "', productdateencoded = '" + dateTimePicker.Value.Date + "', productencodedby = '" + collector + "' WHERE productid = '" + txtProductID.Text + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Update success.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
