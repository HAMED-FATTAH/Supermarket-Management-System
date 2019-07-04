namespace hamedsmms.PL
{
    partial class FORM_COMPANY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_COMPANY));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comproducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_cam_address = new System.Windows.Forms.TextBox();
            this.text_cam_phone = new System.Windows.Forms.TextBox();
            this.text_cam_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Company_list = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Company_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comproducts);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.text_cam_address);
            this.groupBox3.Controls.Add(this.text_cam_phone);
            this.groupBox3.Controls.Add(this.text_cam_name);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 393);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Campany Data:";
            // 
            // comproducts
            // 
            this.comproducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comproducts.FormattingEnabled = true;
            this.comproducts.Location = new System.Drawing.Point(200, 274);
            this.comproducts.Name = "comproducts";
            this.comproducts.Size = new System.Drawing.Size(172, 30);
            this.comproducts.TabIndex = 9;
            this.comproducts.SelectedIndexChanged += new System.EventHandler(this.comproducts_SelectedIndexChanged);
            this.comproducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comproducts_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Barcode:";
            // 
            // text_cam_address
            // 
            this.text_cam_address.Location = new System.Drawing.Point(151, 196);
            this.text_cam_address.Multiline = true;
            this.text_cam_address.Name = "text_cam_address";
            this.text_cam_address.Size = new System.Drawing.Size(234, 30);
            this.text_cam_address.TabIndex = 7;
            this.text_cam_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_cam_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_cam_address_KeyDown);
            // 
            // text_cam_phone
            // 
            this.text_cam_phone.Location = new System.Drawing.Point(151, 124);
            this.text_cam_phone.Multiline = true;
            this.text_cam_phone.Name = "text_cam_phone";
            this.text_cam_phone.Size = new System.Drawing.Size(234, 30);
            this.text_cam_phone.TabIndex = 5;
            this.text_cam_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_cam_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_cam_phone_KeyDown);
            // 
            // text_cam_name
            // 
            this.text_cam_name.Location = new System.Drawing.Point(151, 59);
            this.text_cam_name.Multiline = true;
            this.text_cam_name.Name = "text_cam_name";
            this.text_cam_name.Size = new System.Drawing.Size(234, 28);
            this.text_cam_name.TabIndex = 6;
            this.text_cam_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_cam_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_cam_name_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Exit.ImageKey = "cancel-circle-512.png";
            this.button_Exit.ImageList = this.imageList1;
            this.button_Exit.Location = new System.Drawing.Point(1009, 457);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(120, 50);
            this.button_Exit.TabIndex = 53;
            this.button_Exit.Text = "Exit";
            this.button_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "627249-delete3-512.png");
            this.imageList1.Images.SetKeyName(1, "cancel-circle-512.png");
            this.imageList1.Images.SetKeyName(2, "office_building-add-512.png");
            this.imageList1.Images.SetKeyName(3, "icon-Sustainability-300x300.png");
            this.imageList1.Images.SetKeyName(4, "ttdemngwynrvcrgtsqls.png");
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Delete.ImageKey = "627249-delete3-512.png";
            this.button_Delete.ImageList = this.imageList1;
            this.button_Delete.Location = new System.Drawing.Point(767, 457);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(152, 50);
            this.button_Delete.TabIndex = 52;
            this.button_Delete.Text = "Delete";
            this.button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Update.ImageKey = "icon-Sustainability-300x300.png";
            this.button_Update.ImageList = this.imageList1;
            this.button_Update.Location = new System.Drawing.Point(516, 457);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(169, 50);
            this.button_Update.TabIndex = 51;
            this.button_Update.Text = "Update";
            this.button_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click_1);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.ImageKey = "office_building-add-512.png";
            this.button_add.ImageList = this.imageList1;
            this.button_add.Location = new System.Drawing.Point(285, 457);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(153, 50);
            this.button_add.TabIndex = 50;
            this.button_add.Text = "Add";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // button_new
            // 
            this.button_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_new.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_new.ImageKey = "ttdemngwynrvcrgtsqls.png";
            this.button_new.ImageList = this.imageList1;
            this.button_new.Location = new System.Drawing.Point(48, 457);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(158, 50);
            this.button_new.TabIndex = 49;
            this.button_new.Text = "New";
            this.button_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Company_list);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(472, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 383);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List all Company ";
            // 
            // DGV_Company_list
            // 
            this.DGV_Company_list.AllowUserToAddRows = false;
            this.DGV_Company_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Company_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_Company_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Company_list.Location = new System.Drawing.Point(6, 36);
            this.DGV_Company_list.MultiSelect = false;
            this.DGV_Company_list.Name = "DGV_Company_list";
            this.DGV_Company_list.ReadOnly = true;
            this.DGV_Company_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Company_list.Size = new System.Drawing.Size(678, 338);
            this.DGV_Company_list.TabIndex = 0;
            this.DGV_Company_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Company_list_CellContentClick);
            this.DGV_Company_list.DoubleClick += new System.EventHandler(this.DGV_Company_list_DoubleClick_1);
            // 
            // FORM_COMPANY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1172, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_COMPANY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.FORM_COMPANY_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Company_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_cam_address;
        private System.Windows.Forms.TextBox text_cam_phone;
        private System.Windows.Forms.TextBox text_cam_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_Company_list;
        private System.Windows.Forms.ComboBox comproducts;
        private System.Windows.Forms.ImageList imageList1;



    }
}