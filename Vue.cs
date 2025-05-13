// Ce code représente uniquement la VUE (WinForms) des interfaces.
// Il ne contient pas encore la logique métier (validation, requêtes MySQL, etc.).

using System;
using System.Windows.Forms;

namespace GestionPersonnelAbsences
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }

    public class FrmLogin : Form
    {
        public TextBox TxtLogin = new TextBox();
        public TextBox TxtPwd = new TextBox();
        public Button BtnConnexion = new Button();

        public FrmLogin()
        {
            this.Text = "Connexion";
            this.Size = new System.Drawing.Size(300, 200);

            Label lblLogin = new Label { Text = "Login", Top = 20, Left = 20 };
            TxtLogin.SetBounds(100, 20, 150, 25);

            Label lblPwd = new Label { Text = "Mot de passe", Top = 60, Left = 20 };
            TxtPwd.SetBounds(100, 60, 150, 25);
            TxtPwd.PasswordChar = '*';

            BtnConnexion.Text = "Se connecter";
            BtnConnexion.SetBounds(100, 100, 100, 30);

            Controls.AddRange(new Control[] { lblLogin, TxtLogin, lblPwd, TxtPwd, BtnConnexion });
        }
    }

    public class FrmPersonnel : Form
    {
        public DataGridView dgvPersonnel = new DataGridView();
        public Button btnAjouter = new Button();
        public Button btnModifier = new Button();
        public Button btnSupprimer = new Button();
        public Button btnAbsences = new Button();

        public FrmPersonnel()
        {
            this.Text = "Gestion du personnel";
            this.Size = new System.Drawing.Size(800, 400);

            dgvPersonnel.SetBounds(10, 10, 760, 250);
            btnAjouter.Text = "Ajouter";
            btnAjouter.SetBounds(10, 270, 100, 30);

            btnModifier.Text = "Modifier";
            btnModifier.SetBounds(120, 270, 100, 30);

            btnSupprimer.Text = "Supprimer";
            btnSupprimer.SetBounds(230, 270, 100, 30);

            btnAbsences.Text = "Gérer absences";
            btnAbsences.SetBounds(340, 270, 150, 30);

            Controls.AddRange(new Control[] { dgvPersonnel, btnAjouter, btnModifier, btnSupprimer, btnAbsences });
        }
    }

    public class FrmEditPersonnel : Form
    {
        public TextBox txtNom = new TextBox();
        public TextBox txtTel = new TextBox();
        public TextBox txtEmail = new TextBox();
        public ComboBox cboService = new ComboBox();
        public Button btnValider = new Button();
        public Button btnAnnuler = new Button();

        public FrmEditPersonnel()
        {
            this.Text = "Édition du personnel";
            this.Size = new System.Drawing.Size(400, 300);

            Label lblNom = new Label { Text = "Nom", Top = 20, Left = 20 };
            txtNom.SetBounds(120, 20, 200, 25);

            Label lblTel = new Label { Text = "Téléphone", Top = 100, Left = 20 };
            txtTel.SetBounds(120, 100, 200, 25);

            Label lblEmail = new Label { Text = "Email", Top = 140, Left = 20 };
            txtEmail.SetBounds(120, 140, 200, 25);

            Label lblService = new Label { Text = "Service", Top = 180, Left = 20 };
            cboService.SetBounds(120, 180, 200, 25);

            btnValider.Text = "Valider";
            btnValider.SetBounds(120, 220, 90, 30);

            btnAnnuler.Text = "Annuler";
            btnAnnuler.SetBounds(230, 220, 90, 30);

            Controls.AddRange(new Control[] { lblNom, txtNom, lblTel, txtTel, lblEmail, txtEmail, lblService, cboService, btnValider, btnAnnuler });
        }
    }

    public class FrmAbsences : Form
    {
        public DataGridView dgvAbsences = new DataGridView();
        public Button btnAjouterAbs = new Button();

        public FrmAbsences()
        {
            this.Text = "Absences du personnel";
            this.Size = new System.Drawing.Size(600, 300);

            dgvAbsences.SetBounds(10, 10, 560, 200);
            btnAjouterAbs.Text = "Ajouter une absence";
            btnAjouterAbs.SetBounds(10, 220, 150, 30);

            Controls.AddRange(new Control[] { dgvAbsences, btnAjouterAbs });
        }
    }

    public class FrmEditAbsence : Form
    {
        public DateTimePicker dtpDebut = new DateTimePicker();
        public DateTimePicker dtpFin = new DateTimePicker();
        public ComboBox cboMotif = new ComboBox();
        public Button btnValider = new Button();
        public Button btnAnnuler = new Button();

        public FrmEditAbsence()
        {
            this.Text = "Nouvelle absence";
            this.Size = new System.Drawing.Size(400, 250);

            Label lblDebut = new Label { Text = "Date de début", Top = 20, Left = 20 };
            dtpDebut.SetBounds(150, 20, 200, 25);

            Label lblFin = new Label { Text = "Date de fin", Top = 60, Left = 20 };
            dtpFin.SetBounds(150, 60, 200, 25);

            Label lblMotif = new Label { Text = "Motif", Top = 100, Left = 20 };
            cboMotif.SetBounds(150, 100, 200, 25);

            btnValider.Text = "Valider";
            btnValider.SetBounds(150, 150, 90, 30);

            btnAnnuler.Text = "Annuler";
            btnAnnuler.SetBounds(260, 150, 90, 30);

            Controls.AddRange(new Control[] { lblDebut, dtpDebut, lblFin, dtpFin, lblMotif, cboMotif, btnValider, btnAnnuler });
        }
    }
}
