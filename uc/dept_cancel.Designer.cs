﻿namespace ph.uc
{
  partial class dept_cancel
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.button1 = new System.Windows.Forms.Button();
      this.setlbl = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.button2 = new System.Windows.Forms.Button();
      this.dept = new Guna.UI2.WinForms.Guna2Elipse(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
      this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
      this.button1.Location = new System.Drawing.Point(790, 149);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(167, 46);
      this.button1.TabIndex = 28;
      this.button1.Text = "REFRESH";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // setlbl
      // 
      this.setlbl.AutoSize = true;
      this.setlbl.BackColor = System.Drawing.Color.Transparent;
      this.setlbl.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.setlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
      this.setlbl.Location = new System.Drawing.Point(44, 468);
      this.setlbl.Name = "setlbl";
      this.setlbl.Size = new System.Drawing.Size(104, 52);
      this.setlbl.TabIndex = 27;
      this.setlbl.Text = "Data";
      // 
      // dataGridView1
      // 
      this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(94, 555);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(775, 296);
      this.dataGridView1.TabIndex = 26;
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
      this.label1.Location = new System.Drawing.Point(383, 149);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(164, 60);
      this.label1.TabIndex = 25;
      this.label1.Text = "DEPTS";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
      this.label2.Location = new System.Drawing.Point(217, 313);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 52);
      this.label2.TabIndex = 24;
      this.label2.Text = "Check";
      // 
      // comboBox1
      // 
      this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Valid.",
            "Expired.",
            "Almost expired."});
      this.comboBox1.Location = new System.Drawing.Point(291, 388);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(359, 54);
      this.comboBox1.TabIndex = 23;
      this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(155)))), ((int)(((byte)(150)))));
      this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
      this.button2.Location = new System.Drawing.Point(751, 478);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(167, 46);
      this.button2.TabIndex = 29;
      this.button2.Text = "Payed";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // dept
      // 
      this.dept.TargetControl = this;
      // 
      // dept_cancel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.setlbl);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.comboBox1);
      this.Name = "dept_cancel";
      this.Size = new System.Drawing.Size(1000, 1000);
      this.Load += new System.EventHandler(this.dept_cancel_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label setlbl;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button button2;
    private Guna.UI2.WinForms.Guna2Elipse dept;
  }
}
