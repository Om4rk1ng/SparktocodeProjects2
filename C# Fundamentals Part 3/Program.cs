namespace C__Fundamentals_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////Task 1 Absolute Difference/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            int SubResult = Math.Abs(num2 - num1);

            Console.WriteLine("Absolute value of the subtraction result: " + SubResult);


        }
    }
}
