namespace GestionPersonnelMediaTek86.modele
{
    public class Motif
    {
        public int Id { get; set; }
        public string Libelle { get; set; }

        public Motif(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }

        public override string ToString()
        {
            return Libelle;
        }
    }
}

