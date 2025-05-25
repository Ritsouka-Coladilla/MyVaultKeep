using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Functions_DataLogic
{
    public static class TextFileVaultData
    {
        private static readonly string transactionPath = "transaction.json"; // -CHANGE TO .txt IF NEEDED-
        private static readonly string savingsPath = "savings.json"; // -CHANGE TO .txt IF NEEDED-

        public static void SaveTransaction(string transaction)
        {
            SaveItem(transactionPath, transaction);
        }

        public static List<string> LoadTransactions()
        {
            return LoadItems(transactionPath);
        }

        public static void SaveSavings(string savings)
        {
            SaveItem(savingsPath, savings);
        }

        public static List<string> LoadSavings()
        {
            return LoadItems(savingsPath);
        }

        private static void SaveItem(string path, string item)
        {
            var items = LoadItems(path);
            items.Add(item);
            WriteAll(path, items);
        }

        private static List<string> LoadItems(string path)
        {
            if (!File.Exists(path))
                return new List<string>();

            string extension = Path.GetExtension(path).ToLower();
            if (extension == ".json")
            {
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
            }
            else if (extension == ".txt")
            {
                return new List<string>(File.ReadAllLines(path));
            }

            throw new NotSupportedException("Unsupported file extension: " + extension);
        }

        private static void WriteAll(string path, List<string> items)
        {
            string extension = Path.GetExtension(path).ToLower();
            if (extension == ".json")
            {
                string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);
            }
            else if (extension == ".txt")
            {
                File.WriteAllLines(path, items);
            }
            else
            {
                throw new NotSupportedException("Unsupported file extension: " + extension);
            }
        }
    }

}

