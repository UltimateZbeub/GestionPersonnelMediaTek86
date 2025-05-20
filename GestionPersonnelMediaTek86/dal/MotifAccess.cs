
using GestionPersonnelMediaTek86.bddmanager;
using GestionPersonnelMediaTek86.model;
using System.Collections.Generic;
using System.Data;

namespace GestionPersonnelMediaTek86.dal
{
    /// <summary>
    /// Provides access to the 'Motif' data in the database.
    /// </summary>
    public class MotifAccess
    {
        private readonly BddManager bddManager = new BddManager();

        /// <summary>
        /// Retrieves all motifs from the database.
        /// </summary>
        /// <returns>A list of motifs.</returns>
        public List<Motif> GetAll()
        {
            string req = "SELECT idmotif, libelle FROM motif ORDER BY libelle;";
            DataTable table = bddManager.ExecQuery(req);
            List<Motif> motifs = new List<Motif>();
            foreach (DataRow row in table.Rows)
                motifs.Add(new Motif((int)row["idmotif"], (string)row["libelle"]));
            return motifs;
        }
    }
}
