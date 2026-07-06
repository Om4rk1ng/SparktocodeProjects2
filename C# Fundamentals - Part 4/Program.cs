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
            Console.WriteLine($"The square of  is:");
            int squaredNumber = SquareNumber(number);


            static int SquareNumber(int num)
            {
                return num * num;
            }

            SquareNumber(number);

        }
    }
}
