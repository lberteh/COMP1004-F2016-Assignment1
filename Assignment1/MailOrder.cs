﻿using System;
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

        private void SetLanguageToFrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HoursWorkedTextBox.Text = "Test";
        }
    }
}
