using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using hamedsmms.BL;

namespace hamedsmms.PL
{
    public partial class supplier : Form
    {
        private static supplier frmsup;                                        //  ......................[1]

        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frmsup = null;
        }

        public static supplier getmainform                                          //  .................[3]
        {
            get
            {
                if (frmsup == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frmsup = new supplier();                            // نقوم بانشاءه من جديد
                    frmsup.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frmsup;
            }
        }

        BL.CLS_Supplier clsssup = new BL.CLS_Supplier();
        public string state = "Add";
      
        public supplier()
        {
            InitializeComponent();

            if (frmsup == null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frmsup = this;

            text_user_add.Text = Program.SalesMan;

            Cmb_company.DataSource = clsssup.GET_ALL_COMPANY();
            Cmb_company.DisplayMember = "CoName";
            Cmb_company.ValueMember = "CoName";

            butadd.Enabled = false;
            butnew.Enabled = true;
            butexit.Enabled = true;
            textsupName.Enabled = false;
            textSupphone.Enabled = false;
            textSupemail.Enabled = false;
            textSupaddress.Enabled = false;

            text_Sup_ID.Visible = false; //تجعل ال text  غير مرئى للمستخدم 
            

            Cmb_company.SelectedIndex = -1;
      
        }

        void clear()
        {
            DateSupplier.ResetText();
            text_Sup_ID.Clear();
            textsupName.Clear();
            textSupphone.Clear();
            textSupemail.Clear();
           
            textSupaddress.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                text_Sup_ID.Text = clsssup.SupMaxID().Rows[0][0].ToString();
                butadd.Enabled = true;
                butnew.Enabled = false;

                DateSupplier.ResetText();
                textsupName.Enabled = true;
                textSupphone.Enabled = true;
                textSupemail.Enabled = true;
                textSupaddress.Enabled = true;

                textsupName.Focus();
            
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            supplier supp = new supplier();

            if (state == "Add")
            {

                if (text_Sup_ID.Text == string.Empty || textsupName.Text == string.Empty || textSupphone.Text == string.Empty ||
                    Cmb_company.Text == string.Empty || textSupaddress.Text == string.Empty )
                {
                    MessageBox.Show("Rewrite all data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                clsssup.AddSupplier( textsupName.Text, textSupphone.Text, textSupemail.Text,
                    Cmb_company.Text, textSupaddress.Text, DateSupplier.Value, text_user_add.Text);
                MessageBox.Show("Add Supplier Done Successfuly", "SMMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                butadd.Enabled = false;
                butnew.Enabled = true;
                clear();
                textsupName.Enabled = false;
                textSupphone.Enabled = false;
                textSupemail.Enabled = false;
                textSupaddress.Enabled = false;
            }

            else
            {

                if (text_Sup_ID.Text == string.Empty || textsupName.Text == string.Empty || textSupphone.Text == string.Empty ||
                    Cmb_company.Text == string.Empty || textSupaddress.Text == string.Empty )
                {
                    MessageBox.Show("Rewrite all data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                clsssup.UpdateSupplier(Convert.ToInt32(text_Sup_ID.Text), textsupName.Text, textSupphone.Text, textSupemail.Text,
                    Cmb_company.Text, textSupaddress.Text, DateSupplier.Value, text_user_add.Text);
                MessageBox.Show("Edit Supplier Done Successfuly", "SMMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clear();
                this.Close();
                
            }
            supplier_management.getmainform.dataGridView1.DataSource = clsssup.GET_ALL_Supplier();
            
        }
    
        

        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_Sup_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text_user_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textSupphone.Focus();
            }
        }

        private void textSupphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textSupemail.Focus();
            }
        }

        private void textSupemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cmb_company.Focus();
            }
        }

        private void Cmb_company_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textSupaddress.Focus();
            }
        }

        private void textSupaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DateSupplier.Focus();
            }
        }

        private void DateSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butadd.Focus();
            }
        }

        private void supplier_Load(object sender, EventArgs e)
        {

        }

     
    }
}
