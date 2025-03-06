namespace MyVaultKeep
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DISCLAIMER:
            //This program is only meant to log the progress of your savings account any changes to the amount of cash is not reflected to your actual bank account...
            //ESTIMATED FUNTIONS: Deposit & Withdraw Savings, Allocate Savings to a Goal, Track Spendings/Transactions, Data Storage (TO BE FURTHER ADDED)

            Console.WriteLine("Welcome to MyVault Keep");

            double bal = 0;
            double rent = 0;
            double miscl = 0;
            string confirm;

            do

            {
                Console.WriteLine("Current Balance: " + bal);
                Console.WriteLine("Please select a transaction!");

                string[] transaction = new string[] { "[1] Deposit", "[2] Withdraw", "[3] Set Goals", "[4] Transaction History", "[5] Allotment", "[6] Exit" };

                foreach (var trans in transaction)
                {
                    Console.WriteLine(trans);
                }
                Console.WriteLine("Enter Transaction");

                int enterAction = Convert.ToInt16(Console.ReadLine());

                switch (enterAction)
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposit:");
                        double deposit = Convert.ToDouble(Console.ReadLine());

                        bal += deposit;

                        Console.WriteLine("Your balance is: " + "PHP " + bal);
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to be withdrawn:");
                        double withdraw = Convert.ToDouble(Console.ReadLine());

                        if (withdraw >= 0)
                        {
                            bal -= withdraw;

                            Console.WriteLine("You have successfully withdrawn: " + "PHP " + withdraw);
                        }
                        else if (withdraw < 0)
                        {
                            Console.WriteLine("Please enter a positive value or 0");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please Add a Saving Goal:");
                        double sGoal = Convert.ToDouble(Console.ReadLine());

                        double eGoal = sGoal - bal;

                        Console.WriteLine("You have set a goal of: " + "PHP " + sGoal + " to reach.");

                        if (bal < sGoal)
                        {
                            Console.WriteLine("You are " + "PHP " + eGoal + " short to reach your goal.");
                        }
                        else if (bal > sGoal)
                        {
                            Console.WriteLine("You have already succeeded your goal.");
                        }

                        break;
                    case 4:
                        Console.WriteLine("To be Added...");
                        break;
                    case 5:
                        Console.WriteLine("Set name for Allotment:");
                        string nameAllotment = Console.ReadLine();

                        Console.WriteLine("Set desired amount for Allotment:");
                        double amountAllotment = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("You have successfully set an allotment named " + nameAllotment + " for an amount of: " + "PHP " + amountAllotment);
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("Do you Wish to start another Transaction? Types 'Yes' to continue or 'No' to exit.");
                confirm = Console.ReadLine();

            } while (confirm == "yes" || confirm == "Yes");

        }
    }
}
