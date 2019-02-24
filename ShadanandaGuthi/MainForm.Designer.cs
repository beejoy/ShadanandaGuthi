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
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemLand = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewLand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTenantTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLease = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLeaseRentPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.समपरणमहसचToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.बझएकवबझउनबकठककToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(490, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "जग्गा तथा मोही व्यवस्थापन प्रणाली";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLand,
            this.ToolStripMenuItemTenant,
            this.ToolStripMenuItemLease});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1370, 29);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemLand
            // 
            this.ToolStripMenuItemLand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewLand,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemQuit});
            this.ToolStripMenuItemLand.Name = "ToolStripMenuItemLand";
            this.ToolStripMenuItemLand.Size = new System.Drawing.Size(53, 25);
            this.ToolStripMenuItemLand.Text = "जग्गा";
            // 
            // ToolStripMenuItemNewLand
            // 
            this.ToolStripMenuItemNewLand.Name = "ToolStripMenuItemNewLand";
            this.ToolStripMenuItemNewLand.Size = new System.Drawing.Size(204, 26);
            this.ToolStripMenuItemNewLand.Text = "नयाँ जग्गा विवरण";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // ToolStripMenuItemQuit
            // 
            this.ToolStripMenuItemQuit.Name = "ToolStripMenuItemQuit";
            this.ToolStripMenuItemQuit.Size = new System.Drawing.Size(204, 26);
            this.ToolStripMenuItemQuit.Text = "बन्द गर्नुहोस्";
            this.ToolStripMenuItemQuit.Click += new System.EventHandler(this.ToolStripMenuItemQuit_Click);
            // 
            // ToolStripMenuItemTenant
            // 
            this.ToolStripMenuItemTenant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewTenant,
            this.ToolStripMenuItemTenantTransfer,
            this.समपरणमहसचToolStripMenuItem});
            this.ToolStripMenuItemTenant.Name = "ToolStripMenuItemTenant";
            this.ToolStripMenuItemTenant.Size = new System.Drawing.Size(51, 25);
            this.ToolStripMenuItemTenant.Text = "मोही";
            // 
            // ToolStripMenuItemNewTenant
            // 
            this.ToolStripMenuItemNewTenant.Name = "ToolStripMenuItemNewTenant";
            this.ToolStripMenuItemNewTenant.Size = new System.Drawing.Size(202, 26);
            this.ToolStripMenuItemNewTenant.Text = "नयाँ मोही दर्ता";
            // 
            // ToolStripMenuItemTenantTransfer
            // 
            this.ToolStripMenuItemTenantTransfer.Name = "ToolStripMenuItemTenantTransfer";
            this.ToolStripMenuItemTenantTransfer.Size = new System.Drawing.Size(202, 26);
            this.ToolStripMenuItemTenantTransfer.Text = "मोही हस्तान्तरण";
            // 
            // ToolStripMenuItemLease
            // 
            this.ToolStripMenuItemLease.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLeaseRentPayment,
            this.बझएकवबझउनबकठककToolStripMenuItem});
            this.ToolStripMenuItemLease.Name = "ToolStripMenuItemLease";
            this.ToolStripMenuItemLease.Size = new System.Drawing.Size(59, 25);
            this.ToolStripMenuItemLease.Text = "ठेक्का";
            // 
            // ToolStripMenuItemLeaseRentPayment
            // 
            this.ToolStripMenuItemLeaseRentPayment.Name = "ToolStripMenuItemLeaseRentPayment";
            this.ToolStripMenuItemLeaseRentPayment.Size = new System.Drawing.Size(278, 26);
            this.ToolStripMenuItemLeaseRentPayment.Text = "ठेक्का संकलन";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 26);
            this.toolStripMenuItem2.Text = "सम्पूर्ण जग्गाको सूची";
            // 
            // समपरणमहसचToolStripMenuItem
            // 
            this.समपरणमहसचToolStripMenuItem.Name = "समपरणमहसचToolStripMenuItem";
            this.समपरणमहसचToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.समपरणमहसचToolStripMenuItem.Text = "सम्पूर्ण मोहीको सूची";
            // 
            // बझएकवबझउनबकठककToolStripMenuItem
            // 
            this.बझएकवबझउनबकठककToolStripMenuItem.Name = "बझएकवबझउनबकठककToolStripMenuItem";
            this.बझएकवबझउनबकठककToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.बझएकवबझउनबकठककToolStripMenuItem.Text = "बुझाएको वा बुझाउन बाँकी ठेक्का";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "श्री षडानन्द सीताराम गुठी व्यवस्थापन संस्था १९३२, दिङ्गला, भोजपुर";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem समपरणमहसचToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem बझएकवबझउनबकठककToolStripMenuItem;
    }
}

