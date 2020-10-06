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
            bool test1 = Modele.testPassword(password);
            if(test)
            {
                lblEssai.Visible = true;
                lblEssai.Text = "Connexion";
            }
            else
            {
                lblEssai.Visible = true;
                lblEssai.Text = "Identifiant ou mot de passe incorrect";
            }
        }
    }
}
