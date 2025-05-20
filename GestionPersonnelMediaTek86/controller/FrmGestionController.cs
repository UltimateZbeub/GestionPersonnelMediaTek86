using GestionPersonnelMediaTek86.dal;
using GestionPersonnelMediaTek86.model;
using System.Collections.Generic;

namespace GestionPersonnelMediaTek86.controller
{
    /// <summary>
    /// Contr�leur pour la gestion des donn�es li�es aux services, motifs, personnels et absences.
    /// </summary>
    public class FrmGestionController
    {
        private readonly ServiceAccess serviceAccess;
        private readonly MotifAccess motifAccess;
        private readonly PersonnelAccess personnelAccess;
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmGestionController"/>.
        /// </summary>
        public FrmGestionController()
        {
            serviceAccess = new ServiceAccess();
            motifAccess = new MotifAccess();
            personnelAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess();
        }

        /// <summary>
        /// R�cup�re tous les services.
        /// </summary>
        /// <returns>Liste des services.</returns>
        public List<Service> GetAllServices()
        {
            return serviceAccess.GetAll();
        }

        /// <summary>
        /// R�cup�re tous les motifs.
        /// </summary>
        /// <returns>Liste des motifs.</returns>
        public List<Motif> GetAllMotifs()
        {
            return motifAccess.GetAll();
        }

        /// <summary>
        /// R�cup�re tous les personnels.
        /// </summary>
        /// <param name="services">Liste des services associ�s.</param>
        /// <returns>Liste des personnels.</returns>
        public List<Personnel> GetAllPersonnels(List<Service> services)
        {
            return personnelAccess.GetAll(services);
        }

        /// <summary>
        /// Ajoute un personnel.
        /// </summary>
        /// <param name="personnel">Objet personnel � ajouter.</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.Add(personnel);
        }

        /// <summary>
        /// Modifie un personnel.
        /// </summary>
        /// <param name="personnel">Objet personnel � modifier.</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.Update(personnel);
        }

        /// <summary>
        /// Supprime un personnel.
        /// </summary>
        /// <param name="id">Identifiant du personnel � supprimer.</param>
        public void DeletePersonnel(int id)
        {
            personnelAccess.Delete(id);
        }

        /// <summary>
        /// R�cup�re les absences d�un personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel.</param>
        /// <param name="motifs">Liste des motifs associ�s.</param>
        /// <returns>Liste des absences.</returns>
        public List<Absence> GetAbsences(int idPersonnel, List<Motif> motifs)
        {
            return absenceAccess.GetByPersonnel(idPersonnel, motifs);
        }

        /// <summary>
        /// Ajoute une absence.
        /// </summary>
        /// <param name="absence">Objet absence � ajouter.</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.Add(absence);
        }

        /// <summary>
        /// Modifie une absence.
        /// </summary>
        /// <param name="absence">Objet absence � modifier.</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.Update(absence);
        }

        /// <summary>
        /// Supprime une absence.
        /// </summary>
        /// <param name="id">Identifiant de l'absence � supprimer.</param>
        public void DeleteAbsence(int id)
        {
            absenceAccess.Delete(id);
        }
    }
}
