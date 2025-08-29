namespace Event_Management_System
{
    partial class Form1
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
            this.picBoxLogin = new System.Windows.Forms.PictureBox();
            this.logpanel = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblAcc = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblforgot = new System.Windows.Forms.Label();
            this.linksignup = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.picBoxPass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLogin
            // 
            this.picBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogin.BackgroundImage = global::Event_Management_System.Properties.Resources._5087727;
            this.picBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLogin.Location = new System.Drawing.Point(513, 51);
            this.picBoxLogin.Name = "picBoxLogin";
            this.picBoxLogin.Size = new System.Drawing.Size(164, 145);
            this.picBoxLogin.TabIndex = 1;
            this.picBoxLogin.TabStop = false;
            this.picBoxLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logpanel
            // 
            this.logpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logpanel.BackgroundImage = global::Event_Management_System.Properties.Resources.logBack;
            this.logpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logpanel.Location = new System.Drawing.Point(343, -2);
            this.logpanel.Name = "logpanel";
            this.logpanel.Size = new System.Drawing.Size(10, 537);
            this.logpanel.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(489, 275);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 31);
            this.txtUsername.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(489, 339);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '•';
            this.txtpass.Size = new System.Drawing.Size(230, 31);
            this.txtpass.TabIndex = 3;
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.BackColor = System.Drawing.Color.Transparent;
            this.lblAcc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcc.Location = new System.Drawing.Point(509, 218);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(188, 23);
            this.lblAcc.TabIndex = 6;
            this.lblAcc.Text = "Login to your Account";
            // 
            // btnlogin
            // 
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(489, 401);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(83, 34);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // lblforgot
            // 
            this.lblforgot.AutoSize = true;
            this.lblforgot.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgot.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblforgot.Location = new System.Drawing.Point(602, 410);
            this.lblforgot.Name = "lblforgot";
            this.lblforgot.Size = new System.Drawing.Size(117, 17);
            this.lblforgot.TabIndex = 8;
            this.lblforgot.Text = "Forgot password?";
            // 
            // linksignup
            // 
            this.linksignup.AutoSize = true;
            this.linksignup.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksignup.Location = new System.Drawing.Point(495, 459);
            this.linksignup.Name = "linksignup";
            this.linksignup.Size = new System.Drawing.Size(202, 17);
            this.linksignup.TabIndex = 9;
            this.linksignup.TabStop = true;
            this.linksignup.Text = "Don\'t have an Account? sign Up";
            this.linksignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksignup_LinkClicked);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 136);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(236, 49);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome To,";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.BackColor = System.Drawing.Color.Transparent;
            this.lblevent.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevent.Location = new System.Drawing.Point(13, 224);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(329, 92);
            this.lblevent.TabIndex = 11;
            this.lblevent.Text = "Event Management\r\nSystem\r\n";
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackgroundImage = global::Event_Management_System.Properties.Resources.usernameicon;
            this.picBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxUser.Location = new System.Drawing.Point(434, 275);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(31, 31);
            this.picBoxUser.TabIndex = 12;
            this.picBoxUser.TabStop = false;
            // 
            // picBoxPass
            // 
            this.picBoxPass.BackgroundImage = global::Event_Management_System.Properties.Resources.passIcon;
            this.picBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxPass.Location = new System.Drawing.Point(434, 340);
            this.picBoxPass.Name = "picBoxPass";
            this.picBoxPass.Size = new System.Drawing.Size(31, 31);
            this.picBoxPass.TabIndex = 13;
            this.picBoxPass.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Event_Management_System.Properties.Resources.eventBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 530);
            this.Controls.Add(this.picBoxPass);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.linksignup);
            this.Controls.Add(this.lblforgot);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picBoxLogin);
            this.Controls.Add(this.logpanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logpanel;
        private System.Windows.Forms.PictureBox picBoxLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblforgot;
        private System.Windows.Forms.LinkLabel linksignup;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.PictureBox picBoxPass;
    }
}

