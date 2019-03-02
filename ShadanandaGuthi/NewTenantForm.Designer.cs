namespace ShadanandaGuthi
{
    partial class NewTenantForm
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
            this.LabelHeaderTitle = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.GroupBoxLandDetails = new System.Windows.Forms.GroupBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ListViewLandList = new System.Windows.Forms.ListView();
            this.TextBoxRemarks = new System.Windows.Forms.TextBox();
            this.LabelRemarks = new System.Windows.Forms.Label();
            this.TextBoxAnnualRent = new System.Windows.Forms.TextBox();
            this.LabelAnnualRent = new System.Windows.Forms.Label();
            this.TextBoxLeaseFrom = new System.Windows.Forms.TextBox();
            this.LabelLeaseFrom = new System.Windows.Forms.Label();
            this.LabelPlotNumber = new System.Windows.Forms.Label();
            this.ComboBoxPlotNumber = new System.Windows.Forms.ComboBox();
            this.ComboBoxLandAddress = new System.Windows.Forms.ComboBox();
            this.LabelLandAddress = new System.Windows.Forms.Label();
            this.GroupBoxTenantDetails = new System.Windows.Forms.GroupBox();
            this.TextBoxFather = new System.Windows.Forms.TextBox();
            this.TextBoxMobileNumber = new System.Windows.Forms.TextBox();
            this.LabelFather = new System.Windows.Forms.Label();
            this.LabelMobileNumber = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelFullname = new System.Windows.Forms.Label();
            this.TextBoxFullname = new System.Windows.Forms.TextBox();
            this.PanelHeader.SuspendLayout();
            this.GroupBoxLandDetails.SuspendLayout();
            this.GroupBoxTenantDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHeaderTitle
            // 
            this.LabelHeaderTitle.AutoSize = true;
            this.LabelHeaderTitle.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.LabelHeaderTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelHeaderTitle.Name = "LabelHeaderTitle";
            this.LabelHeaderTitle.Size = new System.Drawing.Size(136, 28);
            this.LabelHeaderTitle.TabIndex = 0;
            this.LabelHeaderTitle.Text = "नयाँ मोही दर्ता";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Firebrick;
            this.PanelHeader.Controls.Add(this.LabelHeaderTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1159, 49);
            this.PanelHeader.TabIndex = 14;
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuit.Location = new System.Drawing.Point(322, 463);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(149, 43);
            this.ButtonQuit.TabIndex = 16;
            this.ButtonQuit.Text = "रद्द गर्नुहोस्";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Location = new System.Drawing.Point(154, 463);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(149, 43);
            this.ButtonSave.TabIndex = 15;
            this.ButtonSave.Text = "सुरक्षित गर्नुहोस्";
            this.ButtonSave.UseVisualStyleBackColor = false;
            // 
            // GroupBoxLandDetails
            // 
            this.GroupBoxLandDetails.Controls.Add(this.ButtonDelete);
            this.GroupBoxLandDetails.Controls.Add(this.ButtonAdd);
            this.GroupBoxLandDetails.Controls.Add(this.ListViewLandList);
            this.GroupBoxLandDetails.Controls.Add(this.TextBoxRemarks);
            this.GroupBoxLandDetails.Controls.Add(this.LabelRemarks);
            this.GroupBoxLandDetails.Controls.Add(this.TextBoxAnnualRent);
            this.GroupBoxLandDetails.Controls.Add(this.LabelAnnualRent);
            this.GroupBoxLandDetails.Controls.Add(this.TextBoxLeaseFrom);
            this.GroupBoxLandDetails.Controls.Add(this.LabelLeaseFrom);
            this.GroupBoxLandDetails.Controls.Add(this.LabelPlotNumber);
            this.GroupBoxLandDetails.Controls.Add(this.ComboBoxPlotNumber);
            this.GroupBoxLandDetails.Controls.Add(this.ComboBoxLandAddress);
            this.GroupBoxLandDetails.Controls.Add(this.LabelLandAddress);
            this.GroupBoxLandDetails.Location = new System.Drawing.Point(497, 82);
            this.GroupBoxLandDetails.Name = "GroupBoxLandDetails";
            this.GroupBoxLandDetails.Size = new System.Drawing.Size(631, 424);
            this.GroupBoxLandDetails.TabIndex = 23;
            this.GroupBoxLandDetails.TabStop = false;
            this.GroupBoxLandDetails.Text = "भोग चलन गरेको जग्गा";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Location = new System.Drawing.Point(455, 92);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(149, 43);
            this.ButtonDelete.TabIndex = 29;
            this.ButtonDelete.Text = "सूचीबाट हटाउनुहोस्";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Location = new System.Drawing.Point(455, 33);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(149, 43);
            this.ButtonAdd.TabIndex = 28;
            this.ButtonAdd.Text = "सूचीमा थप्‍नुहोस्";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // ListViewLandList
            // 
            this.ListViewLandList.Location = new System.Drawing.Point(26, 269);
            this.ListViewLandList.Name = "ListViewLandList";
            this.ListViewLandList.Size = new System.Drawing.Size(578, 127);
            this.ListViewLandList.TabIndex = 27;
            this.ListViewLandList.UseCompatibleStateImageBehavior = false;
            // 
            // TextBoxRemarks
            // 
            this.TextBoxRemarks.Location = new System.Drawing.Point(143, 201);
            this.TextBoxRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxRemarks.Multiline = true;
            this.TextBoxRemarks.Name = "TextBoxRemarks";
            this.TextBoxRemarks.Size = new System.Drawing.Size(461, 60);
            this.TextBoxRemarks.TabIndex = 26;
            // 
            // LabelRemarks
            // 
            this.LabelRemarks.AutoSize = true;
            this.LabelRemarks.Location = new System.Drawing.Point(22, 204);
            this.LabelRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRemarks.Name = "LabelRemarks";
            this.LabelRemarks.Size = new System.Drawing.Size(56, 21);
            this.LabelRemarks.TabIndex = 25;
            this.LabelRemarks.Text = "कैफियत";
            // 
            // TextBoxAnnualRent
            // 
            this.TextBoxAnnualRent.Location = new System.Drawing.Point(143, 159);
            this.TextBoxAnnualRent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxAnnualRent.Name = "TextBoxAnnualRent";
            this.TextBoxAnnualRent.Size = new System.Drawing.Size(257, 29);
            this.TextBoxAnnualRent.TabIndex = 24;
            // 
            // LabelAnnualRent
            // 
            this.LabelAnnualRent.AutoSize = true;
            this.LabelAnnualRent.Location = new System.Drawing.Point(22, 162);
            this.LabelAnnualRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAnnualRent.Name = "LabelAnnualRent";
            this.LabelAnnualRent.Size = new System.Drawing.Size(87, 21);
            this.LabelAnnualRent.TabIndex = 23;
            this.LabelAnnualRent.Text = "वार्षिक ठेक्का :";
            // 
            // TextBoxLeaseFrom
            // 
            this.TextBoxLeaseFrom.Location = new System.Drawing.Point(143, 117);
            this.TextBoxLeaseFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxLeaseFrom.Name = "TextBoxLeaseFrom";
            this.TextBoxLeaseFrom.Size = new System.Drawing.Size(257, 29);
            this.TextBoxLeaseFrom.TabIndex = 22;
            // 
            // LabelLeaseFrom
            // 
            this.LabelLeaseFrom.AutoSize = true;
            this.LabelLeaseFrom.Location = new System.Drawing.Point(22, 120);
            this.LabelLeaseFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLeaseFrom.Name = "LabelLeaseFrom";
            this.LabelLeaseFrom.Size = new System.Drawing.Size(113, 21);
            this.LabelLeaseFrom.TabIndex = 17;
            this.LabelLeaseFrom.Text = "भोग गरेको मिति :";
            // 
            // LabelPlotNumber
            // 
            this.LabelPlotNumber.AutoSize = true;
            this.LabelPlotNumber.Location = new System.Drawing.Point(22, 78);
            this.LabelPlotNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPlotNumber.Name = "LabelPlotNumber";
            this.LabelPlotNumber.Size = new System.Drawing.Size(67, 21);
            this.LabelPlotNumber.TabIndex = 16;
            this.LabelPlotNumber.Text = "कित्ता नं. :";
            // 
            // ComboBoxPlotNumber
            // 
            this.ComboBoxPlotNumber.FormattingEnabled = true;
            this.ComboBoxPlotNumber.Location = new System.Drawing.Point(143, 75);
            this.ComboBoxPlotNumber.Name = "ComboBoxPlotNumber";
            this.ComboBoxPlotNumber.Size = new System.Drawing.Size(257, 29);
            this.ComboBoxPlotNumber.TabIndex = 15;
            // 
            // ComboBoxLandAddress
            // 
            this.ComboBoxLandAddress.FormattingEnabled = true;
            this.ComboBoxLandAddress.Location = new System.Drawing.Point(143, 33);
            this.ComboBoxLandAddress.Name = "ComboBoxLandAddress";
            this.ComboBoxLandAddress.Size = new System.Drawing.Size(257, 29);
            this.ComboBoxLandAddress.TabIndex = 14;
            // 
            // LabelLandAddress
            // 
            this.LabelLandAddress.AutoSize = true;
            this.LabelLandAddress.Location = new System.Drawing.Point(22, 36);
            this.LabelLandAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLandAddress.Name = "LabelLandAddress";
            this.LabelLandAddress.Size = new System.Drawing.Size(89, 21);
            this.LabelLandAddress.TabIndex = 13;
            this.LabelLandAddress.Text = "जग्गा ठेगाना :";
            // 
            // GroupBoxTenantDetails
            // 
            this.GroupBoxTenantDetails.Controls.Add(this.TextBoxFather);
            this.GroupBoxTenantDetails.Controls.Add(this.TextBoxMobileNumber);
            this.GroupBoxTenantDetails.Controls.Add(this.LabelFather);
            this.GroupBoxTenantDetails.Controls.Add(this.LabelMobileNumber);
            this.GroupBoxTenantDetails.Controls.Add(this.TextBoxAddress);
            this.GroupBoxTenantDetails.Controls.Add(this.LabelAddress);
            this.GroupBoxTenantDetails.Controls.Add(this.LabelFullname);
            this.GroupBoxTenantDetails.Controls.Add(this.TextBoxFullname);
            this.GroupBoxTenantDetails.Location = new System.Drawing.Point(31, 82);
            this.GroupBoxTenantDetails.Name = "GroupBoxTenantDetails";
            this.GroupBoxTenantDetails.Size = new System.Drawing.Size(440, 225);
            this.GroupBoxTenantDetails.TabIndex = 24;
            this.GroupBoxTenantDetails.TabStop = false;
            this.GroupBoxTenantDetails.Text = "मोहीको विवरण";
            // 
            // TextBoxFather
            // 
            this.TextBoxFather.Location = new System.Drawing.Point(146, 171);
            this.TextBoxFather.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxFather.Name = "TextBoxFather";
            this.TextBoxFather.Size = new System.Drawing.Size(268, 29);
            this.TextBoxFather.TabIndex = 30;
            // 
            // TextBoxMobileNumber
            // 
            this.TextBoxMobileNumber.Location = new System.Drawing.Point(146, 125);
            this.TextBoxMobileNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxMobileNumber.Name = "TextBoxMobileNumber";
            this.TextBoxMobileNumber.Size = new System.Drawing.Size(268, 29);
            this.TextBoxMobileNumber.TabIndex = 29;
            // 
            // LabelFather
            // 
            this.LabelFather.AutoSize = true;
            this.LabelFather.Location = new System.Drawing.Point(21, 174);
            this.LabelFather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFather.Name = "LabelFather";
            this.LabelFather.Size = new System.Drawing.Size(85, 21);
            this.LabelFather.TabIndex = 28;
            this.LabelFather.Text = "बावुको नाम :";
            // 
            // LabelMobileNumber
            // 
            this.LabelMobileNumber.AutoSize = true;
            this.LabelMobileNumber.Location = new System.Drawing.Point(21, 128);
            this.LabelMobileNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMobileNumber.Name = "LabelMobileNumber";
            this.LabelMobileNumber.Size = new System.Drawing.Size(84, 21);
            this.LabelMobileNumber.TabIndex = 27;
            this.LabelMobileNumber.Text = "मोबाइल नं. :";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(146, 79);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(268, 29);
            this.TextBoxAddress.TabIndex = 26;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(21, 82);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(55, 21);
            this.LabelAddress.TabIndex = 25;
            this.LabelAddress.Text = "ठेगाना :";
            // 
            // LabelFullname
            // 
            this.LabelFullname.AutoSize = true;
            this.LabelFullname.Location = new System.Drawing.Point(21, 36);
            this.LabelFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFullname.Name = "LabelFullname";
            this.LabelFullname.Size = new System.Drawing.Size(117, 21);
            this.LabelFullname.TabIndex = 24;
            this.LabelFullname.Text = "मोहीको पुरा नाम :";
            // 
            // TextBoxFullname
            // 
            this.TextBoxFullname.Location = new System.Drawing.Point(146, 33);
            this.TextBoxFullname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxFullname.Name = "TextBoxFullname";
            this.TextBoxFullname.Size = new System.Drawing.Size(268, 29);
            this.TextBoxFullname.TabIndex = 23;
            // 
            // NewTenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 545);
            this.Controls.Add(this.GroupBoxTenantDetails);
            this.Controls.Add(this.GroupBoxLandDetails);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewTenantForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTenantForm";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.GroupBoxLandDetails.ResumeLayout(false);
            this.GroupBoxLandDetails.PerformLayout();
            this.GroupBoxTenantDetails.ResumeLayout(false);
            this.GroupBoxTenantDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelHeaderTitle;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.GroupBox GroupBoxLandDetails;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ListView ListViewLandList;
        private System.Windows.Forms.TextBox TextBoxRemarks;
        private System.Windows.Forms.Label LabelRemarks;
        private System.Windows.Forms.TextBox TextBoxAnnualRent;
        private System.Windows.Forms.Label LabelAnnualRent;
        private System.Windows.Forms.TextBox TextBoxLeaseFrom;
        private System.Windows.Forms.Label LabelLeaseFrom;
        private System.Windows.Forms.Label LabelPlotNumber;
        private System.Windows.Forms.ComboBox ComboBoxPlotNumber;
        private System.Windows.Forms.ComboBox ComboBoxLandAddress;
        private System.Windows.Forms.Label LabelLandAddress;
        private System.Windows.Forms.GroupBox GroupBoxTenantDetails;
        private System.Windows.Forms.TextBox TextBoxFather;
        private System.Windows.Forms.TextBox TextBoxMobileNumber;
        private System.Windows.Forms.Label LabelFather;
        private System.Windows.Forms.Label LabelMobileNumber;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelFullname;
        private System.Windows.Forms.TextBox TextBoxFullname;
    }
}