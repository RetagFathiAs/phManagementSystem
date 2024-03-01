namespace ph.ph_uc
{
  partial class ph_uc_dash
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.button1 = new System.Windows.Forms.Button();
      this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.MistyRose;
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Location = new System.Drawing.Point(23, 27);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(430, 576);
      this.panel1.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.DarkCyan;
      this.panel3.Location = new System.Drawing.Point(120, 453);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(314, 10);
      this.panel3.TabIndex = 2;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Location = new System.Drawing.Point(120, 40);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(310, 10);
      this.panel2.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::ph.Properties.Resources.drugs;
      this.pictureBox1.Location = new System.Drawing.Point(183, 127);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(247, 289);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // chart1
      // 
      this.chart1.BackColor = System.Drawing.Color.RosyBrown;
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Expired Medicine";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(459, 27);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Color = System.Drawing.Color.Firebrick;
      series1.Legend = "Expired Medicine";
      series1.Name = "Expired Medicine";
      series2.ChartArea = "ChartArea1";
      series2.Color = System.Drawing.Color.DarkCyan;
      series2.Legend = "Expired Medicine";
      series2.Name = "Valid Medicine";
      this.chart1.Series.Add(series1);
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(513, 576);
      this.chart1.TabIndex = 1;
      this.chart1.Text = "chart1";
      title1.Name = "title1";
      this.chart1.Titles.Add(title1);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.PowderBlue;
      this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(832, 530);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(129, 55);
      this.button1.TabIndex = 7;
      this.button1.Text = "REFRESH";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // guna2Elipse1
      // 
      this.guna2Elipse1.TargetControl = this;
      // 
      // ph_uc_dash
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.panel1);
      this.Name = "ph_uc_dash";
      this.Size = new System.Drawing.Size(1047, 678);
      this.Load += new System.EventHandler(this.ph_uc_dash_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Button button1;
    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
  }
}
