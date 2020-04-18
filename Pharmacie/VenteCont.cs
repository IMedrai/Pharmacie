using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class VenteCont
    {
		private string refVente;
		private string libelleProduit;
		private String nomPrenomClient;
		private string modePaiement;
		private DateTime dateVente;
		private Double prixUnitaire;
		private Double total;
		private int qnt;



		public string RefVente
		{
			get { return refVente; }
			set { refVente = value; }
		}
		public string LibelleProduit
		{
			get { return libelleProduit; }
			set { libelleProduit = value; }
		}

		public string ModePaiement
		{
			get { return modePaiement; }
			set { modePaiement = value; }

		}

		public DateTime DateVente
		{
			get { return dateVente; }
			set { dateVente = value; }

		}

		public double PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }
		public double Total { get => total; set => total = value; }
		public int Qnt { get => qnt; set => qnt = value; }
		public string NomPrenomClient { get => nomPrenomClient; set => nomPrenomClient = value; }

		public VenteCont()
		{

		}
	}
}
