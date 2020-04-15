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
		private string cin;
		private string modePaiement;

		public string RefVente
		{
			get { return refVente; }
			set { refVente = value; }
		}
		public string RefProduit
		{
			get { return refProduit; }
			set { refProduit = value; }
		}

		public string Cin
		{
			get { return cin; }
			set { cin = value; }
		}

		public string ModePaiement
		{
			get { return modePaiement; }
			set { modePaiement = value; }

		}

		public Vente()
		{

		}
		public Vente(string refVente, string refProduit, string cin, string modePaiement)
		{
			this.refVente = refVente;
			this.refProduit = refProduit;
			this.cin = cin;
			this.modePaiement = modePaiement;
		}

	}

}
