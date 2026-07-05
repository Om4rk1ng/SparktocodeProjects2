namespace C__Fundamentals_Part_3_Task3
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

            int SubResult= Math.Abs(num2 - num1);

            Console.WriteLine("Absolute value of the subtraction result: " +SubResult);


            ///////Task 2  Power & Root Explorer/////////////////////////////////////////////
            ///
            Console.WriteLine("Enter a number:");
            double number = double.Parse(Console.ReadLine());
            double powerresult = Math.Pow(number, number);
            double squarreootresult = Math.Sqrt(number);

            Console.WriteLine("Power result: " + powerresult);
            Console.WriteLine("Squareroot result: " + squarreootresult);

            ///////Task 3 - Name Formatter/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter your full name:");
            string fullName = Console.ReadLine();

            string upperCaseName = fullName.ToUpper();
            string lowerCaseName = fullName.ToLower();
            string lengthOfName = fullName.Length.ToString();

            Console.WriteLine("Uppercase: " + upperCaseName);
            Console.WriteLine("Lowercase: " + lowerCaseName);
            Console.WriteLine("Length of name: " + lengthOfName);

            ///////Task 4 - Subscription End Date/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter the number of days of free trial:");
            int freeTrialDays = int.Parse(Console.ReadLine());

            DateTime todayDate = DateTime.Today;
            DateTime enddate= todayDate.AddDays(freeTrialDays);

            Console.WriteLine("Your subscription will end on: " + enddate.ToString("yyyy-MM-dd"));

           
        }
    }
}
