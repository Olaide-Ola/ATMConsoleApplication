using ATMConsoleApplication.CustomersDataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApplication.AccountSavings
{
    public static class DepositFund
    {
        public static void CreditAccount(CustomersInformation accountBalance)
        {
            Console.WriteLine("Please input the amount to deposit below");
            try
            {
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                if (depositAmount > 0)
                {
                    accountBalance.AccountBalance += depositAmount;
                    Console.WriteLine($"You have sucessfully credited your account with {depositAmount} Thank you.");
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
