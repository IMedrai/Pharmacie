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
    public partial class VenteForm : Form
    {
        public VenteForm()
        {
            InitializeComponent();
        }

        private void textBox1_refVente_TextChanged(object sender, EventArgs e)
        {
            List<int> refVente = new List<int>();
            
        }

        private void VenteForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            label_refVente.Text = "v_"+ Program.dbHandler.getSqRefVente();
            ProduitCont prodCont = new ProduitCont();
            prodCont.rechercheProduitDispo();

            ClientCont clientCont = new ClientCont();
            clientCont.rechercherTousClient();

            comboBox1_RefProduit.DataSource = prodCont.getLibellesProduit();
            comboBox2_cin.DataSource = clientCont.getNomPrenomClient();
            comboBox1_typePaiement.DataSource = Program.modePaiementCont.listLibelleModePaiement;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            Vente vente = lireFormulaire();
            List<Vente> listVentes = lireListVentes();
            if (listVentes == null)
            {
                listVentes = new List<Vente>();
            }
            vente.updateMySelf(label_refVente.Text);
            listVentes.Add(vente);
            Double totalToutesVente = 0d;
            foreach (Vente v in listVentes)
            {
                totalToutesVente += v.Total;
            }
            textBox2_Total.Text = totalToutesVente.ToString();
            setListVentes(listVentes);
        }

        private List<Vente> lireListVentes()
        {
            return (List<Vente>)dataGridView1.DataSource;
        }

        private void setListVentes(List<Vente> listVentes)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listVentes;
        }

        private Vente lireFormulaire()
        {
            Vente vente = new Vente();
            vente.LibelleProduit = (String)comboBox1_RefProduit.SelectedItem;
            vente.NomPrenomclient = (String)comboBox2_cin.SelectedItem;
            vente.Qnt = (int)numericUpDown1_Qte.Value;
            vente.ModePaiement = (String)comboBox1_typePaiement.SelectedItem;
            return vente;
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            foreach (Control element in groupBox1.Controls)
            {
                if (element is TextBox || element is NumericUpDown || element is ComboBox)
                {
                    element.Text = null;
                }
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Veuillez confirmer la suppression","",MessageBoxButtons.YesNo);
                if ("Yes".Equals(res.ToString()))
                {
                    List<Vente> listDletedVentes = new List<Vente>();
                    foreach (DataGridViewRow ligne in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(ligne);
                    }
                }
                else
                {
                    Console.WriteLine("Non");
                }
            }
        }

        private void button_appliquer_Click(object sender, EventArgs e)
        {
            List <Vente> listVentes = lireListVentes();
            VenteCont venteCont = new VenteCont();
            venteCont.ListVente = listVentes;
            venteCont.ApplyVenteAndUpdateStock();

        }
    }
}
