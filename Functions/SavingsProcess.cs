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
         
        public static bool createSavings(TransactionActions userInput, double amountSavings)
        {
            if (userInput == TransactionActions.Savings && amountSavings <= MyVaultData.Balance)
            {
                MyVaultData.SetSavings(MyVaultData.Name + " PHP: " + amountSavings);
                MyVaultData.Balance -= amountSavings;
                return true;
            }
            return false;
        }
        
        }
    }

