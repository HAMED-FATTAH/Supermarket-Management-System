namespace hamedsmms.PL
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createABackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreABackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.categoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.placesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.campaniesManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bills = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addReturnBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBillManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.userToolStripMenuItem,
            this.bills});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.fileToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1331, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AutoSize = false;
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.createABackupToolStripMenuItem,
            this.restoreABackupToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Image = global::hamedsmms.Properties.Resources._2109135;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.Check_icon;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.loginToolStripMenuItem.Text = "Sign in";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // createABackupToolStripMenuItem
            // 
            this.createABackupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createABackupToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.database_restore_512;
            this.createABackupToolStripMenuItem.Name = "createABackupToolStripMenuItem";
            this.createABackupToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.createABackupToolStripMenuItem.Text = "Create a backup";
            this.createABackupToolStripMenuItem.Click += new System.EventHandler(this.createABackupToolStripMenuItem_Click);
            // 
            // restoreABackupToolStripMenuItem
            // 
            this.restoreABackupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.restoreABackupToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.Crm_Customer_Relationship_Management__Client_512;
            this.restoreABackupToolStripMenuItem.Name = "restoreABackupToolStripMenuItem";
            this.restoreABackupToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.restoreABackupToolStripMenuItem.Text = "Restore a backup";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signOutToolStripMenuItem.Image = global::hamedsmms.Properties.Resources._38_512;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.signOutToolStripMenuItem.Text = "sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.AutoSize = false;
            this.productsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewProductToolStripMenuItem,
            this.productManagementToolStripMenuItem,
            this.toolStripSeparator1,
            this.categoryManagementToolStripMenuItem,
            this.toolStripSeparator5,
            this.placesToolStripMenuItem});
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.Artboard_18_512;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(145, 27);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addANewProductToolStripMenuItem
            // 
            this.addANewProductToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addANewProductToolStripMenuItem.Image = global::hamedsmms.Properties.Resources._27_shop_cart_shopping_sale_offer_discount_ecommerce_finance_512;
            this.addANewProductToolStripMenuItem.Name = "addANewProductToolStripMenuItem";
            this.addANewProductToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.addANewProductToolStripMenuItem.Text = "Add a new product";
            this.addANewProductToolStripMenuItem.Click += new System.EventHandler(this.addANewProductToolStripMenuItem_Click);
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.productManagementToolStripMenuItem.Image = global::hamedsmms.Properties.Resources._878543_open_512x512;
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            this.productManagementToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.productManagementToolStripMenuItem.Text = "Product Management";
            this.productManagementToolStripMenuItem.Click += new System.EventHandler(this.productManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(266, 6);
            // 
            // categoryManagementToolStripMenuItem
            // 
            this.categoryManagementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryManagementToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.category_management;
            this.categoryManagementToolStripMenuItem.Name = "categoryManagementToolStripMenuItem";
            this.categoryManagementToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.categoryManagementToolStripMenuItem.Text = "Category Management";
            this.categoryManagementToolStripMenuItem.Click += new System.EventHandler(this.categoryManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(266, 6);
            // 
            // placesToolStripMenuItem
            // 
            this.placesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.placesToolStripMenuItem.Image = global::hamedsmms.Properties.Resources._0378af9c9d;
            this.placesToolStripMenuItem.Name = "placesToolStripMenuItem";
            this.placesToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.placesToolStripMenuItem.Text = "Places";
            this.placesToolStripMenuItem.Click += new System.EventHandler(this.placesToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.AutoSize = false;
            this.customersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerManagementToolStripMenuItem});
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.user_login_man_person_location_place_geo_point_50935;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(158, 27);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // customerManagementToolStripMenuItem
            // 
            this.customerManagementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerManagementToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.download__1_;
            this.customerManagementToolStripMenuItem.Name = "customerManagementToolStripMenuItem";
            this.customerManagementToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.customerManagementToolStripMenuItem.Text = "Customer Management";
            this.customerManagementToolStripMenuItem.Click += new System.EventHandler(this.customerManagementToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.AutoSize = false;
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSuppliersToolStripMenuItem,
            this.suppliersManagementToolStripMenuItem,
            this.toolStripSeparator4,
            this.campaniesManagementToolStripMenuItem1});
            this.supplierToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.images__2_;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(105, 27);
            this.supplierToolStripMenuItem.Text = "Suppliers";
            // 
            // addNewSuppliersToolStripMenuItem
            // 
            this.addNewSuppliersToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewSuppliersToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.images__3_;
            this.addNewSuppliersToolStripMenuItem.Name = "addNewSuppliersToolStripMenuItem";
            this.addNewSuppliersToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.addNewSuppliersToolStripMenuItem.Text = "Add New Suppliers";
            this.addNewSuppliersToolStripMenuItem.Click += new System.EventHandler(this.addNewSuppliersToolStripMenuItem_Click);
            // 
            // suppliersManagementToolStripMenuItem
            // 
            this.suppliersManagementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suppliersManagementToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.Inventory_512;
            this.suppliersManagementToolStripMenuItem.Name = "suppliersManagementToolStripMenuItem";
            this.suppliersManagementToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.suppliersManagementToolStripMenuItem.Text = "Suppliers Management";
            this.suppliersManagementToolStripMenuItem.Click += new System.EventHandler(this.suppliersManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(284, 6);
            // 
            // campaniesManagementToolStripMenuItem1
            // 
            this.campaniesManagementToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.campaniesManagementToolStripMenuItem1.Image = global::hamedsmms.Properties.Resources.meeting_512;
            this.campaniesManagementToolStripMenuItem1.Name = "campaniesManagementToolStripMenuItem1";
            this.campaniesManagementToolStripMenuItem1.Size = new System.Drawing.Size(287, 26);
            this.campaniesManagementToolStripMenuItem1.Text = "Campanies Management";
            this.campaniesManagementToolStripMenuItem1.Click += new System.EventHandler(this.campaniesManagementToolStripMenuItem1_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.AutoSize = false;
            this.userToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.computer_1331579_960_720;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.userToolStripMenuItem.Size = new System.Drawing.Size(122, 27);
            this.userToolStripMenuItem.Text = "Users";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.images__4_;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.addToolStripMenuItem.Text = "Add a new user ";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userManagementToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.user_28_512;
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // bills
            // 
            this.bills.AutoSize = false;
            this.bills.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bills.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSaleToolStripMenuItem,
            this.slesManagementToolStripMenuItem,
            this.toolStripSeparator3,
            this.addNewPurchaseToolStripMenuItem,
            this.purchasesManagementToolStripMenuItem,
            this.toolStripSeparator2,
            this.addReturnBillToolStripMenuItem,
            this.returnBillManagementToolStripMenuItem});
            this.bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bills.Image = global::hamedsmms.Properties.Resources.download__2_;
            this.bills.Name = "bills";
            this.bills.Size = new System.Drawing.Size(75, 27);
            this.bills.Text = "Bills";
            this.bills.Click += new System.EventHandler(this.sellsPurchaseToolStripMenuItem_Click);
            // 
            // addNewSaleToolStripMenuItem
            // 
            this.addNewSaleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewSaleToolStripMenuItem.Image = global::hamedsmms.Properties.Resources._400_F_200033431_ydgCPftKemsyw7ybiTusYTJDtnmhtTri;
            this.addNewSaleToolStripMenuItem.Name = "addNewSaleToolStripMenuItem";
            this.addNewSaleToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.addNewSaleToolStripMenuItem.Text = "Add New Sale";
            this.addNewSaleToolStripMenuItem.Click += new System.EventHandler(this.addNewSaleToolStripMenuItem_Click);
            // 
            // slesManagementToolStripMenuItem
            // 
            this.slesManagementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.slesManagementToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.product20_512;
            this.slesManagementToolStripMenuItem.Name = "slesManagementToolStripMenuItem";
            this.slesManagementToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.slesManagementToolStripMenuItem.Text = "Sles Management";
            this.slesManagementToolStripMenuItem.Click += new System.EventHandler(this.slesManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(281, 6);
            
            // 
            // addNewPurchaseToolStripMenuItem
            // 
            this.addNewPurchaseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNewPurchaseToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.download__3_;
            this.addNewPurchaseToolStripMenuItem.Name = "addNewPurchaseToolStripMenuItem";
            this.addNewPurchaseToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.addNewPurchaseToolStripMenuItem.Text = "Add New Purchase";
            this.addNewPurchaseToolStripMenuItem.Click += new System.EventHandler(this.addNewPurchaseToolStripMenuItem_Click);
            // 
            // purchasesManagementToolStripMenuItem
            // 
            this.purchasesManagementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.purchasesManagementToolStripMenuItem.Image = global::hamedsmms.Properties.Resources.images__6_;
            this.purchasesManagementToolStripMenuItem.Name = "purchasesManagementToolStripMenuItem";
            this.purchasesManagementToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.purchasesManagementToolStripMenuItem.Text = "Purchases Management";
            this.purchasesManagementToolStripMenuItem.Click += new System.EventHandler(this.purchasesManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(281, 6);
            // 
            // addReturnBillToolStripMenuItem
            // 
            this.addReturnBillToolStripMenuItem.Name = "addReturnBillToolStripMenuItem";
            this.addReturnBillToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.addReturnBillToolStripMenuItem.Text = "Add Return Bill";
            this.addReturnBillToolStripMenuItem.Click += new System.EventHandler(this.addReturnBillToolStripMenuItem_Click);
            // 
            // returnBillManagementToolStripMenuItem
            // 
            this.returnBillManagementToolStripMenuItem.Name = "returnBillManagementToolStripMenuItem";
            this.returnBillManagementToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.returnBillManagementToolStripMenuItem.Text = "Return Bill Management";
            this.returnBillManagementToolStripMenuItem.Click += new System.EventHandler(this.returnBillManagementToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "27_shop_cart_shopping_sale_offer_discount_ecommerce_finance-512.png");
            this.imageList1.Images.SetKeyName(1, "38-512.png");
            this.imageList1.Images.SetKeyName(2, "117-512.png");
            this.imageList1.Images.SetKeyName(3, "240_F_21272014_nTk5PGaSaiRdM3Os4dPA4AHbUpoeHqsu.jpg");
            this.imageList1.Images.SetKeyName(4, "235185.png");
            this.imageList1.Images.SetKeyName(5, "318582.png");
            this.imageList1.Images.SetKeyName(6, "878543_open_512x512.png");
            this.imageList1.Images.SetKeyName(7, "2109135.png");
            this.imageList1.Images.SetKeyName(8, "11872095-print-web-button.jpg");
            this.imageList1.Images.SetKeyName(9, "add.ico");
            this.imageList1.Images.SetKeyName(10, "add-circle-green-512.png");
            this.imageList1.Images.SetKeyName(11, "add-new-user-account-icon-flat-style-vector-12254221.jpg");
            this.imageList1.Images.SetKeyName(12, "Artboard_18-512.png");
            this.imageList1.Images.SetKeyName(13, "category-management.jpg");
            this.imageList1.Images.SetKeyName(14, "Check-icon.png");
            this.imageList1.Images.SetKeyName(15, "closeSlideShow.png");
            this.imageList1.Images.SetKeyName(16, "Crm_Customer_Relationship_Management__Client-512.png");
            this.imageList1.Images.SetKeyName(17, "database-restore-512.png");
            this.imageList1.Images.SetKeyName(18, "images (2).png");
            this.imageList1.Images.SetKeyName(19, "images (3).png");
            this.imageList1.Images.SetKeyName(20, "Inventory-512.png");
            this.imageList1.Images.SetKeyName(21, "48-512.png");
            this.imageList1.Images.SetKeyName(22, "400_F_200033431_ydgCPftKemsyw7ybiTusYTJDtnmhtTri.jpg");
            this.imageList1.Images.SetKeyName(23, "download (2).png");
            this.imageList1.Images.SetKeyName(24, "download (3).png");
            this.imageList1.Images.SetKeyName(25, "images (6).png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::hamedsmms.Properties.Resources.VvBDobI2;
            this.pictureBox1.Location = new System.Drawing.Point(14, 1114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hamedsmms.Properties.Resources.dairy_food_grocery_811102;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem addANewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem categoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem createABackupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem restoreABackupToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem suppliersManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem bills;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem campaniesManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem placesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripMenuItem addNewSaleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem slesManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewPurchaseToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem purchasesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addReturnBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBillManagementToolStripMenuItem;
    }
}