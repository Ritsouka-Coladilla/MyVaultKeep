using Microsoft.Data.SqlClient;
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
        private static readonly string connectionString =
            "Server=DESKTOP-P1UNBNT\\SQLEXPRESS;Database=MyVaultDB;Trusted_Connection=True;TrustServerCertificate=True;";
        //private static readonly string transactionPath = "transaction.json"; // -Change the file type to .txt or .json if needed-
        //private static readonly string savingsPath = "savings.json"; // -Change the file type to .txt or .json if needed-

        public static void SaveTransaction(string transaction)
        {
            SaveTransactionToDatabase(transaction);
           // SaveItem(transactionPath, transaction);
        }

        public static List<string> LoadTransactions()
        {
            return LoadTransactionsFromDatabase();
            //return LoadItems(transactionPath);
        }

        public static void SaveSavings(string savings)
        {
            SaveSavingsToDatabase(savings);    
            //SaveItem(savingsPath, savings);
        }

        public static List<string> LoadSavings()
        {
            return LoadSavingsFromDatabase();
            //return LoadItems(savingsPath);
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

        private static void SaveTransactionToDatabase(string transaction)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Transactions (Description, CreatedAt) VALUES (@Description, @CreatedAt)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Description", transaction);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static List<string> LoadTransactionsFromDatabase()
        {
            var transactions = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Description FROM Transactions ORDER BY CreatedAt";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(reader.GetString(0));
                    }
                }
            }
            return transactions;
        }

        private static void SaveSavingsToDatabase(string savings)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Savings (Description, CreatedAt) VALUES (@Description, @CreatedAt)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Description", savings);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static List<string> LoadSavingsFromDatabase()
        {
            var savings = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Description FROM Savings ORDER BY CreatedAt";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        savings.Add(reader.GetString(0));
                    }
                }
            }
            return savings;
        }

        public static bool DeleteSavings(string name)
        {
            var savingsList = LoadSavings();
            var updatedList = savingsList.Where(s => !s.StartsWith(name + " PHP:")).ToList();

            if (savingsList.Count == updatedList.Count)
                return false;

            WriteSavings(updatedList);
            return true;
        }

        public static bool UpdateSavings(string oldName, string newName, double newAmount)
        {
            var savingsList = LoadSavings();
            bool found = false;

            for (int i = 0; i < savingsList.Count; i++)
            {
                if (savingsList[i].StartsWith(oldName + " PHP:"))
                {
                    savingsList[i] = newName + " PHP: " + newAmount;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                WriteSavings(savingsList);
            }

            return found;
        }

        private static void WriteSavings(List<string> updatedList)
        {
           
            string path = "savings.json"; 
            File.WriteAllText(path, JsonSerializer.Serialize(updatedList, new JsonSerializerOptions { WriteIndented = true }));

        }
    }
}
    



