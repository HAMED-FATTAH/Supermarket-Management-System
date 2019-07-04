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
    public partial class sale_management : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        public sale_management()
        {
            InitializeComponent();
            DGV_SALE_MANGER.DataSource = order.GET_Order();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete Product company ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                order.Delete_ORDER_mang(Convert.ToInt32(this.DGV_SALE_MANGER.CurrentRow.Cells[0].Value));
                MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_SALE_MANGER.DataSource = order.GET_Order();
            }
            else
            {
                MessageBox.Show("Deletion canceled", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            PL.FORM_ORDER frm = new FORM_ORDER();
            frm.ShowDialog();
        }

    }
}
