using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Stock
    {
		private string refProduit;
		private int quantite;
		

		public string RefPreoduit
		{
			get { return refProduit; }
			set { refProduit = value; }
		}


		public int Quantite
		{
			get { return quantite; }
			set { quantite = value; }
		}


		private Stock()
		{
		}

		private Stock(string refProduit, int quantite)
		{
			this.refProduit = refProduit;
			this.quantite = quantite;
		}
	}
}
