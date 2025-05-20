
using GestionPersonnelMediaTek86.controller;
using System;
using System.Windows.Forms;

namespace GestionPersonnelMediaTek86.view
{
    /// <summary>
    /// Formulaire de connexion pour l'application GestionPersonnelMediaTek86.
    /// </summary>
    public partial class FrmLogin : Form
    {
        private FrmLoginController controller;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmLogin"/>.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialise les composants et le contrôleur pour le formulaire.
        /// </summary>
        private void Init()
        {
            controller = new FrmLoginController();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de connexion.
        /// </summary>
        /// <param name="sender">L'objet source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pwd = txtPwd.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                if (controller.ControleAuthentification(login, pwd))
                {
                    FrmGestion frm = new FrmGestion();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect.", "Erreur");
                }
            }
        }
    }
}
