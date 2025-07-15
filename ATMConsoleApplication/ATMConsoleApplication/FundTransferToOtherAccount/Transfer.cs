using ATMConsoleApplication.CustomersDataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATMConsoleApplication.FundTransferToOtherAccount
{
    public static class Transfer
    {
        //public static Customer Recipient { get; set; }
        public static void FundTransfer(Customer customer)
        {
            try
            {
                Console.WriteLine("Please input the recipient's account number below");
                int inputValue = Convert.ToInt32(Console.ReadLine());

                Customer? Recipient = Clients._customer.FirstOrDefault(acctNum => acctNum.AccountNumber == inputValue);

                if (Recipient == null)
                {
                    Console.WriteLine("Account not found. Please check the account number and try again.");
                    return;
                }

                Console.WriteLine($"The recipient account name is {Recipient.FirstName} {Recipient.LastName}");

                Console.WriteLine("Please input the transfer amount below");
                double transferAmount = Convert.ToDouble(Console.ReadLine());


                if (customer.AccountBalance >= transferAmount && transferAmount > 0)
                {
                    //amount to transfer has been debited from the sender's account
                    customer.AccountBalance -= transferAmount;

                    // the recipient has been credited
                    Recipient.AccountBalance += transferAmount;
                    Console.WriteLine("Transaction successful.");

                }
                else if (customer.AccountBalance < transferAmount)
                {
                    Console.WriteLine("Insufficient balance.");
                }
                else
                {
                    Console.WriteLine("Invalid amount");
                }
            }
            catch
            {
                Console.WriteLine("Invalid account number format");
            }
        }
    }
}
