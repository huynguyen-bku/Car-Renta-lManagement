using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagement
{
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
            CarRentalManagement carRentalManagement = new CarRentalManagement();
            FormMain formMain = new FormMain(carRentalManagement);
            Application.Run(formMain);
            carRentalManagement = formMain.MySystem();
        }
    }
}
