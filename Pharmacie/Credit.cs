using System;
using System.Collections.Generic;
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


		private Credit()
		{
		}
		

		private Credit(DateTime dateCredit, string cin, double prix, double montantCredit)
		{
			this.dateCredit = dateCredit;
			this.cin = cin;
			this.montantCredit = montantCredit;
		}
	}
}
