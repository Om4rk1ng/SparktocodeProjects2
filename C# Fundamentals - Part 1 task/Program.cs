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
            Console.Write("Student: " + IsStudent + ", ");


            //task 2: Rectangle Calculator///////////////////////////////////////////////////////////
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area of the Rectangle with length: " + length + " and width " + width + " is" + area);
            Console.WriteLine("perimeter of the Rectangle with length: " + length + " and width " + width + " is" + perimeter);

            //task 3: Even or Odd Checker///////////////////////////////////////////////////////////

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

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("do you hold a valid national ID (Yes/No): ");
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
        }
    }
}
