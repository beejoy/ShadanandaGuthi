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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonAddNewTenant = new System.Windows.Forms.Button();
            this.ButtonDeleteTenant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewLeases = new System.Windows.Forms.DataGridView();
            this.DataGridViewTenants = new System.Windows.Forms.DataGridView();
            this.ColumnSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantFather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonEditTenant = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLandArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeaseFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnnualRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsCurrent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLeases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAddNewTenant
            // 
            this.ButtonAddNewTenant.Location = new System.Drawing.Point(730, 46);
            this.ButtonAddNewTenant.Name = "ButtonAddNewTenant";
            this.ButtonAddNewTenant.Size = new System.Drawing.Size(176, 41);
            this.ButtonAddNewTenant.TabIndex = 4;
            this.ButtonAddNewTenant.Text = "नयाँ मोही विवरण थप्‍नुहोस्";
            this.ButtonAddNewTenant.UseVisualStyleBackColor = true;
            this.ButtonAddNewTenant.Click += new System.EventHandler(this.ButtonAddNewTenant_Click);
            // 
            // ButtonDeleteTenant
            // 
            this.ButtonDeleteTenant.Enabled = false;
            this.ButtonDeleteTenant.Location = new System.Drawing.Point(730, 148);
            this.ButtonDeleteTenant.Name = "ButtonDeleteTenant";
            this.ButtonDeleteTenant.Size = new System.Drawing.Size(176, 41);
            this.ButtonDeleteTenant.TabIndex = 6;
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
            this.label2.TabIndex = 2;
            this.label2.Text = "भोग चलन गरेको जग्गाको विवरण";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "मोहीको सूची";
            // 
            // DataGridViewLeases
            // 
            this.DataGridViewLeases.AllowUserToAddRows = false;
            this.DataGridViewLeases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DataGridViewLeases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewLeases.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLeases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.DataGridViewLeases.ReadOnly = true;
            this.DataGridViewLeases.RowHeadersVisible = false;
            this.DataGridViewLeases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLeases.Size = new System.Drawing.Size(878, 191);
            this.DataGridViewLeases.TabIndex = 3;
            // 
            // DataGridViewTenants
            // 
            this.DataGridViewTenants.AllowUserToAddRows = false;
            this.DataGridViewTenants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            this.DataGridViewTenants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewTenants.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTenants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            this.DataGridViewTenants.ReadOnly = true;
            this.DataGridViewTenants.RowHeadersVisible = false;
            this.DataGridViewTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTenants.Size = new System.Drawing.Size(675, 254);
            this.DataGridViewTenants.TabIndex = 1;
            this.DataGridViewTenants.SelectionChanged += new System.EventHandler(this.DataGridViewTenants_SelectionChanged);
            // 
            // ColumnSNo
            // 
            this.ColumnSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSNo.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnSNo.HeaderText = "क्र.सं.";
            this.ColumnSNo.Name = "ColumnSNo";
            this.ColumnSNo.ReadOnly = true;
            this.ColumnSNo.Width = 59;
            // 
            // ColumnTenantName
            // 
            this.ColumnTenantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTenantName.HeaderText = "मोहीको नाम";
            this.ColumnTenantName.MinimumWidth = 100;
            this.ColumnTenantName.Name = "ColumnTenantName";
            this.ColumnTenantName.ReadOnly = true;
            // 
            // ColumnTenantAddress
            // 
            this.ColumnTenantAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnTenantAddress.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnTenantAddress.HeaderText = "ठेगाना";
            this.ColumnTenantAddress.MinimumWidth = 100;
            this.ColumnTenantAddress.Name = "ColumnTenantAddress";
            this.ColumnTenantAddress.ReadOnly = true;
            // 
            // ColumnTenantMobileNumber
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnTenantMobileNumber.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnTenantMobileNumber.HeaderText = "मोबाइल नं.";
            this.ColumnTenantMobileNumber.Name = "ColumnTenantMobileNumber";
            this.ColumnTenantMobileNumber.ReadOnly = true;
            // 
            // ColumnTenantFather
            // 
            this.ColumnTenantFather.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTenantFather.HeaderText = "पिताको नाम";
            this.ColumnTenantFather.MinimumWidth = 100;
            this.ColumnTenantFather.Name = "ColumnTenantFather";
            this.ColumnTenantFather.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(730, 259);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(176, 41);
            this.ButtonClose.TabIndex = 7;
            this.ButtonClose.Text = "बन्द गर्नुहोस्";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonEditTenant
            // 
            this.ButtonEditTenant.Enabled = false;
            this.ButtonEditTenant.Location = new System.Drawing.Point(730, 97);
            this.ButtonEditTenant.Name = "ButtonEditTenant";
            this.ButtonEditTenant.Size = new System.Drawing.Size(176, 41);
            this.ButtonEditTenant.TabIndex = 5;
            this.ButtonEditTenant.Text = "मोही विवरण सच्याउनुहोस्";
            this.ButtonEditTenant.UseVisualStyleBackColor = true;
            this.ButtonEditTenant.Click += new System.EventHandler(this.ButtonEditTenant_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "क्र.सं.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // ColumnLocation
            // 
            this.ColumnLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnLocation.HeaderText = "गा.वि.स.";
            this.ColumnLocation.MinimumWidth = 100;
            this.ColumnLocation.Name = "ColumnLocation";
            this.ColumnLocation.ReadOnly = true;
            // 
            // ColumnPlotNumber
            // 
            this.ColumnPlotNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPlotNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnPlotNumber.FillWeight = 80F;
            this.ColumnPlotNumber.HeaderText = "कित्ता नं.";
            this.ColumnPlotNumber.MinimumWidth = 70;
            this.ColumnPlotNumber.Name = "ColumnPlotNumber";
            this.ColumnPlotNumber.ReadOnly = true;
            this.ColumnPlotNumber.Width = 71;
            // 
            // ColumnLandArea
            // 
            this.ColumnLandArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnLandArea.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnLandArea.FillWeight = 80F;
            this.ColumnLandArea.HeaderText = "क्षेत्रफल";
            this.ColumnLandArea.MinimumWidth = 80;
            this.ColumnLandArea.Name = "ColumnLandArea";
            this.ColumnLandArea.ReadOnly = true;
            this.ColumnLandArea.Width = 80;
            // 
            // ColumnLeaseFrom
            // 
            this.ColumnLeaseFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnLeaseFrom.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnLeaseFrom.HeaderText = "भोग चलन मिति";
            this.ColumnLeaseFrom.MinimumWidth = 80;
            this.ColumnLeaseFrom.Name = "ColumnLeaseFrom";
            this.ColumnLeaseFrom.ReadOnly = true;
            this.ColumnLeaseFrom.Width = 104;
            // 
            // ColumnAnnualRent
            // 
            this.ColumnAnnualRent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnAnnualRent.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnAnnualRent.HeaderText = "वार्षिक ठेक्का";
            this.ColumnAnnualRent.MinimumWidth = 100;
            this.ColumnAnnualRent.Name = "ColumnAnnualRent";
            this.ColumnAnnualRent.ReadOnly = true;
            // 
            // ColumnIsCurrent
            // 
            this.ColumnIsCurrent.HeaderText = "हाल भोग गरिरहेको हो?";
            this.ColumnIsCurrent.Name = "ColumnIsCurrent";
            this.ColumnIsCurrent.ReadOnly = true;
            this.ColumnIsCurrent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIsCurrent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnRemarks
            // 
            this.ColumnRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRemarks.HeaderText = "कैफियत";
            this.ColumnRemarks.MinimumWidth = 200;
            this.ColumnRemarks.Name = "ColumnRemarks";
            this.ColumnRemarks.ReadOnly = true;
            // 
            // AllTenantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 557);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonEditTenant);
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
        private System.Windows.Forms.Button ButtonEditTenant;
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