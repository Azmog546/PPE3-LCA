using System;
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
    public partial class FormChoixRapport : Form
    {
        public FormChoixRapport()
        {
            InitializeComponent();
        }

        private void FormChoixRapport_Load(object sender, EventArgs e)
        {
            cboMedecin.ValueMember = "idMedecin";
            cboMedecin.DisplayMember = "nom";
            bsRapport.DataSource = ModeleMission2.listeMedecin();
            cboMedecin.DataSource = bsRapport;
        }

        /*   private void CboMedecin_SelectedIndexChanged(object sender, EventArgs e)
           {
               bsMedecin.DataSource = ModeleMission2.RapportParMedecin(int.Parse(cboMedecin.SelectedValue.ToString()));
               dgvRapport.DataSource = bsMedecin;
               dgvRapport.Columns[0].HeaderText = "idRapport";
               dgvRapport.Columns[1].HeaderText = "dateRapport";
               dgvRapport.Columns[2].HeaderText = "idModif";
               dgvRapport.Columns[3].HeaderText = "bilan";

           }
           */


        private void Button3_Click(object sender, EventArgs e)
        {
            FGestionVisite FGV = new FGestionVisite();
            FGV.Show();
        }

        private void BsMedecin_CurrentChanged(object sender, EventArgs e)
        {
            bool fermeture = false;
            if (fermeture) return;
            bsRapport.DataSource = ((MEDECIN)bsMedecin.Current).RAPPORT.ToList().OrderBy(y => y.idRapport).ThenBy(y => y.dateRapport).ToList ();
            dgvRapport.DataSource = bsRapport;
            //Modification des colonnes de la grille
            for (int i = 0; i < dgvRapport.ColumnCount; i++)
            {
                dgvRapport.Columns[i].Visible = false;
            }
            dgvRapport.Columns["idRapport"].Visible = true;
            dgvRapport.Columns["dateRapport"].Visible = true;
            dgvRapport.Columns["idRapport"].HeaderText = "id Rapport";
            dgvRapport.Columns["idRapport"].DisplayIndex = 0;
            dgvRapport.Columns["dateRapport"].HeaderText = "Date Rapport";
            dgvRapport.Columns["dateRapport"].DisplayIndex = 1;
        }
    }
}
