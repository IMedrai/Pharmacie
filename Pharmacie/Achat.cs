using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Achat
    {
		private string refProduit;
		private int numeroRC;
		private string typePaiement;



		public string RefProduit
		{
			get { return refProduit; }
			set { refProduit = value; }
		}

		public int NumeroRC
		{
			get { return numeroRC; }
			set { numeroRC = value; }
		}

		

		public string TypePaiement
		{
			get { return typePaiement; }
			set { typePaiement = value; }
		}

		public Achat()
		{
		}

		public Achat (string refProduit, int numeroRC, string typePaiement)
		{
			this.refProduit = refProduit;
			this.numeroRC = numeroRC;
			this.typePaiement = typePaiement;
			
		}


		public Boolean ajouterAchat()
		{
			String insertRequest = "Insert into achat(refProduit,numeroRC,typePaiement) values (@refProduit,@numeroRC,@typePaiement)";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@refProduit";
			param.Value = this.refProduit;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@numeroRC";
			param.Value = this.numeroRC;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@typePaiement";
			param.Value = this.typePaiement;
			listParams.Add(param);

			
			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(insertRequest, listParams);
			return resultInsert;
		}

		public Boolean modifierAchat()
		{
			return true;
		}

		public Boolean chercherAchatParRef()
		{
			return true;
		}

		public Boolean chercherProduitParCodeBar()
		{
			return true;
		}




	}
}
