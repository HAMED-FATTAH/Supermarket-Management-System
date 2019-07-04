using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace hamedsmms.PL
{
    public partial class FORM_PRODUCTS : Form
    {
        private static FORM_PRODUCTS frm;                                          //  ......................[1]

        static void frm_formclosed(object sender, FormClosedEventArgs e)                 //  ................[2]
        {
            frm = null;
        }

        public static FORM_PRODUCTS getmainform                                          //  .................[3]
        {
            get
            {
                if (frm == null)                                      //  بتاكد ان لو الحدث مهدوم بمعنى انه غير موجود  
                {
                    frm = new FORM_PRODUCTS();                            // نقوم بانشاءه من جديد
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);                    // اطلاق الحدث closed
                }
                return frm;
            }
        }
      

        BL.CLS_Product prd = new BL.CLS_Product();
        public FORM_PRODUCTS()
        {
            InitializeComponent();

            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_print.Enabled = false;
            btn_add.Enabled = true;

            if (frm == null)         /*بعين قيمة لل form لو قيمتة ب null وهى تكون قيمتها الحالية  */    // .......[4]  
                frm = this;

            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
        }

    

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.SeachProduct(txtsearch.Text);
            this.dataGridView1.DataSource=Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_ADD_PRODUCT frm = new FORM_ADD_PRODUCT();
            frm.ShowDialog();
            frm.txtRef.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selected product?", "Deletion process", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                
                MessageBox.Show("Successfully deleted", "Deletion process", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            }
            else 
            {
                MessageBox.Show("Edit Canceled", "Edit Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_print.Enabled = false;
            btn_add.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FORM_ADD_PRODUCT form = new FORM_ADD_PRODUCT();

            form.button1.Visible = false;
            form.txtRef.Text=this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.txtqte.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            form.txt_P_Price.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.txt_S_price.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            form.Text = "Product Update:" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.btnAdd.Text = "Update";
            form.state = "update";
            form.txtRef.ReadOnly = true;
            form.ShowDialog();
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_PRODUCTS_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_PRODUCTS myreport = new RPT.RPT_ALL_PRODUCTS();

            //Create Export Options    خاص باعدادات التقرير
            ExportOptions export = new ExportOptions();

            //Create object for Destination    خاص بمكان حفظ التقرير
            DiskFileDestinationOptions dfdoptions = new DiskFileDestinationOptions();

            ExcelFormatOptions excelformat=new ExcelFormatOptions();

            //set the path of destination      رابط المسار الذى نريد وضع الملف فيه  
            dfdoptions.DiskFileName = "E:\\Productslist.xls";

            export = myreport.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;

            export.ExportFormatType = ExportFormatType.Excel;

            export.ExportFormatOptions = excelformat;

            export.ExportDestinationOptions = dfdoptions;

            myreport.Export();

            MessageBox.Show("List Exported Successfuly ! ", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RPT.RPT_TO_SINGLE myreport = new RPT.RPT_TO_SINGLE();          //نسخة من التقرير او الريبورت

            // ارسال قيمة البراميتر بحيث يقوم بعرض منتوج واحد وهو المححد ف datagridview
            myreport.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            RPT.FRM_RPT_PRODUCT MYFORM = new RPT.FRM_RPT_PRODUCT();          //  هذا من اجل الوصول لواجة الكريستال 
            MYFORM.crystalReportViewer1.ReportSource = myreport;
            MYFORM.ShowDialog();

            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_print.Enabled = false;
            btn_add.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_PRODUCTS myreport = new RPT.RPT_ALL_PRODUCTS();
            RPT.FRM_RPT_PRODUCT myform = new RPT.FRM_RPT_PRODUCT();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_print.Enabled = true;
            
        }
    }
}
