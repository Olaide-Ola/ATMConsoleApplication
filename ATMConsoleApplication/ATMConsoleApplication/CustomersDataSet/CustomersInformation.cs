using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApplication.CustomersDataSet
{
    public class CustomersInformation
    {
        private string _firstName = "";
        private string _lastName = "";
        private int _accountNumber;
        private int _accountPin;
        private double _accountBalance;

        public string FirstName { get { return _firstName; } set{ _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public int AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
        public int AccountPin { get { return _accountPin; } set { _accountPin = value; } }
        public double AccountBalance { get { return _accountBalance; } set { _accountBalance = value; } } 
        
    }
    public class CustomersInformationList
    {
        private static CustomersInformationList? _newCustomer = null;
        public List<CustomersInformation> _customer = new List<CustomersInformation>();
        public static CustomersInformationList NewCustomer
        {
            get
            {
                if (_newCustomer == null)
                {
                    _newCustomer = new CustomersInformationList();
                }
                return _newCustomer;
            }
        }
        private CustomersInformationList()
        {
            _customer.Add(new CustomersInformation { FirstName = "Ogunbunmi", LastName = "Olaide", AccountNumber = 310189, AccountPin = 1996, AccountBalance = 25000 });
            _customer.Add(new CustomersInformation { FirstName = "Olawale", LastName = "Moshood", AccountNumber = 310310, AccountPin = 1998, AccountBalance = 1000 });
        }
        

    }
}
