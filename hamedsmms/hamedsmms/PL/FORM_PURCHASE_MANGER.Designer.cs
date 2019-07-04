namespace hamedsmms.PL
{
    partial class FORM_PURCHASE_MANGER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_PURCHASE_MANGER));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_PUR_MANGER = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_print_all = new System.Windows.Forms.Button();
            this.button_print_selected = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PUR_MANGER)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_PUR_MANGER);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Purchase Bill";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DGV_PUR_MANGER
            // 
            this.DGV_PUR_MANGER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PUR_MANGER.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_PUR_MANGER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PUR_MANGER.Location = new System.Drawing.Point(6, 34);
            this.DGV_PUR_MANGER.Name = "DGV_PUR_MANGER";
            this.DGV_PUR_MANGER.RowTemplate.Height = 24;
            this.DGV_PUR_MANGER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PUR_MANGER.Size = new System.Drawing.Size(1082, 370);
            this.DGV_PUR_MANGER.TabIndex = 0;
            this.DGV_PUR_MANGER.DoubleClick += new System.EventHandler(this.DGV_PUR_MANGER_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_exit);
            this.groupBox2.Controls.Add(this.button_print_all);
            this.groupBox2.Controls.Add(this.button_print_selected);
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Location = new System.Drawing.Point(12, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1094, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_exit.ImageKey = "cancel-circle-512.png";
            this.button_exit.ImageList = this.imageList1;
            this.button_exit.Location = new System.Drawing.Point(943, 31);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(125, 47);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "48-512.png");
            this.imageList1.Images.SetKeyName(1, "bank_check_account_finance_money_financial_item_flat_icon_symbol-512.png");
            this.imageList1.Images.SetKeyName(2, "cancel-circle-512.png");
            this.imageList1.Images.SetKeyName(3, "download (5).png");
            this.imageList1.Images.SetKeyName(4, "print-button-icon-png-2.png");
            this.imageList1.Images.SetKeyName(5, "print-flat.png");
            // 
            // button_print_all
            // 
            this.button_print_all.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_print_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print_all.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_print_all.ImageKey = "print-flat.png";
            this.button_print_all.ImageList = this.imageList1;
            this.button_print_all.Location = new System.Drawing.Point(689, 31);
            this.button_print_all.Name = "button_print_all";
            this.button_print_all.Size = new System.Drawing.Size(183, 47);
            this.button_print_all.TabIndex = 3;
            this.button_print_all.Text = "Print All Bills";
            this.button_print_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_print_all.UseVisualStyleBackColor = false;
            // 
            // button_print_selected
            // 
            this.button_print_selected.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_print_selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print_selected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_print_selected.ImageKey = "print-button-icon-png-2.png";
            this.button_print_selected.ImageList = this.imageList1;
            this.button_print_selected.Location = new System.Drawing.Point(398, 31);
            this.button_print_selected.Name = "button_print_selected";
            this.button_print_selected.Size = new System.Drawing.Size(243, 47);
            this.button_print_selected.TabIndex = 2;
            this.button_print_selected.Text = "Print Selected Bill";
            this.button_print_selected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_print_selected.UseVisualStyleBackColor = false;
            this.button_print_selected.Click += new System.EventHandler(this.button_print_selected_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.ImageKey = "download (5).png";
            this.button_delete.ImageList = this.imageList1;
            this.button_delete.Location = new System.Drawing.Point(210, 31);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(131, 47);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.ImageKey = "48-512.png";
            this.button_add.ImageList = this.imageList1;
            this.button_add.Location = new System.Drawing.Point(23, 31);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(131, 47);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Add";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // FORM_PURCHASE_MANGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1118, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_PURCHASE_MANGER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Management";
            this.Load += new System.EventHandler(this.FORM_PURCHASE_MANGER_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PUR_MANGER)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_PUR_MANGER;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_print_all;
        private System.Windows.Forms.Button button_print_selected;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ImageList imageList1;

    }
}