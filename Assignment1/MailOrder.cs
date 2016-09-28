using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class MailOrder : Form
    {
        // class scope private variables
        private Font placeholderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public MailOrder()
        {
            InitializeComponent();
        }

        private void MailOrder_Load(object sender, EventArgs e) 
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) && ctrl.Name != "SalesBonusTextBox")
                {
                    // Do whatever to the TextBox 
                    ctrl.Font = placeholderFont;
                    ctrl.Text = (string)ctrl.Tag;
                    ctrl.ForeColor = System.Drawing.SystemColors.WindowFrame;
                }
            }
        }

        private void CalculateBonusButton_Click(object sender, EventArgs e)
        {
            CalculateSalesBonus();
        }

        private void CalculateSalesBonus()
        {
            // Local variables
            const double BonusPercentage = 0.02;
            const int MaxHours = 160;
            double TotalHoursWorked;
            double TotalMonthlySales;
            double SalesBonus;
            double PercentageOfHoursWorked;
            double TotalBonusAmount;

            try
            {
                // read values from the text boxes
                TotalHoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);
                PercentageOfHoursWorked = TotalHoursWorked / MaxHours;
                TotalMonthlySales = Convert.ToDouble(TotalSalesTextBox.Text);
                TotalBonusAmount = TotalMonthlySales * BonusPercentage;
                SalesBonus = PercentageOfHoursWorked * TotalBonusAmount;              
           
                SalesBonusTextBox.Text = SalesBonus.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
            }

        }

        private void SetLanguageToFrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MailOrder.ActiveForm.Text = "Bonus de vente";
            LanguagesGroupBox.Text = "La Langue";
            EmployeesNameLabel.Text = "Nom de l'Employé:";
            EmployeeIDLabel.Text = "ID d'Employé:";
            HoursWorkedLabel.Text = "Heures Travaillées:";
            TotalSalesLabel.Text = "Total des ventes:";
            SalesBonusLabel.Text = "Bonus de vente:";
            CalculateBonusButton.Text = "Calculer";
            PrintButton.Text = "Imprimer";
            NextEntryButton.Text = "Suivant";
        }

        private void SetLanguageToEnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MailOrder.ActiveForm.Text = "Sales Bonus";
            LanguagesGroupBox.Text = "Language";
            EmployeesNameLabel.Text = "Employee's Name";
            EmployeeIDLabel.Text = "Employee ID:";
            HoursWorkedLabel.Text = "Hours Worked:";
            TotalSalesLabel.Text = "Total Sales:";
            SalesBonusLabel.Text = "Sales Bonus:";
            CalculateBonusButton.Text = "Calculate";
            PrintButton.Text = "Print";
            NextEntryButton.Text = "Next";
        }

        

        // This method runs when the TextBox "Enter" event is triggered 
        // Empties textbox text if text is equals to placeholder 
        public void TextBoxGotFocus(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            string placeholder = (string)tBox.Tag; // or tb.Tag.ToString()
            if(tBox.Text == placeholder)
            {
                tBox.Text = string.Empty;
            }
            
            Debug.WriteLine(placeholder);
        }

        // This method runs when the TextBox "Leave" event is triggered 
        // Inserts placeholder if textbox text is empty
        public void TextBoxLostFocus(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            string placeholder = (string)tBox.Tag;
            if(tBox.Text == string.Empty)
            {
                tBox.Text = placeholder;
            }
        }


    }
}
