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

            Client patient = lireClientDepuisFormulaire();
            listClients.Add(patient);
            dataGridView1.DataSource = listClients;
            button_vider_Click(sender, e);
        }

        private Client lireClientDepuisFormulaire()
        {
            Client patient = new Client();
            patient.Cin = textBox1_cin.Text;
            patient.Nom = textBox2_nom.Text;
            patient.Prenom = textBox3_prenom.Text;
            return patient;
        }

        private List<Client> LireListClients()
        {
            return (List<Client>)dataGridView1.DataSource;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            textBox1_cin.ReadOnly = false;
        if(dataGridView1.SelectedRows !=null && dataGridView1.SelectedRows.Count > 0) 
            {
                if(textBox1_cin.Text != null && textBox1_cin.Text.Length > 0)
                {
                    Client patientToUpdate = lireClientDepuisFormulaire();
                    List<Client> listClients = (List<Client>)dataGridView1.DataSource;
                    dataGridView1.DataSource = null;
                    foreach( Client patient in listClients)
                    {
                        if (!patient.Cin.Equals(patientToUpdate.Cin))
                        {
                            continue;
                        }
                        patient.Cin = patientToUpdate.Cin;
                        patient.Nom = patientToUpdate.Nom;
                        patient.Prenom = patientToUpdate.Prenom;
                        break;

                    }
                    dataGridView1.DataSource = listClients;
                }
                else
                {
                    foreach(DataGridViewRow ligne in dataGridView1.SelectedRows)
                    {
                        Client patient = (Client)ligne.DataBoundItem;
                        textBox1_cin.Text = patient.Cin;
                        textBox2_nom.Text = patient.Nom;
                        textBox3_prenom.Text = patient.Prenom;
                    }
                    textBox1_cin.ReadOnly = true;

                    }
                }
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
            ClientCont patientD = new ClientCont(LireListClients());
            Boolean result = patientD.ajouterClient();
            if (result == false)

            {
                MessageBox.Show(" Un problème est survenu lors de l'insertion des produits ");
            }
        }
    }

    }



       
    

