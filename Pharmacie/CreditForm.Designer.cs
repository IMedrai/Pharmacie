namespace Pharmacie
{
    partial class CreditForm
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
            this.textBox3_montantCredit = new System.Windows.Forms.TextBox();
            this.textBox2_cin = new System.Windows.Forms.TextBox();
            this.textBox1_dateCredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4_MontantTotal = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_supprimer);
            this.groupBox1.Controls.Add(this.textBox4_MontantTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_appliquer);
            this.groupBox1.Controls.Add(this.button_vider);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_chercher);
            this.groupBox1.Controls.Add(this.button_modifier);
            this.groupBox1.Controls.Add(this.button_ajouter);
            this.groupBox1.Controls.Add(this.textBox3_montantCredit);
            this.groupBox1.Controls.Add(this.textBox2_cin);
            this.groupBox1.Controls.Add(this.textBox1_dateCredit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 676);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crédits";
            // 
            // button_appliquer
            // 
            this.button_appliquer.Location = new System.Drawing.Point(521, 313);
            this.button_appliquer.Name = "button_appliquer";
            this.button_appliquer.Size = new System.Drawing.Size(143, 45);
            this.button_appliquer.TabIndex = 13;
            this.button_appliquer.Text = "Appliquer";
            this.button_appliquer.UseVisualStyleBackColor = true;
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(521, 262);
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(687, 188);
            this.dataGridView1.TabIndex = 11;
            // 
            // button_chercher
            // 
            this.button_chercher.Location = new System.Drawing.Point(521, 203);
            this.button_chercher.Name = "button_chercher";
            this.button_chercher.Size = new System.Drawing.Size(143, 45);
            this.button_chercher.TabIndex = 10;
            this.button_chercher.Text = "Chercher";
            this.button_chercher.UseVisualStyleBackColor = true;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(521, 83);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(143, 40);
            this.button_modifier.TabIndex = 9;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(521, 34);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(143, 43);
            this.button_ajouter.TabIndex = 8;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // textBox3_montantCredit
            // 
            this.textBox3_montantCredit.Location = new System.Drawing.Point(252, 167);
            this.textBox3_montantCredit.Name = "textBox3_montantCredit";
            this.textBox3_montantCredit.Size = new System.Drawing.Size(169, 26);
            this.textBox3_montantCredit.TabIndex = 6;
            // 
            // textBox2_cin
            // 
            this.textBox2_cin.Location = new System.Drawing.Point(252, 120);
            this.textBox2_cin.Name = "textBox2_cin";
            this.textBox2_cin.Size = new System.Drawing.Size(169, 26);
            this.textBox2_cin.TabIndex = 5;
            // 
            // textBox1_dateCredit
            // 
            this.textBox1_dateCredit.Location = new System.Drawing.Point(252, 68);
            this.textBox1_dateCredit.Name = "textBox1_dateCredit";
            this.textBox1_dateCredit.Size = new System.Drawing.Size(169, 26);
            this.textBox1_dateCredit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Montant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° CIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Crédit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Montant Total";
            // 
            // textBox4_MontantTotal
            // 
            this.textBox4_MontantTotal.Location = new System.Drawing.Point(252, 225);
            this.textBox4_MontantTotal.Name = "textBox4_MontantTotal";
            this.textBox4_MontantTotal.Size = new System.Drawing.Size(169, 26);
            this.textBox4_MontantTotal.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DateCredit";
            this.Column1.HeaderText = "Date Crédit";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cin";
            this.Column2.HeaderText = "N° CIN";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "montant";
            this.Column3.HeaderText = "Montant";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "montantTotal";
            this.Column4.HeaderText = "Montant Total";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(521, 139);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(143, 45);
            this.button_supprimer.TabIndex = 16;
            this.button_supprimer.Text = "Appliquer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 742);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreditForm";
            this.Text = "CreditForm";
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
        private System.Windows.Forms.TextBox textBox3_montantCredit;
        private System.Windows.Forms.TextBox textBox2_cin;
        private System.Windows.Forms.TextBox textBox1_dateCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4_MontantTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button_supprimer;
    }
}