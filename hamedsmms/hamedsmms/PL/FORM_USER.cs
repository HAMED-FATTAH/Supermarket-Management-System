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
    public partial class FORM_USER : Form
    {
        private static FORM_USER frm;                                          //  ......................[1]

        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frm = null;
        }

        public static FORM_USER getmainform                                          //  .................[3]
        {
            get
            {
                if (frm == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frm = new FORM_USER();                            // نقوم بانشاءه من جديد
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frm;
            }
        }

        BL.CLS_USER clauser = new BL.CLS_USER();
        public string state = "Add";

        public FORM_USER()
        {
            InitializeComponent();

            if (frm == null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frm = this;
        }

        void clear()
        {
            dateTimePicker1.ResetText();
            text_id_user.Clear();
            text_name_user.Clear();
            text_PW_user.Clear();
            text_Fname_user.Clear();
            text_PH_user.Clear();
            com_Position_user.SelectedIndex = -1;
        }


        private void FORM_USER_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                Close();
            }
            else
            {
                Close();
                FORM_USER_MANAGEMENT.getmainform.btn_add_user.Enabled = true;
                FORM_USER_MANAGEMENT.getmainform.btn_delete.Enabled = false;
                FORM_USER_MANAGEMENT.getmainform.btn_update.Enabled = false;

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (state == "Add")
            {

                if (text_id_user.Text == string.Empty || text_name_user.Text == string.Empty || text_Fname_user.Text == string.Empty ||
                    text_PW_user.Text == string.Empty || text_PH_user.Text == string.Empty || com_Position_user.Text == string.Empty)
                {
                    MessageBox.Show("Rewrite all data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                clauser.AddUser(Convert.ToInt32(text_id_user.Text), text_name_user.Text,
                    text_PW_user.Text, text_Fname_user.Text, dateTimePicker1.Value, com_Position_user.Text, Convert.ToInt32(text_PH_user.Text));
                MessageBox.Show("Add User Done Successfuly", "SMMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clear();
            }

            else
            {
                if (text_id_user.Text == string.Empty || text_name_user.Text == string.Empty || text_Fname_user.Text == string.Empty ||
                    text_PW_user.Text == string.Empty || text_PH_user.Text == string.Empty || com_Position_user.Text == string.Empty)
                {
                    MessageBox.Show("Rewrite all data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                clauser.Update_User(Convert.ToInt32(text_id_user.Text), text_name_user.Text,
                    text_PW_user.Text, text_Fname_user.Text, dateTimePicker1.Value, com_Position_user.Text, Convert.ToInt32(text_PH_user.Text));
                MessageBox.Show("EDIT User Successfuly", "SMMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FORM_USER_MANAGEMENT.getmainform.btn_add_user.Enabled = true;
                FORM_USER_MANAGEMENT.getmainform.btn_delete.Enabled = false;
                FORM_USER_MANAGEMENT.getmainform.btn_update.Enabled = false;
                clear();
                this.Close();
            }
            FORM_USER_MANAGEMENT.getmainform.DGV_user.DataSource = clauser.GET_ALL_USER();



        }

        private void text_id_user_Validated(object sender, EventArgs e)
        {
            if (state == "Add")
            {
                DataTable Dt = new DataTable();
                Dt = clauser.VerifyUserID(text_id_user.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("This identifier already exists ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text_id_user.Focus();
                    text_id_user.SelectionStart = 0;
                    text_id_user.SelectionLength = text_id_user.TextLength;
                }
            }
        }

        private void text_id_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_name_user.Focus();
            }
        }

        private void text_name_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_Fname_user.Focus();
            }
        }

        private void text_Fname_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_PW_user.Focus();
            }
        }

        private void text_PW_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_PH_user.Focus();
            }

        }

        private void text_PH_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                com_Position_user.Focus();
            }
        }

        private void com_Position_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }
        }
    }
}
