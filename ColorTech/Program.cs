﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ColorTech
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
            //Application.Run(new frm_batchSheet());
            Application.Run(new frm_welcome());
        }
    }
}
