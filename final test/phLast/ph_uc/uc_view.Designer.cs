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
      this.View.Location = new System.Drawing.Point(68, 42);
      this.View.Name = "View";
      this.View.Size = new System.Drawing.Size(112, 56);
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
      this.dataGridView1.Location = new System.Drawing.Point(149, 257);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.Size = new System.Drawing.Size(733, 218);
      this.dataGridView1.TabIndex = 2;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(284, 198);
      this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(289, 22);
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
      this.button1.Location = new System.Drawing.Point(827, 42);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(113, 46);
      this.button1.TabIndex = 6;
      this.button1.Text = "REFRESH";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // uc_view
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.View);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "uc_view";
      this.Size = new System.Drawing.Size(1028, 608);
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
