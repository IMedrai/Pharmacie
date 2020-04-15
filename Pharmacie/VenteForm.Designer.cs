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
            this.button_appliquer = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_chercher = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.textBox3_cin = new System.Windows.Forms.TextBox();
            this.textBox2_refVente = new System.Windows.Forms.TextBox();
            this.textBox1_refProduit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_typePaiement = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1_typePaiement);
            this.groupBox1.Controls.Add(this.button_appliquer);
            this.groupBox1.Controls.Add(this.button_vider);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_chercher);
            this.groupBox1.Controls.Add(this.button_modifier);
            this.groupBox1.Controls.Add(this.button_ajouter);
            this.groupBox1.Controls.Add(this.textBox3_cin);
            this.groupBox1.Controls.Add(this.textBox2_refVente);
            this.groupBox1.Controls.Add(this.textBox1_refProduit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 608);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventes";
            // 
            // button_appliquer
            // 
            this.button_appliquer.Location = new System.Drawing.Point(610, 229);
            this.button_appliquer.Name = "button_appliquer";
            this.button_appliquer.Size = new System.Drawing.Size(143, 45);
            this.button_appliquer.TabIndex = 13;
            this.button_appliquer.Text = "Appliquer";
            this.button_appliquer.UseVisualStyleBackColor = true;
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(610, 178);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(143, 45);
            this.button_vider.TabIndex = 12;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(110, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(693, 237);
            this.dataGridView1.TabIndex = 11;
            // 
            // button_chercher
            // 
            this.button_chercher.Location = new System.Drawing.Point(610, 127);
            this.button_chercher.Name = "button_chercher";
            this.button_chercher.Size = new System.Drawing.Size(143, 45);
            this.button_chercher.TabIndex = 10;
            this.button_chercher.Text = "Chercher";
            this.button_chercher.UseVisualStyleBackColor = true;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(610, 84);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(143, 40);
            this.button_modifier.TabIndex = 9;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(610, 35);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(143, 43);
            this.button_ajouter.TabIndex = 8;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // textBox3_cin
            // 
            this.textBox3_cin.Location = new System.Drawing.Point(341, 229);
            this.textBox3_cin.Name = "textBox3_cin";
            this.textBox3_cin.Size = new System.Drawing.Size(169, 26);
            this.textBox3_cin.TabIndex = 6;
            // 
            // textBox2_refVente
            // 
            this.textBox2_refVente.Location = new System.Drawing.Point(341, 121);
            this.textBox2_refVente.Name = "textBox2_refVente";
            this.textBox2_refVente.Size = new System.Drawing.Size(169, 26);
            this.textBox2_refVente.TabIndex = 5;
            // 
            // textBox1_refProduit
            // 
            this.textBox1_refProduit.Location = new System.Drawing.Point(341, 69);
            this.textBox1_refProduit.Name = "textBox1_refProduit";
            this.textBox1_refProduit.Size = new System.Drawing.Size(169, 26);
            this.textBox1_refProduit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type de paiement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Référence Vente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence Produit";
            // 
            // comboBox1_typePaiement
            // 
            this.comboBox1_typePaiement.FormattingEnabled = true;
            this.comboBox1_typePaiement.Location = new System.Drawing.Point(345, 176);
            this.comboBox1_typePaiement.Name = "comboBox1_typePaiement";
            this.comboBox1_typePaiement.Size = new System.Drawing.Size(164, 28);
            this.comboBox1_typePaiement.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "N° CIN";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "refProduit";
            this.Column1.HeaderText = "Référence Produit";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "refVente";
            this.Column2.HeaderText = "Référence Vente";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "typePaiement";
            this.Column3.HeaderText = "Type de Paiement";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cin";
            this.Column4.HeaderText = "CIN";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // VenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 686);
            this.Controls.Add(this.groupBox1);
            this.Name = "VenteForm";
            this.Text = "VenteForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_appliquer;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_chercher;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.TextBox textBox3_cin;
        private System.Windows.Forms.TextBox textBox2_refVente;
        private System.Windows.Forms.TextBox textBox1_refProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1_typePaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}