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
			return true;
		}


		public Boolean modifierClient()
		{
			return true;
		}

		public Boolean chercherClientParCin()
		{
			return true;
		}

		public Boolean chercherClientParNom()
		{
			return true;
		}
	}
}
