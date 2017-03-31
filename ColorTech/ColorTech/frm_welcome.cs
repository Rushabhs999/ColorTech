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
    public partial class frm_welcome : Form
    {
        public static string product;
        public frm_welcome()
        {
            InitializeComponent();

            //tab_welcomeScreen.Font = new Font("Arial", 10, FontStyle.Regular);            
        }

        private void frm_welcome_Load(object sender, EventArgs e)
        {
            load_proMainHead();
            load_proSubHead();
            load_proMasterHead();
        }


        private void submit_productMain_Click(object sender, EventArgs e)
        {
            try
            {
                product = combo_proNameMain.SelectedItem.ToString();
                //MessageBox.Show(product + " is selected");
                frm_probatchSheet pro_frm = new frm_probatchSheet();
                pro_frm.Show();

                //frm_labbatchSheet lab_frm = new frm_labbatchSheet();
                //lab_frm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Null is selected");
            }            
        }

        private void submit_productSub_Click(object sender, EventArgs e)
        {
            try
            {
                product = combo_proNameSub.SelectedItem.ToString();
                //MessageBox.Show(product + " is selected");
                //frm_probatchSheet pro_frm = new frm_probatchSheet();
                //pro_frm.Show();
                //this.Hide();
                frm_labbatchSheet lab_frm = new frm_labbatchSheet();
                lab_frm.ShowDialog();
                //this.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Null is selected");
            } 
        }
        
        private void submit_productMaster_Click(object sender, EventArgs e)
        {
            try
            {
                product = combo_proNameMain.SelectedItem.ToString();
                //MessageBox.Show(product + " is selected");
                frm_probatchSheet pro_frm = new frm_probatchSheet();
                pro_frm.Show();

                //frm_labbatchSheet lab_frm = new frm_labbatchSheet();
                //lab_frm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Null is selected");
            } 
        }

        private void combo_proHeadMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_proMainName();
        }

        private void combo_proHeadSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_proSubName();
        }

        private void combo_proHeadMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_proMasterName();
        }

        public void load_proMainHead()
        {
            try
            {
                string connectionString = "Server=localhost;Database=colortechdb;Uid=root;Pwd='';";
                string query_proHead = "SELECT DISTINCT(`product_head`) from `product` GROUP BY `product_head`";

                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlDataReader dr = new MySqlCommand(query_proHead, con).ExecuteReader();
                while (dr.Read())
                {
                    combo_proHeadMain.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();

                con.Close();

            }
            catch (MySqlException my)
            {
                MessageBox.Show(" Error Loading Employee Names " + my.Message);
            }
        }

        public void load_proSubHead()
        {
            try
            {
                string connectionString = "Server=localhost;Database=colortechdb;Uid=root;Pwd='';";
                string query_proHead = "SELECT DISTINCT(`product_head`) from `product` GROUP BY `product_head`";

                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlDataReader dr = new MySqlCommand(query_proHead, con).ExecuteReader();
                while (dr.Read())
                {
                    combo_proHeadSub.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();

                con.Close();

            }
            catch (MySqlException my)
            {
                MessageBox.Show(" Error Loading Employee Names " + my.Message);
            }
        }


        public void load_proMasterHead()
        {
            try
            {
                string connectionString = "Server=localhost;Database=colortechdb;Uid=root;Pwd='';";
                string query_proHead = "SELECT DISTINCT(`product_head`) from `product` GROUP BY `product_head`";

                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlDataReader dr = new MySqlCommand(query_proHead, con).ExecuteReader();
                while (dr.Read())
                {
                    combo_proHeadMaster.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();

                con.Close();

            }
            catch (MySqlException my)
            {
                MessageBox.Show(" Error Loading Employee Names " + my.Message);
            }
        }
        public void load_proMainName()
        {
            combo_proNameMain.Items.Clear();
            String proHead = combo_proHeadMain.SelectedItem.ToString();

            try
            {
                string connectionString = "Server=localhost;Database=colortechdb;Uid=root;Pwd='';";
                string query_proHead = "SELECT `product_name` FROM `product` WHERE `product_head` = '" + proHead + "'";
                
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlDataReader dr = new MySqlCommand(query_proHead, con).ExecuteReader();
                while (dr.Read())
                {
                    combo_proNameMain.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();

                con.Close();
            }
            catch (MySqlException my)
            {
                MessageBox.Show(" Error Loading Employee Names " + my.Message);
            }

        }

        public void load_proSubName()
        {
            combo_proNameSub.Items.Clear();
            String proHead = combo_proHeadSub.SelectedItem.ToString();

            try
            {
                string connectionString = "Server=localhost;Database=colortechdb;Uid=root;Pwd='';";
                string query_proHead = "SELECT `product_name` FROM `product` WHERE `product_head` = '" + proHead + "'";

                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlDataReader dr = new MySqlCommand(query_proHead, con).ExecuteReader();
                while (dr.Read())
                {
                    combo_proNameSub.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();

                con.Close();
            }
            catch (MySqlException my)
            {
                MessageBox.Show(" Error Loading Employee Names " + my.Message);
            }

        }

        public void load_proMasterName()
        {
            combo_proNameMaster.Items.Clear();
            String proHead = combo_proHeadMaster.SelectedItem.ToString();

            try
            {
                string connectionString = "Server=localhost;Database=colortechdb;Uid=root;Pwd='';";
                string query_proHead = "SELECT `product_name` FROM `product` WHERE `product_head` = '" + proHead + "'";

                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlDataReader dr = new MySqlCommand(query_proHead, con).ExecuteReader();
                while (dr.Read())
                {
                    combo_proNameMaster.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();

                con.Close();
            }
            catch (MySqlException my)
            {
                MessageBox.Show(" Error Loading Employee Names " + my.Message);
            }

        }
        
        private void submit_newEntry_Click(object sender, EventArgs e)
        {

        }

        private void lbl_proNameSub_Click(object sender, EventArgs e)
        {

        }

        private void btn_mainBatch_Click(object sender, EventArgs e)
        {
        }

        private void btn_subBatch_Click(object sender, EventArgs e)
        {
        }

        private void btn_rawMaterial_Click(object sender, EventArgs e)
        {
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "dd MMMM, yyyy";
            //dateTimePicker1.CustomFormat = "mm / dd / yy";
        }

    }
}
