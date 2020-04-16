using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class AchatCont
    {

        private List<Achat> listAchats;

        internal List<Achat> ListAchats { get => ListAchats; set => ListAchats = value; }




        public Boolean ajouterAchat()
        {
            if (listAchats != null && listAchats.Count > 0)
            {
                foreach (Achat ac in listAchats)
                {
                    ac.ajouterAchat();
                }
                return true;
            }
        }

            public Boolean modifierAchat()
            {
                if (listAchats != null && listAchats.Count > 0)
                {
                    foreach (Achat ac in listAchats)
                    {
                        ac.ajouterAchat();
                    }
                }
                return true;
            }

            public Boolean chercherAchatParRef(List<Achat> listAchatAChercher)
            {
                return true;
            }



            public AchatCont(List<Achat> listAchats)
            {
                this.ListAchats = listAchats;
            }

    
            public AchatCont()
            {

            }


    }
    }
}

