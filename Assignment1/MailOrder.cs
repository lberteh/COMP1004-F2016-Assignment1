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
    public partial class MailOrder : Form
    {
        // class scope private variables
        private Font placeholderFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public MailOrder()
        {
            InitializeComponent();
        }

        public void FocusChildTextBox(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            
        }

        private void MailOrder_Load(object sender, EventArgs e) 
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox) && ctrl.Name != "SalesBonusTextBox")
                {
                    // Do whatever to the TextBox 
                    // ctrl.Font = placeholderFont;
                    ctrl.Text = (string)ctrl.Tag;
                    // ctrl.ForeColor = System.Drawing.SystemColors.WindowFrame;
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
            string TotalSales;

            try
            {
                // read values from the text boxes
                TotalHoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);
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
           
                SalesBonusTextBox.Text = SalesBonus.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
            }

        }
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
          //  LanguagesGroupBox.Text = "Idioma";
            EmployeesNameLabel.Text = "Nome do Funcionário";
            EmployeeIDLabel.Text = "ID do Funcionário";
            HoursWorkedLabel.Text = "Horas Trabalhadas";
            TotalSalesLabel.Text = "Total de Vendas";
            Sal.Text = "Bônus de Vendas:";
            CalculateBonusButton.Text = "Calcular";
            PrintButton.Text = "Imprimir";
            NextEntryButton.Text = "Próximo";
        }

        private void SetLanguageToFrench()
        {
            MailOrder.ActiveForm.Text = "Bonus de vente";
            //   LanguagesGroupBox.Text = "La Langue";
            EmployeesNameLabel.Text = "Nom de l'Employé";
            EmployeeIDLabel.Text = "ID d'Employé";
            HoursWorkedLabel.Text = "Heures Travaillées";
            TotalSalesLabel.Text = "Total des ventes";
            Sal.Text = "Bonus de vente";
            CalculateBonusButton.Text = "Calculer";
            PrintButton.Text = "Imprimer";
            NextEntryButton.Text = "Suivant";
        }

        private void SetLanguageToEnglish()
        {
            MailOrder.ActiveForm.Text = "Sales Bonus";
            //   LanguagesGroupBox.Text = "Language";
            EmployeesNameLabel.Text = "Employee's Name";
            EmployeeIDLabel.Text = "Employee ID";
            HoursWorkedLabel.Text = "Hours Worked";
            TotalSalesLabel.Text = "Total Sales";
            Sal.Text = "Sales Bonus";
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

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintMessage();
        }

        private void PrintMessage()
        {
            string caption;
            if (PrintedMessage() == "All fields are required")
            {
                caption = "Print Error";
            }
            else
            {
                caption = "Sending to Printer";
            }
            MessageBox.Show(PrintedMessage(), caption);
        }

        private string PrintedMessage()
        {
            string toPrint;
            try
            {
                toPrint = "hsbdhj";
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox) && ctrl.Name != "SalesBonusTextBox")
                    {
                       if (ctrl.Text == (string)ctrl.Tag || SalesBonusTextBox.Text == string.Empty)
                       {                         
                           
                           throw new Exception("test");
                       }
                       else
                        {
                            toPrint = "Print Preview" 
                                + "\n\nEmployee Name: " + EmployeesNameTextBox.Text
                                + "\nEmployee ID: "     + EmployeeIDTextBox.Text
                                + "\n\nHours Worked: "  + HoursWorkedTextBox.Text
                                + "\nTotal Sales: "     + TotalSalesTextBox.Text
                                + "\n\nSALES BONUS: "   + SalesBonusTextBox.Text;
                        }
                    }
                }
                
            }
            catch (Exception exception)
            {
                toPrint = "All fields are required";                
                Debug.WriteLine(exception.Message);
            }
            return toPrint;
        }

        private void NextEntryButton_Click(object sender, EventArgs e)
        {

        }

        private void TotalSalesTextBox_TextChanged(object sender, EventArgs e)
        {
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
           // enterButton.Enabled = goodToGo;
            if (!goodToGo)
            {
                TotalSalesTextBox.Text = "$0.00";
                TotalSalesTextBox.Select(TotalSalesTextBox.Text.Length, 0);
            }
        }

        private bool TextIsValid(string text)
        {
            Regex currency = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return currency.IsMatch(text);
        }

        private void EmployeesNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetLanguageToEnglishButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFCC66");
        }
    }
}
