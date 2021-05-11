using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemiAppsDev.Functions
{
   class Function
   {
      public static string gen = "";
      public static SqlConnection con;
      public static SqlCommand command;
      public static SqlDataReader reader;

      public static void fill(string q, DataGridView dgv)
      {
         try
         {
            Connection.Connection.DB();
            DataTable dt = new DataTable();
            SqlDataAdapter data = null;
            SqlCommand command = new SqlCommand(q, Connection.Connection.con);
            data = new SqlDataAdapter(command);
            data.Fill(dt);
            dgv.DataSource = dt;
            Connection.Connection.con.Close();
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }
      }
   }
}
