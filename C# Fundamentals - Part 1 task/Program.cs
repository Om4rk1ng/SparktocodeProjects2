namespace C__Fundamentals___Part_1_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Personal Info Card

            string Name = "Omar";
            int Age = 23;
            double Height = 1.65;
            bool IsStudent = true;

            Console.Write("Name: " + Name + ", ");
            Console.Write("Age: " + Age + ", ");
            Console.Write("Height: " + Height + ", ");
            Console.WriteLine("Student: " + IsStudent);


            //task 2: Rectangle Calculator///////////////////////////////////////////////////////////
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area of the Rectangle with length: " + length + " and width " + width + " is " + area);
            Console.WriteLine("perimeter of the Rectangle with length: " + length + " and width " + width + " is " + perimeter);

            //task 3: Even or Odd Checker///////////////////////////////////////////////////////////

            Console.WriteLine("enter whole number: ");
            int whole_number = Convert.ToInt32(Console.ReadLine());

            if (whole_number % 2 == 0)
            {
                Console.WriteLine("The number " + whole_number + " is even.");
            }
            else
            {
                Console.WriteLine("The number " + whole_number + " is odd.");
            }

            //task 4: Voting Eligibility///////////////////////////////////////////////////////////

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("do you hold a valid national ID (Yes/No): ");
            string hasID = Console.ReadLine();

            bool hasIDBool;

            if (hasID == "yes" || hasID == "Yes")
            {
                hasIDBool = true;
            }
            else
            {
                hasIDBool = false;
            }

            if (age >= 18 && hasIDBool == true)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");


            }

            //task 5: Grade Letter Lookup///////////////////////////////////////////////////////////

            Console.WriteLine("enter your grade:");
            string grade = Console.ReadLine();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("very Good");
                    break;
                case "C":
                    Console.WriteLine("Good");
                    break;
                case "D":
                    Console.WriteLine("Pass");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

            //task 6: Temperature Converter///////////////////////////////////////////////////////////

            Console.WriteLine("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            string weather = "";
            switch (celsius)
            {
                case < 10:
                    weather = "Cold";
                    break;
                case >= 10 and < 30:
                    weather = "Mild";
                    break;
                case >= 30:
                    weather = "Hot";
                    break;
            }

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit + "and weather is " + weather);

            //task 7: Movie Ticket Pricing///////////////////////////////////////////////////////////

            Console.WriteLine("Enter your age: ");
            int Age_group = Convert.ToInt32(Console.ReadLine());
            string ticketPrice = "";
            string ageCategory = "";

            if (Age_group >= 0 && Age_group < 12)
            {
                ageCategory = "Children";
                ticketPrice = "2.000 OMR";
            }
            else if (Age_group >= 13 && Age_group <= 59)
            {
                ageCategory = "Adult";
                ticketPrice = "5.000 OMR";
            }
            else
            {
                ageCategory = "Senior";
                ticketPrice = "3.000 OMR";
            }

            Console.WriteLine("Age Category: " + ageCategory + ", Ticket Price: " + ticketPrice);

            //task 8: Restaurant Bill with Membership Discount///////////////////////////////////////////////////////////

            Console.WriteLine("Enter the total bill amount: ");
            int billAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you a member of the restaurant's loyalty program? (Yes/No): ");
            string isMember = Console.ReadLine();
            double discount = 0;
            double final_amount = 0;
            if (billAmount > 20 && isMember == "yes")
            {
                 discount = 0.15;
                 final_amount = billAmount * (1 - discount);
                Console.WriteLine("original bill amount: "+billAmount+", discount amount: "+discount+", final bill amount: "+ final_amount);
            }
            else
            {
                final_amount = billAmount;
                Console.WriteLine("original bill amount: " + billAmount +", final bill amount: " + final_amount);


            }
            //task 9: Day Name Finder///////////////////////////////////////////////////////////

            Console.WriteLine("Enter a number between 1 and 7 representing the day: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 1: Console.WriteLine("sunday"); break;
                case 2: Console.WriteLine("monday"); break;
                case 3: Console.WriteLine("tuesday"); break;
                case 4 : Console.WriteLine("wednesday"); break;
                case 5: Console.WriteLine("thursday"); break;
                case 6: Console.WriteLine("friday"); break;
                case 7: Console.WriteLine("saturday"); break;
                default: Console.WriteLine("Invalid day number"); break;
            }

        }
    }
}