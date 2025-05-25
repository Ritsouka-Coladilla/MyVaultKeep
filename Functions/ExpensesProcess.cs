using Functions_DataLogic;
using MyVaultCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_BusinessLogic
{
    public class ExpensesProcess
    {
       
        public static bool initializeExpenses(TransactionActions userInput, double amountExpenses) //BUSINESS LOGIC
        {
            
            if (userInput == TransactionActions.Expenses)
            {
                switch (MyVaultDetails.EnterExpenses)
                {
                    case 1:
                        if (amountExpenses <= MyVaultDetails.Balance)
                        {
                            MyVaultDetails.Balance -= amountExpenses;
                            MyVaultData.SetTransaction("Food: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    case 2:
                        if (amountExpenses <= MyVaultDetails.Balance)
                        {
                            MyVaultDetails.Balance -= amountExpenses;
                            MyVaultData.SetTransaction("Transportation: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    case 3:
                        if (amountExpenses <= MyVaultDetails.Balance)
                        {
                            MyVaultDetails.Balance -= amountExpenses;
                            MyVaultData.SetTransaction("Utilities: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    case 4:
                        if (amountExpenses <= MyVaultDetails.Balance)
                        {
                            MyVaultDetails.Balance -= amountExpenses;
                            MyVaultData.SetTransaction("Rent: PHP " + amountExpenses);
                            return true;
                        }
                        break;
                    case 5:
                        if (amountExpenses <= MyVaultDetails.Balance)
                        {
                            MyVaultDetails.Balance -= amountExpenses;
                            MyVaultData.SetTransaction("Others: PHP " + amountExpenses);
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



