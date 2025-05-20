namespace GestionPersonnelMediaTek86.model
{
    /// <summary>
    /// Repr�sente un service avec un identifiant et un nom.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Obtient ou d�finit l'identifiant du service.
        /// </summary>
        public int Idservice { get; set; }

        /// <summary>
        /// Obtient ou d�finit le nom du service.
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
        /// Retourne une repr�sentation sous forme de cha�ne du service.
        /// </summary>
        /// <returns>Le nom du service.</returns>
        public override string ToString() => Nom;
    }
}
