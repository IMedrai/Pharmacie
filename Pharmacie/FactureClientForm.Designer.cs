namespace Pharmacie
{
    partial class FactureClientForm
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
            this.groupBox1_FactureClient = new System.Windows.Forms.GroupBox();
            this.groupBox1_Patient = new System.Windows.Forms.GroupBox();
            this.groupBox1_Produit = new System.Windows.Forms.GroupBox();
            this.textBox4_medecin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3_prenom = new System.Windows.Forms.TextBox();
            this.textBox2_nom = new System.Windows.Forms.TextBox();
            this.textBox1_cin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_libelle = new System.Windows.Forms.TextBox();
            this.textBox_prix = new System.Windows.Forms.TextBox();
            this.textBox_refProduit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_quantite = new System.Windows.Forms.TextBox();
            this.button_appliquer = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_chercher = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1_FactureClient.SuspendLayout();
            this.groupBox1_Patient.SuspendLayout();
            this.groupBox1_Produit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1_FactureClient
            // 
            this.groupBox1_FactureClient.Controls.Add(this.dateTimePicker1);
            this.groupBox1_FactureClient.Controls.Add(this.dataGridView1);
            this.groupBox1_FactureClient.Controls.Add(this.button_appliquer);
            this.groupBox1_FactureClient.Controls.Add(this.groupBox1_Produit);
            this.groupBox1_FactureClient.Controls.Add(this.button_vider);
            this.groupBox1_FactureClient.Controls.Add(this.groupBox1_Patient);
            this.groupBox1_FactureClient.Controls.Add(this.button_chercher);
            this.groupBox1_FactureClient.Controls.Add(this.button_modifier);
            this.groupBox1_FactureClient.Controls.Add(this.button_ajouter);
            this.groupBox1_FactureClient.Location = new System.Drawing.Point(41, 12);
            this.groupBox1_FactureClient.Name = "groupBox1_FactureClient";
            this.groupBox1_FactureClient.Size = new System.Drawing.Size(1011, 670);
            this.groupBox1_FactureClient.TabIndex = 0;
            this.groupBox1_FactureClient.TabStop = false;
            this.groupBox1_FactureClient.Text = "Facture Client";
            // 
            // groupBox1_Patient
            // 
            this.groupBox1_Patient.Controls.Add(this.textBox4_medecin);
            this.groupBox1_Patient.Controls.Add(this.label1);
            this.groupBox1_Patient.Controls.Add(this.label4);
            this.groupBox1_Patient.Controls.Add(this.label2);
            this.groupBox1_Patient.Controls.Add(this.textBox3_prenom);
            this.groupBox1_Patient.Controls.Add(this.label3);
            this.groupBox1_Patient.Controls.Add(this.textBox2_nom);
            this.groupBox1_Patient.Controls.Add(this.textBox1_cin);
            this.groupBox1_Patient.Location = new System.Drawing.Point(38, 80);
            this.groupBox1_Patient.Name = "groupBox1_Patient";
            this.groupBox1_Patient.Size = new System.Drawing.Size(459, 284);
            this.groupBox1_Patient.TabIndex = 0;
            this.groupBox1_Patient.TabStop = false;
            this.groupBox1_Patient.Text = "Patient";
            // 
            // groupBox1_Produit
            // 
            this.groupBox1_Produit.Controls.Add(this.textBox_quantite);
            this.groupBox1_Produit.Controls.Add(this.label9);
            this.groupBox1_Produit.Controls.Add(this.textBox_libelle);
            this.groupBox1_Produit.Controls.Add(this.textBox_prix);
            this.groupBox1_Produit.Controls.Add(this.textBox_refProduit);
            this.groupBox1_Produit.Controls.Add(this.label5);
            this.groupBox1_Produit.Controls.Add(this.label6);
            this.groupBox1_Produit.Controls.Add(this.label7);
            this.groupBox1_Produit.Controls.Add(this.label8);
            this.groupBox1_Produit.Location = new System.Drawing.Point(530, 82);
            this.groupBox1_Produit.Name = "groupBox1_Produit";
            this.groupBox1_Produit.Size = new System.Drawing.Size(457, 282);
            this.groupBox1_Produit.TabIndex = 1;
            this.groupBox1_Produit.TabStop = false;
            this.groupBox1_Produit.Text = "Produit";
            // 
            // textBox4_medecin
            // 
            this.textBox4_medecin.Location = new System.Drawing.Point(234, 197);
            this.textBox4_medecin.Name = "textBox4_medecin";
            this.textBox4_medecin.Size = new System.Drawing.Size(169, 26);
            this.textBox4_medecin.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Médecin Traitant";
            // 
            // textBox3_prenom
            // 
            this.textBox3_prenom.Location = new System.Drawing.Point(234, 139);
            this.textBox3_prenom.Name = "textBox3_prenom";
            this.textBox3_prenom.Size = new System.Drawing.Size(169, 26);
            this.textBox3_prenom.TabIndex = 21;
            // 
            // textBox2_nom
            // 
            this.textBox2_nom.Location = new System.Drawing.Point(234, 92);
            this.textBox2_nom.Name = "textBox2_nom";
            this.textBox2_nom.Size = new System.Drawing.Size(169, 26);
            this.textBox2_nom.TabIndex = 20;
            // 
            // textBox1_cin
            // 
            this.textBox1_cin.Location = new System.Drawing.Point(234, 40);
            this.textBox1_cin.Name = "textBox1_cin";
            this.textBox1_cin.Size = new System.Drawing.Size(169, 26);
            this.textBox1_cin.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "N° CIN";
            // 
            // textBox_libelle
            // 
            this.textBox_libelle.Location = new System.Drawing.Point(254, 84);
            this.textBox_libelle.Name = "textBox_libelle";
            this.textBox_libelle.Size = new System.Drawing.Size(169, 26);
            this.textBox_libelle.TabIndex = 15;
            // 
            // textBox_prix
            // 
            this.textBox_prix.Location = new System.Drawing.Point(254, 135);
            this.textBox_prix.Name = "textBox_prix";
            this.textBox_prix.Size = new System.Drawing.Size(169, 26);
            this.textBox_prix.TabIndex = 14;
            // 
            // textBox_refProduit
            // 
            this.textBox_refProduit.Location = new System.Drawing.Point(254, 36);
            this.textBox_refProduit.Name = "textBox_refProduit";
            this.textBox_refProduit.Size = new System.Drawing.Size(169, 26);
            this.textBox_refProduit.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Libellé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Référence du Produit *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quantité";
            // 
            // textBox_quantite
            // 
            this.textBox_quantite.Location = new System.Drawing.Point(254, 195);
            this.textBox_quantite.Name = "textBox_quantite";
            this.textBox_quantite.Size = new System.Drawing.Size(169, 26);
            this.textBox_quantite.TabIndex = 17;
            // 
            // button_appliquer
            // 
            this.button_appliquer.Location = new System.Drawing.Point(635, 398);
            this.button_appliquer.Name = "button_appliquer";
            this.button_appliquer.Size = new System.Drawing.Size(143, 45);
            this.button_appliquer.TabIndex = 22;
            this.button_appliquer.Text = "Appliquer";
            this.button_appliquer.UseVisualStyleBackColor = true;
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(832, 398);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(143, 45);
            this.button_vider.TabIndex = 21;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            // 
            // button_chercher
            // 
            this.button_chercher.Location = new System.Drawing.Point(437, 396);
            this.button_chercher.Name = "button_chercher";
            this.button_chercher.Size = new System.Drawing.Size(143, 45);
            this.button_chercher.TabIndex = 20;
            this.button_chercher.Text = "Chercher";
            this.button_chercher.UseVisualStyleBackColor = true;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(240, 398);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(143, 40);
            this.button_modifier.TabIndex = 19;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(38, 395);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(143, 43);
            this.button_ajouter.TabIndex = 18;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(23, 482);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(876, 165);
            this.dataGridView1.TabIndex = 23;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N° CIN";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RefProduit";
            this.Column1.HeaderText = "Réference Produit";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Libelle";
            this.Column3.HeaderText = "Libelle produit";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Prix";
            this.Column4.HeaderText = "Prix produit";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(607, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(355, 26);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // FactureClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 702);
            this.Controls.Add(this.groupBox1_FactureClient);
            this.Name = "FactureClientForm";
            this.Text = "FactureClientForm";
            this.groupBox1_FactureClient.ResumeLayout(false);
            this.groupBox1_Patient.ResumeLayout(false);
            this.groupBox1_Patient.PerformLayout();
            this.groupBox1_Produit.ResumeLayout(false);
            this.groupBox1_Produit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_FactureClient;
        private System.Windows.Forms.GroupBox groupBox1_Produit;
        private System.Windows.Forms.GroupBox groupBox1_Patient;
        private System.Windows.Forms.TextBox textBox4_medecin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3_prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2_nom;
        private System.Windows.Forms.TextBox textBox1_cin;
        private System.Windows.Forms.TextBox textBox_quantite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_libelle;
        private System.Windows.Forms.TextBox textBox_prix;
        private System.Windows.Forms.TextBox textBox_refProduit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_appliquer;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_chercher;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}