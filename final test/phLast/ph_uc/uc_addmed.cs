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
      DateTime date = dateTimePicker1.Value;
      Int64 total_quantity = Int64.Parse(med_quan.Text);
      Int64 tbs = Int64.Parse(tab_quantity.Text);
      Int64 price = Int64.Parse(pricetxt.Text);
      String company = comname.Text;



      query = "SELECT * FROM drugs WHERE medname ='" + name + "'";

      DataSet ds = fn.getdata(query);
      if (ds.Tables[0].Rows.Count == 0)
      {



        query = "INSERT INTO drugs (medname) values ('" + name + "')";
          fn.setData(query, "");
        query = "SELECT id FROM drugs WHERE medname ='" + name + "'";

        ds = fn.getdata(query);
        string v = ds.Tables[0].Rows[0][0].ToString();
        Int64 id = Int64.Parse(v);
        query = "INSERT INTO druginfo (id,medname,quantity_of_bucket,quantity_of_tabs,price,tabs,company,expire,total_quantity) values ('" + id + "','" + name + "','" + total_quantity + "','" + (total_quantity*tbs) + "','" + price + "','" + tbs + "','" + company + "','" + date + "','"+ total_quantity + "')";
        fn.setData(query, "Sign up Succesfully.");



      }
      else
      {
        query = "SELECT id FROM druginfo WHERE medname ='" + name + "'";

        ds = fn.getdata(query);
        string v = ds.Tables[0].Rows[0][0].ToString();
        Int64 id = Int64.Parse(v); 

        query = "SELECT * FROM druginfo WHERE medname ='" + name + "' AND expire = '"+date+"' AND company ='" + company +"'";
        ds = fn.getdata(query);
        if (ds.Tables[0].Rows.Count != 0)
        {
          string previos_quantity = ds.Tables[0].Rows[0][2].ToString();
          total_quantity = total_quantity + Int64.Parse(previos_quantity);
          query = "UPDATE druginfo SET quantity_of_bucket = '" + total_quantity + "', quantity_of_tabs='"+ (total_quantity*tbs)+ "',total_quantity='" + total_quantity + "' WHERE medname ='" + name + "' AND expire = '" + date + "' AND company ='" + company + "'";
          fn.setData(query, "updated Succesfully.");
        }
        else
        {
          query = "INSERT INTO druginfo (id,medname,quantity_of_bucket,quantity_of_tabs,price,tabs,company,expire,total_quantity) values ('" + id + "','" + name + "','" + total_quantity + "','" + (total_quantity * tbs) + "','" + price + "','" + tbs + "','" + company + "','" + date + "','"+ total_quantity + "')";
          fn.setData(query, "Sign up Succesfully.");
        }

      }





      button1_Click(this, null);


    }

    private void pricetxt_TextChanged(object sender, EventArgs e)
    {
      try
      { 
      Int64 tbs = Int64.Parse(tab_quantity.Text);
      Int64 price = Int64.Parse(pricetxt.Text);


      tab_price.Text = (price / tbs).ToString();
      }
      catch { }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      nametxt.Text ="";
      dateTimePicker1.Text = "";
      med_quan.Text = "";
      tab_quantity.Text = "";
      pricetxt.Text = "";
      comname.Text = "";
      tab_price.Text = "";
      
    }

    private void uc_addmed_Load(object sender, EventArgs e)
    {

    }
  }
}
