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
            DateTime enddate = todayDate.AddDays(freeTrialDays);

            Console.WriteLine("Your subscription will end on: " + enddate.ToString("yyyy-MM-dd"));

            ///////Task 5 - Grade Rounding System/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter your raw grade:");
            double grade = double.Parse(Console.ReadLine());

            double roundedGrade = Math.Round(grade);
            string passfailresult = "";
            if (roundedGrade >= 60)
            {
                passfailresult = "Pass";

            }
            else
            {
                passfailresult = "Fail";
            }

            Console.WriteLine("Rounded Grade: " + roundedGrade + ", Result: " + passfailresult);

            ///////Task 6 - Password Strength Checker/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            bool isweak = password.Length < 8 || password.ToLower().Contains("password");

            if (isweak)
            {
                Console.WriteLine("Your password is weak, must be atleast 8 characters and is not password.");

            }
            else
            {
                Console.WriteLine("Your password is strong because it is atleast 8 characters and does not contain password.");
            }

            ///////Task 7 - Clean Name Comparator/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter the first name with spaces and different cases:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter the second name with spaces and different cases:");
            string name2 = Console.ReadLine();

            string cleanedFirst = name1.Trim().ToUpper();
            string cleanedSecond = name2.Trim().ToUpper();

            if (cleanedFirst != cleanedSecond)
            {
                Console.WriteLine("No Match");
            }
            else
            {
                Console.WriteLine("Match");
            }

            ///////Task 8 - Membership Expiry Checker/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter your membership start date (yyyy-MM-dd): ");
            string startDateInput = Console.ReadLine();
            Console.WriteLine("Enter your number of membership valid days: ");
            int durationIndays = int.Parse(Console.ReadLine());

            try
            {
                DateTime startDate = DateTime.Parse(startDateInput);

                DateTime expiryDate = startDate.AddDays(durationIndays);

                if (expiryDate < DateTime.Today)
                {
                    Console.WriteLine("Active and expiry date is " + expiryDate);
                }
                else
                {
                    Console.WriteLine("Expired on " + expiryDate);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please ensure the date is in YYYY-MM-DD format and days are a whole number.");

            }

            

        }
    }
}