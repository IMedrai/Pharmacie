using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pharmacie
{
	class Produit
	{
		private string refProduit;
		private int codeBar;
		private double prix;
		private string libelle;
		


		public string RefProduit
		{
			get { return refProduit; }
			set { refProduit = value; }
		}

		public int CodeBar
		{
			get { return codeBar; }
			set { codeBar = value; }
		}

		public double Prix
		{
			get { return prix; }
			set { prix = value; }
		}

		public string Libelle
		{
			get { return libelle; }
			set { libelle = value; }
		}

		private Produit()
		{
		}

		private Produit(string refProduit, int codeBar, double prix, string libelle)
		{
			this.refProduit = refProduit;
			this.codeBar = codeBar;
			this.prix = prix;
			this.libelle = libelle;
		}


	}
}


