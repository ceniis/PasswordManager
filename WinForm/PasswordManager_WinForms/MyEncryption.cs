using PasswordManager_WinForms;
using System.Security.Cryptography;

namespace PasswordManagerDraft
{
    /// <summary>
    /// Class for encrypting passwords
    /// </summary>
    public class MyEncryption
    {
        private readonly byte[] key; // Symmetric encryption key
        string keyFilePath = FilePaths.KeyFile;

        /// <summary>
        /// Constructor: Loads or creates an encryption key
        /// </summary>
        public MyEncryption()
        {
            key = File.Exists(keyFilePath) ? LoadKey() : KeyCreator();

            if (key.Length != 32)
                throw new Exception("Invalid AES key length.");
        }

        /// <summary>
        /// Creates and saves a symmetric encryption key to Key.bin
        /// </summary>
        private static byte[] KeyCreator()
        {
            string keyFilePath = FilePaths.KeyFile;
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
            string keyFilePath = FilePaths.KeyFile;

            if (!File.Exists(keyFilePath))
                throw new FileNotFoundException("Error finding key's file.");

            return File.ReadAllBytes(keyFilePath);
        }

        /// <summary>
        /// Encrypts the password
        /// </summary>
        public string Encrypt(string password)
        {
            try
            {
                using Aes aes = Aes.Create();
                if (aes == null) throw new Exception("Error creating AES object.");

                aes.Key = key;
                aes.GenerateIV();

                using MemoryStream memoryStream = new();
                using (CryptoStream cryptoStream = new(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                using (StreamWriter writer = new(cryptoStream))
                {
                    writer.Write(password);
                }

                byte[] encryptedData = memoryStream.ToArray();
                return $"{Convert.ToBase64String(aes.IV)}:{Convert.ToBase64String(encryptedData)}";
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Encoding error.", ex);
            }
        }

        /// <summary>
        /// Decrypts a password
        /// </summary>
        public string? Decrypt(Password encryptedPassword)
        {
            try
            {
                string[] parts = encryptedPassword.password.Split(':');

                if (parts.Length != 2)
                    throw new FormatException("Invalid encrypted password format.");

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
    }
}