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

            ///////Task 2  Power & Root Explorer/////////////////////////////////////////////
            ///
            Console.WriteLine("Enter a number:");
            double number = double.Parse(Console.ReadLine());
            double powerresult = Math.Pow(number, number);
            double squarreootresult = Math.Sqrt(number);

            Console.WriteLine("Power result: " + powerresult);
            Console.WriteLine("Squareroot result: " + squarreootresult);

        }
    }
}
