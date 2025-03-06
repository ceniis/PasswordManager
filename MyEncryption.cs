using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO.Pipes;
using System.Data;

namespace PasswordManagerDraft
{
    /// <summary>
    /// Class for encrypting passwords
    /// </summary>
    public class MyEncryption
    {
        private readonly byte[] key; // symmetric encryption key
        private const string DataFile = "Data.txt"; // file with the key

        /// <summary>
        /// Constructor: Loads or creates an encryption key
        /// </summary>
        public MyEncryption()
        {
            string keyFilePath = "Key.bin";
            key = File.Exists(keyFilePath) ? LoadKey() : KeyCreator();
        }

        /// <summary>
        /// Creates and saves a symmetric encryption key to the file Key.bin
        /// </summary>
        /// <returns>The generated key</returns>
        /// <exception cref="ApplicationException">Error writing the key.</exception>
        private static byte[] KeyCreator()
        {
            string keyFilePath = "Key.bin";
            byte[] key = new byte[32]; // 256-bits AES-key

            // generate the key
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
        /// Reads the symmetric encryption key from the file Key.bin
        /// </summary>
        /// <returns>The key</returns>
        /// <exception cref="FileNotFoundException">File error.</exception>
        private static byte[] LoadKey()
        {
            string keyFilePath = "Key.bin";

            if (!File.Exists(keyFilePath))
            {
                throw new FileNotFoundException("Error finding key's file.");
            }

            return File.ReadAllBytes(keyFilePath);
        }

        /// <summary>
        /// Encodes the password and writes it to file Data.txt
        /// </summary>
        /// <param name="passwordName">The password's name</param>
        /// <param name="password">The password to encode</param>
        /// <exception cref="ApplicationException">Encoding error.</exception>
        public void Encrypt(string passwordName, string password)
        {
            try
            {
                using (FileStream fileStream = new("Data.txt", FileMode.OpenOrCreate))
                {
                    using Aes aes = Aes.Create();
                    if (aes == null) throw new Exception("Error creating an AES object.");

                    aes.Key = key;
                    aes.GenerateIV();

                    using MemoryStream memoryStream = new();
                    using CryptoStream cryptoStream = new(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
                    using (StreamWriter cryptoWriter = new(cryptoStream))
                    {
                        cryptoWriter.Write(password);
                    }
                    byte[] encryptedData = memoryStream.ToArray();

                    string encodedPassword = Convert.ToBase64String(aes.IV) + ":" + Convert.ToBase64String(encryptedData);
                    UpdatePasswordFile(passwordName, encodedPassword);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Encoding error.", ex);
            }
        }

        /// <summary>
        /// Decrypts a password from Data.txt
        /// </summary>
        /// <param name="passwordName">Password's name</param>
        /// <returns>Decoded password</returns>
        /// <exception cref="ApplicationException">Decoding error.</exception>
        public string? Decrypt(string passwordName)
        {
            try
            {
                string? encryptedEntry = FindEncryptedPassword(passwordName);
                if (encryptedEntry == null) return null;

                string[] parts = encryptedEntry.Split(':');
                if (parts.Length != 2) throw new Exception("Format error.");

                byte[] iv = Convert.FromBase64String(parts[0]);
                byte[] encryptedData = Convert.FromBase64String(parts[1]);

                using Aes aes = Aes.Create();
                if (aes == null) throw new Exception("AES error.");
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
        /// Search the coded password
        /// </summary>
        private string? FindEncryptedPassword(string passwordName)
        {
            if (!File.Exists(DataFile)) return null;

            string searchPrefix = passwordName + ":";

            foreach (string line in File.ReadAllLines(DataFile))
            {
                if (line.StartsWith(searchPrefix))
                    return line.Substring(searchPrefix.Length);
            }

            return null;
        }

        /// <summary>
        /// Adds the password to the file
        /// </summary>
        private void UpdatePasswordFile(string passwordName, string encodedPassword)
        {
            string[] lines = File.Exists(DataFile) ? File.ReadAllLines(DataFile) : Array.Empty<string>();
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
                using StreamWriter cryptoWriter = new(DataFile, append: true);
                cryptoWriter.WriteLine(passwordName + ":" + encodedPassword);
            }
            else
            {
                File.WriteAllLines(DataFile, lines);
            }
        }
    }
}