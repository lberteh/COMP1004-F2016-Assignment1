using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        private void CalculateBonusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CalculateSalesBonus()
        {
            // private variables 

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
    }
}
