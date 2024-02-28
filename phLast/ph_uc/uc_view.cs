using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ph
{
  public partial class uc_view : UserControl
  {
    function fn = new function();
    String query;
    public uc_view()
    {
      InitializeComponent();
    }

    private void uc_view_Load(object sender, EventArgs e)
    {
      query = "SELECT * From druginfo";
      DataSet ds = fn.getdata(query); 
      dataGridView1.DataSource= ds.Tables[0];
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      query = "SELECT * FROM druginfo WHERE medname like'" + textBox1.Text + "%'";
      DataSet ds = fn.getdata(query);
      dataGridView1.DataSource = ds.Tables[0];
    }

    private void button1_Click(object sender, EventArgs e)
    {
      uc_view_Load(this, null);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
