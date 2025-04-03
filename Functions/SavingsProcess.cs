using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_BusinessDataLogic
{
    public class SavingsProcess
    {
        
        public static List<string> savingsList = new List<string>();
        public static double savingsBal = 0;
        static string givenName;
        
        public static bool createSavings(TransactionActions userInput, double amountSavings)
        {
            if (userInput == TransactionActions.Savings && amountSavings <= DepositAndWithdrawal.bal)
            {
                savingsList.Add( givenName + " PHP: " + amountSavings);
                DepositAndWithdrawal.bal -= amountSavings;
                return true;
            }
            return false;
        }
        public static void setSavingsName(string namedAccount)
        {
            givenName = namedAccount;
           
        }
        public static string getSavingsName()
        {
            return givenName;
        }
    }
}
