using System.Linq.Expressions;

namespace c__fundamentals__part_2_task_2_loops_error_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////Task 1 Countdown Timer/////////////////////////////////////////////
            ///

            Console.WriteLine("enter a countdown starting number: ");

            for (int countdown = Convert.ToInt32(Console.ReadLine()); countdown > 0; countdown--)
            {
                Console.WriteLine(countdown);
            }

            ///////Task 2 Sum of Numbers 1 to N/////////////////////////////////////////////
            ///

            Console.WriteLine("enter a positive whole number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;

            }
            Console.WriteLine("The sum of numbers from 1 to " + n + " is " + sum);


        }
    }
}