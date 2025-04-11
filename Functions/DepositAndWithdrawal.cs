using Functions_DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Functions_BusinessLogic
{
    public class DepositAndWithdrawal
    {
        
        
        public static bool VaultProcess(TransactionActions userInput, double enteredAmount)
        {
            if (userInput ==  TransactionActions.Withdraw && enteredAmount <= MyVaultData.Balance && enteredAmount > 0) //WITHDRAW

            {
                MyVaultData.Balance -= enteredAmount;
                MyVaultData.SetTransaction($"Withdrawn: PHP { enteredAmount}");
                return true;
               
            }

            if (userInput == TransactionActions.Deposit) //DEPOSIT
            {
                MyVaultData.Balance += enteredAmount;
                MyVaultData.SetTransaction($"Deposit: PHP {enteredAmount}");
                return true;
            }
            return false;
        }
    }
}
