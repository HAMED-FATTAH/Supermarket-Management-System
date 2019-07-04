namespace hamedsmms.PL
{
    partial class FORM_CUSTOMERS_LIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_CUSTOMERS_LIST));
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.AllowUserToAddRows = false;
            this.DGV_Customers.AllowUserToDeleteRows = false;
            this.DGV_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Customers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Customers.Location = new System.Drawing.Point(0, 0);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.ReadOnly = true;
            this.DGV_Customers.RowTemplate.Height = 24;
            this.DGV_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Customers.Size = new System.Drawing.Size(852, 447);
            this.DGV_Customers.TabIndex = 0;
            this.DGV_Customers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customers_CellDoubleClick);
            this.DGV_Customers.DoubleClick += new System.EventHandler(this.DGV_Customers_DoubleClick);
            // 
            // FORM_CUSTOMERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 447);
            this.Controls.Add(this.DGV_Customers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_CUSTOMERS_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of All Customers";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_Customers;

    }
}