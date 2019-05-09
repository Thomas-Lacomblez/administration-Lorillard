using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace ppe_lorillard
{
    static class Program
    {
        public static string MonServeur = "localhost";
        public static string MaBDD = "administrationlorillard";
        public static string MonId = "admin";
        public static string MonMdp = "lorillard";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
