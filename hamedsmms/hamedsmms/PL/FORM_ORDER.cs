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
    public partial class FORM_ORDER : Form
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        PL.FORM_PRODUCTS_LIST P_list = new FORM_PRODUCTS_LIST();
        DataTable Dt = new DataTable();

        void CalculateAmount()
        {
            if (text_prd_price.Text != string.Empty && text_prd_quantity.Text != string.Empty)
            {

                text_prd_amount.Text = (Convert.ToDouble(text_prd_price.Text) * Convert.ToInt32(text_prd_quantity.Text)).ToString();
            }
            else { text_prd_amount.Text = string.Empty; }
        }

        void CalculateTotalAmount()
        {
            if (text_prd_discounit.Text != string.Empty && text_prd_amount.Text != string.Empty)
            {
                double Discount = Convert.ToDouble(text_prd_discounit.Text);
                double Amount = Convert.ToDouble(text_prd_amount.Text);
                double TotalAmount = Amount - (Amount * (Discount / 100));

                text_prd_T_amount.Text = TotalAmount.ToString();
            }
            else { text_prd_T_amount.Text = string.Empty; }
        }

       /* void CalculateShortingQte()
        {
            foreach (DataGridViewRow Row in P_list.DGV_PRODUCTS.Rows)
            {
                double x=Convert.ToDouble(Row.Cells[5].Value);
                double y=Convert.ToDouble(text_prd_quantity.Text);
            //    double z=x*
                if(y<20)
                {
                   MessageBox.Show("Successfully", "Save Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }*/

        void ClearBoxes()
        {
            text_prd_id.Clear();
            text_prd_name.Clear();
            text_prd_price.Clear();
            text_prd_quantity.Clear();
            text_prd_amount.Clear();
            text_prd_discounit.Clear();
            text_prd_T_amount.Clear();
            text_prd_id.Focus();
        }

        void ClearData()
        {
            text_order_id.Clear();
            text_order_des.Clear();
            dt_order.ResetText();
            text_cust_id.Clear();
            text_Cust_name.Clear();
            text_phone.Clear();
            text_address.Clear();
            text_Sum_Total.Clear();
            Dt.Clear();
            ClearBoxes();
            DGV_PRD_BILL.DataSource = null;
            pbox.Image = null;
            button_new.Enabled = false;
            radioButton_public.Enabled = true;
            radioButton_special.Enabled = true;
            button_Product.Enabled = false;
            text_prd_id.Enabled = false;

        }

        void ShowData()
        {
            Dt.Columns.Add("Product ID");
            Dt.Columns.Add("Product Name");
            Dt.Columns.Add("Price");
            Dt.Columns.Add("Quantity");
            Dt.Columns.Add("Amount");
            Dt.Columns.Add("Dscounit(%)");
            Dt.Columns.Add("Total Amount");

            DGV_PRD_BILL.DataSource = Dt;
        }

        /*void ResizeDGV()
        {
            this.DGV_PRD_BILL.RowHeadersWidth = 95;
            
            this.DGV_PRD_BILL.Columns[0].Width = 135;
           /* this.DGV_PRD_BILL.Columns[1].Width = 179;
            this.DGV_PRD_BILL.Columns[2].Width = 143;
            this.DGV_PRD_BILL.Columns[3].Width = 117;
            this.DGV_PRD_BILL.Columns[4].Width = 138;
            this.DGV_PRD_BILL.Columns[5].Width = 129;
            this.DGV_PRD_BILL.Columns[6].Width = 144;

        }*/


        public FORM_ORDER()
        {
            InitializeComponent();

            ShowData();
            
            button_new.Enabled = false;
            radioButton_public.Enabled = true;
            radioButton_special.Enabled = true;
            button_Product.Enabled = false;
            text_prd_id.Enabled = false;

            
            // ResizeDGV();
            text_sales_man.Text = Program.SalesMan;
        }

        private void FORM_ORDER_Load(object sender, EventArgs e)
        {
            radioButton_public.Focus();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.text_order_id.Text = order.GET_LAST_BILL_ID().Rows[0][0].ToString();
            button_new.Enabled = false;
            butto_add.Enabled = true;
            button_Product.Enabled = true;
            text_order_des.Text = "Bill TO " + text_Cust_name.Text;
            text_prd_id.Enabled = true;
            text_prd_id.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //اضافة معلومات الفتورة 
                order.ADD_ORDERS(Convert.ToInt32(text_order_id.Text), dt_order.Value, text_order_des.Text, Convert.ToInt32(text_cust_id.Text), text_sales_man.Text);

                //اضافة المنتوجات المدخلة 
                for (int i = 0; i < DGV_PRD_BILL.Rows.Count - 1; i++)
                {
                    order.ADD_ORDERS_DETAILS(DGV_PRD_BILL.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(text_order_id.Text)
                        , DGV_PRD_BILL.Rows[i].Cells[1].Value.ToString(), DGV_PRD_BILL.Rows[i].Cells[2].Value.ToString()
                        , Convert.ToInt32(DGV_PRD_BILL.CurrentRow.Cells[3].Value), Convert.ToInt32(DGV_PRD_BILL.Rows[i].Cells[5].Value)
                        , DGV_PRD_BILL.Rows[i].Cells[4].Value.ToString(), DGV_PRD_BILL.Rows[i].Cells[6].Value.ToString());
                }

                MessageBox.Show("Saved Successfully", "Save Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Do you want to Print this Order?", "Inquiry Process", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    button_print.Enabled = true;
                    butto_add.Enabled = false;
                    //MessageBox.Show("Successfully Print", "Inquiry Process", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Print Canceled", "Print Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    button_new.Enabled = true;
                }

               // ClearData();
            }
            catch
            { return; }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            ClearBoxes();
            FORM_PRODUCTS_LIST form = new FORM_PRODUCTS_LIST();
            form.ShowDialog();
            text_prd_id.Text = form.DGV_PRODUCTS.CurrentRow.Cells[0].Value.ToString();
            text_prd_name.Text = form.DGV_PRODUCTS.CurrentRow.Cells[1].Value.ToString();
            text_prd_price.Text = form.DGV_PRODUCTS.CurrentRow.Cells[3].Value.ToString();
            text_prd_quantity.Focus();

        }

        private void text_prd_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void text_prd_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void text_prd_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && text_prd_price.Text != string.Empty)
            {
                text_prd_quantity.Focus();
            }
        }

        private void text_prd_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_prd_quantity.Text != string.Empty)
                {
                    if (order.VerifyProductQte(text_prd_id.Text, Convert.ToInt32(text_prd_quantity.Text)).Rows.Count < 1)
                    {
                        MessageBox.Show("The Input Quantity Not Available !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        text_prd_quantity.Focus();
                        text_prd_quantity.SelectionStart = 0;
                        text_prd_quantity.SelectionLength = text_prd_quantity.TextLength;
                        return;

                    }

                    for (int i = 0; i < DGV_PRD_BILL.Rows.Count - 1; i++)
                    {
                        if (DGV_PRD_BILL.Rows[i].Cells[0].Value.ToString() == text_prd_id.Text)
                        {
                            if (MessageBox.Show("Do you want to Edit Quantity the Entered product?", "Edit process", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                MessageBox.Show("Successfully Edited", "Editing process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DGV_PRD_BILL.Rows.RemoveAt(DGV_PRD_BILL.Rows[i].Index);
                            }
                            else
                            {
                                MessageBox.Show("Edit Canceled", "Editing Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }

                }
                else { return; }
            }

            if (e.KeyCode == Keys.Enter && text_prd_quantity.Text != string.Empty)
            {
                text_prd_discounit.Focus();
            }


        }

        private void text_prd_price_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void text_prd_quantity_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void text_prd_discounit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
            /*if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }*/
        }

        private void text_prd_discounit_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotalAmount();
        }

        private void text_prd_discounit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow r = Dt.NewRow();
                r[0] = text_prd_id.Text;
                r[1] = text_prd_name.Text;
                r[2] = text_prd_price.Text;
                r[3] = text_prd_quantity.Text;
                r[4] = text_prd_amount.Text;
                r[5] = text_prd_discounit.Text;
                r[6] = text_prd_T_amount.Text;

                Dt.Rows.Add(r);

                DGV_PRD_BILL.DataSource = Dt;

                ClearBoxes();

                // link to calaulat total amount
                text_Sum_Total.Text =
                    (from DataGridViewRow row in DGV_PRD_BILL.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }

        private void DGV_PRD_BILL_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                text_prd_id.Text = this.DGV_PRD_BILL.CurrentRow.Cells[0].Value.ToString();
                text_prd_name.Text = this.DGV_PRD_BILL.CurrentRow.Cells[1].Value.ToString();
                text_prd_price.Text = this.DGV_PRD_BILL.CurrentRow.Cells[2].Value.ToString();
                text_prd_quantity.Text = this.DGV_PRD_BILL.CurrentRow.Cells[3].Value.ToString();
                text_prd_amount.Text = this.DGV_PRD_BILL.CurrentRow.Cells[4].Value.ToString();
                text_prd_discounit.Text = this.DGV_PRD_BILL.CurrentRow.Cells[5].Value.ToString();
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

        private void text_prd_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (text_prd_id.Text != string.Empty)
                {
                    DataTable dt = new DataTable();
                    dt = order.GetproductBarcode(text_prd_id.Text);
                    if (dt.Rows.Count > 0)
                    {
                        text_prd_id.Text = dt.Rows[0][0].ToString();
                        text_prd_name.Text = dt.Rows[0][1].ToString();
                        text_prd_price.Text = dt.Rows[0][3].ToString();
                    }

                }


            }
            catch { return; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            text_cust_id.Clear();
            text_Cust_name.Clear();
            text_phone.Clear();
            text_address.Clear();
            pbox.Image = null;
            panelCus.Enabled = false;
            button_new.Enabled = true;
            radioButton_special.Checked = false;
            panelCus.Enabled = false;
            text_cust_id.Text = "1040";
            text_Cust_name.Text = "Public Customer";

        }

        private void radioButton_special_CheckedChanged(object sender, EventArgs e)
        {
            text_cust_id.Clear();
            text_Cust_name.Clear();
            text_phone.Clear();
            text_address.Clear();
            pbox.Image = null;
            panelCus.Enabled = true;

        }

        private void radioButton_public_Click(object sender, EventArgs e)
        {
            button_new.Enabled = true;
            radioButton_special.Checked = false;
            panelCus.Enabled = false;
            text_cust_id.Text = "1040";
            text_Cust_name.Text = "Public Customer";
            text_phone.Clear();
            text_address.Clear();
        }

        private void radioButton_special_Click(object sender, EventArgs e)
        {
            pbox.Image = null;
            FORM_CUSTOMERS_LIST form = new FORM_CUSTOMERS_LIST();
            form.ShowDialog();              // هذه الخطوة لعرض الفرم قبل اخذ هذه الادوات التالية

            if (form.DGV_Customers.CurrentRow.Cells[6].Value is DBNull)
            {

                this.text_cust_id.Text = form.DGV_Customers.CurrentRow.Cells[0].Value.ToString();
                this.text_Cust_name.Text = form.DGV_Customers.CurrentRow.Cells[1].Value.ToString();
                this.text_phone.Text = form.DGV_Customers.CurrentRow.Cells[2].Value.ToString();
                this.text_address.Text = form.DGV_Customers.CurrentRow.Cells[4].Value.ToString();
                MessageBox.Show("This client does not have an image");

            }
            else
            {
                this.text_cust_id.Text = form.DGV_Customers.CurrentRow.Cells[0].Value.ToString();
                this.text_Cust_name.Text = form.DGV_Customers.CurrentRow.Cells[1].Value.ToString();
                this.text_phone.Text = form.DGV_Customers.CurrentRow.Cells[2].Value.ToString();
                this.text_address.Text = form.DGV_Customers.CurrentRow.Cells[4].Value.ToString();

                byte[] custpicture = (byte[])form.DGV_Customers.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(custpicture);
                this.pbox.Image = Image.FromStream(ms);
            }

            radioButton_public.Checked = false;
            panelCus.Enabled = true;
        }

        private void button_print_Click(object sender, EventArgs e)
        {

        }

        private void button_print_Click_1(object sender, EventArgs e)
        {
            // get the last order3
           // this.Cursor = Cursors.WaitCursor;
            int Order_ID = Convert.ToInt32(order.GET_last_ORDER().Rows[0][0]);
            RPT.RPT_ORDERS Report = new RPT.RPT_ORDERS();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            Report.SetDataSource(order.GET_ORDER_DETAILS(Order_ID));
            frm.crystalReportViewer1.ReportSource = Report;
            frm.ShowDialog();
           // this.Cursor = Cursors.Default;

        }

    }
}
