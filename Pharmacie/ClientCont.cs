using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        public void rechercherTousClient()
        {
            /*String selectQuery = "select cin,nom,prenom from client";
            List<SqlParameter> listParams = new List<SqlParameter>();
            getClientsFromDict(Program.dbHandler.executeRequest(selectQuery, listParams));*/
            this.ListClients = Program.listGlobalClients;
        }

        public void rechercherTousClientFromDB()
        {
            String selectQuery = "select cin,nom,prenom from client";
            List<SqlParameter> listParams = new List<SqlParameter>();
            getClientsFromDict(Program.dbHandler.executeRequest(selectQuery, listParams));
        }

        private void getClientsFromDict(List<Dictionary<String, Object>> listResults)
        {
            this.ListClients = new List<Client>();
            if (listResults != null && listResults.Count > 0)
            {
                foreach (Dictionary<String, Object> element in listResults)
                {
                    Client client = new Client();
                    client.readClienttFromDictionnary(element);
                    this.ListClients.Add(client);
                }
            }
        }
        public List<String> getNomPrenomClient()
        {
            if (this.ListClients == null || this.ListClients.Count < 0)
            {
                return null;
            }
            List<String> listNomPrenomClients = new List<string>();
            foreach (Client client in this.ListClients)
            {
                listNomPrenomClients.Add(client.Nom+"-"+client.Prenom);
            }
            return listNomPrenomClients;
        }

        public ClientCont(List<Client> listeClients)
        {
            this.listeClients = listeClients;
        }

        public ClientCont()
        {
            
        }
    }
}


