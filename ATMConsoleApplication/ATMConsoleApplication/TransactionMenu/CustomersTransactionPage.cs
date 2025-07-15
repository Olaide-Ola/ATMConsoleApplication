using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMConsoleApplication.CustomersDataSet;
using ATMConsoleApplication.LoginValidation;
using ATMConsoleApplication.AccountSavings;
using ATMConsoleApplication.AccountWithdrawals;
using ATMConsoleApplication.BalanceInquiry;
using ATMConsoleApplication.FundTransferToOtherAccount;

namespace ATMConsoleApplication.TransactionMenu
{
    public class CustomersTransactionPage
    {
        int options;
        public void DisplayCustomer()
        {
            if (LoginCredentialsValidation.LoginCredentials())
            {
                Customer validCustomer = LoginCredentialsValidation.Customer;
                Console.WriteLine("\nTransaction Main Menu.");
                Console.WriteLine("=======================");
                Console.WriteLine();
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance Enquiry");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Exit");

                int promptLine = Console.CursorTop; //This the row number where the menu stops

                try
                {
                    do
                    {
                        Console.WriteLine("Please select an option (1-5)");

                        options = Convert.ToInt32(Console.ReadLine());

                        switch (options)
                        {
                            case 1:
                                DepositFund.CreditAccount(validCustomer);
                                PressEnter();
                                ClearBelowLine(promptLine);
                                break;
                            case 2:
                                Withdrawals.Withdraw(validCustomer);
                                PressEnter();
                                ClearBelowLine(promptLine);
                                break;
                            case 3:
                                AccountBalance.ShowBalance(validCustomer);
                                PressEnter();
                                ClearBelowLine(promptLine);
                                break;
                            case 4:
                                Transfer.FundTransfer(validCustomer);
                                PressEnter();
                                ClearBelowLine(promptLine);
                                break;
                            case 5:
                                Console.WriteLine("Existing the application...");
                                return;
                            default:
                                Console.WriteLine("Invalid input. Please enter the correct item.");
                                break;
                        }
                    } while (true);
                }
                catch
                {

                    Console.WriteLine("Invalid option selected, please try again.");
                }
                
            }
        }
        private static void PressEnter()
        {
            Console.WriteLine("Press Enter key to return to the menu");
            Console.ReadKey();
            
        }
       public static void ClearBelowLine(int startLine)
        {
            int currentLine = Console.CursorTop; //this is the currennt line after PressEnter Method
            Console.SetCursorPosition(0, startLine); // set the cursor position at column o and row after the menu

            //assum startLine/ promptLine is 4
            //assume cuurentLine is 10

            for (int i = startLine; i < currentLine; i++)
            {
                Console.WriteLine(new string(' ', Console.WindowWidth)); //this print blank space accross the console line by line starting from the startline to the currentline which the ClearbelowLine method is called.
            }
            Console.SetCursorPosition(0, startLine); // it reset the cursor back to its original posistio column o row 4
        }

    }
}
