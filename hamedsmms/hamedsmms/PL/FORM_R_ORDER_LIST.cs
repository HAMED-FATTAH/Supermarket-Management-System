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
    public partial class FORM_R_ORDER_LIST : Form
    {
        BL.CLS_RETURN_ORDER R_ORDER = new BL.CLS_RETURN_ORDER();
        public FORM_R_ORDER_LIST()
        {
            InitializeComponent();
            DGV_R_ORDER.DataSource = R_ORDER.GET_R_order();
        }

        private void FORM_R_ORDER_LIST_Load(object sender, EventArgs e)
        {

        }

        private void DGV_R_ORDER_DoubleClick(object sender, EventArgs e)
        {
            
            FORM_RETURN_ORDER.getmainform.txtorderid.Text = DGV_R_ORDER.CurrentRow.Cells[1].Value.ToString();
            FORM_RETURN_ORDER.getmainform.Barcode.Text = DGV_R_ORDER.CurrentRow.Cells[0].Value.ToString();
            FORM_RETURN_ORDER.getmainform.Product_name.Text = DGV_R_ORDER.CurrentRow.Cells[2].Value.ToString();
            FORM_RETURN_ORDER.getmainform.R_price.Text =DGV_R_ORDER.CurrentRow.Cells[3].Value.ToString();
            FORM_RETURN_ORDER.getmainform.Qte.Text =DGV_R_ORDER.CurrentRow.Cells[4].Value.ToString();
            FORM_RETURN_ORDER.getmainform.Dis.Text = DGV_R_ORDER.CurrentRow.Cells[5].Value.ToString();
            FORM_RETURN_ORDER.getmainform.T_Pric.Text = DGV_R_ORDER.CurrentRow.Cells[7].Value.ToString();

            this.Close();
            
        }
    }
        
    
    
}
