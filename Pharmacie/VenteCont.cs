using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class VenteCont
    {

		private List<Vente> listVente;



		public VenteCont()
		{

		}

		internal List<Vente> ListVente { get => listVente; set => listVente = value; }

		public Boolean ApplyVenteAndUpdateStock()
		{
			foreach (Vente vente in this.ListVente)
			{
				if (vente.ajouterVente())
				{
					vente.updateStock();
				}
			}
			return true;
		}

        public void rechercheToutesVente()
        {
			String selectQuery = "select p.refProduit,p.libelleProduit,p.prixProduit,c.cin,c.nom +' '+c.prenom as 'nomPrenom',v.dateVente,v.refVente,v.modePaiement,v.total,v.qnt from produit p, client c, vente v where p.refProduit = v.refProduit and v.cinClient = c.cin";
			List<SqlParameter> listParams = new List<SqlParameter>();
			getVentesFromDict(Program.dbHandler.executeRequest(selectQuery, listParams));
		}

		private void getVentesFromDict(List<Dictionary<String, Object>> listResults)
		{
			this.ListVente = new List<Vente>();
			if (listResults != null && listResults.Count > 0)
			{
				foreach (Dictionary<String, Object> element in listResults)
				{
					Vente vente = new Vente();
					vente.readVenteFromDictionnary(element);
					this.ListVente.Add(vente);
				}
			}

		}

		
	}
}
