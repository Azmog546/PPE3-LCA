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
    public partial class FModifMDP : Form
    {
        public FModifMDP()
        {
            InitializeComponent();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            Modele.modifPassword(txtNouvMDP.Text);
        }

        private void TxtNouvMDP_TextChanged(object sender, EventArgs e)
        {
            TestMDP(txtNouvMDP.Text, txtConfMDP.Text);
        }

        private void TestMDP(string unMDP, string uneConfMDP)
        {
            string erreur = "";
            bool authoriseValid = false;

            if (unMDP.Length >= 5)
            {
                if (unMDP == uneConfMDP)
                {
                    erreur = "";
                    authoriseValid = true;
                }
                else
                {
                    authoriseValid = false;
                    erreur = "Le mot de passe doit être identique.";
                }
            }
            else
            {
                authoriseValid = false;
                erreur = "Le mot de passe doit avoir au moins 5 caractères.";
            }

            btnValider.Enabled = authoriseValid;
            lblErreur.Text = erreur;
        }

        private void TxtConfMDP_TextChanged(object sender, EventArgs e)
        {
            TestMDP(txtNouvMDP.Text, txtConfMDP.Text);
        }
    }
}
