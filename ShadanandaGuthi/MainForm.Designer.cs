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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLand = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageTenant = new System.Windows.Forms.TabPage();
            this.tabPageLease = new System.Windows.Forms.TabPage();
            this.tabPageMiscellaneous = new System.Windows.Forms.TabPage();
            this.MainMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.ToolStripMenuItemNewLocation.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemNewLocation.Text = "नयाँ स्थान विवरण";
            this.ToolStripMenuItemNewLocation.Click += new System.EventHandler(this.ToolStripMenuItemNewLocation_Click);
            // 
            // ToolStripMenuItemNewLand
            // 
            this.ToolStripMenuItemNewLand.Name = "ToolStripMenuItemNewLand";
            this.ToolStripMenuItemNewLand.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemNewLand.Text = "नयाँ जग्गा विवरण";
            this.ToolStripMenuItemNewLand.Click += new System.EventHandler(this.ToolStripMenuItemNewLand_Click);
            // 
            // ToolStripMenuItemLandList
            // 
            this.ToolStripMenuItemLandList.Name = "ToolStripMenuItemLandList";
            this.ToolStripMenuItemLandList.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemLandList.Text = "सम्पूर्ण जग्गाको सूची";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItemQuit
            // 
            this.ToolStripMenuItemQuit.Name = "ToolStripMenuItemQuit";
            this.ToolStripMenuItemQuit.Size = new System.Drawing.Size(180, 24);
            this.ToolStripMenuItemQuit.Text = "बन्द गर्नुहोस्";
            this.ToolStripMenuItemQuit.Click += new System.EventHandler(this.ToolStripMenuItemQuit_Click);
            // 
            // ToolStripMenuItemTenant
            // 
            this.ToolStripMenuItemTenant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewTenant,
            this.ToolStripMenuItemTenantTransfer,
            this.ToolStripMenuItemTenantList});
            this.ToolStripMenuItemTenant.Name = "ToolStripMenuItemTenant";
            this.ToolStripMenuItemTenant.Size = new System.Drawing.Size(42, 24);
            this.ToolStripMenuItemTenant.Text = "मोही";
            // 
            // ToolStripMenuItemNewTenant
            // 
            this.ToolStripMenuItemNewTenant.Name = "ToolStripMenuItemNewTenant";
            this.ToolStripMenuItemNewTenant.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItemNewTenant.Text = "नयाँ मोही दर्ता";
            this.ToolStripMenuItemNewTenant.Click += new System.EventHandler(this.ToolStripMenuItemNewTenant_Click);
            // 
            // ToolStripMenuItemTenantTransfer
            // 
            this.ToolStripMenuItemTenantTransfer.Name = "ToolStripMenuItemTenantTransfer";
            this.ToolStripMenuItemTenantTransfer.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItemTenantTransfer.Text = "मोही हस्तान्तरण";
            // 
            // ToolStripMenuItemTenantList
            // 
            this.ToolStripMenuItemTenantList.Name = "ToolStripMenuItemTenantList";
            this.ToolStripMenuItemTenantList.Size = new System.Drawing.Size(168, 24);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLand);
            this.tabControl1.Controls.Add(this.tabPageTenant);
            this.tabControl1.Controls.Add(this.tabPageLease);
            this.tabControl1.Controls.Add(this.tabPageMiscellaneous);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1370, 685);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLand
            // 
            this.tabPageLand.Controls.Add(this.label1);
            this.tabPageLand.Controls.Add(this.dataGridView1);
            this.tabPageLand.Location = new System.Drawing.Point(4, 29);
            this.tabPageLand.Name = "tabPageLand";
            this.tabPageLand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLand.Size = new System.Drawing.Size(1362, 652);
            this.tabPageLand.TabIndex = 0;
            this.tabPageLand.Text = "जग्गा विवरण";
            this.tabPageLand.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "गुठीको नाममा रहेका जग्गाहरु";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(604, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageTenant
            // 
            this.tabPageTenant.Location = new System.Drawing.Point(4, 29);
            this.tabPageTenant.Name = "tabPageTenant";
            this.tabPageTenant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTenant.Size = new System.Drawing.Size(1362, 652);
            this.tabPageTenant.TabIndex = 1;
            this.tabPageTenant.Text = "मोही विवरण";
            this.tabPageTenant.UseVisualStyleBackColor = true;
            // 
            // tabPageLease
            // 
            this.tabPageLease.Location = new System.Drawing.Point(4, 29);
            this.tabPageLease.Name = "tabPageLease";
            this.tabPageLease.Size = new System.Drawing.Size(1362, 652);
            this.tabPageLease.TabIndex = 2;
            this.tabPageLease.Text = "ठेक्का";
            this.tabPageLease.UseVisualStyleBackColor = true;
            // 
            // tabPageMiscellaneous
            // 
            this.tabPageMiscellaneous.Location = new System.Drawing.Point(4, 29);
            this.tabPageMiscellaneous.Name = "tabPageMiscellaneous";
            this.tabPageMiscellaneous.Size = new System.Drawing.Size(1362, 652);
            this.tabPageMiscellaneous.TabIndex = 3;
            this.tabPageMiscellaneous.Text = "विविध";
            this.tabPageMiscellaneous.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 713);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "श्री षडानन्द सीताराम गुठी व्यवस्थापन संस्था १९३२, दिङ्गला, भोजपुर";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Enter += new System.EventHandler(this.MainForm_Enter);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLand.ResumeLayout(false);
            this.tabPageLand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLand;
        private System.Windows.Forms.TabPage tabPageTenant;
        private System.Windows.Forms.TabPage tabPageLease;
        private System.Windows.Forms.TabPage tabPageMiscellaneous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

