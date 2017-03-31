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
    public partial class frm_labbatchSheet : Form
    {
        public frm_labbatchSheet()
        {
            InitializeComponent();

            txt_product.Text = frm_welcome.product;
            String[] test_name;
            dataGridView_item.Rows.Count.Equals(0);
            dataGridView_test.Rows.Count.Equals(0);
            

            if (txt_product.Text == null)
            {
                dataGridView_test.Rows.Add("");
            }
            else if(txt_product.Text.Equals("Isotrap Clear Gloss"))
            {                
                test_name = new String[] { "Viscocity", "Level","Wetting","Hezi","Yellowing","MEK-30","Tape Test","Recotting","Perfume","Color Change","Water","Density","Observation"};
                
                for (int i = 0; i < test_name.Length;i++ )
                {
                    dataGridView_test.Rows.Add(test_name[i],"","");
                    dataGridView_test.AllowUserToAddRows = false;
                }
            }

            else if (txt_product.Text.Equals("Clear Gloss"))
            {
                test_name = new String[] { "Viscocity", "Level", "Wetting", "Hezi", "Yellowing", "MEK-30", "Tape Test", "Recotting", "Perfume", "Color Change", "Water", "Density", "Observation" };

                for (int i = 0; i < test_name.Length; i++)
                {
                    dataGridView_test.Rows.Add(test_name[i], "", "");
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

        private void dataGridView_item_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the balance column whenever the value of any cell changes.
            //UpdateValue();
            //AutoNumberRowsForGridView(dataGridView_item);
            
        }

        private void dataGridView_item_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Update the balance column whenever rows are deleted.
            //UpdateValue();
            //AutoNumberRowsForGridView(dataGridView_item);
        }
    
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {              

                MySqlConnection connect = new MySqlConnection("Server=localhost;Database=colortechdb;Uid=root;Pwd='';");
                connect.Open();
                MessageBox.Show("Row Count " + dataGridView_test.Rows.Count);
                for (int i = 0; i < dataGridView_test.Rows.Count; i++)
                {
                    dataGridView_test.AllowUserToAddRows = false;
                    
                    //dataGridView_item.Rows[i].Cells["Column4"].Value = dateTimePicker2_lab.ToString();//DateTime.Now.ToString("hh:mm:ss tt");
                    try
                    {
                      int quantity =  Convert.ToInt32(dataGridView_item.Rows[i].Cells["Column3"].Value); 
                        if(quantity != 0)
                        {
                            string query = @"INSERT INTO colortechdb.item_details (sr_no,raw_material,quantity,input_time,charged_by) VALUES ('"
                                + dataGridView_item.Rows[i].Cells["Column1"].Value + "','"
                                + dataGridView_item.Rows[i].Cells["Column2"].Value + "','"
                                + dataGridView_item.Rows[i].Cells["Column3"].Value + "','"
                                + dataGridView_item.Rows[i].Cells["Column4"].Value + "','"
                                + dataGridView_item.Rows[i].Cells["Column5"].Value + "');";

                            MySqlCommand cmd = new MySqlCommand(query, connect);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data Inserted Successful ");    
                        }
                        else
                        {
                            MessageBox.Show("Quantity Entered should be number only");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Enter Quantity in Number only");
                    }                  
                    
                }
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Error "+ex.ToString());
            }
        }       

    }
}
