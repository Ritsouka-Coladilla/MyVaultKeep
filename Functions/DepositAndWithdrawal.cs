using Functions_DataLogic;
using MyVaultCommon;
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
            if (userInput ==  TransactionActions.Withdraw && enteredAmount <= MyVaultDetails.Balance && enteredAmount > 0) //WITHDRAW

            {
                MyVaultDetails.Balance -= enteredAmount;
                MyVaultData.SetTransaction($"Withdrawn: PHP { enteredAmount}");
                return true;
               
            }

            if (userInput == TransactionActions.Deposit) //DEPOSIT
            {
                MyVaultDetails.Balance += enteredAmount;
                MyVaultData.SetTransaction($"Deposit: PHP {enteredAmount}");
                return true;
            }
            return false;
        }
    }
}
