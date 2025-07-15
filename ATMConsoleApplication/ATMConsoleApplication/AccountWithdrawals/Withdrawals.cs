using ATMConsoleApplication.CustomersDataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApplication.AccountWithdrawals
{
    public static class Withdrawals
    {
        public static void Withdraw(Customer customer)
        {
            try
            {
                Console.WriteLine("Please input the amount to withdraw below");
                double withdrawalAmount = Convert.ToDouble(Console.ReadLine());

                if (customer.AccountBalance >= withdrawalAmount && withdrawalAmount > 0)
                {
                    customer.AccountBalance -= withdrawalAmount;
                    Console.WriteLine("Transaction suceesful. You have successfully debit your account with {0}", withdrawalAmount);
                }
                else if(customer.AccountBalance < withdrawalAmount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    Console.WriteLine("Invalid amount");
                }
            }
            catch
            {
                Console.WriteLine("Invalid amount. Please input the correct amount");
            }
        }

    }
}
