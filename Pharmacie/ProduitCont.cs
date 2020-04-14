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
            if (listeProduits != null && listeProduits.Count > 0)
            {
                foreach(Produit prod in listeProduits)
                {
                    prod.ajouterProduit();
                }
            }
            return true;
        }

        public Boolean chercherProduitsParRef(List<Produit> listeProduitsAChercher)
        {
            return true;
        }

        public Boolean chercherProduitsParCodeBar(List<Produit> listeProduitsAChercher)
        {
            return true;
        }

        public ProduitCont(List<Produit> listProduits)
        {
            this.ListeProduits = listProduits;
        }


    }
}
