# ATM Console Application
## Description
A C# console-based ATM(Auto Teller Machine) simulation that allows users to perform basic banking operations such as withdrawal, transfer, deposit, and balance enquiry through a console interface and exiting the system.
## Features
- Account authentication: Secure login with account number and pin
- Balance inquiry
- Withdrawal: Withdraw fund with balance validation
- Deposit
- Open a new account
## Prerequisites
- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (version 8.0 or higher)
- Visual Studio or VS Code
- Windows, macOS or linux
## Installation
1. Clone the repository
``` bash
git clone https://github.com/Olaide-Ola/ATMConsoleApplication.git
```
2. Navigate to the project directory
``` bash
cd ATMConsoleApplication
```
3. Restore dependencies:
```bash
dotnet restore
```
4. Build the project
```bash
dotnet build
```

## Usage Instructions
1. Run the application

```bash
dotnet run
```
2. Follow the on-screen menu
- New user
- Existing user
#### Sample Account
|Account Number |PIN |Initial Balance |
|---------------|----|----------------|
|310189			|1996 |25,000		  |
|310310			|1998 |1,000	      |

## Project Structure
``` plaintext
ATMConsoleApplication/
|___    AccountLogin.cs		- Main entry point of the application, handles new user and existing user login
|___	AccountWithdrawals/
	|___	Withdrawals.cs		- Contains class for fund withdrawal
|___	AccountOpening/
	|___	NewCustomer.cs		- Handles new customer account creation
|___	WelcomeMessage/
	|___	Message.cs		- Display welcome message to user
|___	BalanceInquiry/
	|___	Balance.cs		- Manage user account balance
|___	CustomerDataSet/
	|___	CustomersInformation.cs		- Account data model
|___	FundTransferToOtherAccount/
	|___	Transfer.cs		- Fund transfer from one to account to another
|___	LoginValidation/
	|___	LoginCredentialsValidation.cs		- Input validation
|___	TransactionMenu/
	|___	CustomersTransactionPage.cs		- Customer transaction menu
```

## Error Handling
The application includes error handling for :
- Invalid account number or PIN
- Insufficient funds for withdrawal
- Invalid input for menu options
- Invalid input format
- Negative transaction amount
- Maximum withdrawal limit

## Future Enhancements
- Database integration for persistent data storage
- Web API interface
- Receipt generation for transactions
- Save transaction history to a file

## Contact
Email: ogunbunmi.ridwan@yahoo.com

