namespace hamedsmms.PL
{
    partial class FORM_CATEGORIES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_CATEGORIES));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.button_last = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Next = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_First = new System.Windows.Forms.Button();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExportToExcelAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.ExportToExcelCurrent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.PrintCurrentCateg = new System.Windows.Forms.Button();
            this.PrintAllCateg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_List = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.lbl_position);
            this.groupBox1.Controls.Add(this.button_last);
            this.groupBox1.Controls.Add(this.button_Next);
            this.groupBox1.Controls.Add(this.button_previous);
            this.groupBox1.Controls.Add(this.button_First);
            this.groupBox1.Controls.Add(this.textDescription);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Categories:";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.Location = new System.Drawing.Point(307, 239);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(60, 24);
            this.lbl_position.TabIndex = 8;
            this.lbl_position.Text = "label3";
            this.lbl_position.Click += new System.EventHandler(this.lp_position_Click);
            // 
            // button_last
            // 
            this.button_last.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_last.ImageKey = "Actions-go-last-view-icon.png";
            this.button_last.ImageList = this.imageList1;
            this.button_last.Location = new System.Drawing.Point(461, 233);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(75, 45);
            this.button_last.TabIndex = 7;
            this.button_last.UseVisualStyleBackColor = false;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "117-512.png");
            this.imageList1.Images.SetKeyName(1, "627249-delete3-512.png");
            this.imageList1.Images.SetKeyName(2, "add_order-512.png");
            this.imageList1.Images.SetKeyName(3, "download (1).png");
            this.imageList1.Images.SetKeyName(4, "print-button-icon-png-2.png");
            this.imageList1.Images.SetKeyName(5, "add-circle-green-512.png");
            this.imageList1.Images.SetKeyName(6, "cancel-circle-512.png");
            this.imageList1.Images.SetKeyName(7, "Save.png");
            this.imageList1.Images.SetKeyName(8, "save-icon.png");
            this.imageList1.Images.SetKeyName(9, "Actions-go-first-view-icon.png");
            this.imageList1.Images.SetKeyName(10, "Actions-go-last-view-icon.png");
            this.imageList1.Images.SetKeyName(11, "Actions-go-next-view-icon.png");
            this.imageList1.Images.SetKeyName(12, "left.png");
            this.imageList1.Images.SetKeyName(13, "4me-icon-product-category-nrqabd7wwi8rr2uxvucga9mg8lnqu0rk2kwc617ics.png");
            this.imageList1.Images.SetKeyName(14, "2109135.png");
            this.imageList1.Images.SetKeyName(15, "48-512.png");
            this.imageList1.Images.SetKeyName(16, "cart_upload-01-512.png");
            this.imageList1.Images.SetKeyName(17, "download (5).png");
            this.imageList1.Images.SetKeyName(18, "images (6).png");
            this.imageList1.Images.SetKeyName(19, "images (8).png");
            this.imageList1.Images.SetKeyName(20, "remove_product_delete-512.png");
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Next.ImageKey = "Actions-go-next-view-icon.png";
            this.button_Next.ImageList = this.imageList1;
            this.button_Next.Location = new System.Drawing.Point(387, 233);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(69, 45);
            this.button_Next.TabIndex = 6;
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_previous.ImageKey = "left.png";
            this.button_previous.ImageList = this.imageList1;
            this.button_previous.Location = new System.Drawing.Point(201, 233);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(68, 45);
            this.button_previous.TabIndex = 5;
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_First
            // 
            this.button_First.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_First.ImageKey = "Actions-go-first-view-icon.png";
            this.button_First.ImageList = this.imageList1;
            this.button_First.Location = new System.Drawing.Point(120, 233);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(75, 45);
            this.button_First.TabIndex = 4;
            this.button_First.UseVisualStyleBackColor = false;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(253, 111);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescription.Size = new System.Drawing.Size(326, 82);
            this.textDescription.TabIndex = 3;
            this.textDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(253, 45);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(221, 28);
            this.textID.TabIndex = 2;
            this.textID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textID_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.ExportToExcelAll);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.ExportToExcelCurrent);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.PrintCurrentCateg);
            this.groupBox2.Controls.Add(this.PrintAllCateg);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1363, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations Managment:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ExportToExcelAll
            // 
            this.ExportToExcelAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToExcelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToExcelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToExcelAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportToExcelAll.ImageKey = "images (8).png";
            this.ExportToExcelAll.ImageList = this.imageList1;
            this.ExportToExcelAll.Location = new System.Drawing.Point(748, 136);
            this.ExportToExcelAll.Name = "ExportToExcelAll";
            this.ExportToExcelAll.Size = new System.Drawing.Size(385, 53);
            this.ExportToExcelAll.TabIndex = 8;
            this.ExportToExcelAll.Text = "Save list of Categories file[pdf]";
            this.ExportToExcelAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportToExcelAll.UseVisualStyleBackColor = false;
            this.ExportToExcelAll.Click += new System.EventHandler(this.ExportToExcelAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ImageKey = "cancel-circle-512.png";
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(1169, 136);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 53);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Exit";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageKey = "4me-icon-product-category-nrqabd7wwi8rr2uxvucga9mg8lnqu0rk2kwc617ics.png";
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(210, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 53);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.ImageKey = "2109135.png";
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(47, 55);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(131, 53);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ExportToExcelCurrent
            // 
            this.ExportToExcelCurrent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToExcelCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToExcelCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToExcelCurrent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportToExcelCurrent.ImageKey = "download (5).png";
            this.ExportToExcelCurrent.ImageList = this.imageList1;
            this.ExportToExcelCurrent.Location = new System.Drawing.Point(748, 57);
            this.ExportToExcelCurrent.Name = "ExportToExcelCurrent";
            this.ExportToExcelCurrent.Size = new System.Drawing.Size(559, 53);
            this.ExportToExcelCurrent.TabIndex = 5;
            this.ExportToExcelCurrent.Text = "Save Selected Category & Products its [pdf]";
            this.ExportToExcelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportToExcelCurrent.UseVisualStyleBackColor = false;
            this.ExportToExcelCurrent.Click += new System.EventHandler(this.ExportToExcelCurrent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageKey = "remove_product_delete-512.png";
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(559, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 53);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.ImageKey = "cart_upload-01-512.png";
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(398, 57);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 53);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Update";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PrintCurrentCateg
            // 
            this.PrintCurrentCateg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintCurrentCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintCurrentCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintCurrentCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintCurrentCateg.ImageKey = "48-512.png";
            this.PrintCurrentCateg.ImageList = this.imageList1;
            this.PrintCurrentCateg.Location = new System.Drawing.Point(47, 136);
            this.PrintCurrentCateg.Name = "PrintCurrentCateg";
            this.PrintCurrentCateg.Size = new System.Drawing.Size(290, 53);
            this.PrintCurrentCateg.TabIndex = 1;
            this.PrintCurrentCateg.Text = "Print Selected Category";
            this.PrintCurrentCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintCurrentCateg.UseVisualStyleBackColor = false;
            this.PrintCurrentCateg.Click += new System.EventHandler(this.PrintCurrentCateg_Click);
            // 
            // PrintAllCateg
            // 
            this.PrintAllCateg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintAllCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintAllCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintAllCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintAllCateg.ImageKey = "images (6).png";
            this.PrintAllCateg.ImageList = this.imageList1;
            this.PrintAllCateg.Location = new System.Drawing.Point(398, 138);
            this.PrintAllCateg.Name = "PrintAllCateg";
            this.PrintAllCateg.Size = new System.Drawing.Size(294, 51);
            this.PrintAllCateg.TabIndex = 0;
            this.PrintAllCateg.Text = "Print All Categories";
            this.PrintAllCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintAllCateg.UseVisualStyleBackColor = false;
            this.PrintAllCateg.Click += new System.EventHandler(this.PrintAllCateg_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_List);
            this.groupBox3.Location = new System.Drawing.Point(668, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 333);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // DGV_List
            // 
            this.DGV_List.AllowUserToAddRows = false;
            this.DGV_List.AllowUserToDeleteRows = false;
            this.DGV_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_List.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_List.Location = new System.Drawing.Point(12, 12);
            this.DGV_List.Name = "DGV_List";
            this.DGV_List.ReadOnly = true;
            this.DGV_List.RowTemplate.Height = 24;
            this.DGV_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_List.Size = new System.Drawing.Size(689, 315);
            this.DGV_List.TabIndex = 0;
            this.DGV_List.DoubleClick += new System.EventHandler(this.DGV_List_DoubleClick);
            this.DGV_List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGV_List_MouseClick);
            // 
            // FORM_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1387, 587);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_CATEGORIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Categories";
            this.Load += new System.EventHandler(this.FORM_CATEGORIES_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_List;
        private System.Windows.Forms.Button ExportToExcelAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button PrintAllCateg;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button ExportToExcelCurrent;
        private System.Windows.Forms.Button PrintCurrentCateg;
    }
}