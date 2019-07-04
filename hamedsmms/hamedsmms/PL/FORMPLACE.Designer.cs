namespace hamedsmms.PL
{
    partial class FORMPLACE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMPLACE));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.complaces = new System.Windows.Forms.ComboBox();
            this.comstands = new System.Windows.Forms.ComboBox();
            this.comflours = new System.Windows.Forms.ComboBox();
            this.comproducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.DGV_Places_list = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Places_list)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.complaces);
            this.groupBox3.Controls.Add(this.comstands);
            this.groupBox3.Controls.Add(this.comflours);
            this.groupBox3.Controls.Add(this.comproducts);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1109, 188);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Place Data:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // complaces
            // 
            this.complaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.complaces.FormattingEnabled = true;
            this.complaces.Items.AddRange(new object[] {
            "Right",
            "Center",
            "Left"});
            this.complaces.Location = new System.Drawing.Point(697, 129);
            this.complaces.Name = "complaces";
            this.complaces.Size = new System.Drawing.Size(214, 30);
            this.complaces.TabIndex = 4;
            this.complaces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.complaces_KeyDown);
            // 
            // comstands
            // 
            this.comstands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comstands.FormattingEnabled = true;
            this.comstands.Items.AddRange(new object[] {
            "Stand 1",
            "Stand 2",
            "Stand 3",
            "Stand 4",
            "Stand 5",
            "Stand 6",
            "Stand 7",
            "Stand 8",
            "Stand 9",
            "Stand 10"});
            this.comstands.Location = new System.Drawing.Point(697, 45);
            this.comstands.Name = "comstands";
            this.comstands.Size = new System.Drawing.Size(214, 30);
            this.comstands.TabIndex = 3;
            this.comstands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comstands_KeyDown);
            // 
            // comflours
            // 
            this.comflours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comflours.FormattingEnabled = true;
            this.comflours.Items.AddRange(new object[] {
            "Flour A",
            "Flour B",
            "Flour C",
            "Flour D"});
            this.comflours.Location = new System.Drawing.Point(223, 129);
            this.comflours.Name = "comflours";
            this.comflours.Size = new System.Drawing.Size(222, 30);
            this.comflours.TabIndex = 2;
            this.comflours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comflours_KeyDown);
            // 
            // comproducts
            // 
            this.comproducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comproducts.FormattingEnabled = true;
            this.comproducts.Location = new System.Drawing.Point(223, 48);
            this.comproducts.Name = "comproducts";
            this.comproducts.Size = new System.Drawing.Size(222, 30);
            this.comproducts.TabIndex = 1;
            this.comproducts.SelectedIndexChanged += new System.EventHandler(this.comproducts_SelectedIndexChanged);
            this.comproducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comproducts_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Place:";
            // 
            // button_Update
            // 
            this.button_Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Update.ImageKey = "upload-location-512.png";
            this.button_Update.ImageList = this.imageList1;
            this.button_Update.Location = new System.Drawing.Point(362, 671);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(133, 50);
            this.button_Update.TabIndex = 66;
            this.button_Update.Text = "Update";
            this.button_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0378af9c9d.png");
            this.imageList1.Images.SetKeyName(1, "delete-place-751596.png");
            this.imageList1.Images.SetKeyName(2, "pin_plus-512.png");
            this.imageList1.Images.SetKeyName(3, "upload-location-512.png");
            this.imageList1.Images.SetKeyName(4, "cancel-circle-512.png");
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
            this.button_Exit.Location = new System.Drawing.Point(955, 671);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(126, 50);
            this.button_Exit.TabIndex = 68;
            this.button_Exit.Text = "Exit";
            this.button_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // DGV_Places_list
            // 
            this.DGV_Places_list.AllowUserToAddRows = false;
            this.DGV_Places_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Places_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_Places_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Places_list.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_Places_list.Location = new System.Drawing.Point(6, 31);
            this.DGV_Places_list.MultiSelect = false;
            this.DGV_Places_list.Name = "DGV_Places_list";
            this.DGV_Places_list.ReadOnly = true;
            this.DGV_Places_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Places_list.Size = new System.Drawing.Size(1097, 378);
            this.DGV_Places_list.TabIndex = 0;
            this.DGV_Places_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Places_list_CellContentClick);
            this.DGV_Places_list.DoubleClick += new System.EventHandler(this.DGV_Places_list_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Places_list);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 415);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List all Places";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.ImageKey = "pin_plus-512.png";
            this.button_add.ImageList = this.imageList1;
            this.button_add.Location = new System.Drawing.Point(90, 671);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(125, 50);
            this.button_add.TabIndex = 65;
            this.button_add.Text = "Add";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Delete.ImageKey = "delete-place-751596.png";
            this.button_Delete.ImageList = this.imageList1;
            this.button_Delete.Location = new System.Drawing.Point(674, 671);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(132, 50);
            this.button_Delete.TabIndex = 67;
            this.button_Delete.Text = "Delete";
            this.button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // FORMPLACE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1135, 752);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORMPLACE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place";
            this.Load += new System.EventHandler(this.FORMPLACE_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Places_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox complaces;
        private System.Windows.Forms.ComboBox comstands;
        private System.Windows.Forms.ComboBox comflours;
        private System.Windows.Forms.ComboBox comproducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridView DGV_Places_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ImageList imageList1;
    }
}