namespace Pharmacie
{
    partial class StockForm
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
            this.button_appliquer = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_chercher = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.textBox2_qte = new System.Windows.Forms.TextBox();
            this.textBox1_refProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_appliquer);
            this.groupBox1.Controls.Add(this.button_vider);
            this.groupBox1.Controls.Add(this.button_chercher);
            this.groupBox1.Controls.Add(this.button_modifier);
            this.groupBox1.Controls.Add(this.button_ajouter);
            this.groupBox1.Controls.Add(this.textBox2_qte);
            this.groupBox1.Controls.Add(this.textBox1_refProduit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(48, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(428, 144);
            this.dataGridView1.TabIndex = 19;
            // 
            // button_appliquer
            // 
            this.button_appliquer.Location = new System.Drawing.Point(555, 240);
            this.button_appliquer.Name = "button_appliquer";
            this.button_appliquer.Size = new System.Drawing.Size(143, 45);
            this.button_appliquer.TabIndex = 18;
            this.button_appliquer.Text = "Appliquer";
            this.button_appliquer.UseVisualStyleBackColor = true;
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(555, 189);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(143, 45);
            this.button_vider.TabIndex = 17;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            // 
            // button_chercher
            // 
            this.button_chercher.Location = new System.Drawing.Point(555, 138);
            this.button_chercher.Name = "button_chercher";
            this.button_chercher.Size = new System.Drawing.Size(143, 45);
            this.button_chercher.TabIndex = 16;
            this.button_chercher.Text = "Chercher";
            this.button_chercher.UseVisualStyleBackColor = true;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(555, 95);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(143, 40);
            this.button_modifier.TabIndex = 15;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(555, 46);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(143, 43);
            this.button_ajouter.TabIndex = 14;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // textBox2_qte
            // 
            this.textBox2_qte.Location = new System.Drawing.Point(282, 119);
            this.textBox2_qte.Name = "textBox2_qte";
            this.textBox2_qte.Size = new System.Drawing.Size(165, 26);
            this.textBox2_qte.TabIndex = 4;
            // 
            // textBox1_refProduit
            // 
            this.textBox1_refProduit.Location = new System.Drawing.Point(281, 65);
            this.textBox1_refProduit.Name = "textBox1_refProduit";
            this.textBox1_refProduit.Size = new System.Drawing.Size(166, 26);
            this.textBox1_refProduit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence Produit";
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
            this.Column2.DataPropertyName = "qte";
            this.Column2.HeaderText = "Quantité";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_appliquer;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_chercher;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.TextBox textBox2_qte;
        private System.Windows.Forms.TextBox textBox1_refProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}