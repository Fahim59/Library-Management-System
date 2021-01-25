using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public static class DatabaseConnection
    {
        public static bool ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MUSTAFIZ\FAHIMSQL;Initial Catalog=library;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                con.Close();

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static DataTable GetData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MUSTAFIZ\FAHIMSQL;Initial Catalog=library;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = query;

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);

                DataTable dt = ds.Tables[0];

                con.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
