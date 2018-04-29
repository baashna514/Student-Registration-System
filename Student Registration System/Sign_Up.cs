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
    public partial class Sign_Up : Form
    {

        


        public Sign_Up()
        {
            InitializeComponent();
        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\moina\Documents\Sign_Up_Form.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"); 
            SqlDataAdapter sda = new SqlDataAdapter("insert into Sign_up (User_Name,Password,Email) Values ('" + txt_UserName.Text + "','" + txt_Password.Text + "','" + txt_Email.Text+ "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //if (dt.Rows[0][0].ToString() == "1")
            //{
                //MessageBox.Show("Successfully Submitted..!!");
                this.Hide();
                Login login = new Login();
                login.Show();

                
            //}
            //else
            //{
                //MessageBox.Show("Alredy Exist..!!");
            //}
           

        }
    }
}
