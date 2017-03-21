using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ColorTech
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /*if(txt_username == null)
            {
                MessageBox.Show("Username cannot be Empty");
            }
            else if (txt_password == null)
            {
                MessageBox.Show("Password cannot be Empty");
            }*/
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Invalid entry");
            }
            else
            {
                try
                {
                    string connectionString = "Server=localhost;Database=colortechdb;Uid=root;Pwd='';"; //Set your MySQL connection string here.
                    string query = "select username,password from colortechdb.login where username = '" + this.txt_username.Text + "' AND password = '" + this.txt_password.Text + "' ;"; // set query to fetch data "Select * from  tabelname"; 
                    MySqlConnection con = new MySqlConnection(connectionString);

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    String strResult = String.Empty;
                    strResult = (String)cmd.ExecuteScalar();
                    con.Close();
                    if (strResult.Length != 0)
                    {
                        //this.Hide();
                        MessageBox.Show("Login Successful " + strResult);
                        frm_welcome welcome = new frm_welcome();
                        welcome.ShowDialog();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User Not Found");
                    }
                }
                catch
                {
                    MessageBox.Show("Login Error ");
                }
            }         
        }
    }
}
