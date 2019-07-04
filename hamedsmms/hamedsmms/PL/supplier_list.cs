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
    public partial class supplier_list : Form
    {
        BL.CLS_Supplier claSup = new BL.CLS_Supplier();
        public supplier_list()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = claSup.GET_ALL_Supplier();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            
        }

    }
}
