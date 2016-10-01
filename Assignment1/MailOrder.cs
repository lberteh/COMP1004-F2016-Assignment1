/*
 * App: Sales Bonus
 * Author: Lucas Schoenardie
 * Create on: 30/09/2016
 * Description: Calculates the Sales Bonus paid to each employee based on amount of worked hours
 *              and total monthly sales 
 */
 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    // Partial class declaration 
    public partial class MailOrder : Form
    {

        public MailOrder()
        {
            InitializeComponent();
        }

        //Click Event Handler for Calculate Button 
        private void CalculateBonusButton_Click(object sender, EventArgs e)
        {
            CalculateSalesBonus();            
        }

        // Calculates Total Sales Bonus
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
            string TotalSales;

            try
            {
                // read values from the text boxes
                TotalHoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);

                // Amount of hours validation, checks if inserted hours worked is not greater than 160
                if(TotalHoursWorked > 160)
                {              
                    // if greater than 160, display errors   
                    ErrorPanel.Visible = true;
                    ErrorLabel.Text = "Hours Worked cannot exceed 160!";                    
                } 
                else
                {
                    // if not greater than 160, continue. Hide errors first
                    ErrorPanel.Visible = false;

                    PercentageOfHoursWorked = TotalHoursWorked / MaxHours;

                    // clear all formating and keep only numbers 
                    TotalSales = TotalSalesTextBox.Text.Replace(",", "")
                    .Replace("$", "").Replace(".", "").TrimStart('0');

                    // insert a dot before last 2 digits so we can have cents
                    TotalSales = TotalSales.Insert(TotalSales.Length - 2, ".");
                    // Debug.WriteLine(TotalSales);

                    TotalMonthlySales = Convert.ToDouble(TotalSales);
                    TotalBonusAmount = TotalMonthlySales * BonusPercentage;
                    SalesBonus = PercentageOfHoursWorked * TotalBonusAmount;

                    SalesBonusResultLabel.Text = SalesBonus.ToString("C2");
                }
                
            }
            catch (Exception exception)
            {
                // display error
                ErrorPanel.Visible = true;
                ErrorLabel.Text = "Invalid Data! Please, check Total Sales field.";
                Debug.WriteLine(exception.Message);
            }

        }

        // Click Event Handler. Changes Application Language
        private void SetLanguage(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.Name == "SetLanguageToPortugueseButton")
            {
                SetLanguageToPortuguese();
            }
            if(button.Name == "SetLanguageToEnglishButton")
            {
                SetLanguageToEnglish();
            }
            if (button.Name == "SetLanguageToFrenchButton")
            {
                SetLanguageToFrench();
            }

        }

        private void SetLanguageToPortuguese()
        {
            MailOrder.ActiveForm.Text = "Bônus de vendas";
            LanguageLabel.Text = "Idioma";
            EmployeesNameLabel.Text = "Nome do Funcionário";
            EmployeeIDLabel.Text = "ID do Funcionário";
            HoursWorkedLabel.Text = "Horas Trabalhadas";
            TotalSalesLabel.Text = "Total de Vendas";
            SalesBonusLabel.Text = "Bônus de Vendas:";
            CalculateBonusButton.Text = "Calcular";
            PrintButton.Text = "Imprimir";
            NextEntryButton.Text = "Próximo";

            // change buttons background color (to identify which language is active)
            SetLanguageToPortugueseButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#90a4ae");
            SetLanguageToPortugueseButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eceff1");

            SetLanguageToEnglishButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#b0bec5");
            SetLanguageToEnglishButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#546e7a");

            SetLanguageToFrenchButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#b0bec5");
            SetLanguageToFrenchButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#546e7a");
        }

        private void SetLanguageToFrench()
        {
            MailOrder.ActiveForm.Text = "Bonus de vente";
            LanguageLabel.Text = "La Langue";
            EmployeesNameLabel.Text = "Nom de l'Employé";
            EmployeeIDLabel.Text = "ID d'Employé";
            HoursWorkedLabel.Text = "Heures Travaillées";
            TotalSalesLabel.Text = "Total des ventes";
            SalesBonusLabel.Text = "Bonus de vente";
            CalculateBonusButton.Text = "Calculer";
            PrintButton.Text = "Imprimer";
            NextEntryButton.Text = "Suivant";

            // change buttons background color (to identify which language is active)
            SetLanguageToFrenchButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#90a4ae");
            SetLanguageToFrenchButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eceff1");

            SetLanguageToEnglishButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#b0bec5");
            SetLanguageToEnglishButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#546e7a");

            SetLanguageToPortugueseButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#b0bec5");
            SetLanguageToPortugueseButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#546e7a");
        }

        private void SetLanguageToEnglish()
        {
            MailOrder.ActiveForm.Text = "Sales Bonus";
            LanguageLabel.Text = "Language";
            EmployeesNameLabel.Text = "Employee's Name";
            EmployeeIDLabel.Text = "Employee ID";
            HoursWorkedLabel.Text = "Hours Worked";
            TotalSalesLabel.Text = "Total Sales";
            SalesBonusLabel.Text = "Sales Bonus";
            CalculateBonusButton.Text = "Calculate";
            PrintButton.Text = "Print";
            NextEntryButton.Text = "Next";

            // change buttons background color (to identify which language is active)
            SetLanguageToEnglishButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#90a4ae");
            SetLanguageToEnglishButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#eceff1");

            SetLanguageToFrenchButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#b0bec5");
            SetLanguageToFrenchButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#546e7a");

            SetLanguageToPortugueseButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#b0bec5");
            SetLanguageToPortugueseButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#546e7a");
        }

        // TextChanged Event Handler
        // This method is used to implement a placeholder functionality for the textboxes
        // Once user starts typing, the label that was visible (working as a placeholder), goes invisible
        public void TextBoxTextChange(object sender, EventArgs e)
        {
            // Local variables
            TextBox tBox = (TextBox)sender;
            string siblingLabel = (string)tBox.Tag;
            Label label = ((Label)this.Controls.Find(siblingLabel, true)[0]);

            // Toogles between visible and invisible acording to textbox content. 
            if (tBox.Text != string.Empty)
            {
                label.Visible = false;
            } 
            // If there is no text, label (placeholder) is visible
            else
            {
                label.Visible = true;
            }
        }

        // If Label is Clicked, related textbox gets focused
        public void FocusTextBox(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string siblingTextBox = (string)label.Tag;
            TextBox tBox = ((TextBox)this.Controls.Find(siblingTextBox, true)[0]);
            tBox.Focus();
        }

        // Click Event Handler for Print Button
        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintMessage();
        }

        // Simulates a print preview using a MessageBox
        private void PrintMessage()
        {
            // Displays error based on returned string
            if (PrintedMessage() == "All fields are required")
            {
                ErrorPanel.Visible = true;
                ErrorLabel.Text = "All fields are required!";
            }
            // Previews Print
            else
            {
                ErrorPanel.Visible = false;
                ErrorLabel.Text = string.Empty;
                MessageBox.Show(PrintedMessage(), "Sending to Printer");
            }
            
        }

        // Creates text to be printed
        private string PrintedMessage()
        {
            string toPrint;

            // If at least one field is empty, returns a string that will trigger an error message
            if(EmployeesNameTextBox.Text == string.Empty 
                || EmployeeIDTextBox.Text == string.Empty
                || HoursWorkedTextBox.Text == string.Empty 
                || TotalSalesTextBox.Text == string.Empty
                || SalesBonusResultLabel.Text == string.Empty)
            {
                toPrint = "All fields are required";
            }
            // Creates text to be printed
            else
            {
                toPrint = "Print Preview"
                    + "\n\nEmployee Name: " + EmployeesNameTextBox.Text
                    + "\nEmployee ID: " + EmployeeIDTextBox.Text
                    + "\n\nHours Worked: " + HoursWorkedTextBox.Text
                    + "\nTotal Sales: " + TotalSalesTextBox.Text
                    + "\n\nSALES BONUS: " + SalesBonusResultLabel.Text;
            }

            return toPrint;

        }

        // Click Event Handler for "Next" Button
        private void NextEntryButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Clears form except for Total Sales textbox text.
        private void ClearForm()
        {
            EmployeesNameTextBox.Text = string.Empty;
            EmployeeIDTextBox.Text = string.Empty;
            HoursWorkedTextBox.Text = string.Empty;
            SalesBonusResultLabel.Text = string.Empty;
        }

        // TextChanged Event Handler
        // Dynamically adds currency formating while user types
        private void TotalSalesTextBox_TextChanged(object sender, EventArgs e)
        {
            // Local Variables
            TextBox tBox = (TextBox)sender;
            string siblingLabel = (string)tBox.Tag;            
            Label label = ((Label)this.Controls.Find(siblingLabel, true)[0]);

            // Deal with placeholders
            if (tBox.Text != string.Empty)
            {
                label.Visible = false;
            }
            else
            {
                label.Visible = true;
            }

            //********************* I found the code below on StackOverflow!! ************************
            // http://stackoverflow.com/questions/19215989/textbox-for-price-cash-currency-on-c-sharp
            //  Belongs to user http://stackoverflow.com/users/2998305/greatnate
            //****************************************************************************************

            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = TotalSalesTextBox.Text.Replace(",", "")
                .Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                TotalSalesTextBox.TextChanged -= TotalSalesTextBox_TextChanged;
                //Format the text as currency
                TotalSalesTextBox.Text = string.Format(CultureInfo.CreateSpecificCulture("en-CA"), "{0:C2}", ul);
                TotalSalesTextBox.TextChanged += TotalSalesTextBox_TextChanged;
                TotalSalesTextBox.Select(TotalSalesTextBox.Text.Length, 0);
            }
            bool goodToGo = TextIsValid(TotalSalesTextBox.Text);
            if (!goodToGo)
            {
                TotalSalesTextBox.Text = "$0.00";
                TotalSalesTextBox.Select(TotalSalesTextBox.Text.Length, 0);
            }
        }
        // Uses regex to validade chars entered
        private bool TextIsValid(string text)
        {
            Regex currency = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return currency.IsMatch(text);
        }
        // End of stackoverflow code.

        // KeyPress Event Handler
        // Does not allow user to enter anything but numbers 
        private void HoursWorkedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Checks for amount of hours worked
        private void CheckForHoursWorked()
        {
            try
            {
                int hours = Convert.ToInt32(HoursWorkedTextBox.Text);
                if (hours > 160)
                {
                    // Display error in case hours worked is greater than 160.
                    ErrorPanel.Visible = true;
                    ErrorLabel.Text = "Hours Worked cannot exceed 160!";
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // Leave Event Handler for Hours Worked TextBox
        private void HoursWorkedTextBox_Leave(object sender, EventArgs e)
        {
            CheckForHoursWorked();
        }
    }
}
