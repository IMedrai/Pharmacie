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
        public static ModePaiementCont modePaiementCont;
        public static List<Produit> listGlobalProduits;
        public static List<Client> listGlobalClients;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            modePaiementCont = new ModePaiementCont();
            dbHandler = new ADO("Data Source = SSR\\SQLEXPRESS; Initial Catalog = Pharmacie; Integrated Security = True");
            ProduitCont prodCont = new ProduitCont();
            prodCont.rechercheProduitDispoFromDB();
            Program.listGlobalProduits = prodCont.ListeProduits;
            ClientCont clientCont = new ClientCont();
            clientCont.rechercherTousClientFromDB();
            Program.listGlobalClients = clientCont.ListClients;
            //Console.WriteLine("cccc "+Program.listGlobalProduits.Count);
            Application.Run(new IndexForm());
        }
    }
}
