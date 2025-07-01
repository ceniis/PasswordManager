using System.Text.Json;
using PasswordManagerDraft;

namespace PasswordManager_WinForms
{
    public class FileManager
    {
        private static readonly string DataFile = FilePaths.DataFile; // file directory

        public void SavePassword(Password password)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DataFile)!); // if the directory exist
            List<Password> entries = new List<Password>();

            if (File.Exists(DataFile))
            {
                var json = File.ReadAllText(DataFile);
                if (!string.IsNullOrWhiteSpace(json))
                    entries = JsonSerializer.Deserialize<List<Password>>(json) ?? new List<Password>();
            }

            entries.Add(password);
            string updatedJson = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(DataFile, updatedJson);
        }

        public void SavePasswords(List<Password> passwords)
        {
            string json = JsonSerializer.Serialize(passwords, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(DataFile, json);
        }

        /// <summary>
        /// Return all records
        /// </summary>
        public List<Password> ReadPasswords()
        {
            if (!File.Exists(DataFile))
                return new List<Password>();

            var json = File.ReadAllText(DataFile);
            if (string.IsNullOrWhiteSpace(json))
                return new List<Password>();

            return JsonSerializer.Deserialize<List<Password>>(json) ?? new List<Password>();
        }
    }
}