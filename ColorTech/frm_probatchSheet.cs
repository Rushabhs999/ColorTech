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
    public partial class frm_probatchSheet : Form
    {
        private DataGridView DataGridView1 = new DataGridView();
        public string titleText;
       // public event DataGridViewEditingControlShowingEventHandler dataGridView1_EditingControlShowing;
        public frm_probatchSheet()
        {
            InitializeComponent();
            //grp_batchAllDetails.Font = new Font("Arial", 12, FontStyle.Regular);

            titleText = dataGridView1.Columns[1].HeaderText;
           // MessageBox.Show(titleText);

            
            /*dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Sr No";
            dataGridView1.Columns[1].Name = "Item";
            dataGridView1.Columns[2].Name = "Quantity";
            dataGridView1.Columns[3].Name = "M.R.No.";
            dataGridView1.Columns[4].Name = "Input Time";
            dataGridView1.Columns[5].Name = "Charged By";
            */
            dataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);



            //For Combo Box -- Drop Down List
            /*
             * DataGridViewComboBoxColumn cc = new DataGridViewComboBoxColumn();
            cc.Name = "Combo";
            cc.Items.AddRange(new string[] { "Product 1", "Product 2", "Product 3", "Product 4", "Product 5" });
            this.dataGridView1.Columns.Add(cc); 
            */

            //string[] row = new string[] { "1", "Product 1", "1000" ,"123","10","XYZ"};
            //dataGridView1.Rows.Add(row);

            txt_product.Text = frm_welcome.product;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the balance column whenever the value of any cell changes.
            UpdateValue();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Update the balance column whenever rows are deleted.
            UpdateValue();
        }

        private void UpdateValue()
        {
            //Displaying  data gridview values
            String srNo,item,quantity,mrno,ipTime,charged;

            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    srNo = dataGridView1.Rows[i - 1].Cells["Column1"].Value.ToString();
                    item = dataGridView1.Rows[i - 1].Cells["Column2"].Value.ToString();
                    quantity = dataGridView1.Rows[i - 1].Cells["Column3"].Value.ToString(); 
                    mrno = dataGridView1.Rows[i - 1].Cells["Column4"].Value.ToString(); 
                    ipTime = dataGridView1.Rows[i - 1].Cells["Column5"].Value.ToString(); 
                    charged = dataGridView1.Rows[i - 1].Cells["Column6"].Value.ToString();


                    MessageBox.Show(srNo + " " + item + " " + quantity + " " + mrno + " " + ipTime + " " + charged);

                    Console.WriteLine(srNo + "" + item + "" + quantity + "" + mrno + "" + ipTime + "" + charged);
                }
                catch(Exception e)
                {
                    MessageBox.Show("Table Values cannot be Empty");
                }
            }
          

            
        }


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
           /* ComboBox box = e.Control as ComboBox;
            if (box != null)
            {
                box.DropDownStyle = ComboBoxStyle.DropDown;
                box.AutoCompleteSource = AutoCompleteSource.ListItems;
                box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }*/
            
            
            if (titleText.Equals("Item"))
            {
                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    //AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    //addItems(DataCollection);                    
                    //autoText.AutoCompleteCustomSource = DataCollection;

                    autoText.AutoCompleteCustomSource.AddRange(new string[] { "Product 1", "Product 2", "Product 3", "Product 4", "Product 5" });
                }

                else
                    autoText.AutoCompleteCustomSource = null;
            }
            

        }
        public void addItems(AutoCompleteStringCollection col)
        {
            col.AddRange(new string[] { "Product 1", "Product 2", "Product 3", "Product 4", "Product 5" });
            /*col.Add("Product 1");
            col.Add("Product 2");
            col.Add("Product 3");
            col.Add("Product 4");
            col.Add("Product 5");
            col.Add("Product 6");*/
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

        private void grp_batchAllDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click_1(object sender, EventArgs e)
        {
            //DataGridView1.CellValueChanged += new DataGridViewCellEventHandler(DataGridView1_CellValueChanged);
            //DataGridView1.RowsRemoved += new DataGridViewRowsRemovedEventHandler(DataGridView1_RowsRemoved);
            //DataGridView1.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView1_EditingControlShowing);
            UpdateValue();
        }

        private void tbl_batchDetails_Paint(object sender, PaintEventArgs e)
        {

        }
 
    }
}
