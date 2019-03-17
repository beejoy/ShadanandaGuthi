namespace ShadanandaGuthi
{
    partial class AllLandsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.DataGridViewLands = new System.Windows.Forms.DataGridView();
            this.ColumnSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLandArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTenants = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDeleteLand = new System.Windows.Forms.Button();
            this.ButtonAddNewLand = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeaseFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnnualRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsCurrent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(734, 239);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(159, 41);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.Text = "बन्द गर्नुहोस्";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // DataGridViewLands
            // 
            this.DataGridViewLands.AllowUserToAddRows = false;
            this.DataGridViewLands.AllowUserToDeleteRows = false;
            this.DataGridViewLands.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DataGridViewLands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewLands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridViewLands.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewLands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSNo,
            this.ColumnVDC,
            this.ColumnPlotNumber,
            this.ColumnLandArea,
            this.dataGridViewTextBoxColumn1});
            this.DataGridViewLands.Location = new System.Drawing.Point(26, 45);
            this.DataGridViewLands.Name = "DataGridViewLands";
            this.DataGridViewLands.ReadOnly = true;
            this.DataGridViewLands.RowHeadersVisible = false;
            this.DataGridViewLands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLands.Size = new System.Drawing.Size(675, 235);
            this.DataGridViewLands.TabIndex = 1;
            this.DataGridViewLands.SelectionChanged += new System.EventHandler(this.DataGridViewLands_SelectionChanged);
            // 
            // ColumnSNo
            // 
            this.ColumnSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSNo.HeaderText = "क्र.सं.";
            this.ColumnSNo.Name = "ColumnSNo";
            this.ColumnSNo.ReadOnly = true;
            this.ColumnSNo.Width = 59;
            // 
            // ColumnVDC
            // 
            this.ColumnVDC.HeaderText = "गा.वि.स.";
            this.ColumnVDC.Name = "ColumnVDC";
            this.ColumnVDC.ReadOnly = true;
            // 
            // ColumnPlotNumber
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPlotNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnPlotNumber.HeaderText = "कित्ता नं.";
            this.ColumnPlotNumber.Name = "ColumnPlotNumber";
            this.ColumnPlotNumber.ReadOnly = true;
            // 
            // ColumnLandArea
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnLandArea.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnLandArea.HeaderText = "क्षेत्रफल";
            this.ColumnLandArea.Name = "ColumnLandArea";
            this.ColumnLandArea.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTenants
            // 
            this.DataGridViewTenants.AllowUserToAddRows = false;
            this.DataGridViewTenants.AllowUserToDeleteRows = false;
            this.DataGridViewTenants.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            this.DataGridViewTenants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewTenants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewTenants.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTenants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ColumnTenant,
            this.ColumnAddress,
            this.ColumnMobileNumber,
            this.ColumnFather,
            this.ColumnLeaseFrom,
            this.ColumnAnnualRent,
            this.ColumnIsCurrent,
            this.ColumnRemarks});
            this.DataGridViewTenants.Location = new System.Drawing.Point(26, 324);
            this.DataGridViewTenants.Name = "DataGridViewTenants";
            this.DataGridViewTenants.ReadOnly = true;
            this.DataGridViewTenants.RowHeadersVisible = false;
            this.DataGridViewTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTenants.Size = new System.Drawing.Size(867, 186);
            this.DataGridViewTenants.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "जग्गा (कित्ता)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "मोहीको विवरण";
            // 
            // ButtonDeleteLand
            // 
            this.ButtonDeleteLand.Enabled = false;
            this.ButtonDeleteLand.Location = new System.Drawing.Point(734, 92);
            this.ButtonDeleteLand.Name = "ButtonDeleteLand";
            this.ButtonDeleteLand.Size = new System.Drawing.Size(159, 41);
            this.ButtonDeleteLand.TabIndex = 5;
            this.ButtonDeleteLand.Text = "जग्गा मेटाउनुहोस्";
            this.ButtonDeleteLand.UseVisualStyleBackColor = true;
            this.ButtonDeleteLand.Click += new System.EventHandler(this.ButtonDeleteLand_Click);
            // 
            // ButtonAddNewLand
            // 
            this.ButtonAddNewLand.Location = new System.Drawing.Point(734, 45);
            this.ButtonAddNewLand.Name = "ButtonAddNewLand";
            this.ButtonAddNewLand.Size = new System.Drawing.Size(159, 41);
            this.ButtonAddNewLand.TabIndex = 4;
            this.ButtonAddNewLand.Text = "नयाँ जग्गा विवरण थप्‍नुहोस्";
            this.ButtonAddNewLand.UseVisualStyleBackColor = true;
            this.ButtonAddNewLand.Click += new System.EventHandler(this.ButtonAddNewLand_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "क्र.सं.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // ColumnTenant
            // 
            this.ColumnTenant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTenant.HeaderText = "मोहीको नाम";
            this.ColumnTenant.MinimumWidth = 100;
            this.ColumnTenant.Name = "ColumnTenant";
            this.ColumnTenant.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnAddress.HeaderText = "ठेगाना";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            this.ColumnAddress.Width = 62;
            // 
            // ColumnMobileNumber
            // 
            this.ColumnMobileNumber.HeaderText = "मोबाइल नं.";
            this.ColumnMobileNumber.Name = "ColumnMobileNumber";
            this.ColumnMobileNumber.ReadOnly = true;
            // 
            // ColumnFather
            // 
            this.ColumnFather.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnFather.HeaderText = "पिताको नाम";
            this.ColumnFather.MinimumWidth = 100;
            this.ColumnFather.Name = "ColumnFather";
            this.ColumnFather.ReadOnly = true;
            // 
            // ColumnLeaseFrom
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnLeaseFrom.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnLeaseFrom.HeaderText = "भोग चलन मिति";
            this.ColumnLeaseFrom.Name = "ColumnLeaseFrom";
            this.ColumnLeaseFrom.ReadOnly = true;
            // 
            // ColumnAnnualRent
            // 
            this.ColumnAnnualRent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnAnnualRent.DefaultCellStyle = dataGridViewCellStyle10;
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
            // AllLandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonAddNewLand);
            this.Controls.Add(this.ButtonDeleteLand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewTenants);
            this.Controls.Add(this.DataGridViewLands);
            this.Controls.Add(this.ButtonClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllLandsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "सम्पूर्ण जग्गाको विवरण";
            this.Activated += new System.EventHandler(this.AllLandsForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.DataGridView DataGridViewLands;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLandArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView DataGridViewTenants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDeleteLand;
        private System.Windows.Forms.Button ButtonAddNewLand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFather;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLeaseFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnnualRent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
    }
}