using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ph.ph_uc
{
  public partial class uc_addmed : UserControl
  {
    function fn = new function();
    String query;
    public uc_addmed()
    {
      InitializeComponent();
    }

    private void signbtn_Click(object sender, EventArgs e)
    {
      string name = nametxt.Text;
      String date = dateTimePicker1.Text.ToString();
      Int64 total_quantity = Int64.Parse(med_quan.Text);
      Int64 tbs = Int64.Parse(tab_quantity.Text);
      Int64 price = Int64.Parse(pricetxt.Text);




      query = "SELECT * FROM drugs WHERE medname ='" + name + "'";

      DataSet ds = fn.getdata(query);
      if (ds.Tables[0].Rows.Count == 0)
      {
        try
        {

          query = "INSERT INTO drugs (medname,quantity,price,tabs,expire) values ('" + name + "','" + total_quantity + "','" + price + "','" + tbs + "','" + date + "')";
          fn.setData(query, "Sign up Succesfully.");
        }
        catch (Exception)
        {
          MessageBox.Show("Try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      }
      else
      {
        query = "SELECT * FROM drugs WHERE medname ='" + name + "' AND expire ='" + date +"'";
        ds = fn.getdata(query);
        if (ds.Tables[0].Rows.Count == 0)
        {
          query = "INSERT INTO drugs (medname,quantity,price,tabs,expire) values ('" + name + "','" + total_quantity + "','" + price + "','" + tbs + "','" + date + "')";
          fn.setData(query, "Sign up Succesfully.");
        }
        else
        {
          string previos_quantity = ds.Tables[0].Rows[0][3].ToString();
          total_quantity = total_quantity + Int64.Parse(previos_quantity);
          query = "UPDATE drugs SET quantity = '" + total_quantity + "' WHERE expire ='" + date + "'";
          fn.setData(query, "updated Succesfully.");
        }
      }






     
    }

    private void pricetxt_TextChanged(object sender, EventArgs e)
    {
      Int64 tbs = Int64.Parse(tab_quantity.Text);
      Int64 price = Int64.Parse(pricetxt.Text);


      tab_price.Text = (price / tbs).ToString();
    }
  }
}
