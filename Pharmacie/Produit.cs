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
			Boolean resultInsert = Program.dbHandler.executeRequest(insertRequest,listParams);
			return resultInsert;
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


