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
    public partial class FournisseurForm : Form
    {
        public FournisseurForm()
        {
            InitializeComponent();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (textBox1_RC.Text == null || textBox1_RC.Text.Length < 0)
            {
                MessageBox.Show(" Veuillez renseigner le Numéro RC de votre fournisseur ");
            }
            List<Fournisseur> listFournisseurs = (List<Fournisseur>)dataGridView1.DataSource;
            dataGridView1.DataSource = null;
            if (listFournisseurs == null)
            {
                listFournisseurs = new List<Fournisseur>();
            }

            Fournisseur frs = lireFournisseurDepuisFormulaire();
            listFournisseurs.Add(frs);
            dataGridView1.DataSource = listFournisseurs;
            button_vider_Click(sender, e);
        }

        private Fournisseur lireFournisseurDepuisFormulaire()
        {
            Fournisseur frs = new Fournisseur();
            frs.NumeroRC = int.Parse(textBox1_RC.Text);
            frs.RaisonSociale = textBox2_RS.Text;
            return frs;
        }
        private List<Fournisseur> LireListFournisseurs()
        {
            return (List<Fournisseur>)dataGridView1.DataSource;
        }


        private void button_modifier_Click(object sender, EventArgs e)
        {
             textBox1_RC.ReadOnly = false;
        if(dataGridView1.SelectedRows !=null && dataGridView1.SelectedRows.Count > 0) 
            {
                if(textBox1_RC.Text != null && textBox1_RC.Text.Length > 0)
                {
                    Fournisseur frsToUpdate = lireFournisseurDepuisFormulaire();
                    List<Fournisseur> listFournisseurs = (List<Fournisseur>)dataGridView1.DataSource;
                    dataGridView1.DataSource = null;
                    foreach( Fournisseur frs in listFournisseurs)
                    {
                        if (!frs.NumeroRC.Equals(frsToUpdate.NumeroRC))
                        {
                            continue;
                        }
                        frs.NumeroRC = frsToUpdate.NumeroRC;
                        frs.RaisonSociale = frs.RaisonSociale;
                        
                        break;

                    }
                    dataGridView1.DataSource = listFournisseurs;
                }
                else
                {
                    foreach(DataGridViewRow ligne in dataGridView1.SelectedRows)
                    {
                        Fournisseur frs = (Fournisseur)ligne.DataBoundItem;
                        textBox1_RC.Text = frs.NumeroRC.ToString();
                        textBox2_RS.Text = frs.RaisonSociale;
                       
                    }
                    textBox1_RC.ReadOnly = true;

                    }
                }
        }


        private List<Fournisseur> lireListFournisseurs()
        {
            return (List<Fournisseur>)dataGridView1.DataSource;
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            textBox1_RC.ReadOnly = false;
            foreach (Control element in groupBox1.Controls)
            {
                if (element is TextBox)
                {
                    element.Text = null;
                }
            }

        }

        private void button_appliquer_Click(object sender, EventArgs e)
        {
            

            /*FournisseurCont frsCont = new FournisseurCont(lireListFournisseurs());
            Boolean result = frsCont.ajouterFournisseur();
            if (result == false)
            {
                MessageBox.Show("Un problème est survenu lors de l'insertion des fournisseurs");
            }*/
        }

        private void button_chercher_Click(object sender, EventArgs e)
        {

        }
    }
    }

// si 