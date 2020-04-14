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
    public partial class ProduitForm : Form
    {
        public ProduitForm()
        {
            InitializeComponent();
        }

       

        private void ProduitForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text.Length <= 0) {
                MessageBox.Show("Veuillez renseigner la ref du produit");
            }
            List<Produit> listProduits = (List<Produit>)dataGridView1.DataSource;
            dataGridView1.DataSource = null;
            if (listProduits == null)
            {
                listProduits = new List<Produit>();
            }
            Produit prod = lireProduitDepuisFormulaire();
            listProduits.Add(prod);
            dataGridView1.DataSource = listProduits;
            button_vider_Click(sender, e);


        }

        private Produit lireProduitDepuisFormulaire()
        {
            Produit prod = new Produit();
            prod.RefProduit = textBox1.Text;
            prod.CodeBar = textBox2.Text;
            prod.Libelle = textBox4.Text;
            prod.Prix = Double.Parse(textBox3.Text);
            return prod;
        }

        private List<Produit> lireListProduits()
        {
            return (List<Produit>)dataGridView1.DataSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                if (textBox1.Text != null && textBox1.Text.Length > 0)
                {
                    Produit prodToUpdate = lireProduitDepuisFormulaire();
                    List<Produit> listProduits = (List<Produit>)dataGridView1.DataSource;
                    dataGridView1.DataSource = null;
                    foreach (Produit prod in listProduits)
                    {
                        if (!prod.RefProduit.Equals(prodToUpdate.RefProduit))
                        {
                            continue;
                        }
                        prod.CodeBar = prodToUpdate.CodeBar;
                        prod.Libelle = prodToUpdate.Libelle;
                        prod.Prix = prodToUpdate.Prix;
                        break;
                    }
                    dataGridView1.DataSource = listProduits;
                }
                else
                {
                    foreach (DataGridViewRow ligne in dataGridView1.SelectedRows)
                    {
                        Produit prod = (Produit)ligne.DataBoundItem;
                        textBox1.Text = prod.RefProduit;
                        textBox2.Text = prod.CodeBar;
                        textBox3.Text = prod.Prix.ToString();
                        textBox4.Text = prod.Libelle;
                    }
                    textBox1.ReadOnly = true;
                }
                
               
            }
            
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            foreach (Control element in groupBox1.Controls){
                if (element is TextBox){
                    element.Text = null;
                }
            }
        }

        private void button_appliquer_Click(object sender, EventArgs e)
        {
            ProduitCont prodCont = new ProduitCont(lireListProduits());
            Boolean result = prodCont.ajouterOuModifierProduits();
            if (result == false)
            {
                MessageBox.Show("Un problème est survenu lors de l'insertion des produits");
            }
        }
    }
}
