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
        private static CustomersInformation _accountNumberValidation = new CustomersInformation();
        private static CustomersInformation _accountPinValidation = new CustomersInformation();


        public static CustomersInformation AccountNumberValidation { get { return _accountNumberValidation; } }
        public static CustomersInformation AccountPinValidation { get { return _accountPinValidation; } }
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

                    var customer = CustomersInformationList.NewCustomer._customer.FirstOrDefault(acctNum => acctNum.AccountNumber == userAccountNumber);

                    if (customer != null)
                    {

                        do
                        {
                            try
                            {
                                Message.AccountPinMessage();
                                //promt user to enter thier registerd account pin if account number entered is valid
                                int userAccountPin = Convert.ToInt32(Console.ReadLine());

                                //_accountPinValidation = CustomersInformationList.NewCustomer._customer.FirstOrDefault(acctPin => acctPin.AccountPin == userAccountPin);

                                if (customer.AccountPin == userAccountPin)
                                {
                                    _accountNumberValidation = customer;
                                    _accountPinValidation = customer;

                                    Console.WriteLine("\nLogin suceesfully! Press Enter Key to proceed into your account...\n");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Welcome, " + customer.FirstName.ToUpper() + " " + customer.LastName.ToUpper());
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
