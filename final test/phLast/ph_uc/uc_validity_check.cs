using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ph.ph_uc
{
  public partial class uc_validity_check : UserControl
  {
    function fn = new function();
    string query;
    public uc_validity_check()
    {
      InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if(comboBox1.SelectedIndex == 0)
      {
        query = "SELECT * from druginfo WHERE expire > getdate();";
        setgrid(query, "Valid medicines", Color.Green);
        


      }
      else if(comboBox1.SelectedIndex == 1)
      {
        query = "SELECT * from druginfo WHERE expire < getdate();";
        setgrid(query, "Expired medicines", Color.Red);
       
          
      }

      else if (comboBox1.SelectedIndex == 2)
      {
        query = "SELECT * FROM druginfo WHERE expire BETWEEN DATEADD(MONTH, 1, GETDATE()) AND DATEADD(MONTH, 4, GETDATE());";
        setgrid(query, "Almost Expired medicines", Color.Orange);


      }
    }
    private void setgrid(string query,string lblname,Color col)
    {
      DataSet ds = fn.getdata(query);
      dataGridView1.DataSource = ds.Tables[0];
      setlbl.ForeColor = col;
      setlbl.Text = lblname;

    }

    
  }
}
