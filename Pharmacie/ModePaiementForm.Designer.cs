namespace Pharmacie
{
    partial class ModePaiementForm
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
            this.button_Vider = new System.Windows.Forms.Button();
            this.textBox2_montantMax = new System.Windows.Forms.TextBox();
            this.textBox1_montantMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_appliquer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_appliquer);
            this.groupBox1.Controls.Add(this.button_Vider);
            this.groupBox1.Controls.Add(this.textBox2_montantMax);
            this.groupBox1.Controls.Add(this.textBox1_montantMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modes de Paiement";
            // 
            // button_Vider
            // 
            this.button_Vider.Location = new System.Drawing.Point(516, 80);
            this.button_Vider.Name = "button_Vider";
            this.button_Vider.Size = new System.Drawing.Size(139, 43);
            this.button_Vider.TabIndex = 7;
            this.button_Vider.Text = "Vider";
            this.button_Vider.UseVisualStyleBackColor = true;
            // 
            // textBox2_montantMax
            // 
            this.textBox2_montantMax.Location = new System.Drawing.Point(242, 179);
            this.textBox2_montantMax.Name = "textBox2_montantMax";
            this.textBox2_montantMax.Size = new System.Drawing.Size(187, 26);
            this.textBox2_montantMax.TabIndex = 5;
            // 
            // textBox1_montantMin
            // 
            this.textBox1_montantMin.Location = new System.Drawing.Point(245, 122);
            this.textBox1_montantMin.Name = "textBox1_montantMin";
            this.textBox1_montantMin.Size = new System.Drawing.Size(185, 26);
            this.textBox1_montantMin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Montant Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montant Min";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mode de Paiement";
            // 
            // button_appliquer
            // 
            this.button_appliquer.Location = new System.Drawing.Point(512, 160);
            this.button_appliquer.Name = "button_appliquer";
            this.button_appliquer.Size = new System.Drawing.Size(143, 45);
            this.button_appliquer.TabIndex = 19;
            this.button_appliquer.Text = "Appliquer";
            this.button_appliquer.UseVisualStyleBackColor = true;
            // 
            // ModePaiementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModePaiementForm";
            this.Text = "ModePaiementForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2_montantMax;
        private System.Windows.Forms.TextBox textBox1_montantMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Vider;
        private System.Windows.Forms.Button button_appliquer;
    }
}