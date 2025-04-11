using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_DataLogic
{
    public static class MyVaultData
    {
        public static double Balance { get; set; } = 0;

        public static double SavingsBal { get; set; } = 0;
        public static string Name { get; set; }
        public static int EnterExpenses { get; set; }

        private static List<String> transactionList = new List<String>();

        private static List<String> savingsList = new List<String>();


        public static void SetTransaction(string transaction)
        {
            transactionList.Add(transaction);    
        }

        public static List<String> GetTransactionList() 
        {
            return new List<String> (transactionList);
        }

        public static void SetName(string _name)
        {
             Name = _name;
        }

        public static void SetSavings(string _savings)
        {
            savingsList.Add(_savings);
        }

        public static List<String> GetSavingsList()
        {
            return new List<String>(savingsList);
        }
    }

    
}
