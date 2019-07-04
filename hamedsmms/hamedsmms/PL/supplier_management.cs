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
    public partial class supplier_management : Form
    {
       
        private static supplier_management frm;                                          //  ......................[1]

        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frm = null;
        }

        public static supplier_management getmainform                                          //  .................[3]
        {
            get
            {
                if (frm == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frm = new supplier_management();                            // نقوم بانشاءه من جديد
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frm;
            }
        }

        BL.CLS_Supplier claSup = new BL.CLS_Supplier();
        public supplier_management()
        {
            InitializeComponent();

            if (frm == null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frm = this;

            
            this.dataGridView1.DataSource = claSup.GET_ALL_Supplier();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            supplier Sup = new supplier();

            Sup.butadd.Enabled = true;
            Sup.butnew.Visible = false;
            Sup.textsupName.Enabled = true;
            Sup.textSupphone.Enabled = true;
            Sup.textSupemail.Enabled = true;
            Sup.textSupaddress.Enabled = true;

            Sup.text_Sup_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Sup.textsupName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Sup.textSupphone.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Sup.textSupemail.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();  
            Sup.textSupaddress.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString(); 
            Sup.text_user_add.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Sup.Text = "Supplier Update:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Sup.butadd.Text = "Update";
            Sup.state = "update";
            Sup.ShowDialog();

            Sup.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selected supplier?", "Deletion process", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                claSup.Deletesupplier(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

                MessageBox.Show("Successfully deleted", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = claSup.GET_ALL_Supplier();
            }
            else
            {
                MessageBox.Show("Deletion canceled", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplier suplier = new supplier();
            suplier.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = claSup.SeachSupplier(text_Search.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
