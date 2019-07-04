namespace hamedsmms.PL
{
    partial class FORM_USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_USER));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.com_Position_user = new System.Windows.Forms.ComboBox();
            this.text_Fname_user = new System.Windows.Forms.TextBox();
            this.text_PH_user = new System.Windows.Forms.TextBox();
            this.text_PW_user = new System.Windows.Forms.TextBox();
            this.text_name_user = new System.Windows.Forms.TextBox();
            this.text_id_user = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.com_Position_user);
            this.groupBox1.Controls.Add(this.text_Fname_user);
            this.groupBox1.Controls.Add(this.text_PH_user);
            this.groupBox1.Controls.Add(this.text_PW_user);
            this.groupBox1.Controls.Add(this.text_name_user);
            this.groupBox1.Controls.Add(this.text_id_user);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 395);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // com_Position_user
            // 
            this.com_Position_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Position_user.FormattingEnabled = true;
            this.com_Position_user.Items.AddRange(new object[] {
            "Manager",
            "The Data Officer",
            "Casher"});
            this.com_Position_user.Location = new System.Drawing.Point(200, 461);
            this.com_Position_user.Name = "com_Position_user";
            this.com_Position_user.Size = new System.Drawing.Size(216, 30);
            this.com_Position_user.TabIndex = 7;
            this.com_Position_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.com_Position_user_KeyDown);
            // 
            // text_Fname_user
            // 
            this.text_Fname_user.Location = new System.Drawing.Point(200, 190);
            this.text_Fname_user.Name = "text_Fname_user";
            this.text_Fname_user.Size = new System.Drawing.Size(257, 28);
            this.text_Fname_user.TabIndex = 3;
            this.text_Fname_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_Fname_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Fname_user_KeyDown);
            // 
            // text_PH_user
            // 
            this.text_PH_user.Location = new System.Drawing.Point(200, 320);
            this.text_PH_user.Name = "text_PH_user";
            this.text_PH_user.Size = new System.Drawing.Size(257, 28);
            this.text_PH_user.TabIndex = 5;
            this.text_PH_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_PH_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_PH_user_KeyDown);
            // 
            // text_PW_user
            // 
            this.text_PW_user.Location = new System.Drawing.Point(200, 253);
            this.text_PW_user.Name = "text_PW_user";
            this.text_PW_user.Size = new System.Drawing.Size(257, 28);
            this.text_PW_user.TabIndex = 4;
            this.text_PW_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_PW_user.UseSystemPasswordChar = true;
            this.text_PW_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_PW_user_KeyDown);
            // 
            // text_name_user
            // 
            this.text_name_user.Location = new System.Drawing.Point(200, 122);
            this.text_name_user.Name = "text_name_user";
            this.text_name_user.Size = new System.Drawing.Size(257, 28);
            this.text_name_user.TabIndex = 2;
            this.text_name_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_name_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_name_user_KeyDown);
            // 
            // text_id_user
            // 
            this.text_id_user.Location = new System.Drawing.Point(200, 56);
            this.text_id_user.Name = "text_id_user";
            this.text_id_user.Size = new System.Drawing.Size(257, 28);
            this.text_id_user.TabIndex = 1;
            this.text_id_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_id_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_id_user_KeyDown);
            this.text_id_user.Validated += new System.EventHandler(this.text_id_user_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "User Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "User Date Work:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "User Phone:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "User Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "User ID:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.ImageKey = "images (4).png";
            this.btn_add.ImageList = this.imageList1;
            this.btn_add.Location = new System.Drawing.Point(47, 580);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 47);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel-circle-512.png");
            this.imageList1.Images.SetKeyName(1, "images (4).png");
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.ImageKey = "cancel-circle-512.png";
            this.btn_exit.ImageList = this.imageList1;
            this.btn_exit.Location = new System.Drawing.Point(358, 580);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(137, 47);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // FORM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(589, 656);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_USER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New USer";
            this.Load += new System.EventHandler(this.FORM_USER_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox text_id_user;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox com_Position_user;
        public System.Windows.Forms.TextBox text_Fname_user;
        public System.Windows.Forms.TextBox text_PH_user;
        public System.Windows.Forms.TextBox text_PW_user;
        public System.Windows.Forms.TextBox text_name_user;
    }
}