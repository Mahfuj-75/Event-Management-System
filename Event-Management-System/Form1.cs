using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.CenterToScreen();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r= new Register();
            r.Show();
            this.Hide();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
