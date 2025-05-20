using System;

namespace GestionPersonnelMediaTek86.model
{
    /// <summary>
    /// Repr�sente une absence d'un membre du personnel.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Identifiant unique de l'absence.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identifiant du personnel associ� � l'absence.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Date de d�but de l'absence.
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
        /// <param name="idPersonnel">Identifiant du personnel associ� � l'absence.</param>
        /// <param name="dateDebut">Date de d�but de l'absence.</param>
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
        /// Obtient le libell� du motif de l'absence.
        /// </summary>
        public string LibelleMotif => Motif?.Libelle ?? "";
    }
}
