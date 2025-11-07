using MyVaultCommon;
using Functions_DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_BusinessLogic
{
    public class SavingsProcess
    {
        private readonly EmailAutomation _emailAutomation;  

        public SavingsProcess(EmailAutomation emailAutomation)
        {
            _emailAutomation = emailAutomation;
        }   

        public bool createSavings(TransactionActions userInput, string name, double amountSavings)
        {
            if (userInput == TransactionActions.Savings && amountSavings <= MyVaultDetails.Balance)
            {
                string savingsEntry = $"{name} PHP: {amountSavings}";
                MyVaultData.SetSavings(savingsEntry);
                MyVaultDetails.Balance -= amountSavings;
                MyVaultData.SetTransaction($"Savings: {savingsEntry}");
                _emailAutomation.SendEmail();
                return true;


            }
            return false;
        }

        public static bool deleteSavings(TransactionActions userInput, string name, double amount)
        {
            if (userInput == TransactionActions.Savings && amount > 0)
            {
                bool deleted = MyVaultData.DeleteSavings(name);
                if (deleted)
                {
                    MyVaultDetails.Balance += amount;
                    MyVaultData.SetTransaction($"Deleted Savings: {name} PHP: {amount}");
                    return true;
                }
            }
            return false;
        }

        public static bool updateSavings(TransactionActions userInput, string oldName, string newName, double newAmount)
        {
            if (userInput == TransactionActions.Savings && newAmount > 0)
            {
                bool updated = MyVaultData.UpdateSavings(oldName, newName, newAmount);
                if (updated)
                {
                    MyVaultData.SetTransaction($"Updated Savings: {oldName} → {newName}, New Amount: PHP {newAmount}");
                    return true;
                }
            }
            return false;
        }
    }
}
