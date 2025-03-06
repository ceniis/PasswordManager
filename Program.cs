using System;

namespace PasswordManagerDraft
{
    class Program
    {
        static void Main()
        {
            MyEncryption encryption = new();
            Password passwordGenerator = new();

            while (true)
            {
                Console.WriteLine("\tSelect an action:");
                Console.WriteLine("1 - Generate a password");
                Console.WriteLine("2 - Encrypt and save password");
                Console.WriteLine("3 - Decrypt and display password");
                Console.WriteLine("4 - Exit");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter password name: ");
                        string passwordName = Console.ReadLine();

                        passwordGenerator.name = passwordName;
                        passwordGenerator.Create(include: true, until: 16);
                        Console.WriteLine($"Generated password: {passwordGenerator.password}\n");
                        break;

                    case "2":
                        Console.Write("Enter password name: ");
                        string encryptName = Console.ReadLine();
                        Console.Write("Enter password to encrypt: ");
                        string encryptPassword = Console.ReadLine();

                        encryption.Encrypt(encryptName, encryptPassword);
                        Console.WriteLine("Password encrypted and saved successfully.\n");
                        break;

                    case "3":
                        Console.Write("Enter password name to decrypt: ");
                        string decryptName = Console.ReadLine();
                        string decryptedPassword = encryption.Decrypt(decryptName);

                        if (decryptedPassword != null)
                            Console.WriteLine($"Decrypted password: {decryptedPassword}\n");
                        else
                            Console.WriteLine("Password not found.\n");
                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again.\n");
                        break;
                }
            }
        }
    }
}
