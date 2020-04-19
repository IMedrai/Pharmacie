using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Stock
    {
		private string refProduit;
		private int qnt;
		

		public string RefPreoduit
		{
			get { return refProduit; }
			set { refProduit = value; }
		}


		public int Qnt
		{
			get { return qnt; }
			set { qnt = value; }
		}

		public Boolean ajouterAuStock()
		{
			String updateQuery = "Update stock set qnt = @qnt where refProduit = @refProduit";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@refProduit";
			param.Value = this.refProduit;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@qnt";
			param.Value = this.Qnt;
			listParams.Add(param);

			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(updateQuery, listParams);
			return resultInsert;

		}

		public Boolean creerStock()
		{
			String updateQuery = "insert into stock (qnt,refProduit) values (@qnt,@refProduit)";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@refProduit";
			param.Value = this.refProduit;
			listParams.Add(param);

			param = new SqlParameter();
			param.ParameterName = "@qnt";
			param.Value = this.Qnt;
			listParams.Add(param);

			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(updateQuery, listParams);
			return resultInsert;
		}


		public Stock()
		{
		}

		private Stock(string refProduit, int quantite)
		{
			this.refProduit = refProduit;
			this.qnt = quantite;
		}
	}
}
