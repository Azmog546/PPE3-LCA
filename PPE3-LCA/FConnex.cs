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
            Modele.TestIdentifiant()
        }
    }
}
