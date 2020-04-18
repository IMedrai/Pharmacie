using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class ProduitCont
    {
        private List<Produit> listeProduits;

        internal List<Produit> ListeProduits { get => listeProduits; set => listeProduits = value; }

        public Boolean ajouterOuModifierProduits()
        {
            if (listeProduits != null && listeProduits.Count > 0) // && prod.refProduit.listProduits.count=1)
            {
                foreach(Produit prod in listeProduits)
                {
                    Produit prodRecherche = new Produit();
                    prodRecherche.RefProduit = prod.RefProduit;
                    Boolean exist = prodRecherche.chercherProduitParRef();
                    if (exist)
                    {
                        prod.modifierProduit();
                    }
                    else
                    {
                        prod.ajouterProduit();
                    }
                }
            }
            return true;
        }

        public ProduitCont(List<Produit> listProduits)
        {
            this.ListeProduits = listProduits;
        }


    }
}
