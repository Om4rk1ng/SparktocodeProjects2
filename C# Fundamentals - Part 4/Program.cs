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

            ///////Task 6 -   Rectangle Area & Perimeter Functions/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            static double CalculateArea(double length, double width)
            {
                return length * width;
            }

            static double CalculatePerimeter(double length, double width)
            {
                return 2 * (length + width);
            }

            Console.WriteLine("Area: " + CalculateArea(length, width));
            Console.WriteLine("Perimeter: " + CalculatePerimeter(length, width));


        }
    }
}
