namespace C__Fundamentals_Part_5
{
    internal class Program
    {

        ///////Task 9 functions /////////////////////////////////////////////
        /// 

        public static double CalculateAverage(List<int> gradeList)              //function 1
        {
            if (gradeList.Count == 0) 
            {
                return 0.0;
            }
            double sum = 0;
            foreach (int grade in gradeList) 
            {
                sum += grade;
            }
                return sum / gradeList.Count; 
        }

       public static int FindFirstFailing(List<int> gradeList)             //function 2
        {
            
            return gradeList.Find(x => x < 60);
        }

        /// task 10 function
        public static void RemoveJob(Queue<string> currentQueue, string jobToRemove)
        {
            int originalCount = currentQueue.Count;

            for (int i = 0; i < originalCount; i++)
            {
                string currentJob = currentQueue.Dequeue();

                if (currentJob != jobToRemove)
                {
                    currentQueue.Enqueue(currentJob);
                }
            }
        }

        static void Main(string[] args)
        {
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

            ///////Task 7 - High Score Podium/////////////////////////////////////////////
            ///

            List<int> scores = new List<int>();

            Console.WriteLine("Game Score Leaderboard");

          
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter game score #"+i+": ");
                scores.Add(int.Parse(Console.ReadLine()));
            }

            scores.Sort();
            scores.Reverse();

            
            Console.WriteLine("\n1st place: " + scores[0] + " pts");
            Console.WriteLine("2nd place: " + scores[2] + " pts");
            Console.WriteLine("3rd place: " + scores[2] + " pts");

            ///////Task 8 - Undo Last Action/////////////////////////////////////////////
            ///

            Stack<string> actions = new Stack<string>();

            while (true)
            {
                Console.Write("Enter editor action: ");
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                actions.Push(input);
            }

            
            
                Console.WriteLine("\nUndid first action: " + actions.Pop());
      
                Console.WriteLine("Undid second action: " + actions.Pop());


            Console.WriteLine("\nRemaining actions:");
            foreach (string remainingAction in actions)
            {
                Console.WriteLine(remainingAction);
            }

            ///////Task 9 - Grade Analyzer with Functions/////////////////////////////////////////////
            ///


            List<int> grades1 = new List<int>();

            Console.WriteLine("\nHow many grades do you want to enter? ");
            int count1 = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= count1; i++)
            {
                Console.Write("Enter grade #" + i + ": ");
                int grade = int.Parse(Console.ReadLine());
                grades1.Add(grade);
            }
            
            Console.WriteLine("Average Grade: " + CalculateAverage(grades1));

            

            if (FindFirstFailing(grades1) == 0)
            {
                Console.WriteLine("First Failing Grade: No failing grades found!");
            }
            else
            {
                Console.WriteLine("First Failing Grade: " + FindFirstFailing(grades1));
            }

            ///////Task 10 - Print Queue Manager/////////////////////////////////////////////
            ///

            Queue<string> printQueue = new Queue<string>();

            
            Console.WriteLine("Enter print job names. Type 'done' when you are finished.\n");

            while (true)
            {
                Console.Write("Enter job name: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }

                printQueue.Enqueue(input);
            }

            Console.WriteLine("\nQueue Before Cancellation:");
            foreach (string job in printQueue)
            {
                Console.WriteLine(job);
            }

            Console.Write("\nEnter the name of the print job to cancel: ");
            string jobToCancel = Console.ReadLine();

            RemoveJob(printQueue, jobToCancel);

            Console.WriteLine("\nQueue After Cancellation:");

            foreach (string job in printQueue)
            {
                Console.WriteLine(job);
            }

            

        }
    }
}
