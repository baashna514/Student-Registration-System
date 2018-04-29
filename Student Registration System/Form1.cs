using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Main_Form1 : Form
    {
        public Main_Form1()
        {
            InitializeComponent();
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up su = new Sign_Up();
            su.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();

        }
    }
}
