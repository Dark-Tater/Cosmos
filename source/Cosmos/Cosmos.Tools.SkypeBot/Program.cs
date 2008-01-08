﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cosmos.Tools.SkypeBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkypeBot b = new ScribeSkypeBot(SkypeBot.Cosmos_Dev);
            Application.Run(new MainForm());
        }
    }
}
