namespace GestionPersonnelMediaTek86.modele
{
    public class Service
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public Service(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}

