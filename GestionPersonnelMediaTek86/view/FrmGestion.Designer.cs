namespace GestionPersonnelMediaTek86.view
{
    /// <summary>
    /// Formulaire de gestion du personnel et des absences.
    /// </summary>
    partial class FrmGestion
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources utilisées par le formulaire.
        /// </summary>
        /// <param name="disposing">Indique si les ressources managées doivent être libérées.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Code généré par le concepteur

        /// <summary>
        /// Initialise les composants de l'interface utilisateur.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();

            this.btnAjoutPersonnel = new System.Windows.Forms.Button();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.btnSupprPersonnel = new System.Windows.Forms.Button();

            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnSupprAbsence = new System.Windows.Forms.Button();

            this.lblNom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // --- dgvPersonnels ---
            this.dgvPersonnels.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonnels.Size = new System.Drawing.Size(600, 150);
            this.dgvPersonnels.ReadOnly = true;
            this.dgvPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // --- dgvAbsences ---
            this.dgvAbsences.Location = new System.Drawing.Point(12, 170);
            this.dgvAbsences.Size = new System.Drawing.Size(600, 120);
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // --- Zones saisie personnel ---
            this.txtNom.Location = new System.Drawing.Point(630, 20);
            this.txtTel.Location = new System.Drawing.Point(630, 50);
            this.txtEmail.Location = new System.Drawing.Point(630, 80);
            this.cboService.Location = new System.Drawing.Point(630, 110);
            this.cboService.Size = new System.Drawing.Size(150, 21);

            // --- Labels personnel (droite) ---
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(790, 23);
            this.lblNom.Text = "Nom";

            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(790, 53);
            this.lblTel.Text = "Téléphone";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(790, 83);
            this.lblEmail.Text = "Adresse mail";

            // --- Boutons personnel ---
            this.btnAjoutPersonnel.Text = "Ajouter";
            this.btnAjoutPersonnel.Location = new System.Drawing.Point(630, 140);
            this.btnAjoutPersonnel.Click += new System.EventHandler(this.BtnAjoutPersonnel_Click);

            this.btnModifPersonnel.Text = "Modifier";
            this.btnModifPersonnel.Location = new System.Drawing.Point(720, 140);
            this.btnModifPersonnel.Click += new System.EventHandler(this.BtnModifPersonnel_Click);

            this.btnSupprPersonnel.Text = "Supprimer";
            this.btnSupprPersonnel.Location = new System.Drawing.Point(810, 140);
            this.btnSupprPersonnel.Click += new System.EventHandler(this.BtnSupprPersonnel_Click);

            // --- Saisie absence ---
            this.dtpDebut.Location = new System.Drawing.Point(630, 180);
            this.dtpFin.Location = new System.Drawing.Point(630, 210);
            this.cboMotif.Location = new System.Drawing.Point(630, 240);

            // --- Boutons absences ---
            this.btnAjoutAbsence.Text = "Ajouter";
            this.btnAjoutAbsence.Location = new System.Drawing.Point(630, 270);
            this.btnAjoutAbsence.Click += new System.EventHandler(this.BtnAjoutAbsence_Click);

            this.btnModifAbsence.Text = "Modifier";
            this.btnModifAbsence.Location = new System.Drawing.Point(720, 270);
            this.btnModifAbsence.Click += new System.EventHandler(this.BtnModifAbsence_Click);

            this.btnSupprAbsence.Text = "Supprimer";
            this.btnSupprAbsence.Location = new System.Drawing.Point(810, 270);
            this.btnSupprAbsence.Click += new System.EventHandler(this.BtnSupprAbsence_Click);

            // --- Form ---
            this.ClientSize = new System.Drawing.Size(950, 320);
            this.Controls.Add(this.dgvPersonnels);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.cboMotif);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dtpFin);

            this.Controls.Add(this.btnAjoutPersonnel);
            this.Controls.Add(this.btnModifPersonnel);
            this.Controls.Add(this.btnSupprPersonnel);

            this.Controls.Add(this.btnAjoutAbsence);
            this.Controls.Add(this.btnModifAbsence);
            this.Controls.Add(this.btnSupprAbsence);

            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);

            this.Text = "Gestion du personnel et des absences";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;

        private System.Windows.Forms.Button btnAjoutPersonnel;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.Button btnSupprPersonnel;

        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnSupprAbsence;

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
    }
}