using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.CodeDom.Compiler;
using System.Globalization;

namespace PasswordManagerDraft
{
    /// <summary>
    /// Public class for creating strong and save passwords
    /// </summary>
    public class Password
    {
        // fluids
        public string name { get; set; } // the name of the password
        public string password { get; set; } // the password
        public string login { get; set; } // user's login (optional)
        private readonly string specialSymbols = "!@#$%^&*()_+-=[]{}|;:',.<>?/№";
        private readonly string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        private int PasswordIndex = 0; // password char's index
        private char[] draft { get; set; } // chars' container

        public override bool Equals(object? obj)
        {
            if (obj is Password other)
            {
                return this.name == other.name && this.password == other.password && this.login == other.login;
            }

            return false;
        }

        /// <summary>
        /// Generates a random number, copies it to class
        /// </summary>
        private void Generate()
        {
            Span<byte> numbers = stackalloc byte[1]; // Stack buffer
            RandomNumberGenerator.Fill(numbers);
            draft[PasswordIndex] = (char)(numbers[0] % 10 + '0');
            IncrementIndex();
        }

        /// <summary>
        /// Generates a random special symbol, copies it to class
        /// </summary>
        private void Generate(string readonlyString)
        {
            byte[] randomNumber = new byte[1];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }

            int index = randomNumber[0] % readonlyString.Length; // random char's index
            draft[PasswordIndex] = readonlyString[index]; // copy to class
            IncrementIndex();
        }

        /// <summary>
        /// Password index counter
        /// </summary>
        /// <returns>Index + 1</returns>
        public int IncrementIndex()
        {
            return ++PasswordIndex;
        }

        /// <summary>
        /// Shaffles the chars in the password
        /// </summary>
        /// <param name="draft">An array of chars</param>
        /// <returns>Created password</returns>
        private string Shuffle(char[] draft)
        {
            Random random = new Random();

            // Fisher-Yates algorithm
            for (int i = draft.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (draft[i], draft[j]) = (draft[j], draft[i]);
            }

            return new string(draft);
        }

        /// <summary>
        /// Creates a password
        /// </summary>
        /// <param name="include">If special symbols are included</param>
        /// <param name="until">The length of the password</param>
        public void Create(bool include = true, int until = 14)
        {
            if (until < 12)
                throw new ArgumentException("Password length must be at least 12 characters.");

            draft = new char[until];
            PasswordIndex = 0;
            int letters, numbers, symbols = 0;

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                letters = RandomNumberGenerator.GetInt32(1, until - 2);
                numbers = RandomNumberGenerator.GetInt32(1, until - letters - 1);

                if (include) // if special symbols are included
                {
                    symbols = until - letters - numbers; 
                }
                else
                {
                    letters += until - letters - numbers;
                }
            }

            // generate characters
            for (int i = 0; i < symbols; i++)
            {
                Generate(specialSymbols);
            }

            for (int i = 0; i < numbers; i++)
            {
                Generate();
            }

            for (int i = 0; i < letters; i++)
            {
                Generate(alphabet);
            }

            password = Shuffle(draft);
        }
    }
}