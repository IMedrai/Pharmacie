using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void rechercheProduitDispo()
        {
            
            this.ListeProduits = Program.listGlobalProduits;

        }

        public void rechercheProduitDispoFromDB()
        {
            String selectQuery = "select refProduit,libelleProduit,codebarreProduit,prixProduit from produit";
            List<SqlParameter> listParams = new List<SqlParameter>();
            getProduitsFromDict(Program.dbHandler.executeRequest(selectQuery, listParams));
        }

        private void getProduitsFromDict(List<Dictionary<String, Object>> listResults)
        {
            this.ListeProduits = new List<Produit>();
            if (listResults != null && listResults.Count > 0)
            {
                foreach (Dictionary<String, Object> element in listResults)
                {
                    Produit prod = new Produit();
                    prod.readProduitFromDictionnary(element);
                    this.ListeProduits.Add(prod);
                }
            }
            
        }

        public List<String> getLibellesProduit()
        {
            if (this.ListeProduits == null || this.ListeProduits.Count < 0)
            {
                return null;
            }
            List<String> ListLibellesProduit = new List<string>();
            foreach (Produit prod in this.ListeProduits)
            {
                ListLibellesProduit.Add(prod.Libelle+" : "+prod.Prix+"Dhs");
            }
            return ListLibellesProduit;
        }

        public ProduitCont(List<Produit> listProduits)
        {
            this.ListeProduits = listProduits;
        }

        public ProduitCont()
        {

        }


    }
}
