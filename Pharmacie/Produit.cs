using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pharmacie
{
	class Produit
	{
		private String refProduit;
		private String codeBar;
		private Double prix;
		private String libelle;

		private static readonly String REF_PROD_DB = "refProduit";
		private static readonly String LIBELLE_PROD_DB = "libelleProduit";
		private static readonly String CODE_BARRE_PROD_DB = "codebarreProduit";
		private static readonly String PRIX_PROD_DB = "prixProduit";



		public string RefProduit { get => refProduit; set => refProduit = value; }
		public String CodeBar { get => codeBar; set => codeBar = value; }
		public double Prix { get => prix; set => prix = value; }
		public string Libelle { get => libelle; set => libelle = value; }


		public Produit()
		{
		}

		public Produit(string refProduit, String codeBar, double prix, string libelle)
		{
			RefProduit = refProduit;
			CodeBar = codeBar;
			Prix = prix;
			Libelle = libelle;
		}
		public Boolean ajouterProduit()
		{
			String insertRequest = "Insert into produit(refProduit,libelleProduit,codebarreProduit,prixProduit) values (@refProduit,@libelleProduit,@codebarreProduit,@prixProduit)";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@refProduit";
			param.Value = this.refProduit;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@libelleProduit";
			param.Value = this.libelle;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@codebarreProduit";
			param.Value = this.codeBar;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@prixProduit";
			param.Value = this.prix;
			listParams.Add(param);
			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(insertRequest,listParams);
			return resultInsert;
		}

		public void updateMySelf(Produit otherProd)
		{
			this.Libelle = otherProd.Libelle;
			this.Prix = otherProd.Prix;
			this.CodeBar = otherProd.CodeBar;
		}

		public Boolean modifierProduit()
		{
			String updateRequest = "update produit set libelleProduit = @libelleProduit,codebarreProduit = @codebarreProduit,prixProduit = @prixProduit where refProduit  = @refProduit";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@refProduit";
			param.Value = this.refProduit;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@libelleProduit";
			param.Value = this.libelle;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@codebarreProduit";
			param.Value = this.codeBar;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@prixProduit";
			param.Value = this.prix;
			listParams.Add(param);
			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(updateRequest, listParams);
			return resultInsert;
		}

		public Boolean chercherProduitParRef()
		{
			String insertRequest = "select refProduit,libelleProduit,codebarreProduit,prixProduit from produit where refProduit = @refProduit";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@refProduit";
			param.Value = this.refProduit;
			listParams.Add(param);
			List<Dictionary<String,Object>> listResults = Program.dbHandler.executeRequest(insertRequest, listParams);
			if (listResults == null || listResults.Count <= 0)
			{
				return false;
			}
			return readProduitFromDictionnary(listResults[0]);
		}

		public Boolean chercherProduitParCodeBar()
		{
			return true;
		}

		public Boolean isEmpty()
		{
			Boolean isEmpty = true;
			if (this.RefProduit != null && this.RefProduit.Length > 0)
			{
				isEmpty = false;
			}
			return isEmpty;
		}

		public Boolean readProduitFromDictionnary(Dictionary<String, Object> element)
		{
			Object obj = null;
			element.TryGetValue(REF_PROD_DB, out obj);
			this.RefProduit = (String)obj;

			obj = null;
			element.TryGetValue(LIBELLE_PROD_DB, out obj);
			this.Libelle = (String)obj;

			obj = null;
			element.TryGetValue(CODE_BARRE_PROD_DB, out obj);
			this.CodeBar = (String)obj;

			obj = null;
			element.TryGetValue(PRIX_PROD_DB, out obj);
			this.Prix = (Double)obj;
			
			return true;
		}

		public override bool Equals(Object otherProd)
		{
			return this.RefProduit.Equals(((Produit)otherProd).RefProduit);
		}


	}
}


