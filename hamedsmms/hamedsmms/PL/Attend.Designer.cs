namespace hamedsmms.PL
{
    partial class Attend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attend));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.DTPAttend = new System.Windows.Forms.DateTimePicker();
            this.DTPDepart = new System.Windows.Forms.DateTimePicker();
            this.DTPPeriod = new System.Windows.Forms.DateTimePicker();
            this.labstateAttend = new System.Windows.Forms.Label();
            this.labStateDepart = new System.Windows.Forms.Label();
            this.DGVTimeWork = new System.Windows.Forms.DataGridView();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTimeWork)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attend Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Depart Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Period Date";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(163, 45);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(148, 25);
            this.txtUserID.TabIndex = 5;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            this.txtUserID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserID_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(163, 106);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(234, 25);
            this.txtUserName.TabIndex = 6;
            // 
            // DTPAttend
            // 
            this.DTPAttend.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPAttend.Location = new System.Drawing.Point(163, 220);
            this.DTPAttend.Name = "DTPAttend";
            this.DTPAttend.Size = new System.Drawing.Size(234, 25);
            this.DTPAttend.TabIndex = 7;
            // 
            // DTPDepart
            // 
            this.DTPDepart.CustomFormat = " ";
            this.DTPDepart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPDepart.Location = new System.Drawing.Point(163, 277);
            this.DTPDepart.Name = "DTPDepart";
            this.DTPDepart.Size = new System.Drawing.Size(234, 25);
            this.DTPDepart.TabIndex = 8;
            // 
            // DTPPeriod
            // 
            this.DTPPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPPeriod.Location = new System.Drawing.Point(163, 338);
            this.DTPPeriod.Name = "DTPPeriod";
            this.DTPPeriod.Size = new System.Drawing.Size(234, 25);
            this.DTPPeriod.TabIndex = 9;
            // 
            // labstateAttend
            // 
            this.labstateAttend.AutoSize = true;
            this.labstateAttend.BackColor = System.Drawing.Color.Maroon;
            this.labstateAttend.ForeColor = System.Drawing.Color.White;
            this.labstateAttend.Location = new System.Drawing.Point(168, 413);
            this.labstateAttend.Name = "labstateAttend";
            this.labstateAttend.Size = new System.Drawing.Size(56, 17);
            this.labstateAttend.TabIndex = 10;
            this.labstateAttend.Text = "Attend";
            this.labstateAttend.Visible = false;
            // 
            // labStateDepart
            // 
            this.labStateDepart.AutoSize = true;
            this.labStateDepart.BackColor = System.Drawing.Color.Maroon;
            this.labStateDepart.ForeColor = System.Drawing.Color.White;
            this.labStateDepart.Location = new System.Drawing.Point(341, 413);
            this.labStateDepart.Name = "labStateDepart";
            this.labStateDepart.Size = new System.Drawing.Size(58, 17);
            this.labStateDepart.TabIndex = 11;
            this.labStateDepart.Text = "Depart";
            this.labStateDepart.Visible = false;
            // 
            // DGVTimeWork
            // 
            this.DGVTimeWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVTimeWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTimeWork.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVTimeWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTimeWork.Location = new System.Drawing.Point(438, 12);
            this.DGVTimeWork.Name = "DGVTimeWork";
            this.DGVTimeWork.RowTemplate.Height = 24;
            this.DGVTimeWork.Size = new System.Drawing.Size(749, 576);
            this.DGVTimeWork.TabIndex = 12;
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(163, 162);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(234, 25);
            this.txtUserType.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "User Type";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Attend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1199, 600);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGVTimeWork);
            this.Controls.Add(this.labStateDepart);
            this.Controls.Add(this.labstateAttend);
            this.Controls.Add(this.DTPPeriod);
            this.Controls.Add(this.DTPDepart);
            this.Controls.Add(this.DTPAttend);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Allocation";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTimeWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DateTimePicker DTPAttend;
        private System.Windows.Forms.DateTimePicker DTPDepart;
        private System.Windows.Forms.DateTimePicker DTPPeriod;
        private System.Windows.Forms.Label labstateAttend;
        private System.Windows.Forms.Label labStateDepart;
        private System.Windows.Forms.DataGridView DGVTimeWork;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}