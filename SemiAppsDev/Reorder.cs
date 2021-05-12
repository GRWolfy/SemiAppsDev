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
   public partial class Reorder : Form
   {
      public Reorder()
      {
         InitializeComponent();
      }

      private void btnReorder_Click(object sender, EventArgs e)
      {
         int newStock = InventoryDetails.setstockonhand + Convert.ToInt32(txtReorder.Text);

         try
         {
            Connection.Connection.DB();
            Functions.Function.gen = "UPDATE product SET stockonhand = '" + newStock + "' WHERE productid = '" + InventoryDetails.setproductid + "' ";
            Functions.Function.command = new SqlCommand(Functions.Function.gen, Connection.Connection.con);
            Functions.Function.command.ExecuteNonQuery();
            MessageBox.Show("Saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Connection.con.Close();
            var inventory = new InventoryDetails();
            inventory.Show();
            Hide();
         }

         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
/*
   REORDER DB EXIST AYAW KALIMTI
 */