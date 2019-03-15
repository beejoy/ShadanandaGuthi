namespace ShadanandaGuthi
{
    partial class NewLandForm
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
            this.ComboBoxLocation = new System.Windows.Forms.ComboBox();
            this.TextBoxPlotNumber = new System.Windows.Forms.TextBox();
            this.TextBoxLandArea = new System.Windows.Forms.TextBox();
            this.LabelLocation = new System.Windows.Forms.Label();
            this.LabelPlotNumber = new System.Windows.Forms.Label();
            this.LabelLandArea = new System.Windows.Forms.Label();
            this.LabelLandAreaHint = new System.Windows.Forms.Label();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxLocation
            // 
            this.ComboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLocation.FormattingEnabled = true;
            this.ComboBoxLocation.IntegralHeight = false;
            this.ComboBoxLocation.ItemHeight = 20;
            this.ComboBoxLocation.Location = new System.Drawing.Point(145, 27);
            this.ComboBoxLocation.Name = "ComboBoxLocation";
            this.ComboBoxLocation.Size = new System.Drawing.Size(252, 28);
            this.ComboBoxLocation.TabIndex = 1;
            // 
            // TextBoxPlotNumber
            // 
            this.TextBoxPlotNumber.Location = new System.Drawing.Point(145, 70);
            this.TextBoxPlotNumber.Name = "TextBoxPlotNumber";
            this.TextBoxPlotNumber.Size = new System.Drawing.Size(129, 26);
            this.TextBoxPlotNumber.TabIndex = 3;
            this.TextBoxPlotNumber.TextChanged += new System.EventHandler(this.TextBoxPlotNumber_TextChanged);
            // 
            // TextBoxLandArea
            // 
            this.TextBoxLandArea.Location = new System.Drawing.Point(145, 112);
            this.TextBoxLandArea.Name = "TextBoxLandArea";
            this.TextBoxLandArea.Size = new System.Drawing.Size(129, 26);
            this.TextBoxLandArea.TabIndex = 5;
            this.TextBoxLandArea.TextChanged += new System.EventHandler(this.TextBoxLandArea_TextChanged);
            // 
            // LabelLocation
            // 
            this.LabelLocation.AutoSize = true;
            this.LabelLocation.Location = new System.Drawing.Point(24, 30);
            this.LabelLocation.Name = "LabelLocation";
            this.LabelLocation.Size = new System.Drawing.Size(96, 20);
            this.LabelLocation.TabIndex = 0;
            this.LabelLocation.Text = "जग्गा भएको स्थान :";
            // 
            // LabelPlotNumber
            // 
            this.LabelPlotNumber.AutoSize = true;
            this.LabelPlotNumber.Location = new System.Drawing.Point(24, 73);
            this.LabelPlotNumber.Name = "LabelPlotNumber";
            this.LabelPlotNumber.Size = new System.Drawing.Size(91, 20);
            this.LabelPlotNumber.TabIndex = 2;
            this.LabelPlotNumber.Text = "जग्गाको कित्ता नं. :";
            // 
            // LabelLandArea
            // 
            this.LabelLandArea.AutoSize = true;
            this.LabelLandArea.Location = new System.Drawing.Point(25, 114);
            this.LabelLandArea.Name = "LabelLandArea";
            this.LabelLandArea.Size = new System.Drawing.Size(90, 20);
            this.LabelLandArea.TabIndex = 4;
            this.LabelLandArea.Text = "जग्गाको क्षेत्रफल :";
            // 
            // LabelLandAreaHint
            // 
            this.LabelLandAreaHint.AutoSize = true;
            this.LabelLandAreaHint.Location = new System.Drawing.Point(280, 114);
            this.LabelLandAreaHint.Name = "LabelLandAreaHint";
            this.LabelLandAreaHint.Size = new System.Drawing.Size(118, 20);
            this.LabelLandAreaHint.TabIndex = 8;
            this.LabelLandAreaHint.Text = "(रोपनी-आना-पैसा-दाम)";
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Location = new System.Drawing.Point(274, 168);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(123, 41);
            this.ButtonQuit.TabIndex = 7;
            this.ButtonQuit.Text = "रद्द गर्नुहोस्";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(145, 168);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(123, 41);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "सुरक्षित गर्नुहोस्";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // NewLandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(427, 232);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.LabelLandAreaHint);
            this.Controls.Add(this.LabelLandArea);
            this.Controls.Add(this.LabelPlotNumber);
            this.Controls.Add(this.LabelLocation);
            this.Controls.Add(this.TextBoxLandArea);
            this.Controls.Add(this.TextBoxPlotNumber);
            this.Controls.Add(this.ComboBoxLocation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLandForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "नयाँ जग्गा विवरण";
            this.Load += new System.EventHandler(this.NewLandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxLocation;
        private System.Windows.Forms.TextBox TextBoxPlotNumber;
        private System.Windows.Forms.TextBox TextBoxLandArea;
        private System.Windows.Forms.Label LabelLocation;
        private System.Windows.Forms.Label LabelPlotNumber;
        private System.Windows.Forms.Label LabelLandArea;
        private System.Windows.Forms.Label LabelLandAreaHint;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Button ButtonSave;
    }
}