namespace GestionPersonnelMediaTek86.model
{
    /// <summary>
    /// Représente un service avec un identifiant et un nom.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Obtient ou définit l'identifiant du service.
        /// </summary>
        public int Idservice { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du service.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Service"/>.
        /// </summary>
        /// <param name="idservice">L'identifiant du service.</param>
        /// <param name="nom">Le nom du service.</param>
        public Service(int idservice, string nom)
        {
            Idservice = idservice;
            Nom = nom;
        }

        /// <summary>
        /// Retourne une représentation sous forme de chaîne du service.
        /// </summary>
        /// <returns>Le nom du service.</returns>
        public override string ToString() => Nom;
    }
}
