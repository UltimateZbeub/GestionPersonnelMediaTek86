namespace GestionPersonnelMediaTek86.model
{
    /// <summary>
    /// Repr�sente un motif avec un identifiant et un libell�.
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Obtient ou d�finit l'identifiant du motif.
        /// </summary>
        public int Idmotif { get; set; }

        /// <summary>
        /// Obtient ou d�finit le libell� du motif.
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Motif"/>.
        /// </summary>
        /// <param name="idmotif">L'identifiant du motif.</param>
        /// <param name="libelle">Le libell� du motif.</param>
        public Motif(int idmotif, string libelle)
        {
            Idmotif = idmotif;
            Libelle = libelle;
        }

        /// <summary>
        /// Retourne une cha�ne repr�sentant le libell� du motif.
        /// </summary>
        /// <returns>Le libell� du motif.</returns>
        public override string ToString() => Libelle;
    }
}
