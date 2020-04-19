using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Vente
    {
		private string refVente;
		private String nomPrenomclient;
		private string cinClient;
		private string refProduit;
		private string libelleProduit;
		private string modePaiement;
		private string dateVente;
		private Double prixUnitaire;
		private int qnt;
		private double total;



		public Vente()
		{

		}

		public string RefVente { get => refVente; set => refVente = value; }
		public string RefProduit { get => refProduit; set => refProduit = value; }
		public string ModePaiement { get => modePaiement; set => modePaiement = value; }
		public String DateVente { get => dateVente; set => dateVente = value; }
		public double PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }
		public int Qnt { get => qnt; set => qnt = value; }
		public string NomPrenomclient { get => nomPrenomclient; set => nomPrenomclient = value; }
		public double Total { get => total; set => total = value; }

		public string LibelleProduit { get => libelleProduit; set => libelleProduit = value; }

		public string CinClient { get => cinClient; set => cinClient = value; }


		public void updateMySelf(String refVente)
		{
			this.RefVente = refVente;
			this.DateVente = DateTime.Now.ToString();
			updateMySelfWithProduit();
			updateMySelfWithClient();
			this.Total = this.PrixUnitaire * this.Qnt;
		}

		public void updateMySelfWithProduit()
        {
			foreach (Produit prod in Program.listGlobalProduits)
			{
				if (!this.LibelleProduit.Equals(prod.Libelle + " : " + prod.Prix + "Dhs"))
				{
					continue;
				}
				this.RefProduit = prod.RefProduit;
				this.PrixUnitaire = prod.Prix;
			}
        }

		public void updateMySelfWithClient()
		{
			foreach (Client client in Program.listGlobalClients)
			{
				if (!this.NomPrenomclient.Equals(client.Nom + "-" + client.Prenom))
				{
					continue;
				}
				this.cinClient = client.Cin;
			}
		}
    }

}
