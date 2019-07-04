using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace hamedsmms.PL
{
    public partial class FORM_COMPANY : Form
    {
        public string state = "add";
        //SqlConnection aqlcon = new SqlConnection("Data Source=DESKTOP-SUFKOGM;Initial Catalog=SMMS;Integrated Security=True");
        BL.CLS_COMPANY comp = new BL.CLS_COMPANY();
        public FORM_COMPANY()
        {
            InitializeComponent();

            comproducts.DataSource = comp.GET_ALL_PRODUCTS();
            comproducts.DisplayMember = "Product ID";
            comproducts.ValueMember = "Barcode";

            text_cam_name.Enabled = false;
            text_cam_address.Enabled = false;
            text_cam_phone.Enabled = false;

            comproducts.SelectedIndex = -1;
            button_add.Enabled = false;
            button_Update.Enabled = false;
            button_Delete.Enabled = false;

            this.DGV_Company_list.DataSource = comp.GET_ALL_COMPANY();
            
        }
        private void Clear()
        {
             text_cam_name.Clear();
             text_cam_address.Clear();
             text_cam_phone.Clear();
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            if (comproducts.Text ==string.Empty|| text_cam_name.Text == string.Empty || text_cam_phone.Text == string.Empty || text_cam_address.Text == string.Empty)
            {
                MessageBox.Show("Rewrite all data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                comp.ADD_COMPANY(Convert.ToInt32(comproducts.Text), text_cam_name.Text, text_cam_phone.Text, text_cam_address.Text);
                MessageBox.Show("Successfully added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_Company_list.DataSource = comp.GET_ALL_COMPANY();
            }
             comproducts.SelectedIndex = -1;
             this.Clear();

             text_cam_name.Enabled = false;
             text_cam_address.Enabled = false;
             text_cam_phone.Enabled = false;
            
        }

       

        private void DGV_Company_list_DoubleClick_1(object sender, EventArgs e)
        {
            this.comproducts.Text = DGV_Company_list.CurrentRow.Cells[0].Value.ToString();
            this.text_cam_name.Text = DGV_Company_list.CurrentRow.Cells[1].Value.ToString();
            this.text_cam_phone.Text = DGV_Company_list.CurrentRow.Cells[2].Value.ToString();
            this.text_cam_address.Text = DGV_Company_list.CurrentRow.Cells[3].Value.ToString();

            text_cam_name.Enabled = true;
            text_cam_address.Enabled = true;
            text_cam_phone.Enabled = true;
            button_Update.Enabled = true;
            button_Delete.Enabled = true;
            button_add.Enabled = false;
        }

        private void button_Update_Click_1(object sender, EventArgs e)
        {
            if (comproducts.Text ==string.Empty|| text_cam_name.Text == string.Empty || text_cam_phone.Text == string.Empty || text_cam_address.Text == string.Empty)
            {
                MessageBox.Show("Rewrite all data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                comp.EDIT_COMPANY(Convert.ToInt32(comproducts.Text), text_cam_name.Text, text_cam_phone.Text, text_cam_address.Text);
                MessageBox.Show("Successfully Edit", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_Company_list.DataSource = comp.GET_ALL_COMPANY();
            }
            comproducts.SelectedIndex = -1;
            text_cam_name.Enabled = false;
            text_cam_address.Enabled = false;
            text_cam_phone.Enabled = false;
            button_new.Enabled = true;
            this.Clear();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            text_cam_name.Enabled = true;
            text_cam_address.Enabled = true;
            text_cam_phone.Enabled = true;
            button_add.Enabled = true;
            button_Update.Enabled = false;
            button_Delete.Enabled = false;
            button_new.Enabled = false;
            text_cam_name.Focus();
            
        }

        private void comproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void FORM_COMPANY_Load(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you really want to delete Product company ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comp.Delete_company(Convert.ToInt32(comproducts.Text));
                MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_Company_list.DataSource = comp.GET_ALL_COMPANY();
            }
            else
            {
                MessageBox.Show("Deletion canceled", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
              comproducts.SelectedIndex = -1;
              text_cam_name.Enabled = false;
              text_cam_address.Enabled = false;
              text_cam_phone.Enabled = false;
              this.Clear();
        }

        private void DGV_Company_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_cam_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_cam_phone.Focus();
            }
        }

        private void text_cam_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_cam_address.Focus();
            }
        }

        private void text_cam_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comproducts.Focus();
            }
        }

        private void comproducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_add.Focus();
            }
        }


    }
}
