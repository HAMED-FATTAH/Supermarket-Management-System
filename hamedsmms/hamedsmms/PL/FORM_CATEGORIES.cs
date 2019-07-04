using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace hamedsmms.PL
{
    public partial class FORM_CATEGORIES : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-SUFKOGM;Initial Catalog=SMMS;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt=new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FORM_CATEGORIES()
        {
            InitializeComponent();

            textDescription.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            PrintCurrentCateg.Enabled = false;
            ExportToExcelCurrent.Enabled = false;

            da = new SqlDataAdapter("select CatID as 'ID',CatName as 'Category' from Category", sqlcon);
            da.Fill(dt);
            DGV_List.DataSource = dt;
            textID.DataBindings.Add("text", dt, "ID");
            textDescription.DataBindings.Add("text", dt, "Category");
            bmb = this.BindingContext[dt];
            lbl_position.Text=(bmb.Position+1) + " / " + bmb.Count;
        }

        private void lp_position_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textDescription.Text == string.Empty)
            {
                MessageBox.Show("write the name of category", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDescription.Focus();
                return;
                
            }
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Add Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            lbl_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ExportToExcelCurrent_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_CATEGORY myreport = new RPT.RPT_SINGLE_CATEGORY();

            //Create Export Options    خاص باعدادات التقرير
            ExportOptions export = new ExportOptions();

            //Create object for Destination    خاص بمكان حفظ التقرير
            DiskFileDestinationOptions dfdoptions = new DiskFileDestinationOptions();

            PdfFormatOptions pdfformat = new PdfFormatOptions();

            //set the path of destination      رابط المسار الذى نريد وضع الملف فيه  
            dfdoptions.DiskFileName = "E:\\CategoryDetails.pdf";

            export = myreport.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;

            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            export.ExportFormatOptions = pdfformat;

            export.ExportDestinationOptions = dfdoptions;

            myreport.SetParameterValue("@id", Convert.ToInt32(textID.Text));    //To create or inseart id ...

            myreport.Export();

            MessageBox.Show("List Exported Successfuly ! ", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            PrintCurrentCateg.Enabled = false;
            ExportToExcelCurrent.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lbl_position.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void button_last_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lbl_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lbl_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lbl_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count ][0])+1;
            textID.Text = id.ToString();
            textDescription.Focus();
            textDescription.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            PrintCurrentCateg.Enabled = false;
            ExportToExcelCurrent.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Edited Successfully", "Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_position.Text = (bmb.Position + 1) + " / " + bmb.Count;
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            PrintCurrentCateg.Enabled = false;
            ExportToExcelCurrent.Enabled = false;
        }

        private void PrintCurrentCateg_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_CATEGORY rpt = new RPT.RPT_SINGLE_CATEGORY();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.SetParameterValue("@id", Convert.ToInt32(textID.Text));     //this to insert id from combox
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            PrintCurrentCateg.Enabled = false;
            ExportToExcelCurrent.Enabled = false;
        }

        private void PrintAllCateg_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_CATEGORIES rpt = new RPT.RPT_ALL_CATEGORIES();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void ExportToExcelAll_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_CATEGORIES myreport = new RPT.RPT_ALL_CATEGORIES();

            //Create Export Options    خاص باعدادات التقرير
            ExportOptions export = new ExportOptions();

            //Create object for Destination    خاص بمكان حفظ التقرير
            DiskFileDestinationOptions dfdoptions = new DiskFileDestinationOptions();

            PdfFormatOptions pdfformat = new PdfFormatOptions();

            //set the path of destination      رابط المسار الذى نريد وضع الملف فيه  
            dfdoptions.DiskFileName = "E:\\Categorieslist.pdf";

            export = myreport.ExportOptions;

            export.ExportDestinationType = ExportDestinationType.DiskFile;

            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            export.ExportFormatOptions = pdfformat;

            export.ExportDestinationOptions = dfdoptions;

            myreport.Refresh();

            myreport.Export();

            MessageBox.Show("List Exported Successfuly ! ", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DGV_List_MouseClick(object sender, MouseEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            textDescription.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void DGV_List_DoubleClick(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
           
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            PrintCurrentCateg.Enabled = true;
            ExportToExcelCurrent.Enabled = true;
        }

        private void textID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textDescription.Focus();
            }
        }

        private void FORM_CATEGORIES_Load(object sender, EventArgs e)
        {

        }
    }
}
