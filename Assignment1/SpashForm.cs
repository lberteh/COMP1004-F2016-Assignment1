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
    public partial class SpashForm : Form
    {
        public SpashForm()
        {
            InitializeComponent();
        }

        // Transition from splash form to main form
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;

            // Instantiate the Mail Order form
            MailOrder mailOrder = new MailOrder();

            mailOrder.Show();
            // Hide this form
            this.Hide();
        }
    }
}
