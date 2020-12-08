namespace PPE3_LCA
{
    partial class FRemplirFrais
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
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblMois = new System.Windows.Forms.Label();
            this.txtMois = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl1Colonne = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.lblrepas = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.lblNuité = new System.Windows.Forms.Label();
            this.txtMontantRepas = new System.Windows.Forms.TextBox();
            this.txtRepasQte = new System.Windows.Forms.TextBox();
            this.txtKmTotal = new System.Windows.Forms.TextBox();
            this.txtNuitMontant = new System.Windows.Forms.TextBox();
            this.txtRepasTotal = new System.Windows.Forms.TextBox();
            this.txtNuitéQte = new System.Windows.Forms.TextBox();
            this.lblMontantUnitaire = new System.Windows.Forms.Label();
            this.txtNuitéTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtMontantKm = new System.Windows.Forms.TextBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cbVehicule = new System.Windows.Forms.ComboBox();
            this.dgvAfficheVehicule = new System.Windows.Forms.DataGridView();
            this.numKm = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficheVehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(12, 61);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(41, 13);
            this.lblVisiteur.TabIndex = 0;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(286, 13);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(142, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "ETAT DE FRAIS ENGAGES";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(117, 61);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 2;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(120, 106);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(244, 58);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(318, 20);
            this.txtMatricule.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(244, 103);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(318, 20);
            this.txtNom.TabIndex = 5;
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(15, 160);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(29, 13);
            this.lblMois.TabIndex = 6;
            this.lblMois.Text = "Mois";
            // 
            // txtMois
            // 
            this.txtMois.Location = new System.Drawing.Point(244, 157);
            this.txtMois.Name = "txtMois";
            this.txtMois.Size = new System.Drawing.Size(147, 20);
            this.txtMois.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.36122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.63879F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.Controls.Add(this.lbl1Colonne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblKilo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtKm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblrepas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQte, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNuité, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMontantRepas, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRepasQte, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtKmTotal, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNuitMontant, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRepasTotal, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNuitéQte, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMontantUnitaire, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNuitéTotal, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMontantKm, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(120, 209);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.64286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.35714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 106);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // lbl1Colonne
            // 
            this.lbl1Colonne.AutoSize = true;
            this.lbl1Colonne.Location = new System.Drawing.Point(4, 1);
            this.lbl1Colonne.Name = "lbl1Colonne";
            this.lbl1Colonne.Size = new System.Drawing.Size(53, 20);
            this.lbl1Colonne.TabIndex = 8;
            this.lbl1Colonne.Text = "Frais Forfaitaire";
            this.lbl1Colonne.Click += new System.EventHandler(this.Lbl1Colonne_Click);
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Location = new System.Drawing.Point(4, 76);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(62, 13);
            this.lblKilo.TabIndex = 13;
            this.lblKilo.Text = "Kilométrage";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(83, 79);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(137, 20);
            this.txtKm.TabIndex = 15;
            // 
            // lblrepas
            // 
            this.lblrepas.AutoSize = true;
            this.lblrepas.Location = new System.Drawing.Point(4, 48);
            this.lblrepas.Name = "lblrepas";
            this.lblrepas.Size = new System.Drawing.Size(60, 13);
            this.lblrepas.TabIndex = 10;
            this.lblrepas.Text = "Repas Midi";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(83, 1);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(47, 13);
            this.lblQte.TabIndex = 12;
            this.lblQte.Text = "Quantité";
            // 
            // lblNuité
            // 
            this.lblNuité.AutoSize = true;
            this.lblNuité.Location = new System.Drawing.Point(4, 22);
            this.lblNuité.Name = "lblNuité";
            this.lblNuité.Size = new System.Drawing.Size(32, 13);
            this.lblNuité.TabIndex = 9;
            this.lblNuité.Text = "Nuité";
            // 
            // txtMontantRepas
            // 
            this.txtMontantRepas.Location = new System.Drawing.Point(227, 51);
            this.txtMontantRepas.Name = "txtMontantRepas";
            this.txtMontantRepas.Size = new System.Drawing.Size(127, 20);
            this.txtMontantRepas.TabIndex = 22;
            // 
            // txtRepasQte
            // 
            this.txtRepasQte.Location = new System.Drawing.Point(83, 51);
            this.txtRepasQte.Name = "txtRepasQte";
            this.txtRepasQte.Size = new System.Drawing.Size(137, 20);
            this.txtRepasQte.TabIndex = 14;
            // 
            // txtKmTotal
            // 
            this.txtKmTotal.Location = new System.Drawing.Point(365, 79);
            this.txtKmTotal.Name = "txtKmTotal";
            this.txtKmTotal.Size = new System.Drawing.Size(146, 20);
            this.txtKmTotal.TabIndex = 20;
            // 
            // txtNuitMontant
            // 
            this.txtNuitMontant.Location = new System.Drawing.Point(227, 25);
            this.txtNuitMontant.Name = "txtNuitMontant";
            this.txtNuitMontant.Size = new System.Drawing.Size(127, 20);
            this.txtNuitMontant.TabIndex = 21;
            // 
            // txtRepasTotal
            // 
            this.txtRepasTotal.Location = new System.Drawing.Point(365, 51);
            this.txtRepasTotal.Name = "txtRepasTotal";
            this.txtRepasTotal.Size = new System.Drawing.Size(146, 20);
            this.txtRepasTotal.TabIndex = 19;
            // 
            // txtNuitéQte
            // 
            this.txtNuitéQte.Location = new System.Drawing.Point(83, 25);
            this.txtNuitéQte.Name = "txtNuitéQte";
            this.txtNuitéQte.Size = new System.Drawing.Size(137, 20);
            this.txtNuitéQte.TabIndex = 11;
            // 
            // lblMontantUnitaire
            // 
            this.lblMontantUnitaire.AutoSize = true;
            this.lblMontantUnitaire.Location = new System.Drawing.Point(227, 1);
            this.lblMontantUnitaire.Name = "lblMontantUnitaire";
            this.lblMontantUnitaire.Size = new System.Drawing.Size(83, 13);
            this.lblMontantUnitaire.TabIndex = 16;
            this.lblMontantUnitaire.Text = "Montant unitaire";
            // 
            // txtNuitéTotal
            // 
            this.txtNuitéTotal.Location = new System.Drawing.Point(365, 25);
            this.txtNuitéTotal.Name = "txtNuitéTotal";
            this.txtNuitéTotal.Size = new System.Drawing.Size(146, 20);
            this.txtNuitéTotal.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(365, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total";
            // 
            // txtMontantKm
            // 
            this.txtMontantKm.Location = new System.Drawing.Point(227, 79);
            this.txtMontantKm.Name = "txtMontantKm";
            this.txtMontantKm.Size = new System.Drawing.Size(127, 20);
            this.txtMontantKm.TabIndex = 23;
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(429, 343);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(75, 23);
            this.BtnAjout.TabIndex = 25;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(534, 343);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // cbVehicule
            // 
            this.cbVehicule.FormattingEnabled = true;
            this.cbVehicule.Location = new System.Drawing.Point(111, 343);
            this.cbVehicule.Name = "cbVehicule";
            this.cbVehicule.Size = new System.Drawing.Size(121, 21);
            this.cbVehicule.TabIndex = 27;
            // 
            // dgvAfficheVehicule
            // 
            this.dgvAfficheVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfficheVehicule.Location = new System.Drawing.Point(111, 375);
            this.dgvAfficheVehicule.Name = "dgvAfficheVehicule";
            this.dgvAfficheVehicule.Size = new System.Drawing.Size(611, 150);
            this.dgvAfficheVehicule.TabIndex = 28;
            // 
            // numKm
            // 
            this.numKm.Location = new System.Drawing.Point(289, 343);
            this.numKm.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numKm.Name = "numKm";
            this.numKm.Size = new System.Drawing.Size(84, 20);
            this.numKm.TabIndex = 29;
            // 
            // FRemplirFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.numKm);
            this.Controls.Add(this.dgvAfficheVehicule);
            this.Controls.Add(this.cbVehicule);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtMois);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblVisiteur);
            this.Name = "FRemplirFrais";
            this.Text = "FRemplirFrais";
            this.Load += new System.EventHandler(this.FRemplirFrais_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficheVehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.TextBox txtMois;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtMontantKm;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtMontantRepas;
        private System.Windows.Forms.TextBox txtRepasQte;
        private System.Windows.Forms.TextBox txtKmTotal;
        private System.Windows.Forms.TextBox txtNuitMontant;
        private System.Windows.Forms.TextBox txtRepasTotal;
        private System.Windows.Forms.TextBox txtNuitéQte;
        private System.Windows.Forms.TextBox txtNuitéTotal;
        private System.Windows.Forms.Label lblrepas;
        private System.Windows.Forms.Label lbl1Colonne;
        private System.Windows.Forms.Label lblNuité;
        private System.Windows.Forms.Label lblMontantUnitaire;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cbVehicule;
        private System.Windows.Forms.DataGridView dgvAfficheVehicule;
        private System.Windows.Forms.NumericUpDown numKm;
    }
}