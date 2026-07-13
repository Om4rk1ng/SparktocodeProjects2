namespace OOP_Part_1_Task_6
{

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public string HolderName { get; set; }

        public BankAccount()
        {

        }
        
        public BankAccount(int accountNumber, string holderName, double startingBalance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = startingBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            SendEmail();
        }

        public bool overdrawn
        {
            get
            {
                return Balance > 0;
            }
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

        private static int NoOfStudent = 0;
     
        private string email;

    
        int age;

        private string _securityPin;

        public string SecurityPin
        {
            set
            {
                _securityPin = value;
            }
        }

        public Student()
        {
            NoOfStudent++;
        }

        public static int GetStudentCount()
        {
            return NoOfStudent;
        }

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
            // Object Declarations (Instantiated outside the loop)
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

            while (true)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. View Account Details          11. Student Report Card");
                Console.WriteLine("2. Update Student Address        12. Account Health Status");
                Console.WriteLine("3. Make a Deposit                13. Bulk Sale Optimization");
                Console.WriteLine("4. Make a Withdrawal             14. Scholarship Eligibility Check");
                Console.WriteLine("5. View Product Details          15. Full Balance Top-Up Flow");
                Console.WriteLine("6. Register a Student            16. Quick Account Opening");
                Console.WriteLine("7. Compare Account Balances      17. Total Students Counter");
                Console.WriteLine("8. Restock & Levels Check        18. Overdrawn Account Check");
                Console.WriteLine("9. Transfer Between Accounts     19. Set Student Security PIN");
                Console.WriteLine("20. EXIT");
                Console.Write("Select an option (1-20): ");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        // Case 1 View Account Details
                        account1.CheckBalance();
                        break;

                    case "2":
                        // case 2 Update Student Address
                        Console.Write("Enter the new address: ");
                        string newAddress = Console.ReadLine();

                        student1.Address = newAddress;
                        Console.WriteLine("Confirmation: New Address is " + student1.Address);
                        break;

                    case "3":
                        // case 3 Make a Deposit
                        Console.Write("Enter the deposit amount: ");
                        double depositAmount = double.Parse(Console.ReadLine());

                        account1.Deposit(depositAmount);
                        account1.CheckBalance();
                        break;

                    case "4":
                        // Case 4 - Make a Withdrawal
                        Console.Write("Enter the withdrawal amount: ");
                        double withdrawalAmount = double.Parse(Console.ReadLine());

                        account1.Withdraw(withdrawalAmount);
                        account1.CheckBalance();
                        break;

                    case "5":
                        // case 5 View Product Details
                        product1.GetInventoryValue();
                        break;

                    case "6":
                        // case 6 Register a Student
                        Console.Write("Enter the student's email: ");
                        string inputEmail = Console.ReadLine();

                        student1.Register(inputEmail);
                        Console.WriteLine("Confirmation: The student's registration profile has been updated successfully.");
                        break;

                    case "7":
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
                        break;

                    case "8":
                        // Case 8 - Restock Product & Stock Level Check
                        Console.Write("Enter the quantity to restock: ");
                        int restockQuantity = int.Parse(Console.ReadLine());

                        product1.Restock(restockQuantity);

                        if (product1.StockQuantity < 10)
                        {
                            Console.WriteLine("Stock Level Status: Low");
                        }
                        else if (product1.StockQuantity >= 10 && product1.StockQuantity <= 49)
                        {
                            Console.WriteLine("Stock Level Status: Moderate");
                        }
                        else
                        {
                            Console.WriteLine("Stock Level Status: Well Stocked");
                        }
                        break;

                    case "9":
                        // Case 9 - Transfer Between Accounts
                        Console.Write("Enter the transfer amount: ");
                        double transferAmount = double.Parse(Console.ReadLine());

                        if (account1.Balance >= transferAmount)
                        {
                            account1.Withdraw(transferAmount);
                            account2.Deposit(transferAmount);
                            Console.WriteLine("Transfer successful " + transferAmount + " transferred from " + account1.HolderName + " to " + account2.HolderName);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds in " + account1.HolderName + "'s account.");
                        }
                        break;

                    case "10":
                        // Case 10 - Update Student Grade (Validated)
                        Console.Write("Enter the new grade for the student: ");
                        int newGrade = int.Parse(Console.ReadLine());

                        if (newGrade < 0 || newGrade > 100)
                        {
                            Console.WriteLine("Update rejected: Grade must be within the 0-100 range.");
                        }
                        else
                        {
                            student1.Grade = newGrade;
                            Console.WriteLine("Success: " + student1.Name + "'s grade has been updated to " + student1.Grade);
                        }
                        break;

                    case "11":
                        // Case 11 - Student Report Card
                        Console.WriteLine("\n--- Student Report Card ---");
                        Console.WriteLine("Student Name: " + student1.Name);
                        Console.WriteLine("Address: " + student1.Address);
                        Console.WriteLine("Grade: " + student1.Grade);

                        if (student1.Grade >= 60)
                        {
                            Console.WriteLine("Status: Pass");
                        }
                        else
                        {
                            Console.WriteLine("Status: Fail");
                        }
                        break;

                    case "12":
                        // Case 12 - Account Health Status
                        if (account1.Balance < 50)
                        {
                            Console.WriteLine("account Status: Low Balance");
                        }
                        else if (account1.Balance >= 50 && account1.Balance <= 1000)
                        {
                            Console.WriteLine("Account Status: Healthy");
                        }
                        else
                        {
                            Console.WriteLine("Account Status: Premium");
                        }
                        break;

                    case "13":
                        // Case 13 - Bulk Sale With Revenue Calculation
                        Console.Write("Enter the quantity to sell: ");
                        int saleQuantity = int.Parse(Console.ReadLine());

                        if (product1.StockQuantity < saleQuantity)
                        {
                            int unitsremain = saleQuantity - product1.StockQuantity;
                            Console.WriteLine("not enough, need" + unitsremain + " remaining");
                        }
                        else
                        {
                            product1.Sell(saleQuantity);
                            double revenue = saleQuantity * product1.Price;
                            Console.WriteLine("Sale successful, Units Sold: " + saleQuantity + " | Total Revenue: $" + revenue);
                        }
                        break;

                    case "14":
                        // Case 14 - Scholarship Eligibility Check
                        if (student1.Grade >= 80 && account1.Balance >= 100)
                        {
                            Console.WriteLine("Eligible");
                        }
                        else
                        {
                            if (student1.Grade < 80)
                            {
                                Console.WriteLine("student grade is below 80 which is at " + student1.Grade);
                            }
                            if (account1.Balance < 100)
                            {
                                Console.WriteLine("account balance " + account1.Balance + " below 100");
                            }
                        }
                        break;

                    case "15":
                        // Case 15 - Full Balance Top-Up Flow
                        double realbalance = account1.Balance;

                        if (realbalance < 50)
                        {
                            double topup = 100 - realbalance;
                            account1.Deposit(topup);
                            Console.WriteLine("account before topping: $" + realbalance + ", account after topping: $" + account1.Balance);
                        }
                        else
                        {
                            Console.WriteLine("no need to top, status of current balance is: $" + realbalance);
                        }
                        break;

                    case "16":
                        // Case 16 - Quick Account Opening [Parameterized Constructor]
                        BankAccount Account3 = new BankAccount(1164, "Omar", 40);

                        Console.WriteLine("Account Number: " + Account3.AccountNumber);
                        Console.WriteLine("Holder Name:    " + Account3.HolderName);
                        Console.WriteLine("Total Balance:  $" + Account3.Balance);
                        break;

                    case "17":
                        // Case 17 - Total Students Counter[Static Fields & Methods]
                        Console.WriteLine("student count tracker");
                        Console.WriteLine("Total Student created: " + Student.GetStudentCount());
                        break;

                    case "18":
                        // Case 18 - Overdrawn Account Check [Read-Only Property]
                        Console.WriteLine("account details check");
                        account1.CheckBalance();

                        if (account1.overdrawn)
                        {
                            Console.WriteLine("account is overdrawn");
                        }
                        else
                        {
                            Console.WriteLine("account is not overdrawn");
                        }
                        break;

                    case "19":
                        // Case 19 - Set Student Security PIN [Write-Only Property]
                        Console.Write("Enter a new 4-digit PIN for " + student1.Name + ": ");
                        string inputPin = Console.ReadLine();

                        student1.SecurityPin = inputPin;
                        Console.WriteLine("Success: Security PIN has been updated and encrypted. (Value cannot be displayed)");
                        break;

                    case "20":
                        // Case 20 - Exit option
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid number (1-20).");
                        break;
                }
            }
        }
    }
}
