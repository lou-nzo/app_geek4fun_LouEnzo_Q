using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib_geek4fun_LouEnzo;
using MySql.Data.MySqlClient;

namespace app_geek4fun_LouEnzo_Q
{
    public partial class connexion : Form
    {
        #region variables
        // Variables pour la BDD
        connexionBDD maConnexion;
        MySqlConnection uneConnexion;
        MySqlDataAdapter da;
        DataSet ds;
        #endregion

        public connexion()
        {
            InitializeComponent();

            // Instanciation d'une connexion et d'un quiz
            maConnexion = new connexionBDD();
            // Ouverture de la Connexion
            //uneConnexion = maConnexion.OuvertureConnexion();
        }
        private void deconnexion()
        {
            try
            {
                uneConnexion.Close();
            }
            catch (MySqlException ex)
            {

            }
        }
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            deconnexion();
            Application.Exit();
        }

        private void RecupLoginMdp()
        {
            if (uneConnexion != null)
            {
                MySqlCommand cmdFunc = new MySqlCommand("SELECT func_insert_eleve(@loginUti,@mdpUti)");

                cmdFunc.Connection = uneConnexion;

                cmdFunc.Parameters.Add(new MySqlParameter("@loginUti", MySqlDbType.String));
                cmdFunc.Parameters.Add(new MySqlParameter("@mdpUti", MySqlDbType.String));

                cmdFunc.Parameters["@loginUti"].Value = tbLogin.Text;
                cmdFunc.Parameters["@mdpUti"].Value = tbMdp.Text;

                object resultAjout = cmdFunc.ExecuteScalar();
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            choix choix = new choix();
            choix.ShowDialog();
            choix.Closed += (s, args) => this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            accueil accueil = new accueil();
            accueil.ShowDialog();
            accueil.Closed += (s, args) => this.Close();
        }
    }
    
}
