﻿namespace PasswordManager_WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new();

            if (loginForm.ShowDialog() == DialogResult.OK) 
            {
                Application.Run(new MainForm()); 
            }
        }
    }
}