namespace hamedsmms.PL
{
    partial class FORM_PURC_DATILS
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
            this.DGV_PUR_MANGER = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PUR_MANGER)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_PUR_MANGER
            // 
            this.DGV_PUR_MANGER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PUR_MANGER.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_PUR_MANGER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PUR_MANGER.Location = new System.Drawing.Point(10, 30);
            this.DGV_PUR_MANGER.Name = "DGV_PUR_MANGER";
            this.DGV_PUR_MANGER.RowTemplate.Height = 24;
            this.DGV_PUR_MANGER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PUR_MANGER.Size = new System.Drawing.Size(1082, 475);
            this.DGV_PUR_MANGER.TabIndex = 0;
            this.DGV_PUR_MANGER.DoubleClick += new System.EventHandler(this.DGV_PUR_MANGER_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_PUR_MANGER);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 510);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Purchase Details";
            // 
            // FORM_PURC_DATILS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1118, 534);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_PURC_DATILS";
            this.Text = "Purchase Details";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PUR_MANGER)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_PUR_MANGER;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}