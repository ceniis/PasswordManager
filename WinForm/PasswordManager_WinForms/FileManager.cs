using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager_WinForms
{
    public class FileManager
    {
        private static readonly string DataFile = FilePaths.DataFile; // file directory

        public class Data
        {
            public string name { get; set; }
            public string password { get; set; }
        }

        /// <summary>
        /// Save to Data.json file a new order
        /// </summary>
        /// <param name="passwordName"></param>
        /// <param name="password"></param>
        public void SaveToFile(string passwordName, string password)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DataFile)!); // if the directory exist
            List<Data> entries = new();

            if (File.Exists(DataFile))
            {
                string existingJson = File.ReadAllText(DataFile);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    try
                    {
                        entries = JsonConvert.DeserializeObject<List<Data>>(existingJson) ?? new List<Data>();
                    }
                    catch (Exception)
                    {
                        // if the file is corrupted
                        entries = new List<Data>();
                    }
                }
            }

            var existing = entries.FirstOrDefault(e => e.name == passwordName);
            if (existing != null)
            {
                existing.password = password;
            }
            else
            {
                entries.Add(new Data { name = passwordName, password = password });
            }

            string updatedJson = JsonConvert.SerializeObject(entries, Formatting.Indented);
            File.WriteAllText(DataFile, updatedJson);
        }


        /// <summary>
        /// Searches for the password by name
        /// </summary>
        public string? FindEncryptedPassword(string passwordName)
        {
            if (!File.Exists(DataFile)) return null;

            try
            {
                string json = File.ReadAllText(DataFile);
                List<Data>? allPasswords = JsonConvert.DeserializeObject<List<Data>>(json);

                if (allPasswords == null) return null;

                foreach (Data entry in allPasswords)
                {
                    if (entry.name == passwordName)
                        return entry.password;
                }
            }
            catch (IOException ex)
            {
                throw new ApplicationException("Error reading password file.", ex);
            }

            return null;
        }

        /// <summary>
        /// Count orders
        /// </summary>
        /// <returns></returns>

        public static int Counter()
        {
            if (!File.Exists(FilePaths.DataFile)) return 0;

            string json = File.ReadAllText(FilePaths.DataFile);
            var data = JsonConvert.DeserializeObject<List<Data>>(json);
            return data?.Count ?? 0;
        }

    }
}
