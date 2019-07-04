using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace hamedsmms.PL
{
    public partial class FORM_CUSTOMERS : Form
    {

        BL.CLS_CUSTOMER cust = new BL.CLS_CUSTOMER();
        int ID,Position;
        BindingManagerBase BMB;

        public FORM_CUSTOMERS()
        {
            InitializeComponent();
            text_user_add.Text = Program.SalesMan;


            textName.Enabled=false;
            textPhone.Enabled = false;
            textEmail.Enabled = false;
            textAddress.Enabled = false;
            text_user_add.Enabled = false;
            button_Delete.Enabled = false;
            button_Update.Enabled = false;

            this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
            
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            BMB = this.BindingContext[cust.GET_ALL_CUSTOMERS()];
            lbl_position.Text = (BMB.Position+1) + " / " + BMB.Count;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            if(Position==0)
            {
                MessageBox.Show("This is the first customer..");
            }
            Position -= 1;
            Navigate(Position);
            BMB.Position -= 1;
            lbl_position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "photo file|*.JPG;*.PNG;*.GIF;*.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(op.FileName);
            }
        }


        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textPhone.Focus();
            }
        }

        private void textPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textEmail.Focus();
            }
        }

        private void textEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textAddress.Focus();
            }
        }

        private void textAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_add.Focus();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textPhone.Clear();
            textEmail.Clear();
            textAddress.Clear();
            
            pictureBox.Image = null;
            textName.Focus();

            textName.Enabled = true;
            textPhone.Enabled = true;
            textEmail.Enabled = true;
            textAddress.Enabled = true;
            text_user_add.Enabled = true;
            button_add.Enabled = true;
            button_new.Enabled = false;
            button_Delete.Enabled = false;
            button_Update.Enabled = false;
            textName.Focus();

            


            
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textName.Text == string.Empty || textPhone.Text == string.Empty || textEmail.Text == string.Empty || textAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Rewrite All Data !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }
            
                byte[] Picture;
                if (pictureBox.Image == null)
                {
                    Picture = new byte[0];                   //this line To camouflage لقيمة ال picture

                    cust.ADD_CUSTOMERS(textName.Text, textPhone.Text, textEmail.Text
                    , textAddress.Text, text_date_add.Value, Picture, text_user_add.Text, "Without_Image");
                    MessageBox.Show("Successfully added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    Picture = ms.ToArray();

                    cust.ADD_CUSTOMERS(textName.Text, textPhone.Text, textEmail.Text
                        , textAddress.Text, text_date_add.Value, Picture, text_user_add.Text, "With_Image");
                    MessageBox.Show("Successfully added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                
            textName.Clear();
            textPhone.Clear();
            textEmail.Clear();
            textAddress.Clear();
            button_new.Enabled = true;
            button_add.Enabled = false;
            textName.Focus();
            pictureBox.Image = null;
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textName.Text == string.Empty || textPhone.Text == string.Empty || textEmail.Text == string.Empty || textAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Select What you want to Update ?", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                button_add.Enabled = false;
                byte[] Picture;
                if (pictureBox.Image == null)
                {
                    Picture = new byte[0];                   //this line To camouflage لقيمة ال picture

                    cust.EDIT_CUSTOMERS(textName.Text, textPhone.Text, textEmail.Text
                    , textAddress.Text, text_date_add.Value, Picture, text_user_add.Text, "Without_Image", ID);
                    MessageBox.Show("Modified successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                    
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    Picture = ms.ToArray();

                    cust.EDIT_CUSTOMERS(textName.Text, textPhone.Text, textEmail.Text
                        , textAddress.Text, text_date_add.Value, Picture, text_user_add.Text, "With_Image", ID);
                    MessageBox.Show("Modified successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
            textName.Clear();
            textPhone.Clear();
            textEmail.Clear();
            textAddress.Clear();
            
            button_new.Enabled = true;
            button_add.Enabled = false;
            button_Delete.Enabled = false;
            button_Update.Enabled = false;
            pictureBox.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textName.Text == string.Empty || textPhone.Text == string.Empty || textEmail.Text == string.Empty || textAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Select What you want to Delete?", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you really want to delete the client ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cust.DELETE_CUSTOMERS(ID);
                MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
            }
            textName.Clear();
            textPhone.Clear();
            textEmail.Clear();
            textAddress.Clear();
            pictureBox.Image = null;

            button_Delete.Enabled = false;
            button_Update.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            button_add.Enabled = false;
            button_Update.Enabled = true;
            button_Delete.Enabled = true;

            textName.Enabled = true;
            textPhone.Enabled = true;
            textEmail.Enabled = true;
            textAddress.Enabled = true;
            text_user_add.Enabled = true;

            try
            {
                pictureBox.Image = null;
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.textName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.textPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.textEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.textAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.text_date_add.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                this.text_user_add.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                byte[] Picture = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(Picture);
                pictureBox.Image = System.Drawing.Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = cust.SeachCustomer(txtsearch.Text);
            this.dataGridView1.DataSource = Dt;
        }

        void Navigate(int Index)      // للتحكم ف التنقل بين العملاء 
        {
            try
            {
                pictureBox.Image = null;
                DataTable Dt = cust.GET_ALL_CUSTOMERS();
                DataRowCollection DRC = Dt.Rows;     //للاختصار .
                ID = Convert.ToInt32(DRC[Index][0]);
                textName.Text = DRC[Index][1].ToString();
                textPhone.Text = DRC[Index][2].ToString();
                textEmail.Text = DRC[Index][3].ToString();
                textAddress.Text = DRC[Index][4].ToString();
                text_date_add.Text = DRC[Index][5].ToString();

                byte[] Picture = (byte[])DRC[Index][6];
                MemoryStream ms = new MemoryStream(Picture);
                pictureBox.Image = System.Drawing.Image.FromStream(ms);

                text_user_add.Text = DRC[Index][7].ToString();
            }
            catch { return; }
            
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            Navigate(0);
            BMB.Position = 0;
            lbl_position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            Position = cust.GET_ALL_CUSTOMERS().Rows.Count - 1;
            Navigate(Position);
            BMB.Position = BMB.Count;
            lbl_position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (Position == cust.GET_ALL_CUSTOMERS().Rows.Count - 1)
            {
                MessageBox.Show("This is the last customer..");
            }
            Position += 1;
            Navigate(Position);
            BMB.Position += 1;
            lbl_position.Text = (BMB.Position + 1) + " / " + BMB.Count;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
        
    

