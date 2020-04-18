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
			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(insertRequest,listParams);
			return resultInsert;
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
			SqlDataReader reader = Program.dbHandler.executeRequest(insertRequest, listParams);
			return readProduitFromSQLReader(reader);
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

		private Boolean readProduitFromSQLReader(SqlDataReader reader)
		{
			reader.Read();
			if (reader == null || !reader.HasRows || reader.GetString(0) == null || reader.GetString(0).Length <= 0)
			{
				reader.Close();
				return false;
			}
			this.RefProduit = reader.GetString(0);
			this.Libelle = reader.GetString(1);
			this.CodeBar = reader.GetString(2);
			//this.Prix = System.Convert.ToDouble(reader.GetFloat(3));
			this.Prix = reader.GetDouble(3);
			reader.Close();
			return true;
		}

	}
}


