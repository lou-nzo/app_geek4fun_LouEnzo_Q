using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_geek4fun_LouEnzo
{
    //class represetent les utilisateur
    public class utilisateur
    {
        /// <summary>
        /// Classe permettant la gestion des utilisateur
        /// Chaque utilisateur dispose d'un numéro nom prenom et date de naissance
        /// </summary>
        #region Propriétés 
        private int _numUti;
        private String _nomUti;
        private String _prenomUti;
        private String _emailUti;
        private String _loginUti;
        private String _mdpUti;
        #endregion

        #region Constructeur
        /// <summary>
        /// Utilisateur : constructeur
        /// </summary>
        /// <param name="num">numéro de l'utilisateur </param>
        /// <param name="nom">Nom de l'utilisateur</param>
        /// <param name="prenom">Prenom de l'utilisateur</param>
        /// <param name="email">Email de l'utilisateur</param>
        public utilisateur(int num, String nom, String prenom, String email)
        {
            this._numUti = num;
            this._nomUti = nom;
            this._prenomUti = prenom;
            this._emailUti = email;
        }
        #endregion

        #region Accesseur (avec Properties)
        /// <summary>
        /// Propriété avec getter et setter
        /// </summary>
        /// getter et setter de numéro
        public int num
        {
            get { return _numUti; }
        }

        /// getter et setter du nom
        public String nom
        {
            get { return _nomUti; }
            set { _nomUti = value; }
        }

        /// getter et setter de l'email
        public String email
        {
            get { return _emailUti; }
            set { _emailUti = value; }
        }

        /// getter et setter du prenom
        public String prenom
        {
            get { return _prenomUti; }
            set { _prenomUti = value; }
        }
        #endregion

        #region methodes

        #endregion
    }
}

