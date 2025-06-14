using ATMConsoleApplication.TransactionMenu;
using ATMConsoleApplication.AccountOpening;

namespace ATMConsoleApplication
{
    internal class AccountLogin
    {
        static void Main(string[] args)
        {        
            Console.Title = "Console Bank ATM";
            Console.WriteLine("\nWelcome to Console Bank ATM");
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. New Customer");
            Console.WriteLine("2. Existing Customer");
            Console.WriteLine("Enter your choice (1 or 2): ");

            do
            {
                //prompt user to enter option 1 or 2
                string userOption = Console.ReadLine();

                if (userOption == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Sign-Up - New Customer");
                    NewCustomer.OnboardNewCustomer();
                    break;
                }
                else if (userOption == "2")
                {
                    Console.Clear();
                    CustomersTransactionPage name = new CustomersTransactionPage();
                    name.DisplayCustomer();
                    break;
                }
                else
                {
                    Console.WriteLine("You have not entered any option, please try again");
                }
            } while (true);
        }  
    }
}


