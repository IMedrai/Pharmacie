using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Vente
    {
		private static readonly String CIN_CLIENT_ATTR = "cin";
		private static readonly String REF_PRODUIT_ATTR = "refProduit";
		private static readonly String LIBELLE_PRODUIT_ATTR = "libelleProduit";
		private static readonly String PRIX_PRODUIT_ATTR = "prixProduit";
		private static readonly String NOM_PRENOM_CLIENT_ATTR = "nomPrenom";
		private static readonly String DATE_VENTE_ATTR = "dateVente";
		private static readonly String REF_VENTE_ATTR = "refVente";
		private static readonly String MODE_P_VENTE_ATTR = "modePaiement";
		private static readonly String TOTAL_VENTE_ATTR = "total";
		private static readonly String QNT_VENTE_ATTR = "qnt";


		private string refVente;
		private String nomPrenomclient;
		private string cinClient;
		private string refProduit;
		private string libelleProduit;
		private string modePaiement;
		private string dateVente;
		private Double prixUnitaire;
		private int qnt;
		private double total;

		public Boolean readVenteFromDictionnary(Dictionary<String, Object> element)
		{
			Object obj = null;
			element.TryGetValue(REF_PRODUIT_ATTR, out obj);
			this.RefProduit = (String)obj;

			obj = null;
			element.TryGetValue(LIBELLE_PRODUIT_ATTR, out obj);
			this.LibelleProduit = (String)obj;

			obj = null;
			element.TryGetValue(PRIX_PRODUIT_ATTR, out obj);
			this.PrixUnitaire = (Double)obj;

			obj = null;
			element.TryGetValue(CIN_CLIENT_ATTR, out obj);
			this.CinClient = (String)obj;

			obj = null;
			element.TryGetValue(NOM_PRENOM_CLIENT_ATTR, out obj);
			this.NomPrenomclient = (String)obj;

			obj = null;
			element.TryGetValue(DATE_VENTE_ATTR, out obj);
			this.DateVente = (String)obj;

			obj = null;
			element.TryGetValue(REF_VENTE_ATTR, out obj);
			this.RefVente = (String)obj;

			obj = null;
			element.TryGetValue(MODE_P_VENTE_ATTR, out obj);
			this.ModePaiement = (String)obj;

			obj = null;
			element.TryGetValue(QNT_VENTE_ATTR, out obj);
			this.Qnt = (int)obj;

			obj = null;
			element.TryGetValue(TOTAL_VENTE_ATTR, out obj);
			this.Total = (Double)obj;

			return true;
		}


		public Boolean ajouterVente()
        {
			String insertQuery = "insert into vente (refVente,refProduit,cinClient,qnt,dateVente,total,modePaiement) values (@refVente,@refProduit,@cinClient,@qnt,@dateVente,@total,@modePaiement)";
			List<SqlParameter> listParams = new List<SqlParameter>();

			SqlParameter param = new SqlParameter();
			param.ParameterName = "@cinClient";
			param.Value = this.CinClient;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@refVente";
			param.Value = this.RefVente;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@refProduit";
			param.Value = this.RefProduit;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@qnt";
			param.Value = this.Qnt;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@total";
			param.Value = this.Total;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@modePaiement";
			param.Value = this.ModePaiement;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@dateVente";
			param.Value = this.DateVente;
			listParams.Add(param);

			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(insertQuery, listParams);
			return resultInsert;
		}

        public Boolean updateStock()
        {
			String updateQuery = "update stock set qnt = qnt - @qnt where refProduit = @refProduit";

			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param = new SqlParameter();
			param.ParameterName = "@refProduit";
			param.Value = this.RefProduit;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@qnt";
			param.Value = this.Qnt;
			listParams.Add(param);

			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(updateQuery, listParams);
			return resultInsert;
		}

        public Vente()
		{

		}

		public string RefVente { get => refVente; set => refVente = value; }
		public string RefProduit { get => refProduit; set => refProduit = value; }
		public string ModePaiement { get => modePaiement; set => modePaiement = value; }
		public String DateVente { get => dateVente; set => dateVente = value; }
		public double PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }
		public int Qnt { get => qnt; set => qnt = value; }
		public string NomPrenomclient { get => nomPrenomclient; set => nomPrenomclient = value; }
		public double Total { get => total; set => total = value; }

		public string LibelleProduit { get => libelleProduit; set => libelleProduit = value; }

		public string CinClient { get => cinClient; set => cinClient = value; }


		public void updateMySelf(String refVente)
		{
			this.RefVente = refVente;
			this.DateVente = DateTime.Now.ToString();
			updateMySelfWithProduit();
			updateMySelfWithClient();
			this.Total = this.PrixUnitaire * this.Qnt;
		}

		public void updateMySelfWithProduit()
        {
			foreach (Produit prod in Program.listGlobalProduits)
			{
				if (!this.LibelleProduit.Equals(prod.Libelle + " : " + prod.Prix + "Dhs"))
				{
					continue;
				}
				this.RefProduit = prod.RefProduit;
				this.PrixUnitaire = prod.Prix;
			}
        }

		public void updateMySelfWithClient()
		{
			foreach (Client client in Program.listGlobalClients)
			{
				if (!this.NomPrenomclient.Equals(client.Nom + "-" + client.Prenom))
				{
					continue;
				}
				this.cinClient = client.Cin;
			}
		}
    }

}
