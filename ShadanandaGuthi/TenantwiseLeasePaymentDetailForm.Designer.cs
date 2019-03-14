namespace ShadanandaGuthi
{
    partial class TenantwiseLeasePaymentDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxFilterTenantName = new System.Windows.Forms.TextBox();
            this.DataGridViewTenants = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ComboBoxRentYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridViewPaymentDetails = new System.Windows.Forms.DataGridView();
            this.ColumnSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRentYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListBoxLeasedLands = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPaymentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "मोही छान्नुहोस् वा फिल्टर गर्नुहोस् :";
            // 
            // TextBoxFilterTenantName
            // 
            this.TextBoxFilterTenantName.Location = new System.Drawing.Point(205, 25);
            this.TextBoxFilterTenantName.Name = "TextBoxFilterTenantName";
            this.TextBoxFilterTenantName.Size = new System.Drawing.Size(152, 26);
            this.TextBoxFilterTenantName.TabIndex = 1;
            this.TextBoxFilterTenantName.TextChanged += new System.EventHandler(this.TextBoxFilterTenantName_TextChanged);
            // 
            // DataGridViewTenants
            // 
            this.DataGridViewTenants.AllowUserToAddRows = false;
            this.DataGridViewTenants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DataGridViewTenants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTenants.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTenants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSNo,
            this.ColumnTenantName,
            this.ColumnAddress,
            this.ColumnMobileNumber,
            this.ColumnFather,
            this.ColumnLast});
            this.DataGridViewTenants.Location = new System.Drawing.Point(29, 57);
            this.DataGridViewTenants.MultiSelect = false;
            this.DataGridViewTenants.Name = "DataGridViewTenants";
            this.DataGridViewTenants.ReadOnly = true;
            this.DataGridViewTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTenants.Size = new System.Drawing.Size(588, 204);
            this.DataGridViewTenants.TabIndex = 4;
            this.DataGridViewTenants.SelectionChanged += new System.EventHandler(this.DataGridViewTenants_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ठेक्का तिरेको वर्ष छान्नुहोस् :";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(799, 461);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(123, 41);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = "रद्द गर्नुहोस्";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ComboBoxRentYear
            // 
            this.ComboBoxRentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRentYear.FormattingEnabled = true;
            this.ComboBoxRentYear.Location = new System.Drawing.Point(521, 23);
            this.ComboBoxRentYear.Name = "ComboBoxRentYear";
            this.ComboBoxRentYear.Size = new System.Drawing.Size(96, 28);
            this.ComboBoxRentYear.TabIndex = 3;
            this.ComboBoxRentYear.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRentYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ठेक्का तिरेको विवरण ";
            // 
            // DataGridViewPaymentDetails
            // 
            this.DataGridViewPaymentDetails.AllowUserToAddRows = false;
            this.DataGridViewPaymentDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            this.DataGridViewPaymentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewPaymentDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPaymentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewPaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPaymentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4,
            this.ColumnRentYear,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DataGridViewPaymentDetails.Location = new System.Drawing.Point(29, 293);
            this.DataGridViewPaymentDetails.MultiSelect = false;
            this.DataGridViewPaymentDetails.Name = "DataGridViewPaymentDetails";
            this.DataGridViewPaymentDetails.ReadOnly = true;
            this.DataGridViewPaymentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPaymentDetails.Size = new System.Drawing.Size(893, 148);
            this.DataGridViewPaymentDetails.TabIndex = 6;
            this.DataGridViewPaymentDetails.TabStop = false;
            // 
            // ColumnSNo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSNo.HeaderText = "क्र.सं.";
            this.ColumnSNo.MinimumWidth = 70;
            this.ColumnSNo.Name = "ColumnSNo";
            this.ColumnSNo.ReadOnly = true;
            this.ColumnSNo.Width = 70;
            // 
            // ColumnTenantName
            // 
            this.ColumnTenantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTenantName.HeaderText = "मोहीको नाम";
            this.ColumnTenantName.MinimumWidth = 100;
            this.ColumnTenantName.Name = "ColumnTenantName";
            this.ColumnTenantName.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnAddress.HeaderText = "ठेगाना";
            this.ColumnAddress.MinimumWidth = 100;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnMobileNumber
            // 
            this.ColumnMobileNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnMobileNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnMobileNumber.HeaderText = "मोबाइल नं.";
            this.ColumnMobileNumber.MinimumWidth = 100;
            this.ColumnMobileNumber.Name = "ColumnMobileNumber";
            this.ColumnMobileNumber.ReadOnly = true;
            // 
            // ColumnFather
            // 
            this.ColumnFather.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnFather.HeaderText = "पिता";
            this.ColumnFather.MinimumWidth = 100;
            this.ColumnFather.Name = "ColumnFather";
            this.ColumnFather.ReadOnly = true;
            // 
            // ColumnLast
            // 
            this.ColumnLast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLast.HeaderText = "";
            this.ColumnLast.Name = "ColumnLast";
            this.ColumnLast.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "क्र.सं.";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "गा.वि.स.";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "कित्ता नं.";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column4.HeaderText = "क्षेत्रफल";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ColumnRentYear
            // 
            this.ColumnRentYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnRentYear.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnRentYear.HeaderText = "ठेक्का वर्ष";
            this.ColumnRentYear.MinimumWidth = 70;
            this.ColumnRentYear.Name = "ColumnRentYear";
            this.ColumnRentYear.ReadOnly = true;
            this.ColumnRentYear.Width = 79;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column5.HeaderText = "तिरेको ठेक्का";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column6.HeaderText = "मिति";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 55;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column7.HeaderText = "रसिद नं.";
            this.Column7.MinimumWidth = 70;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 72;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "कैफियत";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // ListBoxLeasedLands
            // 
            this.ListBoxLeasedLands.FormattingEnabled = true;
            this.ListBoxLeasedLands.ItemHeight = 20;
            this.ListBoxLeasedLands.Location = new System.Drawing.Point(640, 57);
            this.ListBoxLeasedLands.Name = "ListBoxLeasedLands";
            this.ListBoxLeasedLands.Size = new System.Drawing.Size(282, 204);
            this.ListBoxLeasedLands.TabIndex = 8;
            this.ListBoxLeasedLands.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "मोहीको नाममा दर्ता रहेको जग्गा";
            // 
            // TenantwiseLeasePaymentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 523);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListBoxLeasedLands);
            this.Controls.Add(this.DataGridViewPaymentDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxRentYear);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewTenants);
            this.Controls.Add(this.TextBoxFilterTenantName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TenantwiseLeasePaymentDetailForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "मोही अनुसार ठेक्का बुझाएको विवरण";
            this.Load += new System.EventHandler(this.TenantwiseLeasePaymentDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTenants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPaymentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFilterTenantName;
        private System.Windows.Forms.DataGridView DataGridViewTenants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox ComboBoxRentYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridViewPaymentDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFather;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRentYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ListBox ListBoxLeasedLands;
        private System.Windows.Forms.Label label4;
    }
}