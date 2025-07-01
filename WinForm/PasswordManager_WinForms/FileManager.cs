using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using PasswordManagerDraft;
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

        /// <summary>
        /// Save to Data.json file a new record
        /// </summary>
        /// <param name="passwordName"></param>
        /// <param name="password"></param>
        public void SaveToFile(string passwordName, string passwordLogin, string password)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DataFile)!); // if the directory exist
            List<Password> entries = new();

            if (File.Exists(DataFile))
            {
                string existingJson = File.ReadAllText(DataFile);

                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    try
                    {
                        entries = JsonConvert.DeserializeObject<List<Password>>(existingJson) ?? new List<Password>();
                    }
                    catch (Exception)
                    {
                        // if the file is corrupted
                        entries = new List<Password>();
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
                entries.Add(new Password { name = passwordName, password = password, login = passwordLogin });
            }

            string updatedJson = JsonConvert.SerializeObject(entries, Formatting.Indented);
            File.WriteAllText(DataFile, updatedJson);
        }


        /// <summary>
        /// Searches for the password by name
        /// </summary>
        public Password? FindEncryptedPassword(string passwordName)
        {
            if (!File.Exists(DataFile)) return null;

            try
            {
                string json = File.ReadAllText(DataFile);
                var allPasswords = AllEncryptedPasswords();

                if (allPasswords == null) return null;

                foreach (Password entry in allPasswords)
                {  
                    if (entry.name == passwordName)
                        return entry;
                }
            }
            catch (IOException ex)
            {
                throw new ApplicationException("Error reading password file.", ex);
            }

            return null;
        }

        /// <summary>
        /// Return all records
        /// </summary>
        public List<Password>? AllEncryptedPasswords()
        {
            if (!File.Exists(DataFile)) return null;

            try
            {
                string json = File.ReadAllText(DataFile);
                return JsonConvert.DeserializeObject<List<Password>>(json);
            }
            catch (IOException ex)
            {
                throw new ApplicationException("Error reading password file.", ex);
            }
        }

        /// <summary>
        /// Count records
        /// </summary>
        /// <returns>Amount of records in the file</returns>
        public static int Counter()
        {
            if (!File.Exists(FilePaths.DataFile)) return 0;

            string json = File.ReadAllText(FilePaths.DataFile);
            var data = JsonConvert.DeserializeObject<List<Password>>(json);
            return data?.Count ?? 0;
        }
    }
}