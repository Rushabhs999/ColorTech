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
        public frm_welcome()
        {
            InitializeComponent();

            panel_options.Font = new Font("Arial", 12, FontStyle.Regular);

            //this.ActiveControl = frm_welcome;
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "dd MMMM, yyyy";
            //dateTimePicker1.CustomFormat = "mm / dd / yy";
        }
        
        private void btn_mainBatch_Click(object sender, EventArgs e)
        {
            panel_content.Hide();
            frm_batchSheet frm = new frm_batchSheet(); // Instantiate a Form3 object.
            frm.Show(); // Show Form3 and
            //this.Close(); // closes the Form2 instance.
            
        }

        private void frm_welcome_Load(object sender, EventArgs e)
        {
            panel_content.Hide();
            //grpbox_newEntrycontent.Hide();
        }

        private void btn_subBatch_Click(object sender, EventArgs e)
        {
            panel_content.Hide();
            frm_batchSheet frm = new frm_batchSheet(); // Instantiate a Form3 object.
            frm.Show(); // Show Form3 and
            //this.Close(); // closes the Form2 instance.
            

        }

        private void btn_rawMaterial_Click(object sender, EventArgs e)
        {
            panel_content.Show();          
        }
    }
}
