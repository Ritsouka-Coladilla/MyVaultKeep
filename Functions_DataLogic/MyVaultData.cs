using MyVaultCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_DataLogic
{
    public static class MyVaultData
    {

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
             MyVaultDetails.Name = _name;
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
