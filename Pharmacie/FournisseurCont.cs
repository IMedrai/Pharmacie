using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class FournisseurCont
    {
        private List<Fournisseur> listeFournisseur;

		internal List<Fournisseur> ListFournisseurs { get => listeFournisseur; set => listeFournisseur = value; }


		public Boolean ajouterFournisseur()
		{
			if (!frs.NumeroRC.Equals(frsAdd.NumeroRC)) // if (listeFournisseur != null && listeFournisseur.Count > 0)
			{
				foreach (Fournisseur frs in ListFournisseurs)
				{
					frs.ajouterFournisseur();
				}
			}
			return true;
		}

		public Boolean modifierFournisseur(List<Fournisseur> listeFournisseurAmodifier)
		{
			if (listeFournisseur != null && listeFournisseur.Count > 0) // nous n'avons rien
			{
				foreach (Fournisseur frs in ListFournisseurs)
				{
					frs.modifierFournisseur();
				}
			}


			return true;
		}

		public Boolean chercherFournisseurParRC(List<Fournisseur> ListechercherFournisseurParRC)
		{
			return true;
		}

		public Boolean chercherFournisseurParRS(List<Fournisseur> ListechercherFournisseurParRS)
		{
			return true;
		}
		public FournisseurCont(List<Fournisseur> listFournisseurs)
		{
			this.ListFournisseurs = listeFournisseur;
		}

	}
}
