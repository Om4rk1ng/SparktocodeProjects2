using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace C__Fundamentals___Part_4
{
    internal class Program
    {
        //task 1 - Welcome Message Function
        public static void PrintWelcome(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        //task 2 - Square Number Function

        public static int SquareNumber(int num)
        {
            return num * num;
        }

        //task 3 - Celsius to Fahrenheit Function

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        //task 4 - Fixed Menu Display Function

        static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. start");
            Console.WriteLine("2. help");
            Console.WriteLine("3. Exit");

        }

        //task 5 - Even or Odd Function
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        //task 6 - Rectangle Area & Perimeter Functions
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        //task 7 - Grade Letter Function
        public static string GetGradeLetter(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        //task 8 - Countdown Function

        public static void Countdown(int number)
        {
            for (int i = number; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            ///////Task 1 Absolute Difference/////////////////////////////////////////////
            ///

            Console.WriteLine("enter your name: ");
            String name = Console.ReadLine();

            

            PrintWelcome(name);

            ///////Task 2 Square Number Function/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter a number to square: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The square of "+number+  " is:");
            int squaredNumber = SquareNumber(number);


           

            Console.WriteLine(SquareNumber(number));

            ///////Task 3 - Celsius to Fahrenheit Function/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter a temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            
            double fahrenheit = CelsiusToFahrenheit(celsius);

            

            Console.WriteLine("fehrenheit: "+ fahrenheit);

            ///////Task 4 -  Fixed Menu Display Function/////////////////////////////////////////////
            ///

            

            DisplayMenu();

            ///////Task 5 -  Even or Odd Function/////////////////////////////////////////////
            ///

            

            Console.WriteLine("Enter a number to check if it is even or odd: ");
            int checkNumber = int.Parse(Console.ReadLine());

           

            if (IsEven(checkNumber))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            ///////Task 6 -   Rectangle Area & Perimeter Functions/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

           

            Console.WriteLine("Area: " + CalculateArea(length, width));
            Console.WriteLine("Perimeter: " + CalculatePerimeter(length, width));

            ///////Task 7 -   Grade Letter Function/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter your grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            Console.WriteLine("Your grade letter is: " + GetGradeLetter(grade));

            //////Task 8 - Countdown Function/////////////////////////////////////////////
            /// 

            Console.WriteLine("Enter a number to start countdown: ");
            int countdownNumber = int.Parse(Console.ReadLine());

            Countdown(countdownNumber);


        }
    }
}
