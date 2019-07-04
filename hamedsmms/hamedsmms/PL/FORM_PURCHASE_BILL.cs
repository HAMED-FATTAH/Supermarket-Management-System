using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace hamedsmms.PL
{
    public partial class FORM_PURCHASE_BILL : Form
    {
        DataTable Dt = new DataTable();
        BL.CLS_PURCHASE purchase = new BL.CLS_PURCHASE();


        public FORM_PURCHASE_BILL()
        {
            InitializeComponent();
            text_SUP_id.Focus();
            CreateDataTable();
            labelstate.Visible = false;
            button_new.Enabled = false;
            text_bill_reset.Enabled = false; ;
            text_prd_name.Enabled = false;
            text_Total_Price.Enabled = false;
            text_prd_quantity.Enabled = false;
            text_barcode.Enabled = false;
            
            text_sales_man.Text = Program.SalesMan;
        }

        void ClearBoxes()
        {
            text_bill_reset.Clear();
            text_prd_name.Clear();
            text_Total_Price.Clear();
            text_prd_quantity.Clear();
            text_barcode.Clear();
            text_Pric_unit.Clear();
            text_prd_T_amount.Clear();

            text_bill_reset.Focus();
        }

        void CalculateAmount()
        {
            if (text_Total_Price.Text != string.Empty && text_prd_quantity.Text != string.Empty)
            {

                text_Pric_unit.Text = (Convert.ToDouble(text_Total_Price.Text) / Convert.ToInt32(text_prd_quantity.Text)).ToString();
                text_prd_T_amount.Text = text_Total_Price.Text;
            }
            else { text_Pric_unit.Text = string.Empty; }
        }

        void CreateDataTable()
        {
            Dt.Columns.Add("Bill Reset");
            Dt.Columns.Add("Barcode");
            Dt.Columns.Add("Product Name");
            Dt.Columns.Add("Total Price");
            Dt.Columns.Add("Quantity");
            Dt.Columns.Add("Price Unit");
            Dt.Columns.Add("Amount");

            this.DGV_PRD_BILL.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.supplier_list suplist = new supplier_list();

            suplist.ShowDialog();
            text_SUP_id.Text = suplist.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text_name.Text = suplist.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text_phone.Text = suplist.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text_address.Text = suplist.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            button_new.Enabled = true;
        }

        private void text_Total_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void text_Total_Price_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void text_prd_quantity_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
        }

        private void text_prd_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                for (int i = 0; i < DGV_PRD_BILL.Rows.Count - 1; i++)
                {
                    if (DGV_PRD_BILL.Rows[i].Cells[0].Value.ToString() == text_barcode.Text)
                    {
                        MessageBox.Show("Product Already Entered !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ClearBoxes();
                        return;
                    }
                }
                DataRow r = Dt.NewRow();
                r[0] = text_bill_reset.Text;
                r[1] = text_barcode.Text;
                r[2] = text_prd_name.Text;
                r[3] = text_Total_Price.Text;
                r[4] = text_prd_quantity.Text;
                r[5] = text_Pric_unit.Text;
                r[6] = text_prd_T_amount.Text;

                Dt.Rows.Add(r);

                DGV_PRD_BILL.DataSource = Dt;

                ClearBoxes();

                text_Sum_Total.Text =
                    (from DataGridViewRow row in DGV_PRD_BILL.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            this.text_order_id.Text = purchase.GET_LAST_PURCHASE_ID().Rows[0][0].ToString();
            button_new.Enabled = false;
            butto_add.Enabled = true;

            text_order_des.Text = "Bill from  " + text_name.Text;
            text_bill_reset.Enabled = true; ;
            text_prd_name.Enabled = true;
            text_Total_Price.Enabled = true;
            text_prd_quantity.Enabled = true;
            text_barcode.Enabled = true;
            text_bill_reset.Focus();
        }

        private void DGV_PRD_BILL_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                text_bill_reset.Text = this.DGV_PRD_BILL.CurrentRow.Cells[0].Value.ToString();
                text_barcode.Text = this.DGV_PRD_BILL.CurrentRow.Cells[1].Value.ToString();
                text_prd_name.Text = this.DGV_PRD_BILL.CurrentRow.Cells[2].Value.ToString();
                text_Total_Price.Text = this.DGV_PRD_BILL.CurrentRow.Cells[3].Value.ToString();
                text_prd_quantity.Text = this.DGV_PRD_BILL.CurrentRow.Cells[4].Value.ToString();
                text_Pric_unit.Text = this.DGV_PRD_BILL.CurrentRow.Cells[5].Value.ToString();
                text_prd_T_amount.Text = this.DGV_PRD_BILL.CurrentRow.Cells[6].Value.ToString();

                DGV_PRD_BILL.Rows.RemoveAt(DGV_PRD_BILL.CurrentRow.Index);
                text_prd_quantity.Focus();
            }
            catch { return; }
        }

        private void DGV_PRD_BILL_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            text_Sum_Total.Text =
                    (from DataGridViewRow row in DGV_PRD_BILL.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV_PRD_BILL_DoubleClick(sender, e);
        }

        private void deleteCurrentRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV_PRD_BILL.Rows.RemoveAt(DGV_PRD_BILL.CurrentRow.Index);
        }

        private void deleteTheAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            DGV_PRD_BILL.Refresh();
        }

        private void butto_add_Click(object sender, EventArgs e)
        {
            purchase.ADD_Purchase(Convert.ToInt32(text_order_id.Text), dt_order.Value, text_order_des.Text, Convert.ToInt32(text_SUP_id.Text), text_sales_man.Text);

            //اضافة المنتوجات المدخلة 
            for (int i = 0; i < DGV_PRD_BILL.Rows.Count - 1; i++)
            {
                purchase.ADD_ORDERS_DETAILS(Convert.ToInt32(text_order_id.Text),
                    DGV_PRD_BILL.Rows[i].Cells[0].Value.ToString(),
                    DGV_PRD_BILL.Rows[i].Cells[1].Value.ToString(),
                     DGV_PRD_BILL.Rows[i].Cells[2].Value.ToString(), 
                     DGV_PRD_BILL.Rows[i].Cells[3].Value.ToString(), 
                     Convert.ToInt32(DGV_PRD_BILL.CurrentRow.Cells[4].Value),
                     DGV_PRD_BILL.Rows[i].Cells[5].Value.ToString(),
                     labelstate.Text
                    , DGV_PRD_BILL.Rows[i].Cells[6].Value.ToString());
            }

            MessageBox.Show("Saved Successfully", "Save Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FORM_PURCHASE_BILL_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
        
    }
}
