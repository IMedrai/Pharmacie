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

        

        public Boolean ajouterOuModifierClient()
        {
            if (listeClients != null && listeClients.Count >0)
            {
                foreach(Client client in listeClients)
                {
                    Client clientRecherche = new Client();
                    clientRecherche.Cin = client.Cin;
                    Boolean exist = clientRecherche.chercherClientParCin();
                    if (exist)
                    {
                        client.modifierClient();
                    }
                    else
                    {
                        client.ajouterClient();
                    }
                    

                }
            }
            return true;
        }


        public ClientCont(List<Client> listeClients)
        {
            this.listeClients = listeClients;
        }
    }
}


