using ExpeditApplikation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentatationLayerExpApp
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            new Program().MainMenu();
        }

        private Program()
        {
            bookingSystem = new BookingSystem();
        }

        private void MainMenu()
        {
            Console.WriteLine("Booking System!" + "\n" + "Welcome!");
        }

        private BookingSystem bookingSystem;
    }
}

