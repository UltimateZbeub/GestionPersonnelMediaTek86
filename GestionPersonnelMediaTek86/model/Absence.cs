using System;

namespace GestionPersonnelMediaTek86.model
{
    /// <summary>
    /// Représente une absence d'un membre du personnel.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Identifiant unique de l'absence.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identifiant du personnel associé à l'absence.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Date de début de l'absence.
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Date de fin de l'absence.
        /// </summary>
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Motif de l'absence.
        /// </summary>
        public Motif Motif { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Absence"/>.
        /// </summary>
        /// <param name="id">Identifiant unique de l'absence.</param>
        /// <param name="idPersonnel">Identifiant du personnel associé à l'absence.</param>
        /// <param name="dateDebut">Date de début de l'absence.</param>
        /// <param name="dateFin">Date de fin de l'absence.</param>
        /// <param name="motif">Motif de l'absence.</param>
        public Absence(int id, int idPersonnel, DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            Id = id;
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Motif = motif;
        }

        /// <summary>
        /// Obtient le libellé du motif de l'absence.
        /// </summary>
        public string LibelleMotif => Motif?.Libelle ?? "";
    }
}
