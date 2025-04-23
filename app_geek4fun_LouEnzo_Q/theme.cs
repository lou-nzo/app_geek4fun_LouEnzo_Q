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
    public partial class theme : Form
    {
        public theme()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sujets sujets = new sujets();
            sujets.ShowDialog();
            sujets.Closed += (s, args) => this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sujets sujets = new sujets();
            sujets.ShowDialog();
            sujets.Closed += (s, args) => this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            sujets sujets = new sujets();
            sujets.ShowDialog();
            sujets.Closed += (s, args) => this.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            sujets sujets = new sujets();
            sujets.ShowDialog();
            sujets.Closed += (s, args) => this.Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.Hide();
            sujets sujets = new sujets();
            sujets.ShowDialog();
            sujets.Closed += (s, args) => this.Close();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.Hide();
            sujets sujets = new sujets();
            sujets.ShowDialog();
            sujets.Closed += (s, args) => this.Close();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Hide();
            sujets sujets = new sujets();
            sujets.ShowDialog();
            sujets.Closed += (s, args) => this.Close();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.Hide();
            sujets sujets = new sujets();
            sujets.ShowDialog();
            sujets.Closed += (s, args) => this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            choix choix = new choix();
            choix.ShowDialog();
            choix.Closed += (s, args) => this.Close();
        }
    }
}
