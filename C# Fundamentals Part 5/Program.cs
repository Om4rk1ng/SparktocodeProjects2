namespace C__Fundamentals_Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///////task 1 Fixed Grades Array/////////////////////////////////////////////
            ///

            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine("enter a number to be added to the array of integers: ");
                int num = int.Parse(Console.ReadLine());

                numbers[i] = num;
            }

            Console.WriteLine("\n");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


        }
    }
}
