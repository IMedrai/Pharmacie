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
		private string modePayement;

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

		public string ModePayement
		{
			get { return modePayement; }
			set { modePayement = value; }

		}

		private Vente()
		{

		}
		private Vente(string refVente, string refProduit, string cin, string modePayement)
		{
			this.refVente = refVente;
			this.refProduit = refProduit;
			this.cin = cin;
			this.modePayement = modePayement;
		}

	}

}
