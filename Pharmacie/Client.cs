using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Client
    {
		private string cin ;
		private string nom;
		private string prenom;



		public string Cin
		{
			get { return cin; }
			set { cin = value; }
		}

		public string Nom
		{
			get { return nom; }
			set { nom = value; }
		}

		public string Prenom
		{
			get { return prenom; }
			set { prenom = value; }
		}


		private Client()
		{
		}

		private Client(string cin, string nom, string prenom)
		{
			this.cin = cin;
			this.nom = nom;
			this.prenom = prenom;
			
		}
	}
}
