using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Credit
    {
		private DateTime dateCredit;
		private string cin;
		private double montantCredit;
		

		public DateTime DateCredit
		{
			get { return dateCredit; }
			set { dateCredit = value; }
		}

		public string Cin
		{
			get { return cin; }
			set { cin = value; }
		}

		public double MontantCredit
		{
			get { return montantCredit; }
			set { montantCredit = value; }
		}


		public Credit()
		{
		}
		

		public Credit(DateTime dateCredit, string cin, double montantCredit)
		{
			this.dateCredit = dateCredit;
			this.cin = cin;
			this.montantCredit = montantCredit;
		}

		public Boolean ajouterCredit()
		{
			string insertRequest = " insert into ( dateCredit, cinCredit,montantCredit) value ( @dateCredit,@cinCredit,@montantCredit)";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@dateCredit";
			param.Value = this.dateCredit;
			listParams.Add(param);


			param = new SqlParameter();
			param.ParameterName = "@cinCredit";
			param.Value = this.cin;
			listParams.Add(param);


			param = new SqlParameter();
			param.ParameterName = "@montantCredit";
			param.Value = this.montantCredit;
			listParams.Add(param);



			Boolean resultInsert = Program.dbHandler.executeRequest(insertRequest, listParams);
			return resultInsert;


		}
		
		public Boolean modifierCredit()
		{
			return true;
		}

		public Boolean chercherCreditPaCin()
		{
			return true;
		}

	}
}
