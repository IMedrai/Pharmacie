using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pharmacie
{
    class Client
    {
		private string cin ;
		private string nom;
		private string prenom;

		public string Cin { get => cin; set => cin = value; }
		public string Nom { get => nom; set => nom = value; }
		public string Prenom { get => prenom; set => prenom = value; }

		public Client()
		{
		}

		public Client(string cin, string nom, string prenom)
		{
			Cin = cin;
			Nom = nom;
			Prenom = prenom;
		}


		public Boolean ajouterClient()
		{
			String insertRequest = "Insert into Client(cinClient,nomClient,prenomClient) values (@cinClient,@nomClient,@prenomClient)";

			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@cinClient";
			param.Value = this.cin;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@nomClient";
			param.Value = this.nom;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@prenomClient";
			param.Value = this.prenom;
			listParams.Add(param);
			Boolean resultInsert = Program.dbHandler.executeRequest(insertRequest, listParams);
			return resultInsert;
		}


		public Boolean modifierClient()
		{
			return true;
		}

		public Boolean chercherClientParCin()
		{
			return true;
		}

		public Boolean chercherClientParNom()
		{
			return true;
		}
	}
}
