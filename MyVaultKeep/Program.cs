using System;

namespace MyVaultKeep
{
    internal class Program
    {
        static double bal = 0;
        static string[] transaction = new string[] { "[1] Deposit", "[2] Withdraw", "[3] Set Goals", "[4] Transaction History", "[5] Allotment", "[6] View Allotment", "[7] Exit" };
        static List<string> transactionList = new List<string>();
        static List<string> allotmentList = new List<string>();
        static void Main(string[] args)
        {

            //DISCLAIMER:
            //This program is only meant to log the progress of your savings account any changes to the amount of cash is not reflected to your actual bank account...
            //ESTIMATED FUNCTIONS: Deposit & Withdraw Savings, Allocate Savings to a Goal, Track Spendings/Transactions, Data Storage (TO BE FURTHER ADDED)

            Console.WriteLine("Welcome to MyVault Keep");

            initialDeposit();

            displayTransactions();

            int enterAction = getEnterAction();

            while (enterAction != 7)
            {
                switch (enterAction)
                {
                    case 1:
                        addDeposit();
                        break;
                    case 2:
                        withdrawDebit();
                        break;
                    case 3:
                        setGoals();
                        break;
                    case 4:
                        transactionHistory();
                        break;
                    case 5:
                        setAllotment();
                        break;
                    case 6:
                        viewAllotment();
                        break;
                    case 7:
                        Console.WriteLine("Thank you for MyVault!");
                        break;
                    default:
                        Console.WriteLine("Invalid Input, please select a value ranging from 1-7");
                        break;

                }
                displayTransactions();
                enterAction = getEnterAction();

            }
            static int getEnterAction()
            {
                
                int enterAction = Convert.ToInt16(Console.ReadLine());

                return enterAction;
            }

                
            static void initialDeposit()
            {
                Console.WriteLine("[Enter your debit amount]: ");
                 bal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("----------------------------");

            }


            static void displayTransactions()
            {
                Console.WriteLine("Current Balance: PHP " + bal);
                Console.WriteLine("Please select a transaction!");
                Console.WriteLine("Enter Transaction:");
                foreach (var trans in transaction)
                {
                    Console.WriteLine(trans);
                    
                }
            }


            static void addDeposit()
            {
                Console.WriteLine("Enter amount to deposit:");
                double deposit = Convert.ToDouble(Console.ReadLine());

                bal += deposit;

                Console.WriteLine("Your balance is: " + "PHP " + bal);
                Console.WriteLine("----------------------------");

                transactionList.Add("Deposit:" + deposit);
            }


            static void withdrawDebit()
            {
                Console.WriteLine("Enter amount to be withdrawn:");
                double withdraw = Convert.ToDouble(Console.ReadLine());

                if (withdraw <= bal)
                {
                    bal -= withdraw;

                    Console.WriteLine("You have successfully withdrawn: " + "PHP " + withdraw);

                    transactionList.Add("Withdrawn: " + withdraw);
                }
                else if (withdraw < 0)
                {
                    Console.WriteLine("Please enter a positive value or 0");
                }
                else if (withdraw > bal)
                {
                    Console.WriteLine("Desired amount exceeds the remaining balance, please enter a lower number.");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("----------------------------");
            }


            static void setGoals()
            {
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
                Console.WriteLine("----------------------------");
            }


            static void transactionHistory()
            {
                Console.WriteLine("Transaction History:");
                Console.WriteLine("____________________________");
                foreach (string transactions in transactionList)
                {
                    Console.WriteLine(transactions);
                }
                Console.WriteLine("----------------------------");
            }


            static void setAllotment()
            {
                Console.WriteLine("Set name for Allotment:");
                string nameAllotment = Console.ReadLine();

                Console.WriteLine("Set desired amount for Allotment:");
                double amountAllotment = Convert.ToDouble(Console.ReadLine());

                if (amountAllotment <= bal)
                {
                    bal -= amountAllotment;
                    Console.WriteLine("You have successfully set an allotment named " + nameAllotment + " for an amount of: " + "PHP " + amountAllotment);
                    allotmentList.Add(nameAllotment + ":" + amountAllotment);
                }
                else if (amountAllotment > bal)
                {
                    Console.WriteLine("Desired amount exceeds the remaining balance, please enter a lower number.");
                }
                else if (amountAllotment < 0)
                {
                    Console.WriteLine("Invalid, please set a positive value for this transaction.");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.WriteLine("----------------------------");

                
                transactionList.Add("Allotment of: PHP " + amountAllotment);
            }


            static void viewAllotment()
            {
                Console.WriteLine("Allotment history: ");
                Console.WriteLine("____________________________");
                foreach (string allotments in allotmentList)
                {
                    Console.WriteLine(allotments);
                }
                Console.WriteLine("----------------------------");
            }


        }

            } 

        }
    

