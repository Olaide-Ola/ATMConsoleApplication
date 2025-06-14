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
        static CustomersInformation recipient = new CustomersInformation();
        public static void FundTransfer(CustomersInformation sender)
        {
            try
            {
                Console.WriteLine("Please input the recipient's account number below");
                int inputValue = Convert.ToInt32(Console.ReadLine());

                recipient = CustomersInformationList.NewCustomer._customer.FirstOrDefault(acctNum => acctNum.AccountNumber == inputValue);

                if (recipient == null)
                {
                    Console.WriteLine("Account not found. Please check the account number and try again.");
                    return;
                }

                Console.WriteLine($"The recipient account name is {recipient.FirstName} {recipient.LastName}");

                Console.WriteLine("Please input the transfer amount below");
                double transferAmount = Convert.ToDouble(Console.ReadLine());


                if (sender.AccountBalance >= transferAmount && transferAmount > 0)
                {
                    //amount to transfer has been debited from the sender's account
                    sender.AccountBalance -= transferAmount;

                    // the recipient has been credited
                    recipient.AccountBalance += transferAmount;
                    Console.WriteLine("Transaction successful.");

                }
                else if (sender.AccountBalance < transferAmount)
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
