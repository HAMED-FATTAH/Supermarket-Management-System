using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hamedsmms.PL
{
    public partial class FORM_PURCHASE_MANGER : Form
    {
        BL.CLS_PURCHASE purchase = new BL.CLS_PURCHASE();

        public FORM_PURCHASE_MANGER()
        {
            InitializeComponent();
            this.DGV_PUR_MANGER.DataSource = purchase.GAT_purchase_Manger();

            button_delete.Enabled = false;
            button_print_selected.Enabled = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FORM_PURCHASE_BILL frm = new FORM_PURCHASE_BILL();
            frm.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete Product company ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                purchase.Delete_PUR_mang(Convert.ToInt32(this.DGV_PUR_MANGER.CurrentRow.Cells[0].Value));
                MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_PUR_MANGER.DataSource = purchase.GAT_purchase_Manger();
            }
            else
            {
                MessageBox.Show("Deletion canceled", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            button_delete.Enabled = false;
            button_print_selected.Enabled = false;
            button_add.Enabled = true;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DGV_PUR_MANGER_DoubleClick(object sender, EventArgs e)
        {
            button_delete.Enabled = true;
            button_print_selected.Enabled = true;
            button_add.Enabled = false;
        }

        private void button_print_selected_Click(object sender, EventArgs e)
        {
            button_delete.Enabled = false;
            button_print_selected.Enabled = false;
            button_add.Enabled = true;
        }

        private void FORM_PURCHASE_MANGER_Load(object sender, EventArgs e)
        {

        }

        
    }
}
