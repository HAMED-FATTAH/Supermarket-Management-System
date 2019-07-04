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
    public partial class FORM_PRODUCTS_LIST : Form
    {
        BL.CLS_Product prd = new BL.CLS_Product();
        public FORM_PRODUCTS_LIST()
        {
            InitializeComponent();
            this.DGV_PRODUCTS.DataSource = prd.GET_ALL_PRODUCTS();
        }

        private void DGV_PRODUCTS_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
