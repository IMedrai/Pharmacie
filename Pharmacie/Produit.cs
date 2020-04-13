using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pharmacie
{
	class Produit
	{
		private String refProduit;
		private int codeBar;
		private Double prix;
		private String libelle;



		public string RefProduit { get => refProduit; set => refProduit = value; }
		public int CodeBar { get => codeBar; set => codeBar = value; }
		public double Prix { get => prix; set => prix = value; }
		public string Libelle { get => libelle; set => libelle = value; }


		public Produit()
		{
		}

		public Produit(string refProduit, int codeBar, double prix, string libelle)
		{
			RefProduit = refProduit;
			CodeBar = codeBar;
			Prix = prix;
			Libelle = libelle;
		}
		public Boolean ajouterProduit()
		{
			return true;
		}

		public Boolean modifierProduit()
		{
			return true;
		}

		public Boolean chercherProduitParRef()
		{
			return true;
		}

		public Boolean chercherProduitParCodeBar()
		{
			return true;
		}
	}
}


