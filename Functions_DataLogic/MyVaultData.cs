using MyVaultCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Functions_DataLogic
{
    public static class MyVaultData
    {
        public static void SetTransaction(string transaction)
        {
            FileVaultData.SaveTransaction(transaction);
        }

        public static List<string> GetTransactionList()
        {
            return FileVaultData.LoadTransactions();
        }

        public static bool DeleteSavings(string name)
        {
            return FileVaultData.DeleteSavingsDB(name);
        }

        public static bool UpdateSavings(string oldName, string newName, double amount)
        {
            return FileVaultData.UpdateSavingsDB(oldName, newName, amount);
        }

        public static void SetSavings(string _savings)
        {
            FileVaultData.SaveSavings(_savings);
        }

        public static List<string> GetSavingsList()
        {
            return FileVaultData.LoadSavings();
        }
    }
}
    

