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
        public static void ShowBalance(Customer customer)
        {
            Console.WriteLine("Your account balance is {0}", customer.AccountBalance);
            Console.WriteLine("Thank you for banking with us.");
        }
    }
}
