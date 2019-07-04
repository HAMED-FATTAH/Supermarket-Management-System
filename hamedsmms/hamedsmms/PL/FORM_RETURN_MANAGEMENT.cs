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
    public partial class FORM_RETURN_MANAGEMENT : Form
    {
        BL.CLS_RETURN_ORDER return_order = new BL.CLS_RETURN_ORDER();

        private static FORM_RETURN_MANAGEMENT frm;                                          //  ......................[1]

        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frm = null;
        }

        public static FORM_RETURN_MANAGEMENT getmainform                                          //  .................[3]
        {
            get
            {
                if (frm == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frm = new FORM_RETURN_MANAGEMENT();                            // نقوم بانشاءه من جديد
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frm;
            }
        }

        public FORM_RETURN_MANAGEMENT()
        {
            InitializeComponent();

            if (frm == null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frm = this;

            DGV_RETURN_MANGE.DataSource = return_order.GET_RETURN_ORDER();

            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_return_product.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete Product Place ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return_order.Delete_R_ORDER(Convert.ToInt32(this.DGV_RETURN_MANGE.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_RETURN_MANGE.DataSource = return_order.GET_RETURN_ORDER();
            }
            else
            {
                MessageBox.Show("Deletion canceled", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DGV_RETURN_MANGE.DataSource = return_order.GET_RETURN_ORDER();
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_return_product.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.FORM_RETURN_ORDER frm = new FORM_RETURN_ORDER();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.FORM_RETURN_ORDER fm = new FORM_RETURN_ORDER();

            fm.txtretId.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[0].Value.ToString();
            fm.txtorderid.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[1].Value.ToString();
            fm.Barcode.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[11].Value.ToString();
            fm.Product_name.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[2].Value.ToString();
            fm.R_price.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[3].Value.ToString();
            fm.Qte.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[4].Value.ToString();
            fm.Dis.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[5].Value.ToString();
            fm.T_Pric.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[6].Value.ToString();
            fm.Prog_User.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[8].Value.ToString();
            fm.Notes.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[10].Value.ToString();
            fm.Text = "Return Update:" + this.DGV_RETURN_MANGE.CurrentRow.Cells[1].Value.ToString();
            fm.btn_add.Text = "Update";
            fm.state = "update";
            fm.txtretId.ReadOnly = true;
            fm.btn_add.Enabled = true;
            fm.btn_new.Visible = false;
            fm.btn_order_list.Visible = false;
            fm.ShowDialog();
            DGV_RETURN_MANGE.DataSource = return_order.GET_RETURN_ORDER();
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_return_product.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                   PL.FORM_RETURN_ORDER fm = new FORM_RETURN_ORDER();
       
                    fm.txtretId.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[0].Value.ToString();
                    fm.txtorderid.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[1].Value.ToString();
                    fm.Barcode.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[11].Value.ToString();
                    fm.Product_name.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[2].Value.ToString();
                    fm.R_price.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[3].Value.ToString();
                    fm.Qte.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[4].Value.ToString();
                    fm.Dis.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[5].Value.ToString();
                    fm.T_Pric.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[6].Value.ToString();
                    fm.Prog_User.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[8].Value.ToString();
                    fm.Notes.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[10].Value.ToString();
                    fm.labstate.Text = this.DGV_RETURN_MANGE.CurrentRow.Cells[9].Value.ToString();
                    fm.Text = "Return Update:" + this.DGV_RETURN_MANGE.CurrentRow.Cells[2].Value.ToString();
                    fm.btn_add.Text = "Accept";
                    fm.state = "Accept";
                    fm.txtretId.ReadOnly = true;
                    fm.btn_add.Enabled = true;
                    fm.btn_new.Visible = false;
                    fm.btn_order_list.Visible = false;
                    fm.ShowDialog();

                    btn_delete.Enabled = false;
                    btn_edit.Enabled = false;
                    btn_return_product.Enabled = false;
        }

        private void FORM_RETURN_MANAGEMENT_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_RETURN_MANGE_DoubleClick(object sender, EventArgs e)
        {
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            btn_return_product.Enabled = true;
        }
    }
}
