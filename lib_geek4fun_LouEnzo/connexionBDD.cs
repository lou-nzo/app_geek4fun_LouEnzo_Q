using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lib_geek4fun_LouEnzo
{
    public class connexionBDD
    {
        #region Propriété
        private MySqlConnection connection;
        #endregion

        /// <summary>
        /// Ouvre la connexion à la BDD
        /// </summary>
        /// <returns>Si la connexion réussie</returns>
        public MySqlConnection OuvertureConnexion()
        {
            try
            {
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["StringBDD"].ConnectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                // Console.WriteLine(ex.Message);
                connection = null;
            }

            return connection;
        }

        /// <summary>
        /// Ferme la connexion établie
        /// </summary>
        /// <param name="connexion">Nom de la Connexion</param>
        public void FermetureConnexion(MySqlConnection connexion)
        {
            connexion?.Close();

            /* Version "Classique"
            if (connexion != null)
            {
                connexion.Close();
            }*/
        }
    }
}
