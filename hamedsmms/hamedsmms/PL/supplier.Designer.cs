namespace hamedsmms.PL
{
    partial class supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_Sup_ID = new System.Windows.Forms.TextBox();
            this.Cmb_company = new System.Windows.Forms.ComboBox();
            this.DateSupplier = new System.Windows.Forms.DateTimePicker();
            this.text_user_add = new System.Windows.Forms.TextBox();
            this.textSupaddress = new System.Windows.Forms.TextBox();
            this.textSupemail = new System.Windows.Forms.TextBox();
            this.textSupphone = new System.Windows.Forms.TextBox();
            this.textsupName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.butexit = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.butnew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.text_Sup_ID);
            this.groupBox1.Controls.Add(this.Cmb_company);
            this.groupBox1.Controls.Add(this.DateSupplier);
            this.groupBox1.Controls.Add(this.text_user_add);
            this.groupBox1.Controls.Add(this.textSupaddress);
            this.groupBox1.Controls.Add(this.textSupemail);
            this.groupBox1.Controls.Add(this.textSupphone);
            this.groupBox1.Controls.Add(this.textsupName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 521);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data of Supplier";
            // 
            // text_Sup_ID
            // 
            this.text_Sup_ID.Location = new System.Drawing.Point(464, 49);
            this.text_Sup_ID.Name = "text_Sup_ID";
            this.text_Sup_ID.ReadOnly = true;
            this.text_Sup_ID.Size = new System.Drawing.Size(28, 28);
            this.text_Sup_ID.TabIndex = 28;
            this.text_Sup_ID.TextChanged += new System.EventHandler(this.text_Sup_ID_TextChanged);
            // 
            // Cmb_company
            // 
            this.Cmb_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_company.FormattingEnabled = true;
            this.Cmb_company.Location = new System.Drawing.Point(206, 238);
            this.Cmb_company.Name = "Cmb_company";
            this.Cmb_company.Size = new System.Drawing.Size(286, 30);
            this.Cmb_company.TabIndex = 4;
            this.Cmb_company.SelectedIndexChanged += new System.EventHandler(this.Cmb_company_SelectedIndexChanged);
            this.Cmb_company.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_company_KeyDown);
            // 
            // DateSupplier
            // 
            this.DateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSupplier.Location = new System.Drawing.Point(217, 408);
            this.DateSupplier.Name = "DateSupplier";
            this.DateSupplier.Size = new System.Drawing.Size(282, 28);
            this.DateSupplier.TabIndex = 6;
            this.DateSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateSupplier_KeyDown);
            // 
            // text_user_add
            // 
            this.text_user_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user_add.Location = new System.Drawing.Point(217, 466);
            this.text_user_add.Name = "text_user_add";
            this.text_user_add.ReadOnly = true;
            this.text_user_add.Size = new System.Drawing.Size(283, 28);
            this.text_user_add.TabIndex = 7;
            this.text_user_add.TextChanged += new System.EventHandler(this.text_user_add_TextChanged);
            // 
            // textSupaddress
            // 
            this.textSupaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSupaddress.Location = new System.Drawing.Point(192, 302);
            this.textSupaddress.Multiline = true;
            this.textSupaddress.Name = "textSupaddress";
            this.textSupaddress.Size = new System.Drawing.Size(300, 66);
            this.textSupaddress.TabIndex = 5;
            this.textSupaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSupaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSupaddress_KeyDown);
            // 
            // textSupemail
            // 
            this.textSupemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSupemail.Location = new System.Drawing.Point(192, 174);
            this.textSupemail.Name = "textSupemail";
            this.textSupemail.Size = new System.Drawing.Size(300, 28);
            this.textSupemail.TabIndex = 3;
            this.textSupemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSupemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSupemail_KeyDown);
            // 
            // textSupphone
            // 
            this.textSupphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSupphone.Location = new System.Drawing.Point(192, 112);
            this.textSupphone.Name = "textSupphone";
            this.textSupphone.Size = new System.Drawing.Size(300, 28);
            this.textSupphone.TabIndex = 2;
            this.textSupphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSupphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSupphone_KeyDown);
            // 
            // textsupName
            // 
            this.textsupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsupName.Location = new System.Drawing.Point(192, 49);
            this.textsupName.Name = "textsupName";
            this.textsupName.Size = new System.Drawing.Size(278, 28);
            this.textsupName.TabIndex = 1;
            this.textsupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textsupName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textsupName_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "User Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date of Registeration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Supplier Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Supplier Company:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Supplier Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Supplier Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Supplier Name:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel-circle-512.png");
            this.imageList1.Images.SetKeyName(1, "download (4).png");
            this.imageList1.Images.SetKeyName(2, "icon-Sustainability-300x300.png");
            // 
            // butexit
            // 
            this.butexit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butexit.ImageKey = "cancel-circle-512.png";
            this.butexit.ImageList = this.imageList1;
            this.butexit.Location = new System.Drawing.Point(409, 575);
            this.butexit.Name = "butexit";
            this.butexit.Size = new System.Drawing.Size(112, 43);
            this.butexit.TabIndex = 27;
            this.butexit.Text = "Exit";
            this.butexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butexit.UseVisualStyleBackColor = false;
            this.butexit.Click += new System.EventHandler(this.butexit_Click);
            // 
            // butadd
            // 
            this.butadd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butadd.ImageKey = "download (4).png";
            this.butadd.ImageList = this.imageList1;
            this.butadd.Location = new System.Drawing.Point(173, 575);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(129, 43);
            this.butadd.TabIndex = 9;
            this.butadd.Text = "Add";
            this.butadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butadd.UseVisualStyleBackColor = false;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butnew
            // 
            this.butnew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butnew.ImageKey = "icon-Sustainability-300x300.png";
            this.butnew.ImageList = this.imageList1;
            this.butnew.Location = new System.Drawing.Point(30, 575);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(126, 43);
            this.butnew.TabIndex = 8;
            this.butnew.Text = "New";
            this.butnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butnew.UseVisualStyleBackColor = false;
            this.butnew.Click += new System.EventHandler(this.button1_Click);
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(579, 650);
            this.Controls.Add(this.butexit);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butnew);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.supplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button butexit;
        public System.Windows.Forms.Button butadd;
        public System.Windows.Forms.Button butnew;
        public System.Windows.Forms.DateTimePicker DateSupplier;
        public System.Windows.Forms.TextBox text_user_add;
        public System.Windows.Forms.TextBox textSupaddress;
        public System.Windows.Forms.TextBox textSupemail;
        public System.Windows.Forms.TextBox textSupphone;
        public System.Windows.Forms.TextBox textsupName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox Cmb_company;
        public System.Windows.Forms.TextBox text_Sup_ID;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}