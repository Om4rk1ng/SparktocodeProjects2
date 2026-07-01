namespace CsharpSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //looping 
            //1- for loop => countable loop
            //2- while loop => uncountable loop

            //For loop:
            //  for( start; end; increment )
            //  {  
            //         some code to be repeated    
            //   }


            int counter = 0;

            for (counter = 10; counter >= 5; counter--)
            {
                Console.WriteLine("certain message loop number:" + counter);

            }

            //////////////////////////////////////////////////////

            //bool exitDecision = false;
            //string userInput;

            //while (exitDecision == false)
            //{
            //    Console.WriteLine("print menu");

            //    Console.WriteLine("Do you want to exit? (y/n)");
            //    userInput = Console.ReadLine();

            //    if(userInput == "y")
            //    {
            //        exitDecision = true;
            //    }
            //}



            bool exitDecision = false;
            string userInput;
            int userchoice;

            do
            {
                Console.WriteLine("print menu");


                try
                {

                    Console.WriteLine("Do you want to exit? (1/2)");
                    userchoice = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine("Do you want to exit? (y/n)");
                userInput = Console.ReadLine();

                if (userInput == "y")
                {
                    exitDecision = true;
                }

            } while (exitDecision == false);


            //nested loop => self study
        }
    }
}