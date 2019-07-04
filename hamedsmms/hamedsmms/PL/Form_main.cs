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
    public partial class Form_main : Form
    {
        //Single Instance

        private static Form_main frm;     //بخلى ال form كلها تتعامل مع بعض كانها one form         .......[1]

        // الاجراء اللى لمابستدعية بيهدم بناء الfrm 
        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frm = null;
        }

        public static Form_main getmainform                                             //  .................[3]
        {
            get
            {
                if (frm == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frm = new Form_main();                            // نقوم بانشاءه من جديد
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frm;
            }
        }

                      /*....................................................................*/

        public Form_main()
        {
            InitializeComponent();

            if(frm==null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frm=this;

            this.productsToolStripMenuItem.Enabled = false;
            this.customersToolStripMenuItem.Enabled = false;
            this.userToolStripMenuItem.Enabled = false;
            this.createABackupToolStripMenuItem.Enabled = false;
            this.restoreABackupToolStripMenuItem.Enabled = false;
            this.supplierToolStripMenuItem.Enabled = false;
            this.signOutToolStripMenuItem.Enabled = false;
            this.bills.Enabled = false;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void customerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_CUSTOMERS frm = new FORM_CUSTOMERS();
            frm.ShowDialog();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
           
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.ShowDialog();
        }

        private void createABackupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addANewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_PRODUCT frm = new FORM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_PRODUCTS frm = new FORM_PRODUCTS();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addNewSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier frm = new supplier();
            frm.ShowDialog();
        }

        private void suppliersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier_management frmsupman = new supplier_management();
            frmsupman.ShowDialog();
        }

        private void addANewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_main.getmainform.productsToolStripMenuItem.Enabled = false;
            Form_main.getmainform.customersToolStripMenuItem.Enabled = false;
            Form_main.getmainform.userToolStripMenuItem.Enabled = false;
            Form_main.getmainform.createABackupToolStripMenuItem.Enabled = false;
            Form_main.getmainform.restoreABackupToolStripMenuItem.Enabled = false;
            Form_main.getmainform.supplierToolStripMenuItem.Enabled = false;
            Form_main.getmainform.loginToolStripMenuItem.Enabled = true;
            Form_main.getmainform.signOutToolStripMenuItem.Enabled = false;
            Form_main.getmainform.bills.Enabled = false;
            MessageBox.Show("SignOut Done Succsfully" , "SMMS");
        }

        private void sellsPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_CATEGORIES frm = new FORM_CATEGORIES();
            frm.ShowDialog();
        }

        private void addNewSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ORDER frm = new FORM_ORDER();
            frm.ShowDialog();
        }

        private void campaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void campaniesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void campaniesManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FORM_COMPANY frm = new FORM_COMPANY();
            frm.ShowDialog();
        }

        private void placesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMPLACE frm = new FORMPLACE();
            frm.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_USER frm = new FORM_USER();
            frm.ShowDialog();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_USER_MANAGEMENT frm = new FORM_USER_MANAGEMENT();
            frm.ShowDialog();
        }

        private void purchasesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_PURCHASE_MANGER frm = new FORM_PURCHASE_MANGER();
            frm.ShowDialog();
        }

        private void addNewPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_PURCHASE_BILL frm = new FORM_PURCHASE_BILL();
            frm.ShowDialog();
        }

        private void slesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sale_management form = new sale_management();
            form.ShowDialog();
        }

       
        private void addReturnBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_RETURN_ORDER frm = new FORM_RETURN_ORDER();
            frm.ShowDialog();
        }

        private void returnBillManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_RETURN_MANAGEMENT frm = new FORM_RETURN_MANAGEMENT();
            frm.ShowDialog();
        }
    }
}
