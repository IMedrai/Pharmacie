using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Achat
    {
		private string refProduit;
		private int numeroRC;
		private string typePaiement;



		public string RefProduit
		{
			get { return refProduit; }
			set { refProduit = value; }
		}

		public int NumeroRC
		{
			get { return numeroRC; }
			set { numeroRC = value; }
		}

		

		public string TypePaiement
		{
			get { return typePaiement; }
			set { typePaiement = value; }
		}

		public Achat()
		{
		}

		public Achat (string refProduit, int numeroRC, string typePaiement)
		{
			this.refProduit = refProduit;
			this.numeroRC = numeroRC;
			this.typePaiement = typePaiement;
			
		}
	}
}
