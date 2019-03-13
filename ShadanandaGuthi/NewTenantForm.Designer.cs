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
            this.TextBoxFather = new System.Windows.Forms.TextBox();
            this.TextBoxMobileNumber = new System.Windows.Forms.TextBox();
            this.LabelFather = new System.Windows.Forms.Label();
            this.LabelMobileNumber = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelFullname = new System.Windows.Forms.Label();
            this.TextBoxFullname = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxFather
            // 
            this.TextBoxFather.Location = new System.Drawing.Point(130, 149);
            this.TextBoxFather.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxFather.Name = "TextBoxFather";
            this.TextBoxFather.Size = new System.Drawing.Size(252, 26);
            this.TextBoxFather.TabIndex = 7;
            this.TextBoxFather.TextChanged += new System.EventHandler(this.TextBoxFather_TextChanged);
            // 
            // TextBoxMobileNumber
            // 
            this.TextBoxMobileNumber.Location = new System.Drawing.Point(130, 109);
            this.TextBoxMobileNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxMobileNumber.Name = "TextBoxMobileNumber";
            this.TextBoxMobileNumber.Size = new System.Drawing.Size(252, 26);
            this.TextBoxMobileNumber.TabIndex = 5;
            this.TextBoxMobileNumber.TextChanged += new System.EventHandler(this.TextBoxMobileNumber_TextChanged);
            // 
            // LabelFather
            // 
            this.LabelFather.AutoSize = true;
            this.LabelFather.Location = new System.Drawing.Point(24, 152);
            this.LabelFather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFather.Name = "LabelFather";
            this.LabelFather.Size = new System.Drawing.Size(66, 20);
            this.LabelFather.TabIndex = 6;
            this.LabelFather.Text = "बावुको नाम :";
            // 
            // LabelMobileNumber
            // 
            this.LabelMobileNumber.AutoSize = true;
            this.LabelMobileNumber.Location = new System.Drawing.Point(24, 112);
            this.LabelMobileNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMobileNumber.Name = "LabelMobileNumber";
            this.LabelMobileNumber.Size = new System.Drawing.Size(65, 20);
            this.LabelMobileNumber.TabIndex = 4;
            this.LabelMobileNumber.Text = "मोबाइल नं. :";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(130, 69);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(252, 26);
            this.TextBoxAddress.TabIndex = 3;
            this.TextBoxAddress.TextChanged += new System.EventHandler(this.TextBoxAddress_TextChanged);
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(24, 72);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(43, 20);
            this.LabelAddress.TabIndex = 2;
            this.LabelAddress.Text = "ठेगाना :";
            // 
            // LabelFullname
            // 
            this.LabelFullname.AutoSize = true;
            this.LabelFullname.Location = new System.Drawing.Point(24, 32);
            this.LabelFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFullname.Name = "LabelFullname";
            this.LabelFullname.Size = new System.Drawing.Size(89, 20);
            this.LabelFullname.TabIndex = 0;
            this.LabelFullname.Text = "मोहीको पुरा नाम :";
            // 
            // TextBoxFullname
            // 
            this.TextBoxFullname.Location = new System.Drawing.Point(130, 29);
            this.TextBoxFullname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxFullname.Name = "TextBoxFullname";
            this.TextBoxFullname.Size = new System.Drawing.Size(252, 26);
            this.TextBoxFullname.TabIndex = 1;
            this.TextBoxFullname.TextChanged += new System.EventHandler(this.TextBoxFullname_TextChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(130, 199);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(123, 41);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "सुरक्षित गर्नुहोस्";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(259, 199);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(123, 41);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = "रद्द गर्नुहोस्";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // NewTenantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(410, 262);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxFather);
            this.Controls.Add(this.TextBoxMobileNumber);
            this.Controls.Add(this.LabelFather);
            this.Controls.Add(this.LabelMobileNumber);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.LabelFullname);
            this.Controls.Add(this.TextBoxFullname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTenantForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "नयाँ मोही विवरण";
            this.Load += new System.EventHandler(this.NewTenantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxFather;
        private System.Windows.Forms.TextBox TextBoxMobileNumber;
        private System.Windows.Forms.Label LabelFather;
        private System.Windows.Forms.Label LabelMobileNumber;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelFullname;
        private System.Windows.Forms.TextBox TextBoxFullname;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
    }
}