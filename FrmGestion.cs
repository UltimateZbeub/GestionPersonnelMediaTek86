using GestionPersonnelMediaTek86.controller;
using GestionPersonnelMediaTek86.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionPersonnelMediaTek86.view
{
    public partial class FrmGestion : Form
    {
        private readonly FrmGestionController controller;
        private List<Service> services;
        private List<Motif> motifs;
        private BindingSource bdgPersonnels = new BindingSource();
        private BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmGestion"/>.
        /// </summary>
        public FrmGestion()
        {
            InitializeComponent();
            controller = new FrmGestionController();
            Init();
        }

        private void Init()
        {
            services = controller.GetAllServices();
            motifs = controller.GetAllMotifs();

            cboService.DataSource = services;
            cboService.DisplayMember = "Nom";

            cboMotif.DataSource = motifs;
            cboMotif.DisplayMember = "Libelle";

            RefreshPersonnelList();
            dgvPersonnels.SelectionChanged += DgvPersonnels_SelectionChanged;
        }

        private void RefreshPersonnelList()
        {
            bdgPersonnels.DataSource = controller.GetAllPersonnels(services);
            dgvPersonnels.DataSource = bdgPersonnels;

            dgvPersonnels.Columns["Id"].Visible = false;
            dgvPersonnels.Columns["Service"].Visible = false;
            dgvPersonnels.Columns["NomService"].HeaderText = "Service";
            dgvPersonnels.Columns["NomService"].DisplayIndex = dgvPersonnels.Columns.Count - 1;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RefreshAbsenceList()
        {
            if (bdgPersonnels.Current is Personnel personnel)
            {
                bdgAbsences.DataSource = controller.GetAbsences(personnel.Id, motifs);
                dgvAbsences.DataSource = bdgAbsences;

                dgvAbsences.Columns["Id"].Visible = false;
                dgvAbsences.Columns["IdPersonnel"].Visible = false;
                dgvAbsences.Columns["LibelleMotif"].HeaderText = "Motif";
                dgvAbsences.Columns["LibelleMotif"].DisplayIndex = dgvAbsences.Columns.Count - 1;
                dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void DgvPersonnels_SelectionChanged(object sender, EventArgs e)
        {
            RefreshAbsenceList();
        }

        private void BtnAjoutPersonnel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtTel.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Tous les champs du personnel doivent être remplis.");
                return;
            }

            var personnel = new Personnel(0, txtNom.Text, txtTel.Text, txtEmail.Text, (Service)cboService.SelectedItem);
            controller.AddPersonnel(personnel);
            RefreshPersonnelList();
        }

        private void BtnModifPersonnel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtTel.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Champs obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bdgPersonnels.Current is Personnel personnel)
            {
                DialogResult result = MessageBox.Show(
                    "Voulez-vous enregistrer les modifications apportées à ce personnel ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    personnel.Name = txtNom.Text;
                    personnel.Phone = txtTel.Text;
                    personnel.Email = txtEmail.Text;
                    personnel.Service = (Service)cboService.SelectedItem;

                    controller.UpdatePersonnel(personnel);
                    RefreshPersonnelList();
                }
            }
        }


        private void BtnSupprPersonnel_Click(object sender, EventArgs e)
        {
            if (bdgPersonnels.Current is Personnel personnel)
            {
                if (MessageBox.Show("Confirmer la suppression du personnel ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DeletePersonnel(personnel.Id);
                    RefreshPersonnelList();
                }
            }
        }

        private void BtnAjoutAbsence_Click(object sender, EventArgs e)
        {
            if (bdgPersonnels.Current is Personnel personnel)
            {
                DateTime debut = dtpDebut.Value.Date;
                DateTime fin = dtpFin.Value.Date;

                if (fin < debut)
                {
                    MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur de date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Absence> absencesExistantes = controller.GetAbsences(personnel.Id, motifs);
                foreach (Absence abs in absencesExistantes)
                {
                    bool chevauche = debut <= abs.DateFin && fin >= abs.DateDebut;
                    if (chevauche)
                    {
                        MessageBox.Show("Ce personnel a déjà une absence pendant cette période.", "Conflit d'absences", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var absence = new Absence(
                    0,
                    personnel.Id,
                    debut,
                    fin,
                    (Motif)cboMotif.SelectedItem
                );
                controller.AddAbsence(absence);
                RefreshAbsenceList();
            }
        }

        private void BtnModifAbsence_Click(object sender, EventArgs e)
        {
            if (bdgAbsences.Current is Absence selectedAbsence && bdgPersonnels.Current is Personnel personnel)
            {
                DateTime debut = dtpDebut.Value.Date;
                DateTime fin = dtpFin.Value.Date;

                if (fin < debut)
                {
                    MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.", "Erreur de date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Récupère toutes les absences de ce personnel (sauf celle qu'on modifie)
                List<Absence> absencesExistantes = controller.GetAbsences(personnel.Id, motifs);
                foreach (Absence abs in absencesExistantes)
                {
                    if (abs.Id != selectedAbsence.Id)
                    {
                        // Vérifie les chevauchements
                        bool chevauche = debut <= abs.DateFin && fin >= abs.DateDebut;
                        if (chevauche)
                        {
                            MessageBox.Show("Ce personnel a déjà une absence pendant cette période.", "Conflit d'absences", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Confirmation utilisateur
                DialogResult result = MessageBox.Show(
                    "Voulez-vous enregistrer les modifications de cette absence ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    selectedAbsence.DateDebut = debut;
                    selectedAbsence.DateFin = fin;
                    selectedAbsence.Motif = (Motif)cboMotif.SelectedItem;

                    controller.UpdateAbsence(selectedAbsence);
                    RefreshAbsenceList();
                }
            }
        }

        private void BtnSupprAbsence_Click(object sender, EventArgs e)
        {
            if (bdgAbsences.Current is Absence absence)
            {
                if (MessageBox.Show("Confirmer la suppression de l'absence ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DeleteAbsence(absence.Id);
                    RefreshAbsenceList();
                }
            }
        }
    }
}
