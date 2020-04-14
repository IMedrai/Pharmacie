using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pharmacie
{
    class Fournisseur
    {

		private int numeroRC;
		private string raisonSociale;

		public int NumeroRC { get => numeroRC; set => numeroRC = value; }
		public string RaisonSociale { get => raisonSociale; set => raisonSociale = value; }

		public Fournisseur()
		{
		}

		public Fournisseur(int numeroRC, string raisonSociale)
		{
			NumeroRC = numeroRC;
			RaisonSociale = raisonSociale;
		}

		public Boolean ajouterFournisseur()
		{

			String insertRequest = "Insert into Fournisseur (RCFournisseur, RSFournisseur) values (@RCFournisseur,@RSFournisseur)";

			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@RCFournisseur";
			param.Value = this.numeroRC;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@RSFournisseur";
			param.Value = this.raisonSociale;
			listParams.Add(param);

		
			Boolean resultInsert = Program.dbHandler.executeRequest(insertRequest, listParams);
			return resultInsert;
		}

		public Boolean modifierFournisseur()
		{
			return true;
		}

		public Boolean chercherFournisseurParRC()
		{
			return true;
		}

		public Boolean chercherFournisseurParRS()
		{
			return true;
		}

	}
}
