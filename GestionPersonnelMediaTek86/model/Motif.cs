namespace GestionPersonnelMediaTek86.model
{
    /// <summary>
    /// Représente un motif avec un identifiant et un libellé.
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Obtient ou définit l'identifiant du motif.
        /// </summary>
        public int Idmotif { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé du motif.
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Motif"/>.
        /// </summary>
        /// <param name="idmotif">L'identifiant du motif.</param>
        /// <param name="libelle">Le libellé du motif.</param>
        public Motif(int idmotif, string libelle)
        {
            Idmotif = idmotif;
            Libelle = libelle;
        }

        /// <summary>
        /// Retourne une chaîne représentant le libellé du motif.
        /// </summary>
        /// <returns>Le libellé du motif.</returns>
        public override string ToString() => Libelle;
    }
}
