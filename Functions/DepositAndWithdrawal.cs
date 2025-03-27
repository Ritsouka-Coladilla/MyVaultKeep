using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Functions_BusinessDataLogic
{
    public class DepositAndWithdrawal
    {
        public static double bal = 0;
        public static List<string> transactionList = new List<string>();
        public static bool VaultProcess(TransactionActions userInput, double enteredAmount)
        {
            if (userInput ==  TransactionActions.Withdraw && enteredAmount <= bal) //WITHDRAW
            {
                bal -= enteredAmount;
                transactionList.Add("Withdrawn:" + enteredAmount);
                return true;
               
            }

            if (userInput == TransactionActions.Deposit) //DEPOSIT
            {
                bal += enteredAmount;
                transactionList.Add("Deposit:" + enteredAmount);
                return true;
            }
            return false;
        }
    }
}
