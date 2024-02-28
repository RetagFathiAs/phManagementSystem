namespace ph
{
    partial class phproducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.sellbtn = new System.Windows.Forms.Button();
      this.validbtn = new System.Windows.Forms.Button();
      this.logoutbtn = new System.Windows.Forms.Button();
      this.btnmodify = new System.Windows.Forms.Button();
      this.view = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.dashbtn = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
      this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
      this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
      this.uc_validity_check1 = new ph.ph_uc.uc_validity_check();
      this.uc_view1 = new ph.uc_view();
      this.uc_addmed1 = new ph.ph_uc.uc_addmed();
      this.ph_uc_dash1 = new ph.ph_uc.ph_uc_dash();
      this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
      this.uc_sell1 = new ph.uc.uc_sell();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.RosyBrown;
      this.panel1.Controls.Add(this.sellbtn);
      this.panel1.Controls.Add(this.validbtn);
      this.panel1.Controls.Add(this.logoutbtn);
      this.panel1.Controls.Add(this.btnmodify);
      this.panel1.Controls.Add(this.view);
      this.panel1.Controls.Add(this.btnAdd);
      this.panel1.Controls.Add(this.dashbtn);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Location = new System.Drawing.Point(1, 2);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(407, 678);
      this.panel1.TabIndex = 1;
      // 
      // sellbtn
      // 
      this.sellbtn.BackColor = System.Drawing.Color.LightSeaGreen;
      this.sellbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
      this.sellbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.sellbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.sellbtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sellbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.sellbtn.Location = new System.Drawing.Point(31, 511);
      this.sellbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.sellbtn.Name = "sellbtn";
      this.sellbtn.Size = new System.Drawing.Size(376, 58);
      this.sellbtn.TabIndex = 7;
      this.sellbtn.Text = "sell medicin";
      this.sellbtn.UseVisualStyleBackColor = false;
      this.sellbtn.Click += new System.EventHandler(this.sellbtn_Click);
      // 
      // validbtn
      // 
      this.validbtn.BackColor = System.Drawing.Color.LightSeaGreen;
      this.validbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
      this.validbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.validbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.validbtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.validbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.validbtn.Location = new System.Drawing.Point(31, 449);
      this.validbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.validbtn.Name = "validbtn";
      this.validbtn.Size = new System.Drawing.Size(376, 58);
      this.validbtn.TabIndex = 6;
      this.validbtn.Text = "medicine validity check";
      this.validbtn.UseVisualStyleBackColor = false;
      this.validbtn.Click += new System.EventHandler(this.validbtn_Click);
      // 
      // logoutbtn
      // 
      this.logoutbtn.BackColor = System.Drawing.Color.WhiteSmoke;
      this.logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
      this.logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.logoutbtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.logoutbtn.ForeColor = System.Drawing.SystemColors.ControlText;
      this.logoutbtn.Location = new System.Drawing.Point(12, 599);
      this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.logoutbtn.Name = "logoutbtn";
      this.logoutbtn.Size = new System.Drawing.Size(376, 64);
      this.logoutbtn.TabIndex = 5;
      this.logoutbtn.Text = "Log Out";
      this.logoutbtn.UseVisualStyleBackColor = false;
      this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
      // 
      // btnmodify
      // 
      this.btnmodify.BackColor = System.Drawing.Color.LightSeaGreen;
      this.btnmodify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
      this.btnmodify.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnmodify.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnmodify.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.btnmodify.Location = new System.Drawing.Point(31, 382);
      this.btnmodify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnmodify.Name = "btnmodify";
      this.btnmodify.Size = new System.Drawing.Size(376, 60);
      this.btnmodify.TabIndex = 4;
      this.btnmodify.Text = "modify medicine";
      this.btnmodify.UseVisualStyleBackColor = false;
      // 
      // view
      // 
      this.view.BackColor = System.Drawing.Color.LightSeaGreen;
      this.view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
      this.view.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.view.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.view.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.view.Location = new System.Drawing.Point(31, 321);
      this.view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.view.Name = "view";
      this.view.Size = new System.Drawing.Size(376, 54);
      this.view.TabIndex = 3;
      this.view.Text = "View medicine";
      this.view.UseVisualStyleBackColor = false;
      this.view.Click += new System.EventHandler(this.view_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
      this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
      this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdd.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.btnAdd.Location = new System.Drawing.Point(31, 260);
      this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(376, 54);
      this.btnAdd.TabIndex = 2;
      this.btnAdd.Text = "Add medicine";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // dashbtn
      // 
      this.dashbtn.BackColor = System.Drawing.Color.LightSeaGreen;
      this.dashbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.dashbtn.FlatAppearance.BorderSize = 5;
      this.dashbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
      this.dashbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
      this.dashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dashbtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dashbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.dashbtn.Location = new System.Drawing.Point(31, 202);
      this.dashbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dashbtn.Name = "dashbtn";
      this.dashbtn.Size = new System.Drawing.Size(376, 54);
      this.dashbtn.TabIndex = 1;
      this.dashbtn.Text = "Dashboard";
      this.dashbtn.UseVisualStyleBackColor = false;
      this.dashbtn.Click += new System.EventHandler(this.dashbtn_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = global::ph.Properties.Resources.drug;
      this.pictureBox1.Location = new System.Drawing.Point(33, 20);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(316, 166);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.uc_sell1);
      this.panel2.Controls.Add(this.uc_validity_check1);
      this.panel2.Controls.Add(this.uc_view1);
      this.panel2.Controls.Add(this.uc_addmed1);
      this.panel2.Controls.Add(this.ph_uc_dash1);
      this.panel2.Location = new System.Drawing.Point(405, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1047, 678);
      this.panel2.TabIndex = 1;
      // 
      // guna2Elipse4
      // 
      this.guna2Elipse4.TargetControl = this.panel2;
      // 
      // guna2Elipse1
      // 
      this.guna2Elipse1.TargetControl = this.panel2;
      // 
      // guna2Elipse2
      // 
      this.guna2Elipse2.TargetControl = this.panel2;
      // 
      // uc_validity_check1
      // 
      this.uc_validity_check1.BackColor = System.Drawing.SystemColors.Window;
      this.uc_validity_check1.Location = new System.Drawing.Point(0, 2);
      this.uc_validity_check1.Name = "uc_validity_check1";
      this.uc_validity_check1.Size = new System.Drawing.Size(1047, 678);
      this.uc_validity_check1.TabIndex = 3;
      // 
      // uc_view1
      // 
      this.uc_view1.Location = new System.Drawing.Point(0, 0);
      this.uc_view1.Margin = new System.Windows.Forms.Padding(4);
      this.uc_view1.Name = "uc_view1";
      this.uc_view1.Size = new System.Drawing.Size(1047, 676);
      this.uc_view1.TabIndex = 2;
      // 
      // uc_addmed1
      // 
      this.uc_addmed1.BackColor = System.Drawing.SystemColors.Window;
      this.uc_addmed1.Location = new System.Drawing.Point(-3, 2);
      this.uc_addmed1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.uc_addmed1.Name = "uc_addmed1";
      this.uc_addmed1.Size = new System.Drawing.Size(1047, 678);
      this.uc_addmed1.TabIndex = 1;
      this.uc_addmed1.Load += new System.EventHandler(this.uc_addmed1_Load);
      // 
      // ph_uc_dash1
      // 
      this.ph_uc_dash1.BackColor = System.Drawing.Color.White;
      this.ph_uc_dash1.Location = new System.Drawing.Point(0, 0);
      this.ph_uc_dash1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ph_uc_dash1.Name = "ph_uc_dash1";
      this.ph_uc_dash1.Size = new System.Drawing.Size(1047, 678);
      this.ph_uc_dash1.TabIndex = 0;
      this.ph_uc_dash1.Load += new System.EventHandler(this.ph_uc_dash1_Load);
      // 
      // guna2Elipse3
      // 
      this.guna2Elipse3.TargetControl = this.panel2;
      // 
      // uc_sell1
      // 
      this.uc_sell1.BackColor = System.Drawing.SystemColors.Window;
      this.uc_sell1.Location = new System.Drawing.Point(0, 0);
      this.uc_sell1.Name = "uc_sell1";
      this.uc_sell1.Size = new System.Drawing.Size(1047, 678);
      this.uc_sell1.TabIndex = 4;
      // 
      // phproducts
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1452, 676);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "phproducts";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.phproducts_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button logoutbtn;
    private System.Windows.Forms.Button btnmodify;
    private System.Windows.Forms.Button view;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button dashbtn;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button sellbtn;
    private System.Windows.Forms.Button validbtn;
    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    private ph_uc.ph_uc_dash ph_uc_dash1;
    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    private ph_uc.uc_addmed uc_addmed1;
    private uc_view uc_view1;
    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    private ph_uc.uc_validity_check uc_validity_check1;
    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    private uc.uc_sell uc_sell1;
  }
}