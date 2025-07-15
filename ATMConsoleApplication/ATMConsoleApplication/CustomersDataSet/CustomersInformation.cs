using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApplication.CustomersDataSet
{
    public class Customer
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private int _accountNumber;
        private int _accountPin;
        private double _accountBalance;
        public string FirstName { get { return _firstName; } set{ _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public int AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
        public int AccountPin { get { return _accountPin; } set { _accountPin = value; } }
        public double AccountBalance { get { return _accountBalance; } set { _accountBalance = value; } } 
        
    }
    public static class Clients
    {
        public static List<Customer> _customer = new List<Customer>()
        {
            new Customer(){FirstName = "Ogunbunmi", LastName = "Olaide", AccountNumber = 310189, AccountPin = 1996, AccountBalance = 25000},
            new Customer(){ FirstName = "Olawale", LastName = "Moshood", AccountNumber = 310310, AccountPin = 1998, AccountBalance = 1000 }
        };
    }
}
