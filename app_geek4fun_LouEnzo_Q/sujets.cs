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
    public partial class sujets : Form
    {
        public sujets()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            theme theme = new theme();
            theme.ShowDialog();
            theme.Closed += (s, args) => this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Hide();
            theme theme = new theme();
            theme.ShowDialog();
            theme.Closed += (s, args) => this.Close();
        }
    }
}
