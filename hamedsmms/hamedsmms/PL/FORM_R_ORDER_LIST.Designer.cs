namespace hamedsmms.PL
{
    partial class FORM_R_ORDER_LIST
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
            this.DGV_R_ORDER = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_R_ORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_R_ORDER
            // 
            this.DGV_R_ORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_R_ORDER.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_R_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_R_ORDER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_R_ORDER.Location = new System.Drawing.Point(0, 0);
            this.DGV_R_ORDER.MultiSelect = false;
            this.DGV_R_ORDER.Name = "DGV_R_ORDER";
            this.DGV_R_ORDER.ReadOnly = true;
            this.DGV_R_ORDER.RowTemplate.Height = 24;
            this.DGV_R_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_R_ORDER.Size = new System.Drawing.Size(1144, 675);
            this.DGV_R_ORDER.TabIndex = 1;
            this.DGV_R_ORDER.DoubleClick += new System.EventHandler(this.DGV_R_ORDER_DoubleClick);
            // 
            // FORM_R_ORDER_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 675);
            this.Controls.Add(this.DGV_R_ORDER);
            this.Name = "FORM_R_ORDER_LIST";
            this.Text = "FORM_R_ORDER_LIST";
            this.Load += new System.EventHandler(this.FORM_R_ORDER_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_R_ORDER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_R_ORDER;
    }
}