namespace Fyp_Proj
{
    partial class Login
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
            this.att = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // att
            // 
            this.att.BackColor = System.Drawing.Color.White;
            this.att.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.att.ForeColor = System.Drawing.Color.Black;
            this.att.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.att.Location = new System.Drawing.Point(154, 208);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(75, 23);
            this.att.TabIndex = 6;
            this.att.Text = "Attendance";
            this.att.UseVisualStyleBackColor = false;
            // 
            // Label5
            // 
            this.Label5.AutoEllipsis = true;
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label5.Location = new System.Drawing.Point(221, 68);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(103, 16);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Login to System";
            // 
            // Label4
            // 
            this.Label4.AutoEllipsis = true;
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label4.Font = new System.Drawing.Font("Impact", 15.75F);
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label4.Location = new System.Drawing.Point(147, 32);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(266, 26);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "RFID Student Tracking System";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(302, 116);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Login As";
            // 
            // cb1
            // 
            this.cb1.ForeColor = System.Drawing.Color.Black;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Staff",
            "Faculty",
            "Student",
            "Administrator"});
            this.cb1.Location = new System.Drawing.Point(370, 108);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(100, 21);
            this.cb1.TabIndex = 3;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.White;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button2.Location = new System.Drawing.Point(395, 208);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Exit";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.White;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signin.ForeColor = System.Drawing.Color.Black;
            this.signin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.signin.Location = new System.Drawing.Point(275, 208);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(75, 23);
            this.signin.TabIndex = 4;
            this.signin.Text = "SignIn";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(81, 153);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(79, 116);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Username";
            // 
            // pass
            // 
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.Location = new System.Drawing.Point(154, 146);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 2;
            this.pass.UseSystemPasswordChar = true;
            // 
            // un
            // 
            this.un.ForeColor = System.Drawing.Color.Black;
            this.un.Location = new System.Drawing.Point(154, 109);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(100, 20);
            this.un.TabIndex = 1;
            this.un.TextChanged += new System.EventHandler(this.un_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "2D Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.att);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.un);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Deactivate += new System.EventHandler(this.Login_Deactivate);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Activated += new System.EventHandler(this.Login_Activated_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button att;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cb1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button signin;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button button1;
    }
}

