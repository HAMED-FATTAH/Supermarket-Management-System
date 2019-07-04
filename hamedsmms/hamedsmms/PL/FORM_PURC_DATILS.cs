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
    public partial class FORM_PURC_DATILS : Form
    {
        BL.CLS_PURCHASE clsspur = new BL.CLS_PURCHASE();


        public FORM_PURC_DATILS()
        {
            InitializeComponent();
            DGV_PUR_MANGER.DataSource = clsspur.GAT_purchase_Details();
        }

        private void DGV_PUR_MANGER_DoubleClick(object sender, EventArgs e)
        {
           
            if (this.DGV_PUR_MANGER.CurrentRow.Cells[7].Value.ToString() == "Add")
            {
                MessageBox.Show("This Product Is Add Before", "SMMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Close();
        }
 
    }
}
