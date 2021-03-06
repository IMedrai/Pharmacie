﻿using System;
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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void gestionDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProduitForm prodForm = new ProduitForm();
            prodForm.Show();

        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }

        private void faireUneVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VenteForm venteForm = new VenteForm();
            venteForm.Show();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            VenteCont venteCont = new VenteCont();
            venteCont.rechercheToutesVente();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = venteCont.ListVente;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            IndexForm_Load(sender,e);
        }
    }
}
