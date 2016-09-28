namespace Assignment1
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LanguagesGroupBox = new System.Windows.Forms.GroupBox();
            this.SetLanguageToFrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.SetLanguageToEnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeesNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.EmployeesNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBonusButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.NextEntryButton = new System.Windows.Forms.Button();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.LanguagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(25, 25);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(196, 173);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // LanguagesGroupBox
            // 
            this.LanguagesGroupBox.Controls.Add(this.SetLanguageToFrenchRadioButton);
            this.LanguagesGroupBox.Controls.Add(this.SetLanguageToEnglishRadioButton);
            this.LanguagesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguagesGroupBox.Location = new System.Drawing.Point(273, 28);
            this.LanguagesGroupBox.Name = "LanguagesGroupBox";
            this.LanguagesGroupBox.Size = new System.Drawing.Size(303, 131);
            this.LanguagesGroupBox.TabIndex = 1;
            this.LanguagesGroupBox.TabStop = false;
            this.LanguagesGroupBox.Text = "Language";
            // 
            // SetLanguageToFrenchRadioButton
            // 
            this.SetLanguageToFrenchRadioButton.AutoSize = true;
            this.SetLanguageToFrenchRadioButton.Location = new System.Drawing.Point(17, 73);
            this.SetLanguageToFrenchRadioButton.Name = "SetLanguageToFrenchRadioButton";
            this.SetLanguageToFrenchRadioButton.Size = new System.Drawing.Size(123, 33);
            this.SetLanguageToFrenchRadioButton.TabIndex = 1;
            this.SetLanguageToFrenchRadioButton.Text = "Français";
            this.SetLanguageToFrenchRadioButton.UseVisualStyleBackColor = true;
            this.SetLanguageToFrenchRadioButton.CheckedChanged += new System.EventHandler(this.SetLanguageToFrenchRadioButton_CheckedChanged);
            // 
            // SetLanguageToEnglishRadioButton
            // 
            this.SetLanguageToEnglishRadioButton.AutoSize = true;
            this.SetLanguageToEnglishRadioButton.Checked = true;
            this.SetLanguageToEnglishRadioButton.Location = new System.Drawing.Point(17, 34);
            this.SetLanguageToEnglishRadioButton.Name = "SetLanguageToEnglishRadioButton";
            this.SetLanguageToEnglishRadioButton.Size = new System.Drawing.Size(111, 33);
            this.SetLanguageToEnglishRadioButton.TabIndex = 0;
            this.SetLanguageToEnglishRadioButton.TabStop = true;
            this.SetLanguageToEnglishRadioButton.Text = "English";
            this.SetLanguageToEnglishRadioButton.UseVisualStyleBackColor = true;
            this.SetLanguageToEnglishRadioButton.CheckedChanged += new System.EventHandler(this.SetLanguageToEnglishRadioButton_CheckedChanged);
            // 
            // EmployeesNameLabel
            // 
            this.EmployeesNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesNameLabel.Location = new System.Drawing.Point(5, 213);
            this.EmployeesNameLabel.Name = "EmployeesNameLabel";
            this.EmployeesNameLabel.Size = new System.Drawing.Size(270, 32);
            this.EmployeesNameLabel.TabIndex = 2;
            this.EmployeesNameLabel.Text = "Employee\'s Name:";
            this.EmployeesNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(-3, 269);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(270, 32);
            this.EmployeeIDLabel.TabIndex = 3;
            this.EmployeeIDLabel.Text = "Employee ID:";
            this.EmployeeIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLabel.Location = new System.Drawing.Point(5, 399);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(270, 32);
            this.TotalSalesLabel.TabIndex = 5;
            this.TotalSalesLabel.Text = "Total Sales:";
            this.TotalSalesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLabel.Location = new System.Drawing.Point(-3, 455);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(270, 31);
            this.SalesBonusLabel.TabIndex = 6;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            this.SalesBonusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EmployeesNameTextBox
            // 
            this.EmployeesNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmployeesNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EmployeesNameTextBox.Location = new System.Drawing.Point(273, 216);
            this.EmployeesNameTextBox.Multiline = true;
            this.EmployeesNameTextBox.Name = "EmployeesNameTextBox";
            this.EmployeesNameTextBox.Size = new System.Drawing.Size(303, 30);
            this.EmployeesNameTextBox.TabIndex = 7;
            this.EmployeesNameTextBox.Tag = "e.g. - Lucas Schoenardie";
            this.EmployeesNameTextBox.Enter += new System.EventHandler(this.TextBoxGotFocus);
            this.EmployeesNameTextBox.Leave += new System.EventHandler(this.TextBoxLostFocus);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(273, 272);
            this.EmployeeIDTextBox.Multiline = true;
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(188, 30);
            this.EmployeeIDTextBox.TabIndex = 8;
            this.EmployeeIDTextBox.Tag = "e.g. - 12345";
            this.EmployeeIDTextBox.Enter += new System.EventHandler(this.TextBoxGotFocus);
            this.EmployeeIDTextBox.Leave += new System.EventHandler(this.TextBoxLostFocus);
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(273, 346);
            this.HoursWorkedTextBox.Multiline = true;
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(188, 30);
            this.HoursWorkedTextBox.TabIndex = 9;
            this.HoursWorkedTextBox.Tag = "e.g. - 160";
            this.HoursWorkedTextBox.Enter += new System.EventHandler(this.TextBoxGotFocus);
            this.HoursWorkedTextBox.Leave += new System.EventHandler(this.TextBoxLostFocus);
            // 
            // TotalSalesTextBox
            // 
            this.TotalSalesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesTextBox.Location = new System.Drawing.Point(273, 402);
            this.TotalSalesTextBox.Multiline = true;
            this.TotalSalesTextBox.Name = "TotalSalesTextBox";
            this.TotalSalesTextBox.Size = new System.Drawing.Size(188, 30);
            this.TotalSalesTextBox.TabIndex = 10;
            this.TotalSalesTextBox.Tag = "e.g. - 14000";
            this.TotalSalesTextBox.Enter += new System.EventHandler(this.TextBoxGotFocus);
            this.TotalSalesTextBox.Leave += new System.EventHandler(this.TextBoxLostFocus);
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusTextBox.Location = new System.Drawing.Point(273, 458);
            this.SalesBonusTextBox.Multiline = true;
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(188, 30);
            this.SalesBonusTextBox.TabIndex = 11;
            // 
            // CalculateBonusButton
            // 
            this.CalculateBonusButton.AutoSize = true;
            this.CalculateBonusButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CalculateBonusButton.FlatAppearance.BorderSize = 2;
            this.CalculateBonusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CalculateBonusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBonusButton.Location = new System.Drawing.Point(16, 521);
            this.CalculateBonusButton.Name = "CalculateBonusButton";
            this.CalculateBonusButton.Size = new System.Drawing.Size(183, 46);
            this.CalculateBonusButton.TabIndex = 12;
            this.CalculateBonusButton.Text = "Calculate";
            this.CalculateBonusButton.UseVisualStyleBackColor = true;
            this.CalculateBonusButton.Click += new System.EventHandler(this.CalculateBonusButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(273, 521);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(128, 46);
            this.PrintButton.TabIndex = 13;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // NextEntryButton
            // 
            this.NextEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NextEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextEntryButton.Location = new System.Drawing.Point(462, 521);
            this.NextEntryButton.Name = "NextEntryButton";
            this.NextEntryButton.Size = new System.Drawing.Size(114, 46);
            this.NextEntryButton.TabIndex = 14;
            this.NextEntryButton.Text = "Next";
            this.NextEntryButton.UseVisualStyleBackColor = true;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedLabel.Location = new System.Drawing.Point(5, 343);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HoursWorkedLabel.Size = new System.Drawing.Size(270, 31);
            this.HoursWorkedLabel.TabIndex = 4;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            this.HoursWorkedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 579);
            this.Controls.Add(this.NextEntryButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateBonusButton);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalSalesTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeesNameTextBox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeesNameLabel);
            this.Controls.Add(this.LanguagesGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.HoursWorkedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MailOrder";
            this.Text = "Sales Bonus";
            this.Load += new System.EventHandler(this.MailOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.LanguagesGroupBox.ResumeLayout(false);
            this.LanguagesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public string employeesName
        {
            get { return this.EmployeesNameTextBox.Text; } set { }            
        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.GroupBox LanguagesGroupBox;
        private System.Windows.Forms.RadioButton SetLanguageToFrenchRadioButton;
        private System.Windows.Forms.RadioButton SetLanguageToEnglishRadioButton;
        private System.Windows.Forms.Label EmployeesNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.TextBox EmployeesNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalSalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Button CalculateBonusButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NextEntryButton;
        private System.Windows.Forms.Label HoursWorkedLabel;
    }
}

