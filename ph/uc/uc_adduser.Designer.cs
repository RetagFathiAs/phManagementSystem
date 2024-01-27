namespace ph.uc
{
    partial class uc_adduser
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
            this.DashBoard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rolcombo = new System.Windows.Forms.ComboBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.mobiletxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.birthcombo = new System.Windows.Forms.ComboBox();
            this.signbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DashBoard
            // 
            this.DashBoard.AutoSize = true;
            this.DashBoard.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.Location = new System.Drawing.Point(51, 35);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Size = new System.Drawing.Size(241, 67);
            this.DashBoard.TabIndex = 1;
            this.DashBoard.Text = "Add User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(604, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(604, 314);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(151, 40);
            this.Username.TabIndex = 7;
            this.Username.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(604, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 40);
            this.label7.TabIndex = 8;
            this.label7.Text = "Password";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // rolcombo
            // 
            this.rolcombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rolcombo.FormattingEnabled = true;
            this.rolcombo.Items.AddRange(new object[] {
            "Pharmacist.",
            "Adminstrator."});
            this.rolcombo.Location = new System.Drawing.Point(99, 220);
            this.rolcombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rolcombo.Name = "rolcombo";
            this.rolcombo.Size = new System.Drawing.Size(448, 40);
            this.rolcombo.TabIndex = 9;
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(99, 358);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(448, 40);
            this.nametxt.TabIndex = 10;
            // 
            // mobiletxt
            // 
            this.mobiletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobiletxt.Location = new System.Drawing.Point(99, 683);
            this.mobiletxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mobiletxt.Name = "mobiletxt";
            this.mobiletxt.Size = new System.Drawing.Size(448, 40);
            this.mobiletxt.TabIndex = 11;
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(612, 220);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(448, 40);
            this.emailtxt.TabIndex = 12;
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(612, 358);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(448, 40);
            this.usertxt.TabIndex = 13;
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(612, 520);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '#';
            this.passtxt.Size = new System.Drawing.Size(448, 40);
            this.passtxt.TabIndex = 14;
            // 
            // birthcombo
            // 
            this.birthcombo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.birthcombo.FormattingEnabled = true;
            this.birthcombo.Location = new System.Drawing.Point(99, 520);
            this.birthcombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birthcombo.Name = "birthcombo";
            this.birthcombo.Size = new System.Drawing.Size(448, 40);
            this.birthcombo.TabIndex = 15;
            // 
            // signbtn
            // 
            this.signbtn.BackColor = System.Drawing.Color.Bisque;
            this.signbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.signbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.signbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signbtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signbtn.Location = new System.Drawing.Point(640, 603);
            this.signbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signbtn.Name = "signbtn";
            this.signbtn.Size = new System.Drawing.Size(153, 62);
            this.signbtn.TabIndex = 16;
            this.signbtn.Text = "Sign In";
            this.signbtn.UseVisualStyleBackColor = false;
            this.signbtn.Click += new System.EventHandler(this.signbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Bisque;
            this.resetbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(840, 603);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(146, 62);
            this.resetbtn.TabIndex = 17;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(572, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 566);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1067, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // uc_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.signbtn);
            this.Controls.Add(this.birthcombo);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.mobiletxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.rolcombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DashBoard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_adduser";
            this.Size = new System.Drawing.Size(1156, 760);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DashBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ComboBox rolcombo;
        private System.Windows.Forms.ComboBox birthcombo;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox mobiletxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button signbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
