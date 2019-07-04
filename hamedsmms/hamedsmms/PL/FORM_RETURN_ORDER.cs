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
    public partial class FORM_RETURN_ORDER : Form
    {
        BL.CLS_RETURN_ORDER clssret = new BL.CLS_RETURN_ORDER();
       

        private static FORM_RETURN_ORDER frm;                                          //  ......................[1]

        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frm = null;
        }

        public static FORM_RETURN_ORDER getmainform                                          //  .................[3]
        {
            get
            {
                if (frm == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frm = new FORM_RETURN_ORDER();                            // نقوم بانشاءه من جديد
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frm;
            }
        }

        public string state = "add";
        public FORM_RETURN_ORDER()
        {
            InitializeComponent();

            if (frm == null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frm = this;

            txtretdone.Visible = false;
            labstate.Visible = false;
            btn_order_list.Enabled = false;
            btn_add.Enabled = false;
            

        }

        void Clear()
        {
            txtretId.Clear();
            txtorderid.Clear();
            txtorderid.Clear();
            Barcode.Clear();
            Product_name.Clear();
            R_price.Clear();
            Qte.Clear();
            Dis.Clear();
            T_Pric.Clear();
            Prog_User.Clear();
            Notes.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtretId.Text == string.Empty || txtretId.Text == string.Empty || Product_name.Text == string.Empty || R_price.Text == string.Empty 
                || Qte.Text == string.Empty || Dis.Text == string.Empty
                || T_Pric.Text == string.Empty || Prog_User.Text == string.Empty || Barcode.Text == string.Empty)
            {
                MessageBox.Show("Please Rewrite All Data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (state == "add")
            {
                clssret.ADD_RETURN_ORDER(Convert.ToInt32(txtretId.Text), Convert.ToInt32(txtorderid.Text), Product_name.Text,
                    R_price.Text, Convert.ToInt32(Qte.Text), Convert.ToInt32(Dis.Text), T_Pric.Text, dateTimePicker1.Value,
                    Prog_User.Text, labstate.Text, Notes.Text, Convert.ToInt32(Barcode.Text));
               // clsspro.UPDATE_STATE(txtRef.Text, labeladd.Text, txtDes.Text);
                MessageBox.Show("Successfully added", "Operation added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FORM_RETURN_MANAGEMENT.getmainform.DGV_RETURN_MANGE.DataSource = clssret.GET_RETURN_ORDER();
            }
            if (state=="update")
            {
                clssret.Update_RETURN_ORDER(Convert.ToInt32(txtretId.Text), Convert.ToInt32(txtorderid.Text), Product_name.Text,
                    R_price.Text, Convert.ToInt32(Qte.Text), Convert.ToInt32(Dis.Text), T_Pric.Text, dateTimePicker1.Value,
                    Prog_User.Text, labstate.Text, Notes.Text, Convert.ToInt32(Barcode.Text));
                    MessageBox.Show("Modified successfully", "Modification process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FORM_RETURN_MANAGEMENT.getmainform.DGV_RETURN_MANGE.DataSource = clssret.GET_RETURN_ORDER(); 
                    this.Close();
            }
            if (state == "Accept")
            {
                if (labstate.Text != txtretdone.Text)
                {
                    clssret.UpdateReturnQTE(Convert.ToInt32(Barcode.Text), Convert.ToInt32(Qte.Text));
                    clssret.UpdateReturn_Status(txtretdone.Text, Convert.ToInt32(txtretId.Text));
                    MessageBox.Show("Return successfully", "Returning process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FORM_RETURN_MANAGEMENT.getmainform.DGV_RETURN_MANGE.DataSource = clssret.GET_RETURN_ORDER();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This Products already Returned", "Return Products process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PL.FORM_R_ORDER_LIST R_order_list = new FORM_R_ORDER_LIST();
            R_order_list.ShowDialog();

            btn_order_list.Enabled = false;
            btn_add.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            txtretId.Text = clssret.MAX_R_ORDER_ID().Rows[0][0].ToString();
            btn_order_list.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
