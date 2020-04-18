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
		private string refProduit;
		private string modePaiement;
		private DateTime dateVente;
		private Double prixUnitaire;
		private int qnt;



		public Vente()
		{

		}

		public string RefVente { get => refVente; set => refVente = value; }
		public string RefProduit { get => refProduit; set => refProduit = value; }
		public string ModePaiement { get => modePaiement; set => modePaiement = value; }
		public DateTime DateVente { get => dateVente; set => dateVente = value; }
		public double PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }
		public int Qnt { get => qnt; set => qnt = value; }
	}

}
