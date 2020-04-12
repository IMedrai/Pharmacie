using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class FactureFournisseur
    {
		private string refFacture;
		private int numeroRC;


		public string RefFacture
		{
			get { return refFacture; }
			set { refFacture = value; }
		}


		public int NumeroRC
		{
			get { return numeroRC; }
			set { numeroRC = value; }
		}


		private FactureFournisseur()
		{
		}

		private FactureFournisseur(string refFacture, int numeroRC)
		{
			this.refFacture = refFacture;
			this.numeroRC = numeroRC;
		}
	}
}
