using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "dd MMMM, yyyy";
            //dateTimePicker1.CustomFormat = "mm / dd / yy";
        }
        
        private void btn_mainBatch_Click(object sender, EventArgs e)
        {
            //panel_content.Hide();
            //panel_main.Show();            
            //this.panel_main.Location = new Point(13,88);
            
            //frm_batchSheet frm = new frm_batchSheet(); // Instantiate a Form3 object.
            //frm.Show(); // Show Form3 and
            //this.Close(); // closes the Form2 instance.
            
        }

        private void frm_welcome_Load(object sender, EventArgs e)
        {
            /*panel_content.Hide();
            panel_main.Hide();*/
            //grpbox_newEntrycontent.Hide();
        }

        private void btn_subBatch_Click(object sender, EventArgs e)
        {
            //panel_content.Hide();
            //panel_main.Show();
            //frm_batchSheet frm = new frm_batchSheet(); // Instantiate a Form3 object.
            //frm.Show(); // Show Form3 and
            //this.Close(); // closes the Form2 instance.          

        }

        private void btn_rawMaterial_Click(object sender, EventArgs e)
        {
            /*panel_main.Hide();
            this.panel_content.Location = new Point(13, 88);
            panel_content.Show();          
             */
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

        private void submit_newEntry_Click(object sender, EventArgs e)
        {

        }

        private void lbl_proNameSub_Click(object sender, EventArgs e)
        {

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
    }
}
