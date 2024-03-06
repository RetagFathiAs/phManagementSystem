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
    public partial class Adminstrator : Form
    {
        public Adminstrator()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            uc_dashboard1.Visible = true;
            uc_dashboard1.BringToFront();
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uc_dashboard1.Visible=false;
            uc_adduser.Visible = false;
            uc_view1.Visible = false;
            uc_addmed1.Visible= false;
      user_view1.Visible = false;


    }

    private void uc_dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uc_adduser.Visible= true; 
            uc_adduser.BringToFront();

        }

        private void uc_adduser1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        user_view1.Visible=true;
        user_view1.BringToFront();
        }

    private void uc_view1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      uc_addmed1.Visible = true;
      uc_addmed1.BringToFront();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      uc_inventory1.Visible = true;
      uc_inventory1.BringToFront();
    }
  }
}
