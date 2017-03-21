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
    public partial class frm_labbatchSheet : Form
    {
        public frm_labbatchSheet()
        {
            InitializeComponent();

            txt_product.Text = frm_welcome.product;
            String[] test_name;
            
            if (txt_product.Text == null)
            {
                dataGridView_test.Rows.Add("");
            }
            if(txt_product.Text.Equals("Isotrap Clear Gloss"))
            {                
                test_name = new String[] { "Viscocity", "Level","Wetting","Hezi","Yellowing","MEK-30","Tape Test","Recotting","Perfume","Color Change","Water","Density","Observation"};
                
                for (int i = 0; i < test_name.Length;i++ )
                {
                    dataGridView_test.Rows.Add(test_name[i],"","");
                    dataGridView_test.AllowUserToAddRows = false;
                }
            }
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker_lab.Format = DateTimePickerFormat.Custom;
            dateTimePicker_lab.CustomFormat = "dd MMMM, yyyy";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }

    }
}
