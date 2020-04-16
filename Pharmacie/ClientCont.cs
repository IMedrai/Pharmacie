using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class ClientCont
    {

        private List<Client> listeClients;

        internal List<Client> ListClients { get => listeClients; set => listeClients = value; }

        

        public Boolean ajouterClient()
        {
            if(listeClients != null && listeClients.Count >0)
            {
                foreach(Client patient in listeClients)
                {
                    patient.ajouterClient();

                }
            }
            return true;
        }


        public Boolean chercherClientParCin(List<Client> listeClientsAchercher)
        {
            return true;
        }

        public Boolean chercherClientParNom(List<Client> listeClientsAChercher)
        {
            return true;
        }


        public ClientCont(List<Client> listeClients)
        {
            this.listeClients = listeClients;
        }
    }
}


