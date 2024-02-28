using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ph.uc
{
  public partial class uc_sell : UserControl
  {
    function fn = new function();
    string query;
    DataSet ds;
    public uc_sell()
    {
      InitializeComponent();
    }

    private void uc_sell_Load(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
      query = "SELECT medname FROM druginfo WHERE expire > getdate() AND quantity > '0' ";
      ds = fn.getdata(query);
      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
      }

    }

    private void button1_Click(object sender, EventArgs e)
    {
      uc_sell_Load(this, null);
    }

    private void searchtxt_TextChanged(object sender, EventArgs e)
    {
      query = "SELECT medname FROM druginfo WHERE medname like '" + searchtxt.Text + "%' AND expire > getdate() AND quantity > '0'";
      ds = fn.getdata(query);

      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      quantity_med.Text = "";

      query = "SELECT * FROM druginfo WHERE medname ='" + listBox1.GetItemText(listBox1.SelectedItem) + "'";
      ds = fn.getdata(query);
       nametxt.Text = ds.Tables[0].Rows[0][1].ToString();
      quantity_med.Text = "1";
      med_price.Text = ds.Tables[0].Rows[0][3].ToString();
      comname.Text = ds.Tables[0].Rows[0][5].ToString();
      dateTimePicker1.Text = ds.Tables[0].Rows[0][6].ToString();


    }

    private void button3_MouseClick(object sender, MouseEventArgs e)
    {
      query = "SELECT * FROM druginfo WHERE medname ='" + listBox1.GetItemText(listBox1.SelectedItem) + "'";
      ds = fn.getdata(query);
      float cost = Int64.Parse(ds.Tables[0].Rows[0][3].ToString());
      Int64 num_tab = Int64.Parse(ds.Tables[0].Rows[0][4].ToString());
      if (button3.Text == "Bucket")
      { 
      button3.Text = "Peice";
        med_price.Text = (cost / num_tab).ToString();
      }
      else
      {
        button3.Text = "Bucket";
        med_price.Text = cost.ToString();
      }
    }

    private void quantity_med_Leave(object sender, EventArgs e)
    {
      Int64 price_smed = Int64.Parse(quantity_med.ToString());
      query = "SELECT * FROM druginfo WHERE medname ='" + listBox1.GetItemText(listBox1.SelectedItem) + "'";
      ds = fn.getdata(query);

      Int64 value = Int64.Parse(ds.Tables[0].Rows[0][3].ToString()) * price_smed;
      
      total_lbl.Text = value.ToString(); 
      
    }
    protected int n, total_amount = 0;
    protected Int64 quantities, new_quantities;

    private void add_basket_Click(object sender, EventArgs e)
    {

    }
  }
}
