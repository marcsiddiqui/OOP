﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BankAccount bankAccount = new BankAccount();
            bankAccount.SetTitle("Muhammad Arsalan");
            bankAccount.SetType("Current");


            Application.Run(new Form1());
        }
    }
}
