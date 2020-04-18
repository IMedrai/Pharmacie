using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class ModePaiementCont
    {
        public List<ModePaiement> modePaiement;
        public List<String> listLibelleModePaiement;

        public ModePaiementCont()
        {
            this.modePaiement = new List<ModePaiement>();
            ModePaiement mpEspece = new ModePaiement();
            mpEspece.TypePayement = "ESPECE";
            mpEspece.MontantMin = 0d;
            mpEspece.MontantMax = 1000000d;

            ModePaiement mpCheque = new ModePaiement();
            mpCheque.TypePayement = "CHEQUE";
            mpCheque.MontantMin = 500d;
            mpCheque.MontantMax = 5000d;

            ModePaiement mpCredit = new ModePaiement();
            mpCredit.TypePayement = "CREDIT";
            mpCredit.MontantMin = 0d;
            mpCredit.MontantMax = 2000d;

            this.modePaiement.Add(mpEspece);
            this.modePaiement.Add(mpCredit);
            this.modePaiement.Add(mpCheque);

            listLibelleModePaiement = new List<string>();

            listLibelleModePaiement.Add("CREDIT");
            listLibelleModePaiement.Add("ESPECE");
            listLibelleModePaiement.Add("CHEQUE");

        }





    }
}
