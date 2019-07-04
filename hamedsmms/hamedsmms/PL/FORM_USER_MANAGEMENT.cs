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
    public partial class FORM_USER_MANAGEMENT : Form
    {
        private static FORM_USER_MANAGEMENT frm;                                          //  ......................[1]

        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frm = null;
        }

        public static FORM_USER_MANAGEMENT getmainform                                          //  .................[3]
        {
            get
            {
                if (frm == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frm = new FORM_USER_MANAGEMENT();                            // نقوم بانشاءه من جديد
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frm;
            }
        }

        BL.CLS_USER ClaUser = new BL.CLS_USER();

        public FORM_USER_MANAGEMENT()
        {
            InitializeComponent();

            if (frm == null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frm = this;

            this.DGV_user.DataSource = ClaUser.GET_ALL_USER();

            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_add_user.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = ClaUser.SeachUsers(txtsearch.Text);
            this.DGV_user.DataSource = Dt;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FORM_USER frm = new FORM_USER();
            frm.btn_add.Text = "Saved User";
            frm.ShowDialog();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            FORM_USER frm = new FORM_USER();
            frm.text_id_user.Text = this.DGV_user.CurrentRow.Cells[0].Value.ToString();
            frm.text_name_user.Text = this.DGV_user.CurrentRow.Cells[1].Value.ToString();
            frm.text_Fname_user.Text = this.DGV_user.CurrentRow.Cells[3].Value.ToString();
            frm.text_PW_user.Text = this.DGV_user.CurrentRow.Cells[2].Value.ToString();
            frm.text_PH_user.Text = this.DGV_user.CurrentRow.Cells[5].Value.ToString();
            frm.com_Position_user.Text = this.DGV_user.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "User Update:" + this.DGV_user.CurrentRow.Cells[1].Value.ToString();
            frm.btn_add.Text = "Update";
            frm.state = "update";
            frm.text_id_user.ReadOnly = true;
            frm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this User ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClaUser.DELETE_USER(Convert.ToInt32(this.DGV_user.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_user.DataSource = ClaUser.GET_ALL_USER();
            }
            else
            {
                MessageBox.Show("Deletion canceled", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DGV_user.DataSource = ClaUser.GET_ALL_USER();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_add_user.Enabled = true;
        }

        private void DGV_user_DoubleClick(object sender, EventArgs e)
        {
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            
        }
    }
}
