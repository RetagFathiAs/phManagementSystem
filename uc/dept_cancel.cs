using System;
using System.Collections;
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
  public partial class dept_cancel : UserControl
  {
    function fn = new function();
    string query;
    DataSet ds;
    string name;
    string keyname;
    public dept_cancel()
    {
      InitializeComponent();
    }

    private void dept_cancel_Load(object sender, EventArgs e)
    {
      query = "SELECT name,keyname FROM depts;";
      ds = fn.getdata(query);
      
      comboBox1.Items.Clear();
      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        comboBox1.Items.Add(ds.Tables[0].Rows[i][0]);
      }

     
    }

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
    {
     
      
       name = comboBox1.SelectedItem.ToString();
      query = "SELECT keyname FROM depts WHERE name='" + name + "';";
      ds = fn.getdata(query);
      keyname= ds.Tables[0].Rows[0][0].ToString();
      query = "IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '" + keyname + "') SELECT * FROM " + keyname + ";";

      ds = fn.getdata(query);
        if (ds.Tables.Count == 0)
        {
        MessageBox.Show("no depts right now!");
        comboBox1.SelectedText = "";
        dataGridView1.DataSource=0;
        }
        else { 
        ds = fn.getdata(query);
        dataGridView1.DataSource = ds.Tables[0];
        }
      



    }
    int sn;
    
    private void button2_Click(object sender, EventArgs e)
    {
      
        if (sn != 0)
        {
          query = "DELETE FROM " + keyname + " WHERE sn='" + sn + "';";
          fn.setData(query,"deleted!");
        this.Refresh();
        }
      
      else
      {
        MessageBox.Show("select person first");
      }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        sn = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
      }
      catch { }
    }
  }
}
