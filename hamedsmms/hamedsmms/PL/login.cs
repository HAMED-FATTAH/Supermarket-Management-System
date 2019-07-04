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
    public partial class login : Form
    {
        BL.CLS_login log = new BL.CLS_login();
        
        public login()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUN.Text == string.Empty || txtPWD.Text == string.Empty)
            {
                MessageBox.Show("Please Rewrite user name or password!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable Dt = log.LOGIN(txtUN.Text, txtPWD.Text);
            if (Dt.Rows.Count > 0)
            {
                if (Dt.Rows[0][5].ToString() == "Manager")
                {
                    Form_main.getmainform.productsToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.customersToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.userToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.createABackupToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.restoreABackupToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.supplierToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.loginToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.signOutToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.bills.Enabled = true;
                    MessageBox.Show("Welcome " + Dt.Rows[0][1].ToString());
                    Program.SalesMan = Dt.Rows[0]["UserFullName"].ToString();
                    this.Close();


                }
                else if (Dt.Rows[0][5].ToString() == "The Data Officer")
                {
                    Form_main.getmainform.productsToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.customersToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.userToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.createABackupToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.restoreABackupToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.supplierToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.loginToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.signOutToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.bills.Enabled = false;
                    MessageBox.Show("Welcome " + Dt.Rows[0][1].ToString());
                    Program.SalesMan = Dt.Rows[0]["UserFullName"].ToString();
                    this.Close();


                }
                else if (Dt.Rows[0][5].ToString() == "Casher")
                {
                    Form_main.getmainform.productsToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.customersToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.userToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.createABackupToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.restoreABackupToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.supplierToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.loginToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.signOutToolStripMenuItem.Enabled = true;
                    Form_main.getmainform.bills.Enabled = true;
                    Form_main.getmainform.addNewPurchaseToolStripMenuItem.Enabled = false;
                    Form_main.getmainform.purchasesManagementToolStripMenuItem.Enabled = false;
                    
                    MessageBox.Show("Welcome " + Dt.Rows[0][1].ToString());
                    Program.SalesMan = Dt.Rows[0]["UserFullName"].ToString();
                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("false");
            }
        }

        private void txtUN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.Focus();
            }
        }
    }
}
