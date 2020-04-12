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
		private string typePayement;



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

		

		public string TypePayement
		{
			get { return typePayement; }
			set { typePayement = value; }
		}

		private Achat()
		{
		}

		private Achat (string refProduit, int numeroRC, string typePayement)
		{
			this.refProduit = refProduit;
			this.numeroRC = numeroRC;
			this.typePayement = typePayement;
			
		}
	}
}
