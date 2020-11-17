﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_LCA
{
    public partial class FProfil : Form
    {
        public FProfil()
        {
            InitializeComponent();
        }

        private void FProfil_Load(object sender, EventArgs e)
        {
            Visiteur utilisateurConnected = Modele.getUtilisateurConnected();

            txtNom.Text = utilisateurConnected.nom;
            txtPrenom.Text = utilisateurConnected.prenom;
            txtIdentifiant.Text = utilisateurConnected.identifiant;
            txtAdresse.Text = utilisateurConnected.rue;
            txtVille.Text = utilisateurConnected.ville;
            txtCodePostal.Text = utilisateurConnected.cp;
            lblDateEmbauche.Text = "Embauché le " + utilisateurConnected.dateEmbauche.ToString();

            lblModifEnreg.Visible = false;
        }

        private void BtnModifInfo_Click(object sender, EventArgs e)
        {
            txtNom.Enabled = true;
            txtPrenom.Enabled = true;
            txtIdentifiant.Enabled = true;
            txtAdresse.Enabled = true;
            txtVille.Enabled = true;
            txtCodePostal.Enabled = true;

            btnValiderModif.Visible = true;
            btnModifInfo.Enabled = false;
            lblModifEnreg.Visible = false;

        }

        private void BtnValiderModif_Click(object sender, EventArgs e)
        {
            ModeleMission1.modifInfoUtilisateur(txtNom.Text, txtPrenom.Text, txtIdentifiant.Text, txtAdresse.Text, txtVille.Text, txtCodePostal.Text);

            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtIdentifiant.Enabled = false;
            txtAdresse.Enabled = false;
            txtVille.Enabled = false;
            txtCodePostal.Enabled = false;

            btnValiderModif.Visible = false;
            btnModifInfo.Enabled = true;
            lblModifEnreg.Visible = true;

        }

        private void BtnModifMDP_Click(object sender, EventArgs e)
        {
            FModifMDP FMo = new FModifMDP();
            FMo.ShowDialog();
            
            
        }
    }
}
