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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminstrator am = new Adminstrator();
            am.Show();
            this.Hide();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
