namespace _2nd_c__Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputting name and displaying it

            Console.Write("enter your name please:");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);

            //coverting input value to another datatype using parser since input is always string

            Console.Write("enter your age please:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("your age is " + age);

            //converting string to int using convert Convert.To"Datatype"() method
            Console.Write("enter your weight please:");
            string weightinput = Console.ReadLine();
            double weight = Convert.ToDouble(weightinput);
            Console.WriteLine("your weight is " + weight);

            //using calculation operators in c#
            Console.Write("enter your first value please:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter your second value please:");
            int b = int.Parse(Console.ReadLine());

            int addresult = a + b;
            int subresult = a - b;
            int mulresult = a * b;
            int divresult = a / b;
            int reminder = a % b;

            Console.WriteLine("the addition of " + a + " and " + b + " is " + addresult);
            Console.WriteLine("the subtraction of " + a + " and " + b + " is " + subresult);
            Console.WriteLine("the multiplication of " + a + " and " + b + " is " + mulresult);
            Console.WriteLine("the division of " + a + " and " + b + " is " + divresult);
            Console.WriteLine("the reminder of " + a + " and " + b + " is " + reminder);










        }
    }
}