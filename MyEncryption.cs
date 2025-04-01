using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManagerDraft
{
    /// <summary>
    /// Class for encrypting passwords
    /// </summary>
    public class MyEncryption
    {
        private readonly byte[] key; // Symmetric encryption key
        private const string DataFile = "Data.txt"; // File storing passwords

        /// <summary>
        /// Constructor: Loads or creates an encryption key
        /// </summary>
        public MyEncryption()
        {
            string keyFilePath = "Key.bin";
            key = File.Exists(keyFilePath) ? LoadKey() : KeyCreator();

            if (key.Length != 32)
                throw new Exception("Invalid AES key length.");
        }

        /// <summary>
        /// Creates and saves a symmetric encryption key to Key.bin
        /// </summary>
        private static byte[] KeyCreator()
        {
            string keyFilePath = "Key.bin";
            byte[] key = new byte[32]; // 256-bit AES key

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(key);
            }

            try
            {
                File.WriteAllBytes(keyFilePath, key);
                File.SetAttributes(keyFilePath, FileAttributes.Hidden | FileAttributes.ReadOnly);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error writing the key.", ex);
            }

            return key;
        }

        /// <summary>
        /// Reads the symmetric encryption key from Key.bin
        /// </summary>
        private static byte[] LoadKey()
        {
            string keyFilePath = "Key.bin";

            if (!File.Exists(keyFilePath))
                throw new FileNotFoundException("Error finding key's file.");

            return File.ReadAllBytes(keyFilePath);
        }

        /// <summary>
        /// Encrypts the password and writes it to Data.txt
        /// </summary>
        public void Encrypt(string passwordName, string password)
        {
            try
            {
                using Aes aes = Aes.Create();
                if (aes == null) throw new Exception("Error creating AES object.");

                aes.Key = key;
                aes.GenerateIV();

                using MemoryStream memoryStream = new();
                using CryptoStream cryptoStream = new(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
                using StreamWriter cryptoWriter = new(cryptoStream);

                cryptoWriter.Write(password);
                cryptoWriter.Flush();
                cryptoStream.FlushFinalBlock(); // Ensure encryption is fully written

                byte[] encryptedData = memoryStream.ToArray();
                string encodedPassword = Convert.ToBase64String(aes.IV) + ":" + Convert.ToBase64String(encryptedData);

                UpdatePasswordFile(passwordName, encodedPassword);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Encoding error.", ex);
            }
        }

        /// <summary>
        /// Decrypts a password from Data.txt
        /// </summary>
        public string? Decrypt(string passwordName)
        {
            try
            {
                string? encryptedEntry = FindEncryptedPassword(passwordName);
                if (encryptedEntry == null) return null;

                string[] parts = encryptedEntry.Split(':');
                if (parts.Length != 2) throw new Exception("Invalid data format.");

                byte[] iv = Convert.FromBase64String(parts[0]);
                byte[] encryptedData = Convert.FromBase64String(parts[1]);

                using Aes aes = Aes.Create();
                if (aes == null) throw new Exception("Error creating AES object.");

                aes.Key = key;
                aes.IV = iv;

                using MemoryStream memoryStream = new(encryptedData);
                using CryptoStream cryptoStream = new(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
                using StreamReader reader = new(cryptoStream);
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Decoding error.", ex);
            }
        }

        /// <summary>
        /// Searches for the encrypted password
        /// </summary>
        private string? FindEncryptedPassword(string passwordName)
        {
            if (!File.Exists(DataFile)) return null;

            string searchPrefix = passwordName + ":";

            try
            {
                foreach (string line in File.ReadLines(DataFile)) // More efficient than ReadAllLines()
                {
                    if (line.StartsWith(searchPrefix))
                        return line.Substring(searchPrefix.Length);
                }
            }
            catch (IOException ex)
            {
                throw new ApplicationException("Error reading password file.", ex);
            }

            return null;
        }

        /// <summary>
        /// Updates or adds the password in Data.txt
        /// </summary>
        private void UpdatePasswordFile(string passwordName, string encodedPassword)
        {
            if (!File.Exists(DataFile))
            {
                File.WriteAllText(DataFile, passwordName + ":" + encodedPassword + Environment.NewLine);
                return;
            }

            string[] lines = File.ReadAllLines(DataFile);
            bool updated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(passwordName + ":"))
                {
                    lines[i] = passwordName + ":" + encodedPassword;
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                File.AppendAllText(DataFile, passwordName + ":" + encodedPassword + Environment.NewLine);
            }
            else
            {
                File.WriteAllLines(DataFile, lines);
            }
        }
    }
}