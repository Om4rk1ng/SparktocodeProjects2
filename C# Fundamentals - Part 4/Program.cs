using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace C__Fundamentals___Part_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////Task 1 Absolute Difference/////////////////////////////////////////////
            ///

            Console.WriteLine("enter your name: ");
            String name = Console.ReadLine();

            static void PrintWelcome(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            PrintWelcome(name);

            ///////Task 2 Square Number Function/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter a number to square: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The square of "+number+  " is:");
            int squaredNumber = SquareNumber(number);


            static int SquareNumber(int num)
            {
                return num * num;
            }

            Console.WriteLine(SquareNumber(number));

            ///////Task 3 - Celsius to Fahrenheit Function/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter a temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            
            double fahrenheit = CelsiusToFahrenheit(celsius);

            static double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            Console.WriteLine("fehrenheit: "+ fahrenheit);

            ///////Task 4 -  Fixed Menu Display Function/////////////////////////////////////////////
            ///

            static void DisplayMenu()
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. start");
                Console.WriteLine("2. help");
                Console.WriteLine("3. Exit");

            }

            DisplayMenu();

            ///////Task 5 -  Even or Odd Function/////////////////////////////////////////////
            ///

            /* Write a function called IsEven that takes an integer parameter and returns a bool indicating whether the number is
even.Ask the user for a number in Main, call the function, and use its returned value in an if-else statement to print
"Even" or "Odd".
Requirements:
• The function must have a bool return type and exactly one int parameter.
• The function should only return true or false - the if-else and printing happen in Main.*/

            Console.WriteLine("Enter a number to check if it is even or odd: ");
            int checkNumber = int.Parse(Console.ReadLine());

            static bool IsEven(int num)
            {
                return num % 2 == 0;
            }

            if (IsEven(checkNumber))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


        }
    }
}
