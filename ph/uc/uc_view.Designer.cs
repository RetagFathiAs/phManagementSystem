namespace ph
{
  partial class uc_view
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
      this.View = new System.Windows.Forms.Label();
      this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.pharmacyDataSet = new ph.pharmacyDataSet();
      this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.usersTableAdapter = new ph.pharmacyDataSetTableAdapters.usersTableAdapter();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // View
      // 
      this.View.AutoSize = true;
      this.View.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.View.Location = new System.Drawing.Point(51, 34);
      this.View.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.View.Name = "View";
      this.View.Size = new System.Drawing.Size(90, 45);
      this.View.TabIndex = 1;
      this.View.Text = "View";
      // 
      // guna2Elipse1
      // 
      this.guna2Elipse1.TargetControl = this;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(3, 212);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(702, 177);
      this.dataGridView1.TabIndex = 2;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(213, 161);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(218, 20);
      this.textBox1.TabIndex = 3;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // pharmacyDataSet
      // 
      this.pharmacyDataSet.DataSetName = "pharmacyDataSet";
      this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // usersBindingSource
      // 
      this.usersBindingSource.DataMember = "users";
      this.usersBindingSource.DataSource = this.pharmacyDataSet;
      // 
      // usersTableAdapter
      // 
      this.usersTableAdapter.ClearBeforeFill = true;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.PowderBlue;
      this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(620, 34);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(85, 37);
      this.button1.TabIndex = 6;
      this.button1.Text = "REFRESH";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // uc_view
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.View);
      this.Name = "uc_view";
      this.Size = new System.Drawing.Size(771, 494);
      this.Load += new System.EventHandler(this.uc_view_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label View;
    private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource usersBindingSource;
    private pharmacyDataSet pharmacyDataSet;
    private pharmacyDataSetTableAdapters.usersTableAdapter usersTableAdapter;
    private System.Windows.Forms.Button button1;
  }
}
