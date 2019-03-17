namespace ShadanandaGuthi
{
    partial class TenantDeregisterForm
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxTenant = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDeregisterTenant = new System.Windows.Forms.Button();
            this.DataGridViewLeases = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLandArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeaseFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnnualRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLeases)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(683, 307);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(123, 41);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "रद्द गर्नुहोस्";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "मोही छान्नुहोस् :";
            // 
            // ComboBoxTenant
            // 
            this.ComboBoxTenant.FormattingEnabled = true;
            this.ComboBoxTenant.Location = new System.Drawing.Point(125, 26);
            this.ComboBoxTenant.Name = "ComboBoxTenant";
            this.ComboBoxTenant.Size = new System.Drawing.Size(258, 28);
            this.ComboBoxTenant.TabIndex = 1;
            this.ComboBoxTenant.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTenant_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "जग्गा छान्नुहोस्";
            // 
            // ButtonDeregisterTenant
            // 
            this.ButtonDeregisterTenant.Location = new System.Drawing.Point(26, 307);
            this.ButtonDeregisterTenant.Name = "ButtonDeregisterTenant";
            this.ButtonDeregisterTenant.Size = new System.Drawing.Size(123, 41);
            this.ButtonDeregisterTenant.TabIndex = 4;
            this.ButtonDeregisterTenant.Text = "दर्ता खारेज गर्नुहोस्";
            this.ButtonDeregisterTenant.UseVisualStyleBackColor = true;
            this.ButtonDeregisterTenant.Click += new System.EventHandler(this.ButtonDeregisterTenant_Click);
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
            this.ColumnRemarks});
            this.DataGridViewLeases.Location = new System.Drawing.Point(26, 96);
            this.DataGridViewLeases.Name = "DataGridViewLeases";
            this.DataGridViewLeases.ReadOnly = true;
            this.DataGridViewLeases.RowHeadersVisible = false;
            this.DataGridViewLeases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLeases.Size = new System.Drawing.Size(780, 194);
            this.DataGridViewLeases.TabIndex = 3;
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
            this.ColumnLeaseFrom.MinimumWidth = 90;
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
            // ColumnRemarks
            // 
            this.ColumnRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRemarks.HeaderText = "कैफियत";
            this.ColumnRemarks.Name = "ColumnRemarks";
            this.ColumnRemarks.ReadOnly = true;
            // 
            // TenantDeregisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 368);
            this.ControlBox = false;
            this.Controls.Add(this.DataGridViewLeases);
            this.Controls.Add(this.ButtonDeregisterTenant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxTenant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TenantDeregisterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "मोही दर्ता खारेज";
            this.Activated += new System.EventHandler(this.TenantDeregisterForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLeases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonDeregisterTenant;
        private System.Windows.Forms.DataGridView DataGridViewLeases;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLandArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLeaseFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnnualRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
    }
}