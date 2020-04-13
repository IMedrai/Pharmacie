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

        ADO d = new ADO();

        private void ProduitForm_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.CONNECTER();
            d.cmd.CommandText = "insert into Produit values ('" + textBox1.Text + "','" + textBox2.Text + "'," + double.Parse(textBox3.Text) + ",'" + textBox4.Text + "')";              
            d.cmd.ExecuteNonQuery();
            MessageBox.Show("Produit ajouté avec succès");

            d.DECONNECTER();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            d.cmd.CommandText = " update Produit set refProduit ='" + textBox1.Text + "',codeBar='" + textBox2.Text + "', prix=" + double.Parse(textBox3.Text) + ",libelle='" + textBox4.Text + "";
            d.cmd.ExecuteNonQuery();
            MessageBox.Show("Produit modifié avec succès");

            d.DECONNECTER();
            this.Close();
        }



    }
}
