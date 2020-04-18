using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

		public Boolean ajouterMontant()
		{
			String insertRequest = " insert into ( montantMin, montantMax) value ( @montantMin, @montantMax)";
			List<SqlParameter> listParams = new List<SqlParameter>();
			SqlParameter param = new SqlParameter();
			param.ParameterName = "@montantMin";
			param.Value = this.montantMin;
			listParams.Add(param);


			param = new SqlParameter();
			param.ParameterName = "@montantMax";
			param.Value = this.montantMax;
			listParams.Add(param);


			Boolean resultInsert = Program.dbHandler.executeNoOutputRequest(insertRequest, listParams);
			return resultInsert;

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
