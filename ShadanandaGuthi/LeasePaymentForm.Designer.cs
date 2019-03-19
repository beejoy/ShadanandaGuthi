namespace ShadanandaGuthi
{
    partial class LeasePaymentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxTenant = new System.Windows.Forms.ComboBox();
            this.ComboBoxLeaseLand = new System.Windows.Forms.ComboBox();
            this.ComboBoxRentYear = new System.Windows.Forms.ComboBox();
            this.TextBoxPaymentDate = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextBoxAnnualRent = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxReceiptNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxRemarks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "मोहीको नाम :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "जग्गा (कित्ता) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ठेक्का तिरेको वर्ष :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "बुझाएको ठेक्का :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ठेक्का तिरेको मिति :";
            // 
            // ComboBoxTenant
            // 
            this.ComboBoxTenant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxTenant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTenant.FormattingEnabled = true;
            this.ComboBoxTenant.Location = new System.Drawing.Point(141, 28);
            this.ComboBoxTenant.Name = "ComboBoxTenant";
            this.ComboBoxTenant.Size = new System.Drawing.Size(303, 28);
            this.ComboBoxTenant.TabIndex = 1;
            this.ComboBoxTenant.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTenant_SelectedIndexChanged);
            // 
            // ComboBoxLeaseLand
            // 
            this.ComboBoxLeaseLand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLeaseLand.FormattingEnabled = true;
            this.ComboBoxLeaseLand.Location = new System.Drawing.Point(141, 73);
            this.ComboBoxLeaseLand.Name = "ComboBoxLeaseLand";
            this.ComboBoxLeaseLand.Size = new System.Drawing.Size(303, 28);
            this.ComboBoxLeaseLand.TabIndex = 3;
            // 
            // ComboBoxRentYear
            // 
            this.ComboBoxRentYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxRentYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxRentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRentYear.FormattingEnabled = true;
            this.ComboBoxRentYear.Location = new System.Drawing.Point(141, 161);
            this.ComboBoxRentYear.Name = "ComboBoxRentYear";
            this.ComboBoxRentYear.Size = new System.Drawing.Size(145, 28);
            this.ComboBoxRentYear.TabIndex = 7;
            // 
            // TextBoxPaymentDate
            // 
            this.TextBoxPaymentDate.Location = new System.Drawing.Point(141, 206);
            this.TextBoxPaymentDate.Name = "TextBoxPaymentDate";
            this.TextBoxPaymentDate.Size = new System.Drawing.Size(145, 26);
            this.TextBoxPaymentDate.TabIndex = 9;
            this.TextBoxPaymentDate.TextChanged += new System.EventHandler(this.TextBoxPaymentDate_TextChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(299, 339);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(145, 41);
            this.ButtonCancel.TabIndex = 15;
            this.ButtonCancel.Text = "रद्द गर्नुहोस्";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextBoxAnnualRent
            // 
            this.TextBoxAnnualRent.Location = new System.Drawing.Point(141, 118);
            this.TextBoxAnnualRent.Name = "TextBoxAnnualRent";
            this.TextBoxAnnualRent.Size = new System.Drawing.Size(303, 26);
            this.TextBoxAnnualRent.TabIndex = 5;
            this.TextBoxAnnualRent.TextChanged += new System.EventHandler(this.TextBoxAnnualRent_TextChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(141, 339);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(145, 41);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "सुरक्षित गर्नुहोस्";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "रसिद नं. :";
            // 
            // TextBoxReceiptNumber
            // 
            this.TextBoxReceiptNumber.Location = new System.Drawing.Point(364, 206);
            this.TextBoxReceiptNumber.Name = "TextBoxReceiptNumber";
            this.TextBoxReceiptNumber.Size = new System.Drawing.Size(80, 26);
            this.TextBoxReceiptNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "कैफियत :";
            // 
            // TextBoxRemarks
            // 
            this.TextBoxRemarks.Location = new System.Drawing.Point(141, 251);
            this.TextBoxRemarks.Multiline = true;
            this.TextBoxRemarks.Name = "TextBoxRemarks";
            this.TextBoxRemarks.Size = new System.Drawing.Size(303, 57);
            this.TextBoxRemarks.TabIndex = 13;
            // 
            // LeasePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 407);
            this.ControlBox = false;
            this.Controls.Add(this.TextBoxRemarks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxReceiptNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxAnnualRent);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxPaymentDate);
            this.Controls.Add(this.ComboBoxRentYear);
            this.Controls.Add(this.ComboBoxLeaseLand);
            this.Controls.Add(this.ComboBoxTenant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeasePaymentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ठेक्का संकलन";
            this.Load += new System.EventHandler(this.LeasePaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxTenant;
        private System.Windows.Forms.ComboBox ComboBoxLeaseLand;
        private System.Windows.Forms.ComboBox ComboBoxRentYear;
        private System.Windows.Forms.TextBox TextBoxPaymentDate;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextBoxAnnualRent;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxReceiptNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxRemarks;
    }
}