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
    public partial class FResponsabilite : Form
    {
        public FResponsabilite()
        {
            InitializeComponent();
        }

        private void FResponsabilite_Load(object sender, EventArgs e)
        {

            //bsRegionResp.DataSource = ModeleMission1.listRegionResponsable(Modele.getUtilisateurConnected().idVisiteur);
            bsRegionResp.DataSource = Modele.getUtilisateurConnected().Region.ToList();
            dgvRegionResp.DataSource = bsRegionResp.DataSource;

            for (int i = 0; i < dgvRegionResp.ColumnCount; i++)
            {
                dgvRegionResp.Columns[i].Visible = false;
            }
            dgvRegionResp.Columns["libRegion"].Visible = true;
            dgvRegionResp.Columns["libRegion"].HeaderText = "Nom de la région";

            if(dgvRegionResp.RowCount == 0)
            {
                //MARCHE PAS
                //dgvRegionResp.Rows.Add("Aucune région");

            }

            bsSecteurResp.DataSource = Modele.getUtilisateurConnected().Secteur.ToList();
            dgvSecteurResp.DataSource = bsSecteurResp.DataSource;

            for (int i = 0; i < dgvSecteurResp.ColumnCount; i++)
            {
                dgvSecteurResp.Columns[i].Visible = false;
            }
            dgvSecteurResp.Columns["libSecteur"].Visible = true;
            dgvSecteurResp.Columns["libSecteur"].HeaderText = "Nom de la région";


        }
    }
}
