using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class FactureClient
    {
		private string refFacture;
		private string refVente;


		public string RefFacture
		{
			get { return refFacture; }
			set { refFacture = value; }
		}


		public string RefVente
		{
			get { return refVente; }
			set { refVente = value; }
		}


		public FactureClient()
		{
		}

		public FactureClient(string refFacture, string refVente)
		{
			this.refFacture = refFacture;
			this.refVente = refVente;
		}

		public Boolean ajouterFacture()
		{

			String insertRequest = " insert into ( refFacture, refVente) value ( @refFacture, @refVente)";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@refFacture";
			param.Value = this.refFacture;
			listParams.Add(param);


			param = new SqlParameter();
			param.ParameterName = "@refVente";
			param.Value = this.refVente;
			listParams.Add(param);


			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(insertRequest, listParams);
			return resultInsert;

		}
	}
}
