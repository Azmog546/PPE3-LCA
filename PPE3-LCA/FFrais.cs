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
    public partial class FFrais : Form
    {
        private DateTime moment = DateTime.Now;
        private int[] mois = new int[12] { 0, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        private string[] month = new string[12];
        int now;
        public FFrais()
        {
            InitializeComponent();
            now = moment.Month;
            for (int i = 0; i < 12; i++)
            {
                mois[i] = (mois[i] + now) % 12;
                switch (mois[i]) 
                {
                    case 0 : month[i] = "Decembre"; break;
                    case 1 : month[i] = "Janvier"; break;
                    case 2 : month[i] = "Fevrier"; break;
                    case 3 : month[i] = "Mars"; break;
                    case 4 : month[i] = "Avril"; break;
                    case 5 : month[i] = "Mai"; break;
                    case 6 : month[i] = "Juin"; break;
                    case 7 : month[i] = "Juillet"; break;
                    case 8 : month[i] = "Aout"; break;
                    case 9 : month[i] = "Septembre"; break;
                    case 10 : month[i] = "Octobre"; break;
                    case 11 : month[i] = "Novembre"; break;
                }
                cbFrais.Items.Add(month[i]);
            }
            cbFrais.SelectedIndex = 0;                 
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FFrais_Load(object sender, EventArgs e)
        {

        }

        private void BtnAffiche_Click(object sender, EventArgs e)
        {
            FAfficheFrais FAF = new FAfficheFrais();
            FAF.Show();
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            FRemplirFrais FRF = new FRemplirFrais();
            FRF.Show();
        }
    }
}
