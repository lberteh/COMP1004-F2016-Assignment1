/*
 * App: Sales Bonus
 * Author: Lucas Schoenardie
 * Create on: 30/09/2016
 * Description: Calculates the Sales Bonus paid to each employee based on amount of worked hours
 *              and total monthly sales 
 */

namespace Assignment1
{
    // Partial class declaration 
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
            this.EmployeesNameTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBonusButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.NextEntryButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LanguagePanel = new System.Windows.Forms.Panel();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.SetLanguageToPortugueseButton = new System.Windows.Forms.Button();
            this.SetLanguageToFrenchButton = new System.Windows.Forms.Button();
            this.SetLanguageToEnglishButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.TotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeesNameLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.SalesBonusResultLabel = new System.Windows.Forms.Label();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LanguagePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesNameTextBox
            // 
            this.EmployeesNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmployeesNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.EmployeesNameTextBox.Location = new System.Drawing.Point(9, 8);
            this.EmployeesNameTextBox.Name = "EmployeesNameTextBox";
            this.EmployeesNameTextBox.Size = new System.Drawing.Size(299, 17);
            this.EmployeesNameTextBox.TabIndex = 7;
            this.EmployeesNameTextBox.Tag = "EmployeesNameLabel";
            this.EmployeesNameTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChange);
            // 
            // CalculateBonusButton
            // 
            this.CalculateBonusButton.AutoSize = true;
            this.CalculateBonusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.CalculateBonusButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CalculateBonusButton.FlatAppearance.BorderSize = 0;
            this.CalculateBonusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBonusButton.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBonusButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBonusButton.Location = new System.Drawing.Point(120, 405);
            this.CalculateBonusButton.Name = "CalculateBonusButton";
            this.CalculateBonusButton.Size = new System.Drawing.Size(110, 35);
            this.CalculateBonusButton.TabIndex = 12;
            this.CalculateBonusButton.Text = "Calculate";
            this.CalculateBonusButton.UseVisualStyleBackColor = false;
            this.CalculateBonusButton.Click += new System.EventHandler(this.CalculateBonusButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.PrintButton.Location = new System.Drawing.Point(20, 405);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(90, 35);
            this.PrintButton.TabIndex = 13;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // NextEntryButton
            // 
            this.NextEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.NextEntryButton.FlatAppearance.BorderSize = 0;
            this.NextEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextEntryButton.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextEntryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.NextEntryButton.Location = new System.Drawing.Point(240, 405);
            this.NextEntryButton.Name = "NextEntryButton";
            this.NextEntryButton.Size = new System.Drawing.Size(90, 35);
            this.NextEntryButton.TabIndex = 14;
            this.NextEntryButton.Text = "Next";
            this.NextEntryButton.UseVisualStyleBackColor = false;
            this.NextEntryButton.Click += new System.EventHandler(this.NextEntryButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 75);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // LanguagePanel
            // 
            this.LanguagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.LanguagePanel.Controls.Add(this.LanguageLabel);
            this.LanguagePanel.Controls.Add(this.SetLanguageToPortugueseButton);
            this.LanguagePanel.Controls.Add(this.SetLanguageToFrenchButton);
            this.LanguagePanel.Controls.Add(this.SetLanguageToEnglishButton);
            this.LanguagePanel.Location = new System.Drawing.Point(20, 115);
            this.LanguagePanel.Name = "LanguagePanel";
            this.LanguagePanel.Size = new System.Drawing.Size(310, 80);
            this.LanguagePanel.TabIndex = 17;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.LanguageLabel.Location = new System.Drawing.Point(7, 8);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(89, 19);
            this.LanguageLabel.TabIndex = 18;
            this.LanguageLabel.Text = "Language";
            // 
            // SetLanguageToPortugueseButton
            // 
            this.SetLanguageToPortugueseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.SetLanguageToPortugueseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SetLanguageToPortugueseButton.FlatAppearance.BorderSize = 0;
            this.SetLanguageToPortugueseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetLanguageToPortugueseButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetLanguageToPortugueseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SetLanguageToPortugueseButton.Location = new System.Drawing.Point(210, 35);
            this.SetLanguageToPortugueseButton.Name = "SetLanguageToPortugueseButton";
            this.SetLanguageToPortugueseButton.Size = new System.Drawing.Size(90, 35);
            this.SetLanguageToPortugueseButton.TabIndex = 20;
            this.SetLanguageToPortugueseButton.Text = "Português";
            this.SetLanguageToPortugueseButton.UseVisualStyleBackColor = false;
            this.SetLanguageToPortugueseButton.Click += new System.EventHandler(this.SetLanguage);
            // 
            // SetLanguageToFrenchButton
            // 
            this.SetLanguageToFrenchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.SetLanguageToFrenchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SetLanguageToFrenchButton.FlatAppearance.BorderSize = 0;
            this.SetLanguageToFrenchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetLanguageToFrenchButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetLanguageToFrenchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SetLanguageToFrenchButton.Location = new System.Drawing.Point(110, 35);
            this.SetLanguageToFrenchButton.Name = "SetLanguageToFrenchButton";
            this.SetLanguageToFrenchButton.Size = new System.Drawing.Size(90, 35);
            this.SetLanguageToFrenchButton.TabIndex = 19;
            this.SetLanguageToFrenchButton.Text = "Français";
            this.SetLanguageToFrenchButton.UseVisualStyleBackColor = false;
            this.SetLanguageToFrenchButton.Click += new System.EventHandler(this.SetLanguage);
            // 
            // SetLanguageToEnglishButton
            // 
            this.SetLanguageToEnglishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.SetLanguageToEnglishButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SetLanguageToEnglishButton.FlatAppearance.BorderSize = 0;
            this.SetLanguageToEnglishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetLanguageToEnglishButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetLanguageToEnglishButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.SetLanguageToEnglishButton.Location = new System.Drawing.Point(10, 35);
            this.SetLanguageToEnglishButton.Name = "SetLanguageToEnglishButton";
            this.SetLanguageToEnglishButton.Size = new System.Drawing.Size(90, 35);
            this.SetLanguageToEnglishButton.TabIndex = 18;
            this.SetLanguageToEnglishButton.Text = "English";
            this.SetLanguageToEnglishButton.UseVisualStyleBackColor = false;
            this.SetLanguageToEnglishButton.Click += new System.EventHandler(this.SetLanguage);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.EmployeeIDLabel);
            this.panel3.Controls.Add(this.EmployeeIDTextBox);
            this.panel3.Location = new System.Drawing.Point(20, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 35);
            this.panel3.TabIndex = 16;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(10, 9);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(101, 17);
            this.EmployeeIDLabel.TabIndex = 19;
            this.EmployeeIDLabel.Tag = "EmployeeIDTextBox";
            this.EmployeeIDLabel.Text = "Employee ID";
            this.EmployeeIDLabel.Click += new System.EventHandler(this.FocusTextBox);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmployeeIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(9, 8);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(299, 17);
            this.EmployeeIDTextBox.TabIndex = 8;
            this.EmployeeIDTextBox.Tag = "EmployeeIDLabel";
            this.EmployeeIDTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChange);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.HoursWorkedLabel);
            this.panel4.Controls.Add(this.HoursWorkedTextBox);
            this.panel4.Location = new System.Drawing.Point(20, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 35);
            this.panel4.TabIndex = 16;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(10, 9);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(111, 17);
            this.HoursWorkedLabel.TabIndex = 20;
            this.HoursWorkedLabel.Tag = "HoursWorkedTextBox";
            this.HoursWorkedLabel.Text = "Hours Worked";
            this.HoursWorkedLabel.Click += new System.EventHandler(this.FocusTextBox);
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HoursWorkedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(9, 8);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(299, 17);
            this.HoursWorkedTextBox.TabIndex = 9;
            this.HoursWorkedTextBox.Tag = "HoursWorkedLabel";
            this.HoursWorkedTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChange);
            this.HoursWorkedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursWorkedTextBox_KeyPress);
            this.HoursWorkedTextBox.Leave += new System.EventHandler(this.HoursWorkedTextBox_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.TotalSalesLabel);
            this.panel5.Controls.Add(this.TotalSalesTextBox);
            this.panel5.Location = new System.Drawing.Point(20, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 35);
            this.panel5.TabIndex = 16;
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TotalSalesLabel.Location = new System.Drawing.Point(10, 9);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(88, 17);
            this.TotalSalesLabel.TabIndex = 21;
            this.TotalSalesLabel.Tag = "TotalSalesTextBox";
            this.TotalSalesLabel.Text = "Total Sales";
            this.TotalSalesLabel.Click += new System.EventHandler(this.FocusTextBox);
            // 
            // TotalSalesTextBox
            // 
            this.TotalSalesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TotalSalesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalSalesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.TotalSalesTextBox.Location = new System.Drawing.Point(9, 8);
            this.TotalSalesTextBox.Name = "TotalSalesTextBox";
            this.TotalSalesTextBox.Size = new System.Drawing.Size(299, 17);
            this.TotalSalesTextBox.TabIndex = 10;
            this.TotalSalesTextBox.Tag = "TotalSalesLabel";
            this.TotalSalesTextBox.TextChanged += new System.EventHandler(this.TotalSalesTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmployeesNameLabel);
            this.panel1.Controls.Add(this.EmployeesNameTextBox);
            this.panel1.Location = new System.Drawing.Point(20, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 35);
            this.panel1.TabIndex = 15;
            // 
            // EmployeesNameLabel
            // 
            this.EmployeesNameLabel.AutoSize = true;
            this.EmployeesNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmployeesNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeesNameLabel.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EmployeesNameLabel.Location = new System.Drawing.Point(10, 9);
            this.EmployeesNameLabel.Name = "EmployeesNameLabel";
            this.EmployeesNameLabel.Size = new System.Drawing.Size(137, 17);
            this.EmployeesNameLabel.TabIndex = 18;
            this.EmployeesNameLabel.Tag = "EmployeesNameTextBox";
            this.EmployeesNameLabel.Text = "Employee\'s Name";
            this.EmployeesNameLabel.Click += new System.EventHandler(this.FocusTextBox);
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SalesBonusLabel.Location = new System.Drawing.Point(20, 460);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(102, 17);
            this.SalesBonusLabel.TabIndex = 18;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            // 
            // SalesBonusResultLabel
            // 
            this.SalesBonusResultLabel.AutoSize = true;
            this.SalesBonusResultLabel.Font = new System.Drawing.Font("Lucida Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.SalesBonusResultLabel.Location = new System.Drawing.Point(11, 483);
            this.SalesBonusResultLabel.Name = "SalesBonusResultLabel";
            this.SalesBonusResultLabel.Size = new System.Drawing.Size(0, 55);
            this.SalesBonusResultLabel.TabIndex = 19;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.ErrorPanel.Controls.Add(this.ErrorLabel);
            this.ErrorPanel.Location = new System.Drawing.Point(20, 488);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(310, 70);
            this.ErrorPanel.TabIndex = 20;
            this.ErrorPanel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.ErrorLabel.Location = new System.Drawing.Point(9, 8);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorLabel.TabIndex = 21;
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(350, 577);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.SalesBonusResultLabel);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.LanguagePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NextEntryButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateBonusButton);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";          
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LanguagePanel.ResumeLayout(false);
            this.LanguagePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public string employeesName
        {
            get { return this.EmployeesNameTextBox.Text; } set { }            
        }

        #endregion
        private System.Windows.Forms.TextBox EmployeesNameTextBox;
        private System.Windows.Forms.Button CalculateBonusButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NextEntryButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LanguagePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalSalesTextBox;
        private System.Windows.Forms.Button SetLanguageToEnglishButton;
        private System.Windows.Forms.Button SetLanguageToPortugueseButton;
        private System.Windows.Forms.Button SetLanguageToFrenchButton;
        private System.Windows.Forms.Label EmployeesNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Label SalesBonusResultLabel;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

