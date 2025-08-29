namespace Event_Management_System
{
    partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.lblregister = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Event_Management_System.Properties.Resources.signup;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Location = new System.Drawing.Point(-76, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 529);
            this.panel1.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Event_Management_System.Properties.Resources.backbtn;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.Color.Transparent;
            this.btnback.Location = new System.Drawing.Point(83, 15);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(43, 41);
            this.btnback.TabIndex = 0;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblregister
            // 
            this.lblregister.AutoSize = true;
            this.lblregister.BackColor = System.Drawing.Color.White;
            this.lblregister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregister.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblregister.Location = new System.Drawing.Point(348, 6);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(157, 31);
            this.lblregister.TabIndex = 1;
            this.lblregister.Text = "Register Now";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Event_Management_System.Properties.Resources.Untitled_design__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 515);
            this.Controls.Add(this.lblregister);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblregister;
        private System.Windows.Forms.Button btnback;
    }
}