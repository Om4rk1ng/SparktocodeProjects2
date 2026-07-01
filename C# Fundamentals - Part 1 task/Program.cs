namespace C__Fundamentals___Part_1_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Personal Info Card

            
            string Name=Console.ReadLine();
            int Age = Convert.ToInt32(Console.ReadLine());
            double Height = Convert.ToDouble(Console.ReadLine());
            bool IsStudent = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Student: " + IsStudent);

            
            //task 2: Rectangle Calculator///////////////////////////////////////////////////////////
            double length = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            double area = length * width;
            double perimeter = 2 * (length + width);
            Console.WriteLine("Area of the Rectangle with length: "+length+" and width "+width+" is" + area);
            Console.WriteLine("perimeter of the Rectangle with length: " + length + " and width " + width + " is" + perimeter);


        }
    }
}
