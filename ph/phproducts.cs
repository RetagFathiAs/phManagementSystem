﻿using System;
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
    public partial class phproducts : Form
    {
        public phproducts()
        {
            InitializeComponent();
        }

    private void logoutbtn_Click(object sender, EventArgs e)
    {
      Form1 fm = new Form1();
      fm.Show();
      this.Hide();
    }

    private void dashbtn_Click(object sender, EventArgs e)
    {
      ph_uc_dash1.Visible = true;
    }

   

    private void phproducts_Load(object sender, EventArgs e)
    {
      ph_uc_dash1.Visible=false;
      dashbtn.PerformClick();
      uc_addmed1.Visible = false;

    }

    private void ph_uc_dash1_Load(object sender, EventArgs e)
    {

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      ph_uc_dash1.Visible = false;
      uc_addmed1.Visible= true; 
    }

    private void uc_addmed1_Load(object sender, EventArgs e)
    {

    }
  }
}
