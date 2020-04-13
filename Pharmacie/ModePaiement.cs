using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class ModePaiement
    {
		private string typePayement;
		private double montantMin;
		private double montantMax;

		public string TypePayement { get => typePayement; set => typePayement = value; }
		public double MontantMin { get => montantMin; set => montantMin = value; }
		public double MontantMax { get => montantMax; set => montantMax = value; }

		public ModePaiement()
		{
		}

		public ModePaiement(string typePayement, double montantMin, double montantMax)
		{
			TypePayement = typePayement;
			MontantMin = montantMin;
			MontantMax = montantMax;
		}

		public Boolean choisirModePayement()
		{
			return true;
		}

		public Boolean modifierMontantMin()
		{
			return true;
		}

		public Boolean modifierMontantMax()
		{
			return true;
		}


	}
}
