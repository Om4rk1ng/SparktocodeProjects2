using System.Linq.Expressions;

namespace c__fundamentals__part_2_task_2_loops_error_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////Task 1 Countdown Timer/////////////////////////////////////////////
            ///

            Console.WriteLine("enter a countdown starting number: ");

            for (int countdown = Convert.ToInt32(Console.ReadLine()); countdown > 0; countdown--)
            {
                Console.WriteLine(countdown);
            }

            ///////Task 2 Sum of Numbers 1 to N/////////////////////////////////////////////
            ///

            Console.WriteLine("enter a positive whole number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;

            }
            Console.WriteLine("The sum of numbers from 1 to " + n + " is " + sum);

            ///////Task 3 Multiplication Table/////////////////////////////////////////////
            ///

            Console.WriteLine("enter a number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(m + " x " + i + " = " + (m * i));
            }

            ///////Task 4 Password Retry/////////////////////////////////////////////
            ///

            string correctPassword = "Spark2026";
            string userInput = " ";

            while (userInput != correctPassword)
            {
                Console.WriteLine("Please enter the password: ");
                userInput = Console.ReadLine();
                if (userInput == correctPassword)
                {
                    Console.WriteLine("Access granted.");
                }
                else
                {
                    Console.WriteLine("Incorrect password, try again.");
                }
            }

            ///////Task 5  Number Guessing Game/////////////////////////////////////////////
            ///

            int secretNumber = 42;
            int guess = 0;
            int counter = 0;

            do
            {
                Console.WriteLine("Guess the secret number between 1 and 100: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > 42 && guess == 100)
                {
                    Console.WriteLine("Too high");
                }
                else if (guess < 42 && guess == 0)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("you guessed correctly");
                }
                counter++;
            }
            while (guess != secretNumber);

            Console.WriteLine("number of attempts: " + counter);

            ///////Task 6  Safe Division Calculator/////////////////////////////////////////////
            ///

            try
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("The result of " + num1 + " divided by " + num2 + " is: " + result);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Division by zero is not allowed.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");

            }

            ///////Task 7  Repeating Menu with Exit Option/////////////////////////////////////////////
            ///
            try
            {
                int option = 0;
                while (option != 3)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Say Hello");
                    Console.WriteLine("2. Show Current time-of-day greeting");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Enter your choice (1-3): ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Hello");
                            break;
                        case 2:
                            Console.WriteLine("Current time of day greeting is good morning");
                            break;
                        case 3:
                            Console.WriteLine("Exiting the program.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");

            }

            ///////Task 8  Sum of Even Numbers Only/////////////////////////////////////////////
            ///

            Console.WriteLine("enter a positive whole number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int evenSum = 0;

            for (int i = 0; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;

                }
            }
            Console.WriteLine("The sum of even numbers from 0 to " + N + " is " + evenSum);

            ///////Task 9  Validated Positive Number Input/////////////////////////////////////////////
            ///
            bool isValidInput = false;
            sum = 0;
            do
            {
                try
                {
                    Console.WriteLine("Please enter a positive whole number: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n <= 0)
                    {

                        Console.WriteLine("Invalid input. Please enter a positive whole number.");

                    }
                    else
                    {
                        isValidInput = true;

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }



            }
            while (!isValidInput);

            for (int i = 0; i <= n; ++i)
            {

                sum += i;
            }

            Console.WriteLine("The sum of numbers from 0 to " + n + " is " + sum);






            ///////Task 10   Simple ATM Simulation/////////////////////////////////////////////
            ///


            int correctPin = 1234;
            double balance = 100.000;
            int maxAttempts = 3;
            bool isAuthenticated = false;


            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write("Enter your 4-digit PIN (Attempt " + attempt + "/" + maxAttempts + "): ");
                try
                {
                    int enteredPin = Convert.ToInt32(Console.ReadLine());

                    if (enteredPin == correctPin)
                    {
                        isAuthenticated = true;
                        Console.WriteLine();
                        Console.WriteLine("Access Granted. Welcome to your account!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN.");
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Invalid entry. Non-numeric input registered as a wrong attempt.");
                }
            }


            if (!isAuthenticated)
            {
                Console.WriteLine();
                Console.WriteLine("Card Blocked. Please contact your bank branch.");
            }
            else
            {

                bool sessionActive = true;

                while (sessionActive)
                {
                    Console.WriteLine();
                    Console.WriteLine("=== ATM MAIN MENU ===");
                    Console.WriteLine("1) Deposit");
                    Console.WriteLine("2) Withdraw");
                    Console.WriteLine("3) Check Balance");
                    Console.WriteLine("4) Exit");
                    Console.Write("Please select an option (1-4): ");

                    int choice = 0;
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                try
                                {
                                    Console.Write("Enter the deposit amount (OMR): ");
                                    double depositAmount = Convert.ToDouble(Console.ReadLine());

                                    if (depositAmount <= 0)
                                    {
                                        Console.WriteLine("Error: Deposit amount must be positive.");
                                    }
                                    else
                                    {
                                        balance = balance + depositAmount;
                                        Console.WriteLine("Successfully deposited " + depositAmount + " OMR.");
                                        Console.WriteLine("Current Balance: " + balance + " OMR");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error: Invalid numeric amount entered.");
                                }
                                break;

                            case 2:
                                try
                                {
                                    Console.Write("Enter the withdrawal amount (OMR): ");
                                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                                    if (withdrawAmount <= 0)
                                    {
                                        Console.WriteLine("Error: Withdrawal amount must be positive.");
                                    }
                                    else if (withdrawAmount > balance)
                                    {
                                        Console.WriteLine("Error: Insufficient funds. Your balance is lower than this amount.");
                                    }
                                    else
                                    {
                                        balance = balance - withdrawAmount;
                                        Console.WriteLine("Successfully withdrew " + withdrawAmount + " OMR.");
                                        Console.WriteLine("Current Balance: " + balance + " OMR");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error: Invalid numeric amount entered.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("Your current balance is: " + balance + " OMR");
                                break;

                            case 4:
                                Console.WriteLine();
                                Console.WriteLine("Thank you for using our ATM services. Have a great day!");
                                sessionActive = false;
                                break;

                            default:
                                Console.WriteLine("Invalid selection. Please choose a number from 1 to 4.");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please choose a valid option number.");
                    }
                }
            }
        }
    }
}