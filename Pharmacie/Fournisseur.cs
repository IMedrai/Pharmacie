using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Fournisseur
    {

		private int numeroRC;
		private string raisonSociale;

		public int NumeroRC { get => numeroRC; set => numeroRC = value; }
		public string RaisonSociale { get => raisonSociale; set => raisonSociale = value; }

		public Fournisseur()
		{
		}

		public Fournisseur(int numeroRC, string raisonSociale)
		{
			NumeroRC = numeroRC;
			RaisonSociale = raisonSociale;
		}

		public Boolean ajouterFournisseur()
		{
			return true;
		}

		public Boolean modifierFournisseur()
		{
			return true;
		}

		public Boolean chercherFournisseurParRC()
		{
			return true;
		}

		public Boolean chercherFournisseurParRS()
		{
			return true;
		}




	}
}
