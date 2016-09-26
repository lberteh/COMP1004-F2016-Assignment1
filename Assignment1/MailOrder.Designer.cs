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
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.EmployeesNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesLabelTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBonusButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.NextEntryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.LanguagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(29, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(200, 172);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // LanguagesGroupBox
            // 
            this.LanguagesGroupBox.Controls.Add(this.SetLanguageToFrenchRadioButton);
            this.LanguagesGroupBox.Controls.Add(this.SetLanguageToEnglishRadioButton);
            this.LanguagesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguagesGroupBox.Location = new System.Drawing.Point(264, 50);
            this.LanguagesGroupBox.Name = "LanguagesGroupBox";
            this.LanguagesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.LanguagesGroupBox.TabIndex = 1;
            this.LanguagesGroupBox.TabStop = false;
            this.LanguagesGroupBox.Text = "Language";
            // 
            // SetLanguageToFrenchRadioButton
            // 
            this.SetLanguageToFrenchRadioButton.AutoSize = true;
            this.SetLanguageToFrenchRadioButton.Location = new System.Drawing.Point(17, 56);
            this.SetLanguageToFrenchRadioButton.Name = "SetLanguageToFrenchRadioButton";
            this.SetLanguageToFrenchRadioButton.Size = new System.Drawing.Size(88, 24);
            this.SetLanguageToFrenchRadioButton.TabIndex = 1;
            this.SetLanguageToFrenchRadioButton.Text = "Français";
            this.SetLanguageToFrenchRadioButton.UseVisualStyleBackColor = true;
            // 
            // SetLanguageToEnglishRadioButton
            // 
            this.SetLanguageToEnglishRadioButton.AutoSize = true;
            this.SetLanguageToEnglishRadioButton.Checked = true;
            this.SetLanguageToEnglishRadioButton.Location = new System.Drawing.Point(17, 26);
            this.SetLanguageToEnglishRadioButton.Name = "SetLanguageToEnglishRadioButton";
            this.SetLanguageToEnglishRadioButton.Size = new System.Drawing.Size(79, 24);
            this.SetLanguageToEnglishRadioButton.TabIndex = 0;
            this.SetLanguageToEnglishRadioButton.TabStop = true;
            this.SetLanguageToEnglishRadioButton.Text = "English";
            this.SetLanguageToEnglishRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesNameLabel
            // 
            this.EmployeesNameLabel.AutoSize = true;
            this.EmployeesNameLabel.Location = new System.Drawing.Point(29, 226);
            this.EmployeesNameLabel.Name = "EmployeesNameLabel";
            this.EmployeesNameLabel.Size = new System.Drawing.Size(91, 13);
            this.EmployeesNameLabel.TabIndex = 2;
            this.EmployeesNameLabel.Text = "Employee\'s Name";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(29, 280);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIDLabel.TabIndex = 3;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(29, 326);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(76, 13);
            this.HoursWorkedLabel.TabIndex = 4;
            this.HoursWorkedLabel.Text = "Hours Worked";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(29, 371);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(60, 13);
            this.TotalSalesLabel.TabIndex = 5;
            this.TotalSalesLabel.Text = "Total Sales";
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(29, 419);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(66, 13);
            this.SalesBonusLabel.TabIndex = 6;
            this.SalesBonusLabel.Text = "Sales Bonus";
            // 
            // EmployeesNameTextBox
            // 
            this.EmployeesNameTextBox.Location = new System.Drawing.Point(184, 226);
            this.EmployeesNameTextBox.Name = "EmployeesNameTextBox";
            this.EmployeesNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeesNameTextBox.TabIndex = 7;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(184, 273);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDTextBox.TabIndex = 8;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(184, 319);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursWorkedTextBox.TabIndex = 9;
            // 
            // TotalSalesLabelTextBox
            // 
            this.TotalSalesLabelTextBox.Location = new System.Drawing.Point(184, 368);
            this.TotalSalesLabelTextBox.Name = "TotalSalesLabelTextBox";
            this.TotalSalesLabelTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesLabelTextBox.TabIndex = 10;
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(184, 412);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTextBox.TabIndex = 11;
            // 
            // CalculateBonusButton
            // 
            this.CalculateBonusButton.Location = new System.Drawing.Point(32, 469);
            this.CalculateBonusButton.Name = "CalculateBonusButton";
            this.CalculateBonusButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateBonusButton.TabIndex = 12;
            this.CalculateBonusButton.Text = "Calculate";
            this.CalculateBonusButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(184, 469);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 13;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // NextEntryButton
            // 
            this.NextEntryButton.Location = new System.Drawing.Point(341, 469);
            this.NextEntryButton.Name = "NextEntryButton";
            this.NextEntryButton.Size = new System.Drawing.Size(75, 23);
            this.NextEntryButton.TabIndex = 14;
            this.NextEntryButton.Text = "Next";
            this.NextEntryButton.UseVisualStyleBackColor = true;
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 516);
            this.Controls.Add(this.NextEntryButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateBonusButton);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalSalesLabelTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeesNameTextBox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeesNameLabel);
            this.Controls.Add(this.LanguagesGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "MailOrder";
            this.Text = "Sales Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.LanguagesGroupBox.ResumeLayout(false);
            this.LanguagesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.GroupBox LanguagesGroupBox;
        private System.Windows.Forms.RadioButton SetLanguageToFrenchRadioButton;
        private System.Windows.Forms.RadioButton SetLanguageToEnglishRadioButton;
        private System.Windows.Forms.Label EmployeesNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.TextBox EmployeesNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalSalesLabelTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Button CalculateBonusButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NextEntryButton;
    }
}

