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
            Application.Run(new Form1());

            new Program().MainMenu();
        }

        private Program()
        {
            bookingSystem = new BookingSystem();
        }

        private void MainMenu()
        {
            Console.WriteLine("Welcome to the Booking System!");

            while (true)
            {
                if (LogIn())
                {
                    Console.WriteLine("You are now logged in {0}.", bookingSystem.LoggedIn.Name);
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Failed to log in.");
                }
            }
        }

        private bool LogIn()
        {
            string idToParse = "";
            int id;
            while (!int.TryParse(idToParse, out id))
            {
                Console.WriteLine("Write your User ID: ");
                idToParse = Console.ReadLine();
            }
            Console.WriteLine("Write your password: ");
            string password = Console.ReadLine();

            return bookingSystem.LogIn(id, password);
        }

        private BookingSystem bookingSystem;
    }
}

