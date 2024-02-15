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
    public partial class uc_dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public uc_dashboard()
        {
            InitializeComponent();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {
            
            
            setlabel(ds, lbAdmin);
            setlabelpharmacist(ds, lbph);
        }

        private void setlabel(DataSet ds , Label lbAdmin) 
        {
            query = "SELECT count(userRole) FROM users WHERE userRole='Adminstrator'";
            ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbAdmin.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbAdmin.Text = "0";
            }
        }
        private void setlabelpharmacist(DataSet ds, Label lbAdmin)
        {
            query = "SELECT count(userRole) FROM users WHERE userRole='Pharmacist.'";
            ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbAdmin.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbAdmin.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uc_dashboard_Load(this, null);
        }
    }
}
