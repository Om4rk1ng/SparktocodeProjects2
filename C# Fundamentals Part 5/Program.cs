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

            ///////Task 2 - Dynamic To-Do List/////////////////////////////////////////////
            ///

            List <String> to_do_items= new List <String>();

            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine("\nenter task "+(i+1));
                string task = Console.ReadLine();

                to_do_items.Add(task);
            }
            int count = 0;
            foreach (string num in to_do_items) {
                
                count++;
                Console.WriteLine(count + ". "+num);
                    
                        }


        }
    }
}
