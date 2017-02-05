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
    public partial class frm_batchSheet : Form
    {        
        public frm_batchSheet()
        {
            InitializeComponent();
           // lbl_product.Font = new Font("Arial", 12, FontStyle.Regular);
            grp_batchAllDetails.Font = new Font("Arial", 12, FontStyle.Regular);
            //frm_batchSheet.Font = new Font("Arial", 12, FontStyle.Regular);
            
        }
        
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            /*
            string[] row = { txt_product.Text,txt_batchNo.Text,txt_customer.Text };
            var listViewItem = new ListViewItem();
            listViewItem.SubItems.Add("1");
            listViewItem.SubItems.Add("2");
            listViewItem.SubItems.Add("3");
            lst_item.Items.Add(listViewItem);
            */
            /*ListViewItem item = new ListViewItem();
            item.Text = "Column A";
            lst_item.Items.Add(item);
            */


        }
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM, yyyy";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_packingMaterial_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
