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

            List<String> to_do_items = new List<String>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nenter task " + (i + 1));
                string task = Console.ReadLine();

                to_do_items.Add(task);
            }
            int count = 0;
            foreach (string num in to_do_items)
            {

                count++;
                Console.WriteLine(count + ". " + num);

            }

            ///////Task 3 - Browsing History Stack/////////////////////////////////////////////
            ///
            Stack<String> browsinghis = new Stack<String>();

            for (int i = 0; i < 3; i++)
            {

                Console.Write($"Enter website URL #"+i+": ");
                string url = Console.ReadLine();

                browsinghis.Push(url);

            }

            Console.WriteLine("\ncurrent page is on" + browsinghis.Peek());

            Console.WriteLine("\ngoing back from page: "+browsinghis.Pop());

            Console.WriteLine("\nyou successfully landed on " + browsinghis.Peek());

            ///////Task 4 - Customer Service Queue/////////////////////////////////////////////
            ///

            Queue<String> list = new Queue<String>();

            for (int i = 0;i < 3;i++)
            {
                Console.WriteLine("\nenter customer "+(i+1)+" name:");
                string name = Console.ReadLine();

                list.Enqueue(name);
            }

            Console.WriteLine("\ncustomer "+list.Dequeue+" is served first");


            ///////Task 5 - Array Grade Range/////////////////////////////////////////////
            ///

            int[] grades = new int[5];
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nEnter grade "+ (i + 1)+":");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(grades);
            
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            double average = sum / 5;

            Console.WriteLine("Lowest Grade: "+grades[0]);
            Console.WriteLine("Highest Grade: "+grades[4]);
            Console.WriteLine("Average Grade: "+average);

            ///////Task 6 - Filtered Shopping List/////////////////////////////////////////////
            ///

            List<string> shoppingList = new List<string>();

            Console.WriteLine("\nenter your shopping list items one by one and type done when finished");
            int ii= 0;
            while (true)
            {

                Console.WriteLine("add item" + (ii + 1) + ":");
                ii++;
                string additem = Console.ReadLine();
                
                if (additem == "done") 
                {
                    break;
                }
                else
                {
                    shoppingList.Add(additem);
                }

                
            }
            Console.WriteLine("before removing:" + shoppingList);

            Console.Write("\nEnter the name of the item you want to remove: ");
            string itemToRemove = Console.ReadLine();

            shoppingList.Remove(itemToRemove);

            Console.WriteLine("after removal: " + shoppingList);

        }
    }
}