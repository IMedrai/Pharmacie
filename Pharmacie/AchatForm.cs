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
    public partial class AchatForm : Form
    {
        public AchatForm()
        {
            InitializeComponent();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            if (textBox1_refProduit.Text == null || textBox1_refProduit.Text.Length <= 0)
            {
                MessageBox.Show("Veuillez renseigner la référence du produit ");
            }
            List<Achat> listAchats = (List<Achat>)dataGridView1.DataSource;
            dataGridView1.DataSource = null;
            if (listAchats == null)
            {
                listAchats = new List<Achat>();
            }
            Achat ac = lireAchatDepuisFormulaire();
            listAchats.Add(ac);
            dataGridView1.DataSource = listAchats;
            button_vider_Click(sender, e);
        }
    
        private Achat lireAchatDepuisFormulaire()
        {
            Achat ac = new Achat();
            ac.RefProduit = textBox1_refProduit.Text;
            ac.NumeroRC = int.Parse(textBox2_numeroRC.Text);
            ac.TypePaiement = textBox5_typePaiement.Text;
            return ac;
        }

        private List<Achat> LireListAchats()
        {
            return (List<Achat>)dataGridView1.DataSource;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            textBox1_refProduit.ReadOnly = false;
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                if (textBox1_refProduit.Text != null && textBox1_refProduit.Text.Length > 0)
                {
                    Achat acToUpdate = lireAchatDepuisFormulaire();
                    List<Achat> listAchats = (List<Achat>)dataGridView1.DataSource;
                    dataGridView1.DataSource = null;
                    foreach (Achat ac in listAchats)
                    {
                        if (!ac.RefProduit.Equals(acToUpdate.RefProduit))
                        {
                            continue;
                        }
                          ac.RefProduit = acToUpdate.RefProduit;
                        ac.NumeroRC = acToUpdate.NumeroRC;
                        ac.TypePaiement= acToUpdate.TypePaiement;
                        break;

                    }
                    dataGridView1.DataSource = listAchats;
                }
                else
                {
                    foreach (DataGridViewRow ligne in dataGridView1.SelectedRows)
                    {
                        Achat ac = (Achat)ligne.DataBoundItem;
                        textBox1_refProduit.Text = ac.RefProduit;
                        textBox2_numeroRC.Text = ac.NumeroRC.ToString();
                        textBox5_typePaiement.Text = ac.TypePaiement;
                    }
                    textBox1_refProduit.ReadOnly = true;

                }
            }
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            textBox1_refProduit.ReadOnly = false;
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
            AchatCont acCont= new AchatCont(LireListAchats());
            Boolean result = acCont.ajouterAchat();
            if (result == false)

            {
                MessageBox.Show(" Un problème est survenu lors de l'insertion des achats");
            }
        }
    }
    }

