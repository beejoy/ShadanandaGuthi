namespace ShadanandaGuthi
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemLand = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewLand = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLandList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTenantTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTenantList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLease = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLeaseRentPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRentDue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRentDueByTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRentDueByAllTenants = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SplitContainerHorizontal = new System.Windows.Forms.SplitContainer();
            this.LabelTotalLandsInSelectedLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTotalLands = new System.Windows.Forms.Label();
            this.ListBoxLocations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewLands = new System.Windows.Forms.DataGridView();
            this.ColumnVDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLandArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridViewTenants = new System.Windows.Forms.DataGridView();
            this.ColumnTenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripMenuItemTenantRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerVertical)).BeginInit();
            this.SplitContainerVertical.Panel1.SuspendLayout();
            this.SplitContainerVertical.Panel2.SuspendLayout();
            this.SplitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerHorizontal)).BeginInit();
            this.SplitContainerHorizontal.Panel1.SuspendLayout();
            this.SplitContainerHorizontal.Panel2.SuspendLayout();
            this.SplitContainerHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLand,
            this.ToolStripMenuItemTenant,
            this.ToolStripMenuItemLease});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1370, 28);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemLand
            // 
            this.ToolStripMenuItemLand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewLocation,
            this.ToolStripMenuItemNewLand,
            this.ToolStripMenuItemLandList,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemQuit});
            this.ToolStripMenuItemLand.Name = "ToolStripMenuItemLand";
            this.ToolStripMenuItemLand.Size = new System.Drawing.Size(44, 24);
            this.ToolStripMenuItemLand.Text = "जग्गा";
            // 
            // ToolStripMenuItemNewLocation
            // 
            this.ToolStripMenuItemNewLocation.Name = "ToolStripMenuItemNewLocation";
            this.ToolStripMenuItemNewLocation.Size = new System.Drawing.Size(170, 24);
            this.ToolStripMenuItemNewLocation.Text = "नयाँ स्थान विवरण";
            this.ToolStripMenuItemNewLocation.Click += new System.EventHandler(this.ToolStripMenuItemNewLocation_Click);
            // 
            // ToolStripMenuItemNewLand
            // 
            this.ToolStripMenuItemNewLand.Name = "ToolStripMenuItemNewLand";
            this.ToolStripMenuItemNewLand.Size = new System.Drawing.Size(170, 24);
            this.ToolStripMenuItemNewLand.Text = "नयाँ जग्गा विवरण";
            this.ToolStripMenuItemNewLand.Click += new System.EventHandler(this.ToolStripMenuItemNewLand_Click);
            // 
            // ToolStripMenuItemLandList
            // 
            this.ToolStripMenuItemLandList.Name = "ToolStripMenuItemLandList";
            this.ToolStripMenuItemLandList.Size = new System.Drawing.Size(170, 24);
            this.ToolStripMenuItemLandList.Text = "सम्पूर्ण जग्गाको सूची";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // ToolStripMenuItemQuit
            // 
            this.ToolStripMenuItemQuit.Name = "ToolStripMenuItemQuit";
            this.ToolStripMenuItemQuit.Size = new System.Drawing.Size(170, 24);
            this.ToolStripMenuItemQuit.Text = "बन्द गर्नुहोस्";
            this.ToolStripMenuItemQuit.Click += new System.EventHandler(this.ToolStripMenuItemQuit_Click);
            // 
            // ToolStripMenuItemTenant
            // 
            this.ToolStripMenuItemTenant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewTenant,
            this.ToolStripMenuItemTenantRegister,
            this.ToolStripMenuItemTenantTransfer,
            this.ToolStripMenuItemTenantList});
            this.ToolStripMenuItemTenant.Name = "ToolStripMenuItemTenant";
            this.ToolStripMenuItemTenant.Size = new System.Drawing.Size(42, 24);
            this.ToolStripMenuItemTenant.Text = "मोही";
            // 
            // ToolStripMenuItemNewTenant
            // 
            this.ToolStripMenuItemNewTenant.Name = "ToolStripMenuItemNewTenant";
            this.ToolStripMenuItemNewTenant.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemNewTenant.Text = "नयाँ मोही विवरण";
            this.ToolStripMenuItemNewTenant.Click += new System.EventHandler(this.ToolStripMenuItemNewTenant_Click);
            // 
            // ToolStripMenuItemTenantTransfer
            // 
            this.ToolStripMenuItemTenantTransfer.Name = "ToolStripMenuItemTenantTransfer";
            this.ToolStripMenuItemTenantTransfer.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemTenantTransfer.Text = "मोही हस्तान्तरण";
            // 
            // ToolStripMenuItemTenantList
            // 
            this.ToolStripMenuItemTenantList.Name = "ToolStripMenuItemTenantList";
            this.ToolStripMenuItemTenantList.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemTenantList.Text = "सम्पूर्ण मोहीको सूची";
            // 
            // ToolStripMenuItemLease
            // 
            this.ToolStripMenuItemLease.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLeaseRentPayment,
            this.ToolStripMenuItemRentDue});
            this.ToolStripMenuItemLease.Name = "ToolStripMenuItemLease";
            this.ToolStripMenuItemLease.Size = new System.Drawing.Size(49, 24);
            this.ToolStripMenuItemLease.Text = "ठेक्का";
            // 
            // ToolStripMenuItemLeaseRentPayment
            // 
            this.ToolStripMenuItemLeaseRentPayment.Name = "ToolStripMenuItemLeaseRentPayment";
            this.ToolStripMenuItemLeaseRentPayment.Size = new System.Drawing.Size(224, 24);
            this.ToolStripMenuItemLeaseRentPayment.Text = "ठेक्का संकलन";
            // 
            // ToolStripMenuItemRentDue
            // 
            this.ToolStripMenuItemRentDue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRentDueByTenant,
            this.ToolStripMenuItemRentDueByAllTenants});
            this.ToolStripMenuItemRentDue.Name = "ToolStripMenuItemRentDue";
            this.ToolStripMenuItemRentDue.Size = new System.Drawing.Size(224, 24);
            this.ToolStripMenuItemRentDue.Text = "बुझाएको वा बुझाउन बाँकी ठेक्का";
            // 
            // ToolStripMenuItemRentDueByTenant
            // 
            this.ToolStripMenuItemRentDueByTenant.Name = "ToolStripMenuItemRentDueByTenant";
            this.ToolStripMenuItemRentDueByTenant.Size = new System.Drawing.Size(165, 24);
            this.ToolStripMenuItemRentDueByTenant.Text = "मोही अनुसार";
            // 
            // ToolStripMenuItemRentDueByAllTenants
            // 
            this.ToolStripMenuItemRentDueByAllTenants.Name = "ToolStripMenuItemRentDueByAllTenants";
            this.ToolStripMenuItemRentDueByAllTenants.Size = new System.Drawing.Size(165, 24);
            this.ToolStripMenuItemRentDueByAllTenants.Text = "सबैको एकमुष्ट सूची";
            // 
            // SplitContainerVertical
            // 
            this.SplitContainerVertical.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerVertical.IsSplitterFixed = true;
            this.SplitContainerVertical.Location = new System.Drawing.Point(0, 28);
            this.SplitContainerVertical.Name = "SplitContainerVertical";
            // 
            // SplitContainerVertical.Panel1
            // 
            this.SplitContainerVertical.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainerVertical.Panel1.Controls.Add(this.pictureBox1);
            this.SplitContainerVertical.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // SplitContainerVertical.Panel2
            // 
            this.SplitContainerVertical.Panel2.Controls.Add(this.SplitContainerHorizontal);
            this.SplitContainerVertical.Size = new System.Drawing.Size(1370, 681);
            this.SplitContainerVertical.SplitterDistance = 427;
            this.SplitContainerVertical.TabIndex = 2;
            this.SplitContainerVertical.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ShadanandaGuthi.Properties.Resources.shadananda_guru_705x965px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 648);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SplitContainerHorizontal
            // 
            this.SplitContainerHorizontal.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerHorizontal.IsSplitterFixed = true;
            this.SplitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerHorizontal.Name = "SplitContainerHorizontal";
            this.SplitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerHorizontal.Panel1
            // 
            this.SplitContainerHorizontal.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainerHorizontal.Panel1.Controls.Add(this.LabelTotalLandsInSelectedLocation);
            this.SplitContainerHorizontal.Panel1.Controls.Add(this.label1);
            this.SplitContainerHorizontal.Panel1.Controls.Add(this.LabelTotalLands);
            this.SplitContainerHorizontal.Panel1.Controls.Add(this.ListBoxLocations);
            this.SplitContainerHorizontal.Panel1.Controls.Add(this.label2);
            this.SplitContainerHorizontal.Panel1.Controls.Add(this.DataGridViewLands);
            this.SplitContainerHorizontal.Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 5);
            // 
            // SplitContainerHorizontal.Panel2
            // 
            this.SplitContainerHorizontal.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainerHorizontal.Panel2.Controls.Add(this.label3);
            this.SplitContainerHorizontal.Panel2.Controls.Add(this.DataGridViewTenants);
            this.SplitContainerHorizontal.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.SplitContainerHorizontal.Size = new System.Drawing.Size(939, 681);
            this.SplitContainerHorizontal.SplitterDistance = 426;
            this.SplitContainerHorizontal.TabIndex = 0;
            this.SplitContainerHorizontal.TabStop = false;
            // 
            // LabelTotalLandsInSelectedLocation
            // 
            this.LabelTotalLandsInSelectedLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTotalLandsInSelectedLocation.AutoSize = true;
            this.LabelTotalLandsInSelectedLocation.Location = new System.Drawing.Point(911, 10);
            this.LabelTotalLandsInSelectedLocation.Name = "LabelTotalLandsInSelectedLocation";
            this.LabelTotalLandsInSelectedLocation.Size = new System.Drawing.Size(15, 20);
            this.LabelTotalLandsInSelectedLocation.TabIndex = 4;
            this.LabelTotalLandsInSelectedLocation.Text = "०";
            this.LabelTotalLandsInSelectedLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "जग्गा भएको स्थान";
            // 
            // LabelTotalLands
            // 
            this.LabelTotalLands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTotalLands.AutoSize = true;
            this.LabelTotalLands.Location = new System.Drawing.Point(779, 10);
            this.LabelTotalLands.Name = "LabelTotalLands";
            this.LabelTotalLands.Size = new System.Drawing.Size(130, 20);
            this.LabelTotalLands.TabIndex = 3;
            this.LabelTotalLands.Text = "जम्मा कित्ता (जग्गा) संख्या :";
            this.LabelTotalLands.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ListBoxLocations
            // 
            this.ListBoxLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxLocations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxLocations.FormattingEnabled = true;
            this.ListBoxLocations.ItemHeight = 20;
            this.ListBoxLocations.Location = new System.Drawing.Point(7, 33);
            this.ListBoxLocations.Name = "ListBoxLocations";
            this.ListBoxLocations.Size = new System.Drawing.Size(303, 382);
            this.ListBoxLocations.TabIndex = 0;
            this.ListBoxLocations.SelectedIndexChanged += new System.EventHandler(this.ListBoxLocations_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "जग्गा विवरण";
            // 
            // DataGridViewLands
            // 
            this.DataGridViewLands.AllowUserToAddRows = false;
            this.DataGridViewLands.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewLands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewLands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridViewLands.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewLands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVDC,
            this.ColumnPlotNumber,
            this.ColumnLandArea});
            this.DataGridViewLands.Location = new System.Drawing.Point(330, 33);
            this.DataGridViewLands.Name = "DataGridViewLands";
            this.DataGridViewLands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLands.Size = new System.Drawing.Size(596, 382);
            this.DataGridViewLands.TabIndex = 0;
            this.DataGridViewLands.SelectionChanged += new System.EventHandler(this.DataGridViewLands_SelectionChanged);
            // 
            // ColumnVDC
            // 
            this.ColumnVDC.HeaderText = "गा.वि.स.";
            this.ColumnVDC.Name = "ColumnVDC";
            // 
            // ColumnPlotNumber
            // 
            this.ColumnPlotNumber.HeaderText = "कित्ता नं.";
            this.ColumnPlotNumber.Name = "ColumnPlotNumber";
            // 
            // ColumnLandArea
            // 
            this.ColumnLandArea.HeaderText = "क्षेत्रफल";
            this.ColumnLandArea.Name = "ColumnLandArea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "मोही विवरण";
            // 
            // DataGridViewTenants
            // 
            this.DataGridViewTenants.AllowUserToAddRows = false;
            this.DataGridViewTenants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewTenants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTenants.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTenant,
            this.ColumnAddress,
            this.ColumnMobileNumber,
            this.ColumnFather});
            this.DataGridViewTenants.Location = new System.Drawing.Point(7, 28);
            this.DataGridViewTenants.Name = "DataGridViewTenants";
            this.DataGridViewTenants.Size = new System.Drawing.Size(919, 179);
            this.DataGridViewTenants.TabIndex = 0;
            this.DataGridViewTenants.SelectionChanged += new System.EventHandler(this.DataGridViewTenants_SelectionChanged);
            // 
            // ColumnTenant
            // 
            this.ColumnTenant.HeaderText = "मोहीको नाम";
            this.ColumnTenant.Name = "ColumnTenant";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "ठेगाना";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // ColumnMobileNumber
            // 
            this.ColumnMobileNumber.HeaderText = "मोबाइल नं.";
            this.ColumnMobileNumber.Name = "ColumnMobileNumber";
            // 
            // ColumnFather
            // 
            this.ColumnFather.HeaderText = "पिताको नाम";
            this.ColumnFather.Name = "ColumnFather";
            // 
            // ToolStripMenuItemTenantRegister
            // 
            this.ToolStripMenuItemTenantRegister.Name = "ToolStripMenuItemTenantRegister";
            this.ToolStripMenuItemTenantRegister.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemTenantRegister.Text = "मोही दर्ता";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.SplitContainerVertical);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "श्री षडानन्द सीताराम गुठी व्यवस्थापन संस्था १९३२, दिङ्गला, भोजपुर";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.SplitContainerVertical.Panel1.ResumeLayout(false);
            this.SplitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerVertical)).EndInit();
            this.SplitContainerVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SplitContainerHorizontal.Panel1.ResumeLayout(false);
            this.SplitContainerHorizontal.Panel1.PerformLayout();
            this.SplitContainerHorizontal.Panel2.ResumeLayout(false);
            this.SplitContainerHorizontal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerHorizontal)).EndInit();
            this.SplitContainerHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLand;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewLand;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTenant;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewTenant;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTenantTransfer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLease;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLeaseRentPayment;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLandList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTenantList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRentDue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewLocation;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRentDueByTenant;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRentDueByAllTenants;
        private System.Windows.Forms.SplitContainer SplitContainerVertical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer SplitContainerHorizontal;
        private System.Windows.Forms.DataGridView DataGridViewLands;
        private System.Windows.Forms.DataGridView DataGridViewTenants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLandArea;
        private System.Windows.Forms.Label LabelTotalLands;
        private System.Windows.Forms.Label LabelTotalLandsInSelectedLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFather;
        private System.Windows.Forms.ListBox ListBoxLocations;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTenantRegister;
    }
}

