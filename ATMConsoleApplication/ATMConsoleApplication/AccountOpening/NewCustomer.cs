using ATMConsoleApplication.CustomersDataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMConsoleApplication.TransactionMenu;

namespace ATMConsoleApplication.AccountOpening
{
    public class NewCustomer
    {
        public static void OnboardNewCustomer()
        {
               CustomersInformation newCustomersInformation = new CustomersInformation();
            Console.WriteLine("To create your account, please provide the following details");

                Console.WriteLine("Enter your first name: ");
                string firstName = Console.ReadLine();
                newCustomersInformation.FirstName = firstName;

                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine();
                newCustomersInformation.LastName = lastName;

                bool isValid = false;
                while (!isValid)
                {
                    try
                    {
                        Console.WriteLine("Create a 4-digit PIN");
                        Console.WriteLine("This will be used to access your account securely.");
                        int pin = Convert.ToInt32(Console.ReadLine());

                        if (pin > 999 && pin <= 9999)
                        {
                            newCustomersInformation.AccountPin = pin;
                            isValid = true;
                        }
                        else if (pin <= 999 || pin > 9999)
                        {
                            Console.WriteLine("Invalid Pin, it must be exactly 4 digits");
                        }
                    }
                    catch
                    {
                           Console.WriteLine("Invalid pin format");
                    }
                    
                }

              Console.WriteLine($"Your initial account balance is {newCustomersInformation.AccountBalance = default}");

            //An auto 6 digits account number will be generated here
            Random random = new Random();
            int generateAccountNumber = random.Next(100000, 1000000);

            Console.WriteLine($"Accout Created Successfully! \nThank you for registering with Console Bank. \nYour new account number is: {newCustomersInformation.AccountNumber = generateAccountNumber}");

            Console.WriteLine("You can now login to your account using your PIN and account number.");

            Console.WriteLine("Press Enter Key to continue");
            Console.ReadKey();
            Console.Clear();

            CustomersInformationList.NewCustomer._customer.Add(newCustomersInformation);
                CustomersTransactionPage customersTransactionPage = new CustomersTransactionPage();
                customersTransactionPage.DisplayCustomer();
        }
        
    }
}
