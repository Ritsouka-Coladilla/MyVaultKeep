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
        public static bool initializeExpenses(TransactionActions userInput, double amountExpenses) //BUSINESS LOGIC
        {
            

            if (userInput == TransactionActions.Expenses && amountExpenses <= DepositAndWithdrawal.bal)
            {
                DepositAndWithdrawal.bal -= amountExpenses;
                DepositAndWithdrawal.transactionList.Add(nameExpenses + " PHP " + amountExpenses);

                return true;
            }
            return false;

        }

        public static void setExpensesName()
        {
             nameExpenses = Console.ReadLine();
        }

    }
}



