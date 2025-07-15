using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMConsoleApplication.WelcomeMessage;
using ATMConsoleApplication.CustomersDataSet;


namespace ATMConsoleApplication.LoginValidation
{
    public class LoginCredentialsValidation
    {
        public static Customer Customer { get; set; }
        public static bool LoginCredentials()
        {          
            Message.UserWelcomeMessage();
            bool loginCheck = false;
            while (!loginCheck)
            {
                Console.WriteLine("Enter your account number below: ");
                try
                {
                    //promt user to enter their registered account number
                    int userAccountNumber = Convert.ToInt32(Console.ReadLine());        
                   var customer = Clients._customer.FirstOrDefault(acctNum => acctNum.AccountNumber == userAccountNumber);
                    if (customer != null)
                    {
                        do
                        {
                            try
                            {
                                Message.AccountPinMessage();
                                //promt user to enter thier registerd account pin if account number entered is valid
                                int userAccountPin = Convert.ToInt32(Console.ReadLine());
                                if (customer.AccountPin == userAccountPin)
                                {
                                    Customer = customer;
                                    Console.WriteLine("\nLogin suceesfully! Press Enter Key to proceed into your account...\n");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Welcome, " + Customer.FirstName.ToUpper() + " " + Customer.LastName.ToUpper());
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid account pin. Please try again.");

                                }
                            }
                            catch
                            {
                                Console.WriteLine("The account pin you inputted is not in the correct format.");
                            }
                        } while (true);

                        loginCheck = true;
                    }

                    else
                    {
                        Console.WriteLine("Invalid account number. Please try again");

                    }
                }
                catch
                {
                    Console.WriteLine("The account number you inputted is not in the correct format.");

                }
            }

            return true;
        }

    }
}
