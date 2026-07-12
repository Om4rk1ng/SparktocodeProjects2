namespace OOP_Part_1_Task_6
{

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public string HolderName { get; set; }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
            }
            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Name: " + HolderName + " | Balance: " + Balance);
        }

        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }
    }

    public class Student
    {
    
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

     
        private string email;

    
        int age;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Notification: Registration email sent to " + email);
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock available for " + ProductName + ".");
            }

            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {
            Console.WriteLine("Notification: Transaction logged for " + ProductName);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            account1.AccountNumber = 1163;
            account1.HolderName = "karim";
            account1.Balance = 120;

            BankAccount account2 = new BankAccount();
            account2.AccountNumber = 15203;
            account2.HolderName = "Ali";
            account2.Balance = 63;

      
            Student student1 = new Student();
            student1.Name = "Ali";
            student1.Address = "Muscat";
            student1.Grade = 65;
            student1.Register("ali.student@email.com");

            Student student2 = new Student();
            student2.Name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 70;
            student2.Register("ahmed.student@email.com");

            
            Product product1 = new Product();
            product1.ProductName = "Wireless Mouse";
            product1.Price = 5.500;
            product1.StockQuantity = 50;

            Product product2 = new Product();
            product2.ProductName = "Mechanical Keyboard";
            product2.Price = 15.750;
            product2.StockQuantity = 20;

            //Case 1 View Account Details

            account1.CheckBalance();

            //case 2 Update Student Address

            Console.Write("Enter the new address: ");
            string newAddress = Console.ReadLine();

            student1.Address = newAddress;
            Console.WriteLine("Confirmation: New Address is " + student1.Address);

            //case 3 Make a Deposit

            Console.Write("Enter the deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());

           
            account1.Deposit(depositAmount);

            account1.CheckBalance();

            //Case 4 - Make a Withdrawal

            Console.Write("Enter the withdrawal amount: ");
            double withdrawalAmount = double.Parse(Console.ReadLine());

            account1.Withdraw(withdrawalAmount);
            account1.CheckBalance();

            //case 5 View Product Details
            product1.GetInventoryValue();

            //case 6 Register a Student

            Console.Write("Enter the student's email: ");
            string inputEmail = Console.ReadLine();

            student1.Register(inputEmail);
            Console.WriteLine("Confirmation: The student's registration profile has been updated successfully.");


            // Case 7 - Compare Two Account Balances
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine(account1.HolderName + " holds more money.");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine(account2.HolderName + " holds more money.");
            }
            else
            {
                Console.WriteLine("Both accounts are equal.");
            }



        }
    }
}
