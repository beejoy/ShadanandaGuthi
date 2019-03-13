namespace ShadanandaGuthi
{
    partial class CurrentYearForm
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
            this.ListBoxCurrentYear = new System.Windows.Forms.ListBox();
            this.ButtonSetCurrentYear = new System.Windows.Forms.Button();
            this.ButtonDeleteYear = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAddNewYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "चालू वर्ष";
            // 
            // ListBoxCurrentYear
            // 
            this.ListBoxCurrentYear.FormattingEnabled = true;
            this.ListBoxCurrentYear.ItemHeight = 20;
            this.ListBoxCurrentYear.Location = new System.Drawing.Point(26, 46);
            this.ListBoxCurrentYear.Name = "ListBoxCurrentYear";
            this.ListBoxCurrentYear.Size = new System.Drawing.Size(120, 204);
            this.ListBoxCurrentYear.TabIndex = 3;
            // 
            // ButtonSetCurrentYear
            // 
            this.ButtonSetCurrentYear.Location = new System.Drawing.Point(175, 100);
            this.ButtonSetCurrentYear.Name = "ButtonSetCurrentYear";
            this.ButtonSetCurrentYear.Size = new System.Drawing.Size(123, 41);
            this.ButtonSetCurrentYear.TabIndex = 9;
            this.ButtonSetCurrentYear.Text = "चालू वर्ष सेट गर्नुहोस्";
            this.ButtonSetCurrentYear.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteYear
            // 
            this.ButtonDeleteYear.Location = new System.Drawing.Point(175, 154);
            this.ButtonDeleteYear.Name = "ButtonDeleteYear";
            this.ButtonDeleteYear.Size = new System.Drawing.Size(123, 41);
            this.ButtonDeleteYear.TabIndex = 10;
            this.ButtonDeleteYear.Text = "वर्ष मेटाउहोस्";
            this.ButtonDeleteYear.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(175, 208);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(123, 41);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "रद्द गर्नुहोस्";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAddNewYear
            // 
            this.ButtonAddNewYear.Location = new System.Drawing.Point(175, 46);
            this.ButtonAddNewYear.Name = "ButtonAddNewYear";
            this.ButtonAddNewYear.Size = new System.Drawing.Size(123, 41);
            this.ButtonAddNewYear.TabIndex = 13;
            this.ButtonAddNewYear.Text = "नयाँ वर्ष थप गर्नुहोस्";
            this.ButtonAddNewYear.UseVisualStyleBackColor = true;
            // 
            // CurrentYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 275);
            this.Controls.Add(this.ButtonAddNewYear);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonDeleteYear);
            this.Controls.Add(this.ButtonSetCurrentYear);
            this.Controls.Add(this.ListBoxCurrentYear);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentYearForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "चालू वर्ष सेटिङ्ग";
            this.Activated += new System.EventHandler(this.CurrentYearForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBoxCurrentYear;
        private System.Windows.Forms.Button ButtonSetCurrentYear;
        private System.Windows.Forms.Button ButtonDeleteYear;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAddNewYear;
    }
}