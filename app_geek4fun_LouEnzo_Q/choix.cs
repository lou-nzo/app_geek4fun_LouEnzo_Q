using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace app_geek4fun_LouEnzo_Q
{
    public partial class choix : Form
    {
        #region variables
        MySqlConnection laConnection;
        MySqlDataAdapter da;
        DataSet ds;
        #endregion

        public choix()
        {
            InitializeComponent();
        }

        private void deconnexion()
        {
            try
            {
                laConnection.Close();
            }
            catch (MySqlException ex)
            {

            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            this.Hide();
            theme theme = new theme();
            theme.ShowDialog();
            theme.Closed += (s, args) => this.Close();
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            this.Hide();
            connexion connexion = new connexion();
            connexion.ShowDialog();
            connexion.Closed += (s, args) => this.Close();
            deconnexion();

        }
    }
}
