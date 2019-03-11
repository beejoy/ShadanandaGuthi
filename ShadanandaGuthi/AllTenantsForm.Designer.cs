namespace ShadanandaGuthi
{
    partial class AllTenantsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonAddNewTenant = new System.Windows.Forms.Button();
            this.ButtonDeleteTenant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewLeases = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLandArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeaseFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnnualRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsCurrent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTenants = new System.Windows.Forms.DataGridView();
            this.ColumnSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantFather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLeases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddNewTenant
            // 
            this.ButtonAddNewTenant.Location = new System.Drawing.Point(730, 46);
            this.ButtonAddNewTenant.Name = "ButtonAddNewTenant";
            this.ButtonAddNewTenant.Size = new System.Drawing.Size(176, 41);
            this.ButtonAddNewTenant.TabIndex = 23;
            this.ButtonAddNewTenant.Text = "नयाँ मोही विवरण थप्‍नुहोस्";
            this.ButtonAddNewTenant.UseVisualStyleBackColor = true;
            this.ButtonAddNewTenant.Click += new System.EventHandler(this.ButtonAddNewTenant_Click);
            // 
            // ButtonDeleteTenant
            // 
            this.ButtonDeleteTenant.Location = new System.Drawing.Point(730, 93);
            this.ButtonDeleteTenant.Name = "ButtonDeleteTenant";
            this.ButtonDeleteTenant.Size = new System.Drawing.Size(176, 41);
            this.ButtonDeleteTenant.TabIndex = 22;
            this.ButtonDeleteTenant.Text = "मोही विवरण मेटाउनुहोस्";
            this.ButtonDeleteTenant.UseVisualStyleBackColor = true;
            this.ButtonDeleteTenant.Click += new System.EventHandler(this.ButtonDeleteTenant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "भोग चलन गरेको जग्गाको विवरण";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "मोहीको सूची";
            // 
            // DataGridViewLeases
            // 
            this.DataGridViewLeases.AllowUserToAddRows = false;
            this.DataGridViewLeases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewLeases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.DataGridViewLeases.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLeases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.DataGridViewLeases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLeases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ColumnLocation,
            this.ColumnPlotNumber,
            this.ColumnLandArea,
            this.ColumnLeaseFrom,
            this.ColumnAnnualRent,
            this.ColumnIsCurrent,
            this.ColumnRemarks});
            this.DataGridViewLeases.Location = new System.Drawing.Point(28, 343);
            this.DataGridViewLeases.Name = "DataGridViewLeases";
            this.DataGridViewLeases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLeases.Size = new System.Drawing.Size(878, 191);
            this.DataGridViewLeases.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn2.HeaderText = "क्र.सं.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // ColumnLocation
            // 
            this.ColumnLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnLocation.HeaderText = "गा.वि.स.";
            this.ColumnLocation.MinimumWidth = 100;
            this.ColumnLocation.Name = "ColumnLocation";
            // 
            // ColumnPlotNumber
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPlotNumber.DefaultCellStyle = dataGridViewCellStyle28;
            this.ColumnPlotNumber.FillWeight = 80F;
            this.ColumnPlotNumber.HeaderText = "कित्ता नं.";
            this.ColumnPlotNumber.Name = "ColumnPlotNumber";
            // 
            // ColumnLandArea
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnLandArea.DefaultCellStyle = dataGridViewCellStyle29;
            this.ColumnLandArea.FillWeight = 80F;
            this.ColumnLandArea.HeaderText = "क्षेत्रफल";
            this.ColumnLandArea.Name = "ColumnLandArea";
            // 
            // ColumnLeaseFrom
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnLeaseFrom.DefaultCellStyle = dataGridViewCellStyle30;
            this.ColumnLeaseFrom.HeaderText = "भोग चलन मिति";
            this.ColumnLeaseFrom.Name = "ColumnLeaseFrom";
            // 
            // ColumnAnnualRent
            // 
            this.ColumnAnnualRent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnAnnualRent.DefaultCellStyle = dataGridViewCellStyle31;
            this.ColumnAnnualRent.HeaderText = "वार्षिक ठेक्का";
            this.ColumnAnnualRent.MinimumWidth = 100;
            this.ColumnAnnualRent.Name = "ColumnAnnualRent";
            // 
            // ColumnIsCurrent
            // 
            this.ColumnIsCurrent.HeaderText = "हाल भोग गरिरहेको हो?";
            this.ColumnIsCurrent.Name = "ColumnIsCurrent";
            this.ColumnIsCurrent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsCurrent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnRemarks
            // 
            this.ColumnRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRemarks.HeaderText = "कैफियत";
            this.ColumnRemarks.Name = "ColumnRemarks";
            // 
            // DataGridViewTenants
            // 
            this.DataGridViewTenants.AllowUserToAddRows = false;
            this.DataGridViewTenants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridViewTenants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle32;
            this.DataGridViewTenants.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTenants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.DataGridViewTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSNo,
            this.ColumnTenantName,
            this.ColumnTenantAddress,
            this.ColumnTenantMobileNumber,
            this.ColumnTenantFather,
            this.dataGridViewTextBoxColumn1});
            this.DataGridViewTenants.Location = new System.Drawing.Point(28, 46);
            this.DataGridViewTenants.Name = "DataGridViewTenants";
            this.DataGridViewTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTenants.Size = new System.Drawing.Size(675, 254);
            this.DataGridViewTenants.TabIndex = 18;
            this.DataGridViewTenants.SelectionChanged += new System.EventHandler(this.DataGridViewTenants_SelectionChanged);
            // 
            // ColumnSNo
            // 
            this.ColumnSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSNo.DefaultCellStyle = dataGridViewCellStyle34;
            this.ColumnSNo.HeaderText = "क्र.सं.";
            this.ColumnSNo.Name = "ColumnSNo";
            this.ColumnSNo.Width = 59;
            // 
            // ColumnTenantName
            // 
            this.ColumnTenantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTenantName.HeaderText = "मोहीको नाम";
            this.ColumnTenantName.MinimumWidth = 100;
            this.ColumnTenantName.Name = "ColumnTenantName";
            // 
            // ColumnTenantAddress
            // 
            this.ColumnTenantAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnTenantAddress.DefaultCellStyle = dataGridViewCellStyle35;
            this.ColumnTenantAddress.HeaderText = "ठेगाना";
            this.ColumnTenantAddress.MinimumWidth = 100;
            this.ColumnTenantAddress.Name = "ColumnTenantAddress";
            // 
            // ColumnTenantMobileNumber
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnTenantMobileNumber.DefaultCellStyle = dataGridViewCellStyle36;
            this.ColumnTenantMobileNumber.HeaderText = "मोबाइल नं.";
            this.ColumnTenantMobileNumber.Name = "ColumnTenantMobileNumber";
            // 
            // ColumnTenantFather
            // 
            this.ColumnTenantFather.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTenantFather.HeaderText = "पिताको नाम";
            this.ColumnTenantFather.MinimumWidth = 100;
            this.ColumnTenantFather.Name = "ColumnTenantFather";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(730, 259);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(176, 41);
            this.ButtonClose.TabIndex = 17;
            this.ButtonClose.Text = "बन्द गर्नुहोस्";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AllTenantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 557);
            this.Controls.Add(this.ButtonAddNewTenant);
            this.Controls.Add(this.ButtonDeleteTenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewLeases);
            this.Controls.Add(this.DataGridViewTenants);
            this.Controls.Add(this.ButtonClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllTenantsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "मोही अनुसार जग्गा विवरण";
            this.Activated += new System.EventHandler(this.AllTenantsForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLeases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddNewTenant;
        private System.Windows.Forms.Button ButtonDeleteTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewLeases;
        private System.Windows.Forms.DataGridView DataGridViewTenants;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenantAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenantMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenantFather;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLandArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLeaseFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnnualRent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
    }
}