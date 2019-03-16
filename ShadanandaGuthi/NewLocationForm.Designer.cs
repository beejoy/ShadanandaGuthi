namespace ShadanandaGuthi
{
    partial class NewLocationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxLocalLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.DataGridViewLocations = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "साविक गा.वि.स. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "नयाँ स्थानीय तह :";
            // 
            // TextBoxLocation
            // 
            this.TextBoxLocation.Location = new System.Drawing.Point(120, 22);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(240, 26);
            this.TextBoxLocation.TabIndex = 1;
            this.TextBoxLocation.TextChanged += new System.EventHandler(this.TextBoxLocation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "(जस्तै : तुङ्गेछा-३)";
            // 
            // TextBoxLocalLevel
            // 
            this.TextBoxLocalLevel.Location = new System.Drawing.Point(120, 81);
            this.TextBoxLocalLevel.Name = "TextBoxLocalLevel";
            this.TextBoxLocalLevel.Size = new System.Drawing.Size(240, 26);
            this.TextBoxLocalLevel.TabIndex = 4;
            this.TextBoxLocalLevel.TextChanged += new System.EventHandler(this.TextBoxLocalLevel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "(जस्तै : षडानन्द-८)";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(19, 164);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(123, 41);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "सुरक्षित गर्नुहोस्";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Location = new System.Drawing.Point(257, 164);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(103, 41);
            this.ButtonQuit.TabIndex = 8;
            this.ButtonQuit.Text = "रद्द गर्नुहोस्";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // DataGridViewLocations
            // 
            this.DataGridViewLocations.AllowUserToAddRows = false;
            this.DataGridViewLocations.AllowUserToDeleteRows = false;
            this.DataGridViewLocations.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridViewLocations.Location = new System.Drawing.Point(388, 22);
            this.DataGridViewLocations.Name = "DataGridViewLocations";
            this.DataGridViewLocations.ReadOnly = true;
            this.DataGridViewLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLocations.Size = new System.Drawing.Size(369, 183);
            this.DataGridViewLocations.TabIndex = 9;
            this.DataGridViewLocations.TabStop = false;
            this.DataGridViewLocations.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewLocations_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "क्र.सं.";
            this.Column1.MinimumWidth = 70;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "साविक गा.वि.स.";
            this.Column2.MinimumWidth = 110;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "नयाँ स्थानीय तह";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(148, 164);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(103, 41);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "मेटाउनुहोस्";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // NewLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 224);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.DataGridViewLocations);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxLocalLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLocationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "स्थान विवरण";
            this.Load += new System.EventHandler(this.NewLocationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxLocalLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.DataGridView DataGridViewLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button ButtonDelete;
    }
}