using System;
using System.Collections.Generic;
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


		private FactureClient()
		{
		}

		private FactureClient(string refFacture, string refVente)
		{
			this.refFacture = refFacture;
			this.refVente = refVente;
		}
	}
}
