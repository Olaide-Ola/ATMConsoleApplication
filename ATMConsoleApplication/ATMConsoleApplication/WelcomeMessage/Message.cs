using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATMConsoleApplication.WelcomeMessage
{
    internal static class Message
    {
        public static void UserWelcomeMessage()
        {

            Console.WriteLine("\n\n========== Welcome To Console Bank ATM =========\n\n");
            Console.WriteLine("Please enter your account details below to begin. ");
            Console.WriteLine("\nPress [Enter] key to continue....\n");
            Console.ReadKey();
            
        }
        public static void AccountPinMessage()
        {
            Console.WriteLine("Enter your account pin: ");
        }
    }
}
