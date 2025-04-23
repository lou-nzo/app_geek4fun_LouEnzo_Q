using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_geek4fun_LouEnzo_Q
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            this.Hide();
            connexion connexion = new connexion();
            connexion.ShowDialog();
            connexion.Closed += (s, args) => this.Close();
        }
    }
}
