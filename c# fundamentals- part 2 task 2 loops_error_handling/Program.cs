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




        }
    }
}