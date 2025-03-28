using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_BusinessDataLogic
{
    public class ExpensesProcess
    {
        
        public static string nameExpenses;
        public static int enterExpenses;
        public static bool initializeExpenses(TransactionActions userInput, double amountExpenses) //BUSINESS LOGIC
        {
            
            if (userInput == TransactionActions.Expenses)
            {
                switch (enterExpenses)
                {
                    case 1:
                        if (amountExpenses <= DepositAndWithdrawal.bal)
                        {
                            DepositAndWithdrawal.bal -= amountExpenses;
                            DepositAndWithdrawal.transactionList.Add("Food: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    case 2:
                        if (amountExpenses <= DepositAndWithdrawal.bal)
                        {
                            DepositAndWithdrawal.bal -= amountExpenses;
                            DepositAndWithdrawal.transactionList.Add("Transportation: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    case 3:
                        if (amountExpenses <= DepositAndWithdrawal.bal)
                        {
                            DepositAndWithdrawal.bal -= amountExpenses;
                            DepositAndWithdrawal.transactionList.Add("Utilities: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    case 4:
                        if (amountExpenses <= DepositAndWithdrawal.bal)
                        {
                            DepositAndWithdrawal.bal -= amountExpenses;
                            DepositAndWithdrawal.transactionList.Add("Rent: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    case 5:
                        if (amountExpenses <= DepositAndWithdrawal.bal)
                        {
                            DepositAndWithdrawal.bal -= amountExpenses;
                            DepositAndWithdrawal.transactionList.Add("Others: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input, please select a value ranging from 1-5");
                        break;

                }return true;

                
            }
            return false;

        }

    }
}



