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
    public partial class FConnex : Form
    {
        private int nbEssai=0;
        public FConnex()
        {
            InitializeComponent();
        }

        private void PanelConnexion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            string identifiant = txtIdentifiant.Text;
            string password = txtPassword.Text;
            bool test = Modele.testIdentifiant(identifiant);
            if(test==false)
            {
                nbEssai += 1;
                lblEssai.Visible = true;
                lblEssai.Text = "Essai "+nbEssai;
            }
            else
            {
                //
            }
        }
    }
}
