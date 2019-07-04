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
    public partial class FORM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMER cust = new BL.CLS_CUSTOMER();
        public FORM_CUSTOMERS_LIST()
        {
            InitializeComponent();

            this.DGV_Customers.DataSource = cust.GET_ALL_CUSTOMERS();

            this.DGV_Customers.Columns[0].Visible = false;
            this.DGV_Customers.Columns[6].Visible = false;
            //this.DGV_Customers.Rows[0].Visible = false;
        }

        private void DGV_Customers_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void DGV_Customers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

  
    }
}
