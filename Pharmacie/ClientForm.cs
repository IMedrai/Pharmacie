using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (textBox1_cin.Text == null || textBox1_cin.Text.Length <= 0)
            {
                MessageBox.Show("Veuillez renseigner le CIN de votre client : ");
            }
            List<Client> listClients = (List<Client>)dataGridView1.DataSource;
            dataGridView1.DataSource = null;
            if (listClients == null)
            {
                listClients = new List<Client>();
            }

            Client client = lireClientDepuisFormulaire();
            listClients.Add(client);
            dataGridView1.DataSource = listClients;
            button_vider_Click(sender, e);
        }

        private List<Client> lireListClients()
        {
            return (List<Client>)dataGridView1.DataSource;
        }

        private void setListClients(List<Client> listClients)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listClients;
        }

        private Client lireClientDepuisFormulaire()
        {
            Client client = new Client();
            client.Cin = textBox1_cin.Text;
            client.Nom = textBox2_nom.Text;
            client.Prenom = textBox3_prenom.Text;
            return client;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            textBox1_cin.ReadOnly = false;
            if(dataGridView1.SelectedRows !=null && dataGridView1.SelectedRows.Count > 0) 
            {
                if(textBox1_cin.Text != null && textBox1_cin.Text.Length > 0)
                {
                    Client clientToUpdate = lireClientDepuisFormulaire();
                    List<Client> listClients = (List<Client>)dataGridView1.DataSource;
                    dataGridView1.DataSource = null;
                    foreach( Client client in listClients)
                    {
                        if (!client.Cin.Equals(clientToUpdate.Cin))
                        {
                            continue;
                        }
                        client.Cin = clientToUpdate.Cin;
                        client.Nom = clientToUpdate.Nom;
                        client.Prenom = clientToUpdate.Prenom;
                        break;

                    }
                    dataGridView1.DataSource = listClients;
                    button_vider_Click(sender, e);
                }
                else
                {
                    foreach(DataGridViewRow ligne in dataGridView1.SelectedRows)
                    {
                        Client client = (Client)ligne.DataBoundItem;
                        setFormulaire(client);
                    }
                    textBox1_cin.ReadOnly = true;
                }
            }
        }

        private void setFormulaire(Client client)
        {
            textBox1_cin.Text = client.Cin;
            textBox2_nom.Text = client.Nom;
            textBox3_prenom.Text = client.Prenom;
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            textBox1_cin.ReadOnly = false;
            foreach (Control element in groupBox1.Controls)
            {
                if( element is TextBox)
                {
                    element.Text = null;
                }
            }


        }

        private void button_appliquer_Click(object sender, EventArgs e)
        {
            ClientCont patientD = new ClientCont(lireListClients());
            Boolean result = patientD.ajouterOuModifierClient();
            if (result == false)

            {
                MessageBox.Show(" Un problème est survenu lors de l'insertion des produits ");
            }
            else
            {
                updateProgramListProduit(patientD, Program.listGlobalClients);
                MessageBox.Show("Toutes les modifications ont été appliquées");
            }
        }


        private List<Client> updateProgramListProduit(ClientCont clientCont, List<Client> listClientsProgram)
        {
            foreach (Client clientProgram in listClientsProgram)
            {
                foreach (Client clientUpdated in clientCont.ListClients)
                {
                    if (!clientProgram.Equals(clientUpdated))
                    {
                        continue;
                    }
                    clientProgram.updateMySelf(clientUpdated);
                    break;
                }
            }
            return listClientsProgram;
        }

        private void button_chercher_Click(object sender, EventArgs e)
        {
            if (textBox1_cin.Text != null && textBox1_cin.Text.Length > 0)
            {
                Boolean isExist = true;
                List<Client> listClientsExistant = lireListClients();
                if (listClientsExistant != null && listClientsExistant.Count > 0)
                {
                    foreach (Client clientExistant in listClientsExistant)
                    {
                        if (textBox1_cin.Text.Equals(clientExistant.Cin))
                        {
                            setFormulaire(clientExistant);
                            isExist = true;
                            break;
                        }
                    }
                }
                if (!isExist)
                {
                    
                    MessageBox.Show("Le Client [" + textBox1_cin.Text + "] n'existe pas");
                }
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            setListClients(Program.listGlobalClients);
        }
    }

    }



       
    

