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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void SeConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConnex FCo = new FConnex();
            FCo.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FGestionVisite FGv = new FGestionVisite();
            FGv.Show();
        }
    }
}
