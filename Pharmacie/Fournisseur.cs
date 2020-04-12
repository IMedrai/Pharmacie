using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Fournisseur
    {

		private int numeroRC;
		private string raisonSociale;


		public int NumeroRC
		{
			get { return numeroRC; }
			set { numeroRC = value; }
		}


		public string RaisonSociale
		{
			get { return raisonSociale; }
			set { raisonSociale = value; }
		}


		private Fournisseur()
		{
		}

		private Fournisseur (int numeroRC, string raisonSociale)
		{
			this.numeroRC = numeroRC;
			this.raisonSociale = raisonSociale;
		}
	}
}
