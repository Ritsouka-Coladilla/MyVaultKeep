﻿using MyVaultCommon;
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
            TextFileVaultData.SaveTransaction(transaction);
        }

        public static List<string> GetTransactionList()
        {
            return TextFileVaultData.LoadTransactions();
        }

        public static void SetName(string _name)
        {
            MyVaultDetails.Name = _name;
        }

        public static void SetSavings(string _savings)
        {
            TextFileVaultData.SaveSavings(_savings);
        }

        public static List<string> GetSavingsList()
        {
            return TextFileVaultData.LoadSavings();
        }
    }
}
    

