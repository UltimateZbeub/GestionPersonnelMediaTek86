namespace GestionPersonnelMediaTek86.modele
{
    public class Personnel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int IdService { get; set; }

        public Personnel(int id, string nom, string tel, string email, int idService)
        {
            Id = id;
            Nom = nom;
            Tel = tel;
            Email = email;
            IdService = idService;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
