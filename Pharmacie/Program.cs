using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie
{
    static class Program
    {

        public static ADO dbHandler;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dbHandler = new ADO("Data Source = SSR\\SQLEXPRESS; Initial Catalog = Pharmacie; Integrated Security = True");
            Application.Run(new ProduitForm());
        }
    }
}
