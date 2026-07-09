using System;
using System.Collections.Generic;

namespace Mini_Compound_Project_Banking_Management_App
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        public static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Find Richest Customer");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        FindRichestCustomer();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }


        ///////Service 1 - Add New Account/////////////////////////////////////////////
        ///
        public static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new account number: ");
            string accNum = Console.ReadLine();

            if (accountNumbers.Contains(accNum))
            {
                Console.WriteLine("This account number is already used");
                return;
            }

            Console.Write("Enter initial deposit amount: ");
            double initialDeposit = double.Parse(Console.ReadLine());

            if (initialDeposit < 0)
            {
                Console.WriteLine("Initial deposit cannot be negative");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(accNum);
            balances.Add(initialDeposit);

            Console.WriteLine("Account successfully created");
            Console.WriteLine("Name: " + name + " | Acc No: " + accNum + " | Balance: " + initialDeposit);
        }

        ///////Service 2 - Deposit Money/////////////////////////////////////////////
        ///
        public static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string accNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accNum);

            if (index == -1)
            {
                Console.WriteLine("Account number not found");
                return;
            }

            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive");
                return;
            }

            balances[index] += amount;
            Console.WriteLine("Deposit successful, Updated Balance: " + balances[index]);
        }

        ///////Service 3 - Withdraw Money/////////////////////////////////////////////
        ///
        public static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            string accNum = Console.ReadLine();

            int index = accountNumbers.IndexOf(accNum);

            if (index == -1)
            {
                Console.WriteLine("Account number not found");
                return;
            }

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive");
                return;
            }

            if (amount > balances[index])
            {
                Console.WriteLine("Insufficient balance, Your current balance is: " + balances[index]);
                return;
            }

            balances[index] -= amount;
            Console.WriteLine("Withdrawal successful, Updated Balance: " + balances[index]);
        }

    }
}