namespace Pharmacie
{
    partial class VenteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_refVente = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1_Qte = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2_cin = new System.Windows.Forms.ComboBox();
            this.comboBox1_RefProduit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1_typePaiement = new System.Windows.Forms.ComboBox();
            this.button_appliquer = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_chercher = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomPrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CinClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModePaiement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Qte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label_refVente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox2_Total);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown1_Qte);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox2_cin);
            this.groupBox1.Controls.Add(this.comboBox1_RefProduit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1_typePaiement);
            this.groupBox1.Controls.Add(this.button_appliquer);
            this.groupBox1.Controls.Add(this.button_vider);
            this.groupBox1.Controls.Add(this.button_chercher);
            this.groupBox1.Controls.Add(this.button_modifier);
            this.groupBox1.Controls.Add(this.button_ajouter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1453, 877);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomPrenomClient,
            this.CinClient,
            this.RefProduit,
            this.LibelleProduit,
            this.Qnt,
            this.ModePaiement,
            this.DateVente,
            this.PrixUnitaire,
            this.Total,
            this.RefVente});
            this.dataGridView1.Location = new System.Drawing.Point(33, 485);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1379, 367);
            this.dataGridView1.TabIndex = 27;
            // 
            // label_refVente
            // 
            this.label_refVente.AutoSize = true;
            this.label_refVente.Location = new System.Drawing.Point(769, 58);
            this.label_refVente.Name = "label_refVente";
            this.label_refVente.Size = new System.Drawing.Size(0, 20);
            this.label_refVente.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(596, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(355, 26);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textBox2_Total
            // 
            this.textBox2_Total.Location = new System.Drawing.Point(831, 350);
            this.textBox2_Total.Name = "textBox2_Total";
            this.textBox2_Total.Size = new System.Drawing.Size(125, 26);
            this.textBox2_Total.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total à payer";
            // 
            // numericUpDown1_Qte
            // 
            this.numericUpDown1_Qte.Location = new System.Drawing.Point(320, 183);
            this.numericUpDown1_Qte.Name = "numericUpDown1_Qte";
            this.numericUpDown1_Qte.Size = new System.Drawing.Size(163, 26);
            this.numericUpDown1_Qte.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantité";
            // 
            // comboBox2_cin
            // 
            this.comboBox2_cin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2_cin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2_cin.FormattingEnabled = true;
            this.comboBox2_cin.Location = new System.Drawing.Point(320, 236);
            this.comboBox2_cin.Name = "comboBox2_cin";
            this.comboBox2_cin.Size = new System.Drawing.Size(164, 28);
            this.comboBox2_cin.TabIndex = 17;
            // 
            // comboBox1_RefProduit
            // 
            this.comboBox1_RefProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1_RefProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1_RefProduit.FormattingEnabled = true;
            this.comboBox1_RefProduit.Location = new System.Drawing.Point(322, 130);
            this.comboBox1_RefProduit.Name = "comboBox1_RefProduit";
            this.comboBox1_RefProduit.Size = new System.Drawing.Size(162, 28);
            this.comboBox1_RefProduit.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Client";
            // 
            // comboBox1_typePaiement
            // 
            this.comboBox1_typePaiement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1_typePaiement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1_typePaiement.FormattingEnabled = true;
            this.comboBox1_typePaiement.Location = new System.Drawing.Point(320, 291);
            this.comboBox1_typePaiement.Name = "comboBox1_typePaiement";
            this.comboBox1_typePaiement.Size = new System.Drawing.Size(164, 28);
            this.comboBox1_typePaiement.TabIndex = 14;
            // 
            // button_appliquer
            // 
            this.button_appliquer.Location = new System.Drawing.Point(761, 396);
            this.button_appliquer.Name = "button_appliquer";
            this.button_appliquer.Size = new System.Drawing.Size(143, 45);
            this.button_appliquer.TabIndex = 13;
            this.button_appliquer.Text = "Appliquer";
            this.button_appliquer.UseVisualStyleBackColor = true;
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(579, 396);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(143, 45);
            this.button_vider.TabIndex = 12;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            // 
            // button_chercher
            // 
            this.button_chercher.Location = new System.Drawing.Point(393, 396);
            this.button_chercher.Name = "button_chercher";
            this.button_chercher.Size = new System.Drawing.Size(143, 45);
            this.button_chercher.TabIndex = 10;
            this.button_chercher.Text = "Chercher";
            this.button_chercher.UseVisualStyleBackColor = true;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(215, 401);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(143, 40);
            this.button_modifier.TabIndex = 9;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(33, 398);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(143, 43);
            this.button_ajouter.TabIndex = 8;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type de paiement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Référence Vente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence Produit";
            // 
            // NomPrenomClient
            // 
            this.NomPrenomClient.DataPropertyName = "NomPrenomClient";
            this.NomPrenomClient.HeaderText = "Client";
            this.NomPrenomClient.MinimumWidth = 8;
            this.NomPrenomClient.Name = "NomPrenomClient";
            this.NomPrenomClient.Width = 150;
            // 
            // CinClient
            // 
            this.CinClient.DataPropertyName = "CinClient";
            this.CinClient.HeaderText = "CIN Client";
            this.CinClient.MinimumWidth = 8;
            this.CinClient.Name = "CinClient";
            this.CinClient.Width = 150;
            // 
            // RefProduit
            // 
            this.RefProduit.DataPropertyName = "RefProduit";
            this.RefProduit.HeaderText = "Référence Produit";
            this.RefProduit.MinimumWidth = 8;
            this.RefProduit.Name = "RefProduit";
            this.RefProduit.Width = 150;
            // 
            // LibelleProduit
            // 
            this.LibelleProduit.DataPropertyName = "LibelleProduit";
            this.LibelleProduit.HeaderText = "Libelle Produit";
            this.LibelleProduit.MinimumWidth = 8;
            this.LibelleProduit.Name = "LibelleProduit";
            this.LibelleProduit.Width = 150;
            // 
            // Qnt
            // 
            this.Qnt.DataPropertyName = "Qnt";
            this.Qnt.HeaderText = "Quantité";
            this.Qnt.MinimumWidth = 8;
            this.Qnt.Name = "Qnt";
            this.Qnt.Width = 150;
            // 
            // ModePaiement
            // 
            this.ModePaiement.DataPropertyName = "ModePaiement";
            this.ModePaiement.HeaderText = "Mode paiement";
            this.ModePaiement.MinimumWidth = 8;
            this.ModePaiement.Name = "ModePaiement";
            this.ModePaiement.Width = 150;
            // 
            // DateVente
            // 
            this.DateVente.DataPropertyName = "DateVente";
            this.DateVente.HeaderText = "Date vente";
            this.DateVente.MinimumWidth = 8;
            this.DateVente.Name = "DateVente";
            this.DateVente.Width = 150;
            // 
            // PrixUnitaire
            // 
            this.PrixUnitaire.DataPropertyName = "PrixUnitaire";
            this.PrixUnitaire.HeaderText = "Prix unitaire";
            this.PrixUnitaire.MinimumWidth = 8;
            this.PrixUnitaire.Name = "PrixUnitaire";
            this.PrixUnitaire.Width = 150;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // RefVente
            // 
            this.RefVente.DataPropertyName = "RefVente";
            this.RefVente.HeaderText = "Référence Vente";
            this.RefVente.MinimumWidth = 8;
            this.RefVente.Name = "RefVente";
            this.RefVente.Width = 150;
            // 
            // VenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1713, 918);
            this.Controls.Add(this.groupBox1);
            this.Name = "VenteForm";
            this.Text = "VenteForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VenteForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Qte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_appliquer;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_chercher;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1_typePaiement;
        private System.Windows.Forms.TextBox textBox2_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Qte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2_cin;
        private System.Windows.Forms.ComboBox comboBox1_RefProduit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_refVente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPrenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModePaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefVente;
    }
}