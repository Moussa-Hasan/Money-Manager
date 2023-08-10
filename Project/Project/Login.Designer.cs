namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.iconMin = new System.Windows.Forms.PictureBox();
            this.iconExit = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegiter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbShowPass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRegistrationMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            this.SuspendLayout();
            // 
            // iconMin
            // 
            this.iconMin.Image = ((System.Drawing.Image)(resources.GetObject("iconMin.Image")));
            this.iconMin.Location = new System.Drawing.Point(770, 18);
            this.iconMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconMin.Name = "iconMin";
            this.iconMin.Size = new System.Drawing.Size(30, 31);
            this.iconMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMin.TabIndex = 10;
            this.iconMin.TabStop = false;
            this.iconMin.Click += new System.EventHandler(this.iconMin_Click);
            // 
            // iconExit
            // 
            this.iconExit.Image = ((System.Drawing.Image)(resources.GetObject("iconExit.Image")));
            this.iconExit.Location = new System.Drawing.Point(808, 18);
            this.iconExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(30, 31);
            this.iconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExit.TabIndex = 8;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(134, 525);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(598, 72);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(132, 359);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(598, 65);
            this.txtPassword.TabIndex = 13;
            // 
            // btnRegiter
            // 
            this.btnRegiter.BackColor = System.Drawing.Color.White;
            this.btnRegiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegiter.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold);
            this.btnRegiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.btnRegiter.Location = new System.Drawing.Point(132, 774);
            this.btnRegiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegiter.Name = "btnRegiter";
            this.btnRegiter.Size = new System.Drawing.Size(598, 68);
            this.btnRegiter.TabIndex = 14;
            this.btnRegiter.Text = "Register";
            this.btnRegiter.UseVisualStyleBackColor = false;
            this.btnRegiter.Click += new System.EventHandler(this.btnRegiter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(124, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 52);
            this.label1.TabIndex = 15;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 21F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(124, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 52);
            this.label2.TabIndex = 16;
            this.label2.Text = "password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(132, 215);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(598, 65);
            this.txtUsername.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(122, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 69);
            this.label3.TabIndex = 17;
            this.label3.Text = "Login";
            // 
            // chbShowPass
            // 
            this.chbShowPass.AutoSize = true;
            this.chbShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbShowPass.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold);
            this.chbShowPass.ForeColor = System.Drawing.Color.Silver;
            this.chbShowPass.Location = new System.Drawing.Point(471, 430);
            this.chbShowPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbShowPass.Name = "chbShowPass";
            this.chbShowPass.Size = new System.Drawing.Size(246, 41);
            this.chbShowPass.TabIndex = 18;
            this.chbShowPass.Text = "Show Password";
            this.chbShowPass.UseVisualStyleBackColor = true;
            this.chbShowPass.CheckedChanged += new System.EventHandler(this.chbShowPass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(302, 723);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dont have an account?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegistrationMessage
            // 
            this.lblRegistrationMessage.BackColor = System.Drawing.Color.White;
            this.lblRegistrationMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRegistrationMessage.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold);
            this.lblRegistrationMessage.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistrationMessage.Location = new System.Drawing.Point(134, 626);
            this.lblRegistrationMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRegistrationMessage.Multiline = true;
            this.lblRegistrationMessage.Name = "lblRegistrationMessage";
            this.lblRegistrationMessage.Size = new System.Drawing.Size(598, 65);
            this.lblRegistrationMessage.TabIndex = 21;
            this.lblRegistrationMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 889);
            this.Controls.Add(this.lblRegistrationMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbShowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegiter);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.iconMin);
            this.Controls.Add(this.iconExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconMin;
        private System.Windows.Forms.PictureBox iconExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbShowPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblRegistrationMessage;
    }
}