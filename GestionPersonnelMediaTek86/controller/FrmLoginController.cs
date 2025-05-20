using GestionPersonnelMediaTek86.dal;
using System;

namespace GestionPersonnelMediaTek86.controller
{
    /// <summary>
    /// Contrôleur pour FrmLogin
    /// </summary>
    class FrmLoginController
    {
        private readonly ResponsableAccess responsableAccess;

        public FrmLoginController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Vérifie l'authentification à partir du login et du mot de passe
        /// </summary>
        /// <param name="login">Login saisi</param>
        /// <param name="pwd">Mot de passe saisi</param>
        /// <returns>True si l'utilisateur est authentifié</returns>
        public bool ControleAuthentification(string login, string pwd)
        {
            return responsableAccess.ControleAuthentification(login, pwd);
        }
    }
}
