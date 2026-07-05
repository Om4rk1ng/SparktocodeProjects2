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

            ///////Task 9 - Round Up / Round Down Explorer/////////////////////////////////////////////
            ///
            try
            {
                Console.WriteLine("enter a decimal number");

                double decimalnumber = double.Parse(Console.ReadLine());

                double roundednumber = Math.Round(decimalnumber);
                double roundUp = Math.Ceiling(decimalnumber);
                double roundDown = Math.Floor(decimalnumber);

                Console.WriteLine("Rounded number: " + roundednumber);
                Console.WriteLine("Rounded up number: " + roundUp);
                Console.WriteLine("Rounded down number: " + roundDown);

            }
            catch (FormatException)
            {
                Console.WriteLine("Please ensure the number is a valid decimal number.");
            }

            ///////Task 10 - Word Position Finder/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter a word to find its position:");
            string wordToFind = Console.ReadLine();

            int firstIndex = sentence.IndexOf(wordToFind);
            int lastIndex = sentence.LastIndexOf(wordToFind);


            if (sentence.Contains(wordToFind))
            {
                Console.WriteLine("First occurrence index: " + firstIndex);
                Console.WriteLine("Last occurrence index: " + lastIndex);
            }
            else
            {
                Console.WriteLine("The word was not found in the sentence.");
            }

            ///////Task 11 - One-Time Password (OTP) Generator/////////////////////////////////////////////
            ///

            Random random = new Random();

            int otp = random.Next(1000, 9999); // Generates a 6-digit OTP

            Console.WriteLine("Your One-Time Password (OTP) is: " + otp);

            int attempt = 1;
            int maxattempts = 3;
            bool isVerified = false;

            for (; attempt >= maxattempts; attempt++)
            {
                try
                {
                    Console.WriteLine("Enter the OTP:");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput == otp)
                    {
                        isVerified = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect OTP. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid numeric OTP.");
                }

                if (isVerified)
                {
                    Console.WriteLine("OTP verified successfully!");
                }
                else
                {
                    Console.WriteLine("Maximum attempts reached. OTP verification failed.");
                }


            }

            ///////Task 12 - Birthday Insights/////////////////////////////////////////////
            ///

            Console.WriteLine("Enter your birthdate (yyyy-MM-dd):");

            string birthdateInput = Console.ReadLine();
            try
            {
                DateTime birthdate = DateTime.Parse(birthdateInput);

                DayOfWeek dayofweek = birthdate.DayOfWeek;

                DateTime today = DateTime.Today;

                int age = today.Year - birthdate.Year;

                if (today.Month < birthdate.Month || (today.Month == birthdate.Month && today.Day < birthdate.Day))
                {
                    age--;
                }

                Console.WriteLine("You were born on a " + dayofweek);
                Console.WriteLine("You are " + age + " years old.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please ensure the date is in YYYY-MM-DD format.");

            }
        }
    }
}