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
			SqlDataReader reader = Program.dbHandler.executeRequest(insertRequest, listParams);
			return readClientFromSQLReader(reader);
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
	}
}
