﻿using Functions_DataLogic;
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
            if (userInput ==  TransactionActions.Withdraw && enteredAmount <= MyVaultDetails.Balance && enteredAmount > 0) 

            {
                MyVaultDetails.Balance -= enteredAmount;
                MyVaultData.SetTransaction($"Withdrawn: PHP { enteredAmount}");
                new EmailAutomation().SendEmail();
                return true;
               
            }

            if (userInput == TransactionActions.Deposit) //DEPOSIT
            {
                MyVaultDetails.Balance += enteredAmount;
                MyVaultData.SetTransaction($"Deposit: PHP {enteredAmount}");
                new EmailAutomation().SendEmail();
                return true;
            }
            return false;
        }
    }
}
