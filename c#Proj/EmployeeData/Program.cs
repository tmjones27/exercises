/*Tiani Jones BIS 345
 * Write a graphical user application that accepts employee data to include employee name, number, pay rate and number of hours worked.
 * The total amount of pay should be calculated and your application should allow the user to browse to save and load the file.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeData
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
