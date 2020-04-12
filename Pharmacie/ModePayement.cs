using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class ModePayement
    {
		private string typePayement;
		private double montantMin;
		private double montantMax;



		public string TypePayement
		{
			get { return typePayement; }
			set { typePayement = value; }
		}


		public double MontantMin
		{
			get { return montantMin; }
			set { montantMin = value; }
		}

		public double MontantMax
		{
			get { return montantMax; }
			set { montantMax = value; }
		}

		private ModePayement()
		{
		}

		private ModePayement(string typePayement, double montantMin, double montantMax, string libelle)
		{
			this.typePayement = typePayement;
			this.montantMin = montantMin;
			this.montantMax = montantMax;
		
		}

	}
}
