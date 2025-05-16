using System;

namespace GestionPersonnelMediaTek86.modele
{
    public class Absence
    {
        public int Id { get; set; }
        public int IdPersonnel { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int IdMotif { get; set; }

        public Absence(int id, int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            Id = id;
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            IdMotif = idMotif;
        }

        public override string ToString()
        {
            return $"Du {DateDebut.ToShortDateString()} au {DateFin.ToShortDateString()}";
        }
    }
}
