using ATMConsoleApplication.CustomersDataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApplication.BalanceInquiry
{
    public static class AccountBalance
    {
        public static void ShowBalance(CustomersInformation accountbalance)
        {
            Console.WriteLine("Your account balance is {0}", accountbalance.AccountBalance);
            Console.WriteLine("Thank you for banking with us.");
        }
    }
}
