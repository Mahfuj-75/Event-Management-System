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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.CenterToScreen();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 f= new Form1();
            f.Show();
            this.Hide();
        }

       
    }
}
