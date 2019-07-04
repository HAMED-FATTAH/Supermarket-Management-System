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
    public partial class FORM_ADD_PRODUCT : Form
    {
        BL.CLS_PURCHASE clsspur = new BL.CLS_PURCHASE();
        BL.CLS_Product clsspro = new BL.CLS_Product();

        private static FORM_ADD_PRODUCT frm;                                          //  ......................[1]
       
        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frm = null;
        }

        public static FORM_ADD_PRODUCT getmainform                                          //  .................[3]
        {
            get
            {
                if (frm == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frm = new FORM_ADD_PRODUCT();                            // نقوم بانشاءه من جديد
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frm;
            }
        }

        public string state = "add";

        BL.CLS_Product prd = new BL.CLS_Product();

        public FORM_ADD_PRODUCT()
        {
            InitializeComponent();

            if (frm == null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frm = this;

            cmbCategories.DataSource = prd.GET_ALL_CATEGORIES();
            cmbCategories.DisplayMember = "CatName";
            cmbCategories.ValueMember = "CatID";

            cmbCategories.SelectedIndex = -1;
            labeladd.Visible = false;               // ل اخفاء ليبل حالة المنتج من الفرم
           
        }
        void clear()
        {
            txtRef.Clear();
            txtDes.Clear();
            txt_P_Price.Clear();
            txt_S_price.Clear();
            txtqte.Clear();
            cmbCategories.SelectedIndex = -1;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtRef.Text == string.Empty || txtDes.Text == string.Empty || txt_P_Price.Text == string.Empty
                || txt_S_price.Text == string.Empty || txtqte.Text == string.Empty||cmbCategories.Text==string.Empty)     
            {
                MessageBox.Show("Please Rewrite All Data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
           
                if (state == "add")
                {
                    prd.ADD_PRODUCTS(txtRef.Text, txtDes.Text, textDate.Value, txt_P_Price.Text, txt_S_price.Text, Convert.ToInt32(txtqte.Text), Convert.ToInt32(cmbCategories.SelectedValue));
                    clsspro.UPDATE_STATE(txtRef.Text, labeladd.Text, txtDes.Text);
                    MessageBox.Show("Successfully added", "Operation added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    clear();
                }
                else
                {
                    prd.Update_PRODUCTS(txtRef.Text, txtDes.Text, textDate.Value, txt_P_Price.Text, txt_S_price.Text, Convert.ToInt32(txtqte.Text), Convert.ToInt32(cmbCategories.SelectedValue));

                    clear();
                    cmbCategories.SelectedIndex = -1;

                    MessageBox.Show("Modified successfully", "Modification process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FORM_PRODUCTS.getmainform.btn_update.Enabled = false;
                    FORM_PRODUCTS.getmainform.btn_delete.Enabled = false;
                    FORM_PRODUCTS.getmainform.btn_print.Enabled = false;
                    FORM_PRODUCTS.getmainform.btn_add.Enabled = true;
                    
                }
                FORM_PRODUCTS.getmainform.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();    //This is for updating data of data greadview after processing add or update ...
                txtRef.Focus();     
        }

        

        private void txtRef_Validated(object sender, EventArgs e) // when exit from combox
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.VerifyProductID(txtRef.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("This identifier already exists ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
            
            FORM_PRODUCTS.getmainform.btn_update.Enabled = false;
            FORM_PRODUCTS.getmainform.btn_delete.Enabled = false;
            FORM_PRODUCTS.getmainform.btn_print.Enabled = false;
            FORM_PRODUCTS.getmainform.btn_add.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDes.Focus();
            }
        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textDate.Focus();
            }
        }

        private void textDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_P_Price.Focus();
            }
        }

        private void txt_P_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_S_price.Focus();
            }
        }

        private void txt_S_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtqte.Focus();
            }
        }

        private void txtqte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCategories.Focus();
            }
        }

        private void cmbCategories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PL.FORM_PURC_DATILS fm = new FORM_PURC_DATILS();
            fm.ShowDialog();
            if (fm.DGV_PUR_MANGER.CurrentRow.Cells[7].Value.ToString() != "Add")
            {
                //this.Close();
                txtRef.Text = fm.DGV_PUR_MANGER.CurrentRow.Cells[2].Value.ToString();
                txtDes.Text = fm.DGV_PUR_MANGER.CurrentRow.Cells[3].Value.ToString();
                txt_P_Price.Text = fm.DGV_PUR_MANGER.CurrentRow.Cells[4].Value.ToString();
                txtqte.Text = fm.DGV_PUR_MANGER.CurrentRow.Cells[5].Value.ToString();
                /*  }
                  else
                  {
               
                  }*/
                fm.Close();
            }
        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void FORM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }

    }
}
