using System;
using Functions_BusinessLogic;
using Functions_DataLogic;
using MyVaultCommon;

namespace MyVaultKeep
{
    internal class Program
    {
        static string[] transaction = new string[] { "[1] Deposit", "[2] Withdraw", "[3] Create Savings", "[4] Transaction History", "[5] Expenses", "[6] View Savings Account,", "[7] Exit" };
        static string[] expensesClassification = new string[] { "[1] Food/Groceries", "[2] Transportation", "[3] Utilities", "[4] Rent", "[5] Others" };

        static void Main(string[] args)
        {

            //DISCLAIMER:
            //This program is only meant to log the progress of your savings account any changes to the amount of cash is not reflected to your actual bank account...
            //ESTIMATED FUNTIONS: Deposit & Withdraw Savings, Allot money to Specified Expenses, Create, and Allocate Savings, Track Spendings/Transactions, Data Storage (TO BE FURTHER ADDED)...

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
            static int getEnterAction() //UI LOGIC -ENABLES USER TO ENTER ACTION-
            {
                Console.Write("[User Input]: ");
                int enterAction = Convert.ToInt32(Console.ReadLine());

                return enterAction;
            }


            static void displayCurrentBalance()//UI LOGIC -DISPLAYS CURRENT BALANCE-
            {
                Console.WriteLine("Current Balance: PHP " + MyVaultDetails.Balance);
                Console.WriteLine("----------------------------");
            }


            static void initialDeposit() //UI LOGIC -CREATES INITIAL DEPOSIT-
            {
                Console.Write("[Enter your debit amount]: ");
                MyVaultDetails.Balance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("----------------------------");

            }


            static void displayTransactions() //UI LOGIC -DISPLAYS TRANSACTIONS-
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Please select a transaction!");
                Console.WriteLine("Enter Transaction:");
                foreach (var trans in transaction)
                {
                    Console.WriteLine(trans);

                }
            }

            static void displayExpenses() //UI LOGIC -DISPLAYS TRANSACTIONS-
            {

                Console.WriteLine("Please select a classification for expenses!");
                Console.WriteLine("Enter Classification:");
                foreach (var expensesType in expensesClassification)
                {
                    Console.WriteLine(expensesType);

                }
            }


            static void addDeposit() //UI LOGIC -METHOD FOR DEPOSITING-
            {
                Console.Write("Enter amount to deposit: ");
                double deposit = Convert.ToDouble(getEnterAction());
                DepositAndWithdrawal.VaultProcess(TransactionActions.Deposit, deposit);

                Console.WriteLine("----------------------------");

            }

            static void withdrawDebit() //UI LOGIC -METHOD FOR WITHDRAWING-
            {
                Console.WriteLine("----------------------------");
                Console.Write("Enter amount to be withdrawn: ");
                double withdraw = Convert.ToDouble(getEnterAction());

                if (!DepositAndWithdrawal.VaultProcess(TransactionActions.Withdraw, withdraw))
                {
                    Console.WriteLine("Insufficient Balance");

                }

                displayCurrentBalance();

            }

            static void createSavings() //UI LOGIC -METHOD FOR CREATING SAVINGS-
            {
                Console.WriteLine("Enter Savings Name: ");
                string savingsName = Console.ReadLine();

                Console.WriteLine("Enter amount to transfer: ");
                double savingsValue = Convert.ToDouble(getEnterAction());

                if (!SavingsProcess.createSavings(TransactionActions.Savings, savingsName, savingsValue))
                {
                    Console.WriteLine("Insufficient Balance");
                }
                Console.WriteLine("----------------------------");
            }

            static void transactionHistory() //UI LOGIC -METHOD FOR VIEWING TRANSACTION HISTORY-
            {
                Console.WriteLine("Transaction History:");
                Console.WriteLine("____________________________");
                foreach (var Viewtransactions in MyVaultData.GetTransactionList())
                {
                    Console.WriteLine(Viewtransactions);
                }
                Console.WriteLine("----------------------------");
            }

            static void setExpenses() //UI LOGIC -METHOD FOR SETTING EXPENSES-
            {
                displayExpenses();
                MyVaultDetails.EnterExpenses = Convert.ToInt16(getEnterAction());

                Console.WriteLine("Enter amount to allot: ");
                double expensesValue = Convert.ToDouble(getEnterAction());

                if (!ExpensesProcess.initializeExpenses(TransactionActions.Expenses, expensesValue))
                {
                    Console.WriteLine("Insufficient Balance");

                }

                Console.WriteLine("----------------------------");

            }


            static void viewSavingsAccount() //UI LOGIC -METHOD FOR VIEWING SAVINGS ACCOUNT-
            {
                Console.WriteLine("Savings Accounts: ");
                Console.WriteLine("____________________________");
                foreach (string savings in MyVaultData.GetSavingsList())
                {
                    Console.WriteLine(savings);
                }
                Console.WriteLine("----------------------------");
            }


        }

    }
}





