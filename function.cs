using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ph
{
    internal class function
    {
        public SqlConnection getconnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-VSMEBK0\\SQLEXPRESS; database = pharmacy; integrated security = True";
            return con;
        }
        public DataSet getdata(String query) 
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;   
            cmd.CommandText= query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String msg) 
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;
            con.Open();
            cmd.CommandText= query;
            cmd.ExecuteNonQuery(); 
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }
    public void setData(String query)
    {
      SqlConnection con = getconnection();
      SqlCommand cmd = new SqlCommand();
      cmd.Connection = con;
      con.Open();
      cmd.CommandText = query;
      cmd.ExecuteNonQuery();
      con.Close();
    }
  }
}
