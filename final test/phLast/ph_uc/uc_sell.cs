using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ph.uc
{
  public partial class uc_sell : UserControl
  {
    function fn = new function();
    string query;
    DataSet ds;
    DateTime date;
   
    public uc_sell()
    {
      InitializeComponent();
    }

    private void uc_sell_Load(object sender, EventArgs e)
    {
      dataGridView1.Columns[4].Visible = false;
      dataGridView1.Columns[6].Visible = false;
      dataGridView1.Columns[7].Visible = false;
      query = "UPDATE druginfo SET quantity_of_bucket = (quantity_of_tabs / tabs);";
      fn.setData(query);
      nametxt.Text = "";
      comname.Text = "";
      med_price.Text = "";
      total_price.Text = "";
      dateTimePicker1.Text = "";
      quantity_med.Text = "";
      searchtxt.Text = "";
      listBox1.Items.Clear();
      query = "ALTER TABLE druginfo NOCHECK CONSTRAINT FK_druginfo_drugs; DELETE FROM drugs WHERE id IN (  SELECT id FROM druginfo GROUP BY id HAVING SUM(CASE WHEN quantity_of_tabs > 0 THEN 1 ELSE 0 END) = 0); ALTER TABLE druginfo CHECK CONSTRAINT FK_druginfo_drugs;";
      fn.setData(query);
      query = "DELETE from druginfo WHERE quantity_of_tabs = 0";
      fn.setData(query);
      query = "SELECT d.medname FROM drugs AS d WHERE d.medname LIKE '%" + searchtxt.Text + "%' AND EXISTS( SELECT 1 FROM druginfo AS di WHERE di.medname LIKE '%" + searchtxt.Text + "%' and di.expire > GETDATE() AND di.quantity_of_bucket > 0);";
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
      listBox1.Items.Clear();

      query = "SELECT d.medname FROM drugs AS d WHERE d.medname LIKE '%"+ searchtxt.Text+ "%' AND EXISTS( SELECT 1 FROM druginfo AS di WHERE di.medname LIKE '%"+ searchtxt.Text+"%' and di.expire > GETDATE() AND di.quantity_of_bucket > 0);";
      ds = fn.getdata(query);

      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Expire.Items.Clear();
      Expire.Text = "";
      quantity_med.Text = "";
      query = "SELECT * FROM druginfo WHERE medname ='" + listBox1.GetItemText(listBox1.SelectedItem) + "'";
      ds = fn.getdata(query);
      nametxt.Text = ds.Tables[0].Rows[0][2].ToString();
      comname.Text = ds.Tables[0].Rows[0][7].ToString();
      Expire_MouseClick(this,null);
       Expire.SelectedIndex = 0;
      Expire_SelectionChangeCommitted(this,null);

      // Assuming the cell contains a valid date or string value
      dateTimePicker1.Text =Expire.SelectedItem.ToString();
    }

    private void button3_MouseClick(object sender, MouseEventArgs e)
    {
      if (listBox1.SelectedItems.Count == 0)
      {
        MessageBox.Show("select medicine first!!!! ");
      }
      else
      {
        query = "SELECT price,tabs FROM druginfo WHERE medname ='" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + date + "';";
        ds = fn.getdata(query);
        float cost = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
        Int64 num_tab = Int64.Parse(ds.Tables[0].Rows[0][1].ToString());
        if (button3.Text == "Tab")
        {
          button3.Text = "Bucket";
          med_price.Refresh();
          med_price.Text = (cost / num_tab).ToString();
          total_price.Refresh();
          total_price.Text = (int.Parse(med_price.Text) * int.Parse(quantity_med.Text)).ToString();
          total_lbl.Text = total_price.Text;

        }
        else
        {
          button3.Text = "Tab";
          med_price.Refresh();

          med_price.Text = cost.ToString();
          total_price.Refresh();
          total_price.Text = (int.Parse(med_price.Text) * int.Parse(quantity_med.Text)).ToString();
          total_lbl.Text = total_price.Text;

        }
      }
    }

    private void quantity_med_Leave(object sender, EventArgs e)
    {
     

    }
    protected int n, total_amount = 0;
    protected Int64 quantities, new_quantities, new_quantities_of_tabs;

    

   

    private void button3_Click(object sender, EventArgs e)
    {
      
    }

    private void quantity_med_TextChanged(object sender, EventArgs e)
    {
      if (listBox1.SelectedItems.Count == 0)
      {
        MessageBox.Show("select medicine first!!!! ");
      }
      else
      {
        try
        {
          Int64 price_smed = Int64.Parse(quantity_med.Text);


          Int64 value = int.Parse(med_price.Text) * price_smed;

          total_lbl.Text = value.ToString();
          total_price.Text = value.ToString();
        }
        catch { }
      }
    }
    

    private void Expire_MouseClick(object sender, MouseEventArgs e)
    {
      if (listBox1.SelectedItems.Count == 0)
      {
        MessageBox.Show("select medicine first!!!! ");
      }
      else
      {
        query = "SELECT expire,sn FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "';";
        ds = fn.getdata(query);
        Expire.Items.Clear();
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
          Expire.Items.Add(ds.Tables[0].Rows[i][0]);
        }
        Expire.SelectedItem = 0;
      }
      
    }

    private void Expire_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (listBox1.SelectedItems.Count == 0)
      {
        MessageBox.Show("select medicine first!!!! ");
      }
      else
      {
        date = Convert.ToDateTime(Expire.SelectedItem);
        string query2 = "SELECT sn FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + date + "';";
        DataSet ds2 = fn.getdata(query2);
        snlbl.Text = ds2.Tables[0].Rows[0][0].ToString();

        // ---------------------------------------------

        query = "SELECT * FROM druginfo WHERE medname ='" + listBox1.GetItemText(listBox1.SelectedItem) + "'";
        ds = fn.getdata(query);

        quantity_med.Text = "1";
        med_price.Text = ds.Tables[0].Rows[0][5].ToString();

        // Assuming the cell contains a valid date or string value
        dateTimePicker1.Text = date.ToString();
        Int64 total = Int64.Parse(ds.Tables[0].Rows[0][5].ToString()) * 1;
        total_price.Text = total.ToString();
      }
    }
    

    private void Expire_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }

   

    private void add_basket_Click(object sender, EventArgs e)
    {

      if (listBox1.SelectedItems.Count == 0)
      {
        MessageBox.Show("select medicine first!!!! ");
      }
      else
      {
        
            
            query = "SELECT quantity_of_tabs FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + Expire.SelectedItem + "';";
        ds = fn.getdata(query);
        Int64 stored_tabs = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
        query = "SELECT quantity_of_bucket FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + Expire.SelectedItem + "';";
        ds = fn.getdata(query);
        Int64 stored_bucket = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());


        if (button3.Text == "Tab")
        {
          if (stored_bucket < Int64.Parse(quantity_med.Text))
          {
            MessageBox.Show("No enough quantity! .\n tabs available : " + stored_tabs + "\n bucket available : " + stored_bucket);
          }
          else
          {
            query = "SELECT quantity_of_bucket,tabs FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + date + "';";
            ds = fn.getdata(query);
            quantities = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            new_quantities = quantities - Int64.Parse(quantity_med.Text);
            Int64 n_tabs = Int64.Parse(ds.Tables[0].Rows[0][1].ToString());
            new_quantities_of_tabs = new_quantities * n_tabs;

            date = Convert.ToDateTime(Expire.SelectedItem);
            try
            {
              n = dataGridView1.Rows.Add();
              dataGridView1.Rows[n].Cells[0].Value = nametxt.Text;
              dataGridView1.Rows[n].Cells[1].Value = med_price.Text;
            
            if (button3.Text == "Tab")
            {
              dataGridView1.Rows[n].Cells[3].Value = quantity_med.Text;
              dataGridView1.Rows[n].Cells[2].Value = 0;
            }
            else
            {
              dataGridView1.Rows[n].Cells[2].Value = quantity_med.Text;
              dataGridView1.Rows[n].Cells[3].Value = 0;
            }

            dataGridView1.Rows[n].Cells[4].Value = Expire.SelectedItem ;
            dataGridView1.Rows[n].Cells[5].Value = total_price.Text;
            dataGridView1.Rows[n].Cells[6].Value = snlbl.Text;
            dataGridView1.Rows[n].Cells[7].Value = comname.Text;
            total_amount = total_amount + int.Parse(total_price.Text);
            total_lbl.Text = "Rs. " + total_amount.ToString();
            }
            catch { }
            try
            {
              query = "UPDATE druginfo SET quantity_of_bucket = '" + new_quantities + "', quantity_of_tabs='" + new_quantities_of_tabs + "' WHERE medname = '" + nametxt.Text + "' AND company ='" + comname.Text + "' AND expire = '" + Expire.SelectedItem + "' ;";
              fn.setData(query, "sell done! no go back!!!");
            }
            catch { MessageBox.Show("i am here"); }


            uc_sell_Load(this, null);
          }
        }
        else
        {
          if (stored_tabs < Int64.Parse(quantity_med.Text))
          {
            MessageBox.Show("No enough quantity! .\n tabs available : " + stored_tabs + "\n bucket available : " + stored_bucket);
          }
          else
          {
            query = "SELECT tabs,quantity_of_bucket,quantity_of_tabs FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + Expire.SelectedItem + "';";
            ds = fn.getdata(query);
            if (Int64.Parse(quantity_med.Text) >= Int64.Parse(ds.Tables[0].Rows[0][0].ToString()))
            {
              int real = (int)(Int64.Parse(quantity_med.Text)) % (int)(Int64.Parse(ds.Tables[0].Rows[0][0].ToString()));
              if (real == 0)
              {
                int number = (int)(Int64.Parse(quantity_med.Text)) / (int)(Int64.Parse(ds.Tables[0].Rows[0][0].ToString()));
                query = "SELECT quantity_of_bucket,tabs FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + Expire.SelectedItem + "';";
                ds = fn.getdata(query);
                quantities = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                new_quantities = quantities - number;
                Int64 n_tabs = Int64.Parse(ds.Tables[0].Rows[0][1].ToString());
                new_quantities_of_tabs = new_quantities * n_tabs;

              }
              else
              {

                int number = (int)(Int64.Parse(quantity_med.Text)) / (int)(Int64.Parse(ds.Tables[0].Rows[0][0].ToString()));
                query = "SELECT quantity_of_bucket,tabs FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + Expire.SelectedItem + "';";
                ds = fn.getdata(query);
                quantities = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                new_quantities = quantities - number;
                new_quantities_of_tabs = (new_quantities * 2) - real;
              }

            }
            else
            {
              query = "SELECT quantity_of_tabs,quantity_of_bucket FROM druginfo WHERE medname = '" + nametxt.Text + "' AND company = '" + comname.Text + "' AND expire = '" + Expire.SelectedItem + "';";
              ds = fn.getdata(query);
              quantities = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
              new_quantities_of_tabs = quantities - Int64.Parse(quantity_med.Text);
              Int64 buck_quantity = Int64.Parse(ds.Tables[0].Rows[0][1].ToString());
              new_quantities = buck_quantity;
            }


            date = Convert.ToDateTime(Expire.SelectedItem);
            n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = nametxt.Text;
            dataGridView1.Rows[n].Cells[1].Value = med_price.Text;
          
        if(button3.Text == "Tab") 
        {
          dataGridView1.Rows[n].Cells[3].Value = quantity_med.Text;
          dataGridView1.Rows[n].Cells[2].Value = 0;
         }
        else
        {
          dataGridView1.Rows[n].Cells[2].Value = quantity_med.Text;
          dataGridView1.Rows[n].Cells[3].Value = 0;
        }

        dataGridView1.Rows[n].Cells[4].Value = Expire.SelectedItem;
        dataGridView1.Rows[n].Cells[5].Value = total_price.Text;
        dataGridView1.Rows[n].Cells[6].Value = snlbl.Text;
            dataGridView1.Rows[n].Cells[7].Value = comname.Text;

            total_amount = total_amount + int.Parse(total_price.Text);
        total_lbl.Text = "Rs. " + total_amount.ToString();

        try
        {
          query = "UPDATE druginfo SET quantity_of_bucket = '" + new_quantities + "', quantity_of_tabs='" + new_quantities_of_tabs + "' WHERE medname = '" + nametxt.Text + "' AND company ='" + comname.Text + "' AND expire = '" + Expire.SelectedItem + "' ;";
          fn.setData(query, "sell done! no go back!!!");
        }
        catch { MessageBox.Show("i am here"); }


        uc_sell_Load(this, null);
          }
        }
      }










    
    }
    int total_prices_in_grid,unit_p_grid, sn;
    protected Int64 numtab,numbuc;
    string name_grid,com_grid;
    DateTime d_grid;
    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        total_prices_in_grid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
        unit_p_grid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        sn = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
        numtab = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        numbuc = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        name_grid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        com_grid= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        d_grid = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
      }
      catch { }
    }

    private void remove_btn_Click(object sender, EventArgs e)
    {
      if(sn != 0) {
        try { 
          query = "SELECT quantity_of_bucket,quantity_of_tabs,tabs FROM druginfo WHERE sn ='" + sn + "';";
          ds = fn.getdata(query);
          int tab = int.Parse(ds.Tables[0].Rows[0][2].ToString());
        int buc_q = int.Parse(ds.Tables[0].Rows[0][0].ToString());
          int tab_q  = int.Parse(ds.Tables[0].Rows[0][1].ToString());
          int n_quantities = (int)(buc_q + numbuc + (numtab / tab));
          int n_quantities_of_tabs = (int)(tab_q +numtab + (numbuc * tab) );
          query = "UPDATE druginfo SET quantity_of_bucket='" + n_quantities + "', quantity_of_tabs='" + n_quantities_of_tabs + "' WHERE  medname = '" + name_grid + "' AND company ='" + com_grid + "' AND expire = '" + d_grid + "' ;";
          fn.setData(query, "deleted successfully1!");
        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
        
        total_amount -= total_prices_in_grid;
        total_lbl.Text = "RS." + total_amount.ToString();
        uc_sell_Load(this, null);
      }
        catch { }
        
        }
      
      else
      {
        MessageBox.Show("choose which cart you want to remove!.");
      }
    }
    private void parshase_btn_Click(object sender, EventArgs e)
    {
      DGVPrinter print = new DGVPrinter();
      print.Title = "Medical Bill";
      print.SubTitle = String.Format("Date :"+ DateTime.Now.Date.ToString());
      print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
      print.PageNumbers = true;
      print.PageNumberInHeader = false;
      print.PorportionalColumns = true;
      print.HeaderCellAlignment = StringAlignment.Near;
      print.Footer = " Total payed amount : " + total_lbl.Text;
      print.FooterSpacing = 15;
      print.PrintDataGridView(dataGridView1);

      total_amount = 0;
      total_lbl.Text = "";
      dataGridView1.Rows.Clear();

    }
  }
}
