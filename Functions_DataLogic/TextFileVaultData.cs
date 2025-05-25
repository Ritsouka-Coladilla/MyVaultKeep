using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_DataLogic
{
    public class TextFileVaultData
    {
        string filePath = "textFileVault.txt";

        public TextFileVaultData()
        {
            GetDataFromFile();
        }

        private void GetDataFromFile()
        {
            var txtData = File.ReadAllText(filePath);
            
        }

    }
}
