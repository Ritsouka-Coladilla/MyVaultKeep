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
         
        public static bool createSavings(TransactionActions userInput, double amountSavings)
        {
            if (userInput == TransactionActions.Savings && amountSavings <= MyVaultDetails.Balance)
            {
                MyVaultData.SetSavings(MyVaultDetails.Name + " PHP: " + amountSavings);
                MyVaultDetails.Balance -= amountSavings;
                MyVaultData.SetTransaction("Savings: " + MyVaultDetails.Name + " PHP: " + amountSavings);

                return true;

                
            }
            return false;
        }
        
        }
    }

