using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace hamedsmms.PL
{
    public partial class Attend : Form
    {
        BL.ClassWorkTime CLS_WT = new BL.ClassWorkTime();
        public Attend()
        {
            InitializeComponent();
            labstateAttend.Enabled = false;
            labStateDepart.Enabled = false;
            timer1.Start();
            setdata();
        }

        void setdata()
        {
            DGVTimeWork.DataSource = CLS_WT.GET_ALL_Attend();
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < DGVTimeWork.Rows.Count - 1; i++)
                {
                    if (DGVTimeWork.Rows[i].Cells[0].Value.ToString() == txtUserID.Text 
                        && DGVTimeWork.Rows[i].Cells[6].Value.ToString() == labstateAttend.Text)
                    {
                        foreach (DataGridViewRow Row in DGVTimeWork.Rows)
                        {
                            CLS_WT.UpdateDerartTime(DTPDepart.Value, Convert.ToInt32(txtUserID.Text));
                            CLS_WT.UpdateAttenState(labStateDepart.Text, Convert.ToInt32(txtUserID.Text));
                        }

                        setdata();
                        txtUserID.Clear();
                        txtUserName.Clear();
                        txtUserType.Clear();
                        return;
                    }
                }

                CLS_WT.InsertWorkTime(Convert.ToInt32(txtUserID.Text), txtUserName.Text,txtUserType.Text, DTPAttend.Value, DTPDepart.Value,DTPPeriod.Value, labstateAttend.Text);
                setdata();
                txtUserID.Clear();
                txtUserName.Clear();
                txtUserType.Clear();
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            if (txtUserID.Text != string.Empty)
            {
                DataTable DT = new DataTable();
                DT = CLS_WT.GetUser_data(Convert.ToInt32(txtUserID.Text));

                if (DT.Rows.Count > 0)
                {

                    txtUserID.Text = DT.Rows[0][0].ToString();
                    txtUserName.Text = DT.Rows[0][1].ToString();
                    txtUserType.Text = DT.Rows[0][2].ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DTPAttend.Value = DateTime.Now;
            DTPDepart.Value = DateTime.Now;
            DTPPeriod.Value = DateTime.Now;
        }

        
    }
}
