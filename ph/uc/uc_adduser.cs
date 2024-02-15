using Microsoft.VisualBasic;
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
    public partial class uc_adduser : UserControl
    {
        function fn = new function();
        String query;
        public uc_adduser()
        {
            InitializeComponent();
        }


        private void signbtn_Click(object sender, EventArgs e)
        {
            String rol = rolcombo.Text;
            String name = nametxt.Text;
            String db = birthcombo.Text;
            Int64 mob = Int64.Parse(mobiletxt.Text);
            String email = emailtxt.Text;
            String user = usertxt.Text; 
            String pass = passtxt.Text; 

            try
            {
                query = "INSERT INTO users (userRole,name,dob,mobile,email,username,pass) values ('" + rol + "','" + name + "','" + db + "','" + mob + "','" + email + "','" + user + "','" + pass + "')";
                fn.setData(query, "Sign up Succesfully.");
            }
            catch(Exception) 
            {
                MessageBox.Show("User Allready Exist.","Error.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear() 
        {
            rolcombo.ResetText();
            String name = nametxt.Text;
            birthcombo.ResetText();
            mobiletxt.Clear();
            emailtxt.Clear();
            usertxt.Clear();
            passtxt.Clear();
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM users WHERE username ='" + usertxt.Text + "'";

            DataSet ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.Image = Properties.Resources.tick_mark;

            }
            else
            {
                pictureBox1.Image = Properties.Resources.remove;

            }
        }

    private void uc_adduser_Load(object sender, EventArgs e)
    {

    }
  }
}
