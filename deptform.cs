using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ph
{
  public partial class deptform : Form
  {
    function fn = new function();
    DataSet ds;
    string query;

    public deptform()
    {
      InitializeComponent();
    }
    
    private void signbtn_Click(object sender, EventArgs e)
    {
      if (textBox1.Text!="" && mobiletxt.Text != "" && keynametxt.Text!="" && nametxt.Text!="")
      { 
      query = "SELECT * FROM depts WHERE keyname ='" + keynametxt.Text + "'";

      DataSet ds = fn.getdata(query);
      if (ds.Tables[0].Rows.Count == 0)
      {
        
         query = "INSERT INTO depts (name,mobilephone,homephone,keyname) values ('" + nametxt.Text + "','" + mobiletxt.Text + "','" + textBox1.Text + "','"+ keynametxt.Text + "');";
        fn.setData(query,"done");


          /**  string clientName = keynametxt.Text;

            // Allow only alphanumeric characters in the client name
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            clientName = rgx.Replace(clientName, "");

            query = "CREATE TABLE [" + clientName + "] ([medname] varchar NOT NULL, [quantity_of_bucket] int NOT NULL, [quantity_of_tabs] int NOT NULL, [price] bigint NOT NULL)";
            fn.setData(query);
          **/

        }
        else
      {
        MessageBox.Show("try another key name");

       
      }
      }
      else
      {
        MessageBox.Show("fill full data!");
      }


    }

    private void exitbtn_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void keynametxt_TextChanged(object sender, EventArgs e)
    {
      
      query = "SELECT keyname FROM depts WHERE keyname ='" + keynametxt.Text + "';";
      DataSet ds = fn.getdata(query);
      try
      {
        
        if (ds.Tables[0].Rows.Count == 0)
        {
          pictureBox1.Image = Properties.Resources.tick_mark;

        }
        else
        {
          pictureBox1.Image = Properties.Resources.remove;

        }
      }
      catch (Exception ex) { }
    }
  }
}
