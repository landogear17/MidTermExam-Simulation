﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermExam_Simulation
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
            //Form form1 = new Form1();
            //form1.Show();
            //Application.Run();
            Application.Run(new Form1());
            //Application.Run(new OrderBook());
        }
    }
}
