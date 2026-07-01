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
        }
    }
}
