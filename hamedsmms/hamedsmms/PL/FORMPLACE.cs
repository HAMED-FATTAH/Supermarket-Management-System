using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace hamedsmms.PL
{
    public partial class FORMPLACE : Form
    {
        
        BL.CLS_PLACE clasplace = new BL.CLS_PLACE();
        public FORMPLACE()
        {
            InitializeComponent();

            this.DGV_Places_list.DataSource = clasplace.GET_ALL_Places();

            comproducts.DataSource = clasplace.GET_ALL_PRODUCTS();
            comproducts.DisplayMember = "Product ID";
            comproducts.ValueMember = "Barcode";

            comproducts.SelectedIndex = -1;
            button_Delete.Enabled = false;
            button_Update.Enabled = false;
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (comproducts.Text == string.Empty || comflours.Text == string.Empty || comstands.Text == string.Empty ||
                complaces.Text == string.Empty)
            {
                MessageBox.Show("Enter all data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                clasplace.ADD_place(Convert.ToInt32(comproducts.Text), comflours.Text, comstands.Text, complaces.Text);
                MessageBox.Show("Successfully added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_Places_list.DataSource = clasplace.GET_ALL_Places();

            }
            comflours.SelectedIndex = -1;
            comstands.SelectedIndex = -1;
            comproducts.SelectedIndex = -1;
            complaces.SelectedIndex = -1;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (comproducts.Text == string.Empty || comflours.Text == string.Empty || comstands.Text == string.Empty ||
                complaces.Text == string.Empty)
            {
                MessageBox.Show("Enter all data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                clasplace.Update_Places(Convert.ToInt32(comproducts.Text), comflours.Text, comstands.Text, complaces.Text);
                MessageBox.Show("Successfully updated ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_Places_list.DataSource = clasplace.GET_ALL_Places();

            }

            comflours.SelectedIndex = -1;
            comstands.SelectedIndex = -1;
            comproducts.SelectedIndex = -1;
            complaces.SelectedIndex = -1;
            button_add.Enabled = true;
            button_Delete.Enabled = false;
            button_Update.Enabled = false;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete Product Place ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clasplace.Delete_Places(Convert.ToInt32(comproducts.Text));
                MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Successfully deleted", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_Places_list.DataSource = clasplace.GET_ALL_Places();
            }
            else
            {
                MessageBox.Show("Deletion canceled", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            comflours.SelectedIndex = -1;
            comstands.SelectedIndex = -1;
            comproducts.SelectedIndex = -1;
            complaces.SelectedIndex = -1;
            button_add.Enabled = true;
        }

        private void DGV_Places_list_DoubleClick(object sender, EventArgs e)
        {
            this.comproducts.Text = DGV_Places_list.CurrentRow.Cells[0].Value.ToString();
            this.comflours.Text = DGV_Places_list.CurrentRow.Cells[1].Value.ToString();
            this.comstands.Text = DGV_Places_list.CurrentRow.Cells[2].Value.ToString();
            this.complaces.Text = DGV_Places_list.CurrentRow.Cells[3].Value.ToString();
            button_Delete.Enabled = true;
            button_Update.Enabled = true;
        }

        private void DGV_Places_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FORMPLACE_Load(object sender, EventArgs e)
        {

        }

        private void comproducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comproducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comflours.Focus();
            }
        }

        private void comflours_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comstands.Focus();
            }
        }

        private void comstands_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                complaces.Focus();
            }
        }

        private void complaces_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_add.Focus();
            }
        }
    }
}
