namespace PPE3_LCA
{
    partial class FFraisEngage
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblInfon1 = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblMois = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(275, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(142, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "ETAT DE FRAIS ENGAGES";
            // 
            // lblInfon1
            // 
            this.lblInfon1.AutoSize = true;
            this.lblInfon1.Location = new System.Drawing.Point(133, 44);
            this.lblInfon1.Name = "lblInfon1";
            this.lblInfon1.Size = new System.Drawing.Size(466, 13);
            this.lblInfon1.TabIndex = 1;
            this.lblInfon1.Text = "A retourner, accompagné des justificatifs au plus tard le 10 du mois qui suit l’e" +
    "ngagement des frais";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(50, 99);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 2;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(50, 137);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(155, 96);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(444, 20);
            this.txtMatricule.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(155, 134);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(444, 20);
            this.txtNom.TabIndex = 5;
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(50, 178);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(29, 13);
            this.lblMois.TabIndex = 6;
            this.lblMois.Text = "Mois";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 7;
            // 
            // FFraisEngage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblInfon1);
            this.Controls.Add(this.lblTitre);
            this.Name = "FFraisEngage";
            this.Text = "FFraisEngage";
            this.Load += new System.EventHandler(this.FFraisEngage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblInfon1;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.TextBox textBox1;
    }
}