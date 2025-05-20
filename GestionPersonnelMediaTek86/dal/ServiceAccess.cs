
using GestionPersonnelMediaTek86.bddmanager;
using GestionPersonnelMediaTek86.model;
using System.Collections.Generic;
using System.Data;

namespace GestionPersonnelMediaTek86.dal
{
    /// <summary>
    /// Provides access to the 'service' data in the database.
    /// </summary>
    public class ServiceAccess
    {
        private readonly BddManager bddManager = new BddManager();

        /// <summary>
        /// Retrieves all services from the database.
        /// </summary>
        /// <returns>A list of all services.</returns>
        public List<Service> GetAll()
        {
            string req = "SELECT idservice, nom FROM service ORDER BY nom;";
            DataTable table = bddManager.ExecQuery(req);
            List<Service> services = new List<Service>();
            foreach (DataRow row in table.Rows)
                services.Add(new Service((int)row["idservice"], (string)row["nom"]));
            return services;
        }
    }
}
