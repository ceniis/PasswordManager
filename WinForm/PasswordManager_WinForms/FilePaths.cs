using System;
using System.IO;

namespace PasswordManager_WinForms
{
    public static class FilePaths
    {
        public static readonly string BaseDirectory = Path.Combine(
           Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
           "PasswordManager"
       );

        public static readonly string DataFile = Path.Combine(BaseDirectory, "Data.json");
        public static readonly string LoginPasswordFile = Path.Combine(BaseDirectory, "LoginPassword.json");
        public static readonly string KeyFile = Path.Combine(BaseDirectory, "Key.bin");

        static FilePaths()
        {
            if (!Directory.Exists(BaseDirectory))
                Directory.CreateDirectory(BaseDirectory);
        }
    }
}
