using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Connection
    {
        SqlConnection con;
        SqlDataAdapter adapt;
        DataSet ds;
        public Connection()
        {
            String conStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            con = new SqlConnection(conStr);
        }
        public DataTable Execute(String sql)
        {
            try
            {
                adapt = new SqlDataAdapter(sql, con);
                ds = new DataSet();
                adapt.Fill(ds);
                
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return ds.Tables[0];

        }
        public void ExecuteNonQuery(String sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

    }

}
