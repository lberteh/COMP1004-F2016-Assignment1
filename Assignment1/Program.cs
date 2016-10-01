/*
 * App: Sales Bonus
 * Author: Lucas Schoenardie
 * Create on: 30/09/2016
 * Description: Calculates the Sales Bonus paid to each employee based on amount of worked hours
 *              and total monthly sales 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    // Class declaration
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SpashForm());
        }
    }
}
