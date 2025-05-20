namespace GestionPersonnelMediaTek86.model
{
    /// <summary>
    /// Représente un membre du personnel avec ses informations personnelles et son service associé.
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Identifiant unique du membre du personnel.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom du membre du personnel.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Numéro de téléphone du membre du personnel.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Adresse e-mail du membre du personnel.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Service auquel appartient le membre du personnel.
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Personnel"/>.
        /// </summary>
        /// <param name="id">Identifiant unique du membre du personnel.</param>
        /// <param name="name">Nom du membre du personnel.</param>
        /// <param name="phone">Numéro de téléphone du membre du personnel.</param>
        /// <param name="email">Adresse e-mail du membre du personnel.</param>
        /// <param name="service">Service auquel appartient le membre du personnel.</param>
        public Personnel(int id, string name, string phone, string email, Service service)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Service = service;
        }

        /// <summary>
        /// Retourne une représentation sous forme de chaîne du membre du personnel.
        /// </summary>
        /// <returns>Nom du membre du personnel.</returns>
        public override string ToString() => Name;

        /// <summary>
        /// Obtient le nom du service auquel appartient le membre du personnel.
        /// </summary>
        public string NomService => Service?.Nom ?? "";
    }
}
