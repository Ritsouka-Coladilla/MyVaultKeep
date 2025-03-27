using System;
using Functions_BusinessDataLogic;

namespace MyVaultKeep
{
    internal class Program
    {
        static string[] transaction = new string[] { "[1] Deposit", "[2] Withdraw", "[3] Create Savings", "[4] Transaction History", "[5] Expenses", "[6] View Savings Account", "[7] Exit" };
        
        
        static void Main(string[] args)
        {

            //DISCLAIMER:
            //This program is only meant to log the progress of your savings account any changes to the amount of cash is not reflected to your actual bank account...
            //ESTIMATED FUNTIONS: Deposit & Withdraw Savings, Create, and Allocate Savings, Track Spendings/Transactions, Data Storage (TO BE FURTHER ADDED)

            Console.WriteLine("Welcome to MyVault Keep");

            initialDeposit();
            displayCurrentBalance();
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
                        createSavings();
                        break;
                    case 4:
                        transactionHistory();
                        break;
                    case 5:
                        setExpenses();
                        break;
                    case 6:
                        viewSavingsAccount();
                        break;
                    case 7:
                        Console.WriteLine("Thank you for MyVault!");
                        break;
                    default:
                        Console.WriteLine("Invalid Input, please select a value ranging from 1-7");
                        break;

                }
                displayCurrentBalance();
                displayTransactions();
                enterAction = getEnterAction();

            }
            static int getEnterAction()
            {
                Console.Write("[User Input]: ");
                int enterAction = Convert.ToInt32(Console.ReadLine());
                
                return enterAction;
            }


            static void displayCurrentBalance()//UI LOGIC
            {
                Console.WriteLine("Current Balance: PHP " + DepositAndWithdrawal.bal);
                Console.WriteLine("----------------------------");
            }


            static void initialDeposit() //UI LOGIC
            {
                Console.Write("[Enter your debit amount]: ");
                DepositAndWithdrawal.bal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("----------------------------");

            }


            static void displayTransactions() //UI LOGIC
            {
                
                Console.WriteLine("Please select a transaction!");
                Console.WriteLine("Enter Transaction:");
                foreach (var trans in transaction)
                {
                    Console.WriteLine(trans);

                }
            }


                static void addDeposit() //UI LOGIC
            {
                    Console.Write("Enter amount to deposit: ");
                    double deposit = Convert.ToDouble(getEnterAction());
                    DepositAndWithdrawal.VaultProcess(TransactionActions.Deposit, deposit);

                Console.WriteLine("----------------------------");

                }

                static void withdrawDebit() //UI LOGIC
            {
                    Console.WriteLine("----------------------------");
                    Console.Write("Enter amount to be withdrawn: ");
                    double withdraw = Convert.ToDouble(getEnterAction());
                    
                    if(!DepositAndWithdrawal.VaultProcess(TransactionActions.Withdraw, withdraw))
                {
                    Console.WriteLine("Insufficient Balance");
                   
                }

                displayCurrentBalance();
          
                }

                static void createSavings() //UI LOGIC
            {

            }

            static void transactionHistory() //UI LOGIC
                {
                    Console.WriteLine("Transaction History:");
                    Console.WriteLine("____________________________");
                    foreach (var Viewtransactions in DepositAndWithdrawal.transactionList)
                    {
                    Console.WriteLine(Viewtransactions);
                    }
                    Console.WriteLine("----------------------------");
                }

                static void setExpenses() //UI LOGIC
                {
                    Console.WriteLine("Set Expenses Name: ");
                    ExpensesProcess.setExpensesName();

                    Console.WriteLine("Enter amount to allot: ");
                    double allotmentValue = Convert.ToDouble(getEnterAction());

                    if (!ExpensesProcess.initializeExpenses(TransactionActions.Allotment, allotmentValue))
                {
                    Console.WriteLine("Insufficient Balance");

                }

                Console.WriteLine("----------------------------");

            } 

               
                static void viewSavingsAccount() //UI LOGIC
            {
                    Console.WriteLine("Savings Accounts: ");
                    Console.WriteLine("____________________________");
                    foreach (string savings in SavingsProcess.savingsList)
                    {
                        Console.WriteLine(savings);
                    }
                    Console.WriteLine("----------------------------");
                }


            }

        }
    }





