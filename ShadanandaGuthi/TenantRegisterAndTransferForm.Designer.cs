namespace ShadanandaGuthi
{
    partial class TenantRegisterAndTransferForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxLocation = new System.Windows.Forms.ComboBox();
            this.ComboBoxLand = new System.Windows.Forms.ComboBox();
            this.ComboBoxNewTenant = new System.Windows.Forms.ComboBox();
            this.TextBoxLeaseFrom = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxCurrentTenant = new System.Windows.Forms.ComboBox();
            this.TextBoxAnnualRent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxRemarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "जग्गा भएको स्थान :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "कित्ता नं. / क्षेत्रफल :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "हालको मोही :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "नयाँ मोही :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "भोग चलनको मिति :";
            // 
            // ComboBoxLocation
            // 
            this.ComboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLocation.FormattingEnabled = true;
            this.ComboBoxLocation.IntegralHeight = false;
            this.ComboBoxLocation.Location = new System.Drawing.Point(136, 25);
            this.ComboBoxLocation.Name = "ComboBoxLocation";
            this.ComboBoxLocation.Size = new System.Drawing.Size(252, 28);
            this.ComboBoxLocation.TabIndex = 1;
            this.ComboBoxLocation.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLocation_SelectedIndexChanged);
            // 
            // ComboBoxLand
            // 
            this.ComboBoxLand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLand.FormattingEnabled = true;
            this.ComboBoxLand.IntegralHeight = false;
            this.ComboBoxLand.Location = new System.Drawing.Point(136, 67);
            this.ComboBoxLand.Name = "ComboBoxLand";
            this.ComboBoxLand.Size = new System.Drawing.Size(252, 28);
            this.ComboBoxLand.TabIndex = 3;
            this.ComboBoxLand.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLand_SelectedIndexChanged);
            // 
            // ComboBoxNewTenant
            // 
            this.ComboBoxNewTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNewTenant.FormattingEnabled = true;
            this.ComboBoxNewTenant.IntegralHeight = false;
            this.ComboBoxNewTenant.Location = new System.Drawing.Point(136, 151);
            this.ComboBoxNewTenant.Name = "ComboBoxNewTenant";
            this.ComboBoxNewTenant.Size = new System.Drawing.Size(252, 28);
            this.ComboBoxNewTenant.TabIndex = 7;
            // 
            // TextBoxLeaseFrom
            // 
            this.TextBoxLeaseFrom.Location = new System.Drawing.Point(136, 193);
            this.TextBoxLeaseFrom.Name = "TextBoxLeaseFrom";
            this.TextBoxLeaseFrom.Size = new System.Drawing.Size(135, 26);
            this.TextBoxLeaseFrom.TabIndex = 9;
            this.TextBoxLeaseFrom.TextChanged += new System.EventHandler(this.TextBoxLeaseFrom_TextChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(136, 357);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(123, 41);
            this.ButtonSave.TabIndex = 16;
            this.ButtonSave.Text = "सुरक्षित गर्नुहोस्";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Location = new System.Drawing.Point(265, 357);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(123, 41);
            this.ButtonQuit.TabIndex = 17;
            this.ButtonQuit.Text = "रद्द गर्नुहोस्";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "(जस्तै : २०७४-०४-०५)";
            // 
            // ComboBoxCurrentTenant
            // 
            this.ComboBoxCurrentTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCurrentTenant.FormattingEnabled = true;
            this.ComboBoxCurrentTenant.IntegralHeight = false;
            this.ComboBoxCurrentTenant.Location = new System.Drawing.Point(136, 109);
            this.ComboBoxCurrentTenant.Name = "ComboBoxCurrentTenant";
            this.ComboBoxCurrentTenant.Size = new System.Drawing.Size(252, 28);
            this.ComboBoxCurrentTenant.TabIndex = 5;
            this.ComboBoxCurrentTenant.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCurrentTenant_SelectedIndexChanged);
            // 
            // TextBoxAnnualRent
            // 
            this.TextBoxAnnualRent.Location = new System.Drawing.Point(136, 233);
            this.TextBoxAnnualRent.Name = "TextBoxAnnualRent";
            this.TextBoxAnnualRent.Size = new System.Drawing.Size(135, 26);
            this.TextBoxAnnualRent.TabIndex = 12;
            this.TextBoxAnnualRent.TextChanged += new System.EventHandler(this.TextBoxAnnualRent_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "वार्षिक ठेक्का :";
            // 
            // TextBoxRemarks
            // 
            this.TextBoxRemarks.Location = new System.Drawing.Point(136, 273);
            this.TextBoxRemarks.Multiline = true;
            this.TextBoxRemarks.Name = "TextBoxRemarks";
            this.TextBoxRemarks.Size = new System.Drawing.Size(252, 58);
            this.TextBoxRemarks.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "कैफियत :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "(नगद वा जिन्सी)";
            // 
            // TenantRegisterAndTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 420);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxRemarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxAnnualRent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxCurrentTenant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.TextBoxLeaseFrom);
            this.Controls.Add(this.ComboBoxNewTenant);
            this.Controls.Add(this.ComboBoxLand);
            this.Controls.Add(this.ComboBoxLocation);
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
            this.Name = "TenantRegisterAndTransferForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "मोही दर्ता तथा हस्तान्तरण";
            this.Load += new System.EventHandler(this.TenantRegisterAndTransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxLocation;
        private System.Windows.Forms.ComboBox ComboBoxLand;
        private System.Windows.Forms.ComboBox ComboBoxNewTenant;
        private System.Windows.Forms.TextBox TextBoxLeaseFrom;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.ToolTip ToolTipMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxCurrentTenant;
        private System.Windows.Forms.TextBox TextBoxAnnualRent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxRemarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}