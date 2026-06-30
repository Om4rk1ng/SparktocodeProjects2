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











        }
    }
}