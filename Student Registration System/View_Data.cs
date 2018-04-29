using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyProject
{
    public partial class View_Data : Form
    {
        public View_Data()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("");
            //con.Open();
           // SqlDataAdapter sda = new SqlDataAdapter("",con);
           // DataTable dt = new DataTable();
           // sda.Fill(dt);
        }
    }
}
