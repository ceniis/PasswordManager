using System;
using System.IO;
using NUnit.Framework;
using PasswordManagerDraft;
using PasswordManager_WinForms;
using System.Linq;

namespace TestProject_PasswordManager
{
    public class Tests
    {
        public class MyEncryptionTests
        {
            private MyEncryption encryption = new MyEncryption();
            private Password password = new Password();

            [Test]
            public void EncryptDecrypt_ShouldReturnOriginalPassword()
            {
                password.name = "TestPassword";
                password.password = "MySecurePassword123!";           
                string encrypted = encryption.Encrypt(password.password);
                Password test = new Password();
                test.name = "TestPassword1";
                test.password = encrypted;
                string decrypted = encryption.Decrypt(test);

                Assert.AreEqual(password.password, decrypted);
            }

            [Test]
            public void Encrypt_ShouldReturnNonEmptyString()
            {
                string encrypted = encryption.Encrypt("test");
                Assert.IsFalse(string.IsNullOrEmpty(encrypted));
            }
        }

        public class PasswordTests
        {
            private Password password = new Password();

            [Test]
            public void Create_ShouldGeneratePassword_OfExpectedLength()
            {
                password.Create(true, 16);
                Assert.AreEqual(16, password.password.Length);
            }

            [Test]
            public void Create_ShouldContainSpecialSymbols_IfRequested()
            {
                password.Create(true, 20);
                Assert.IsTrue(password.password.Any(c => "!@#$%^&*()_+-=[]{}|;:',.<>?/№".Contains(c)));
            }

            [Test]
            public void Create_ShouldNotContainSpecialSymbols_IfExcluded()
            {
                password.Create(false, 20);
                Assert.IsFalse(password.password.Any(c => "!@#$%^&*()_+-=[]{}|;:',.<>?/№".Contains(c)));
            }

            [Test]
            public void Create_TooShortPassword_ShouldThrow()
            {
                var ex = Assert.Throws<ArgumentException>(() => password.Create(true, 8));
                Assert.That(ex.Message, Does.Contain("at least 12"));
            }
        }
    }
}