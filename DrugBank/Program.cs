using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tiraggo.Interfaces;
using Tiraggo.Loader;

namespace DrugBank
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Tiraggo.Interfaces.tgProviderFactory.Factory = new Tiraggo.Loader.tgDataProviderFactory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Tiraggo.Interfaces.tgProviderFactory.Factory = new Tiraggo.Loader.tgDataProviderFactory();
            Application.Run(new Form1());            
        }
    }
}
