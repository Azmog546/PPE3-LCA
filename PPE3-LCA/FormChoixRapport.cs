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
            bsMedecin.DataSource = Modele.listeMedecin();
            cboMedecin.DataSource = bsMedecin;
        }

        private void CboListePrati_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
