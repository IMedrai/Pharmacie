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
		private static readonly String CIN_CLIENT_DB = "cin";
		private static readonly String PRENOM_CLIENT_DB = "prenom";
		private static readonly String NOM_CLIENT_DB = "nom";

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
			String insertRequest = "Insert into Client(cin,nom,prenom) values (@cinClient,@nomClient,@prenomClient)";

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

			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(insertRequest, listParams);
			return resultInsert;
		}


		public Boolean modifierClient()
		{
			String insertRequest = "update Client set nom = @nomClient, prenom = @prenomClient where cin = @cinClient";

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

			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(insertRequest, listParams);
			return resultInsert;
		}

		public Boolean chercherClientParCin()
		{
			String insertRequest = "select cin,nom,prenom from client where cin = @cinClient";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@cinClient";
			param.Value = this.Cin;
			listParams.Add(param);
			List<Dictionary<String, Object>> listResults = Program.dbHandler.executeRequest(insertRequest, listParams);
			if (listResults == null || listResults.Count <= 0)
			{
				return false;
			}
			return readClienttFromDictionnary(listResults[0]);
		}


		public Boolean readClienttFromDictionnary(Dictionary<String, Object> element)
		{
			Object obj = null;
			element.TryGetValue(CIN_CLIENT_DB, out obj);
			this.Cin = (String)obj;

			obj = null;
			element.TryGetValue(NOM_CLIENT_DB, out obj);
			this.Nom = (String)obj;

			obj = null;
			element.TryGetValue(PRENOM_CLIENT_DB, out obj);
			this.Prenom = (String)obj;
			return true;
		}

		private Boolean readClientFromSQLReader(SqlDataReader reader)
		{
			reader.Read();
			if (reader == null || !reader.HasRows || reader.GetString(0) == null || reader.GetString(0).Length <= 0)
			{
				reader.Close();
				return false;
			}
			this.Cin = reader.GetString(0);
			this.Nom = reader.GetString(1);
			this.Prenom = reader.GetString(2);
			reader.Close();
			return true;
		}

		public Boolean chercherClientParNom()
		{
			return true;
		}

        internal void updateMySelf(Client clientUpdated)
        {
			this.Nom = clientUpdated.Nom;
			this.Prenom = clientUpdated.Prenom;
        }

		public override bool Equals(object obj)
		{
			return this.Cin.Equals(((Client)obj).Cin);
		}
	}
}
