using GestionPersonnelMediaTek86.bddmanager;
using GestionPersonnelMediaTek86.model;
using System;
using System.Collections.Generic;
using System.Data;

namespace GestionPersonnelMediaTek86.dal
{
    /// <summary>
    /// Provides data access methods for managing absences in the database.
    /// </summary>
    public class AbsenceAccess
    {
        private readonly BddManager bddManager = new BddManager();

        /// <summary>
        /// Retrieves a list of absences for a specific personnel.
        /// </summary>
        /// <param name="idPersonnel">The ID of the personnel.</param>
        /// <param name="motifs">The list of motifs to match with absences.</param>
        /// <returns>A list of absences associated with the specified personnel.</returns>
        public List<Absence> GetByPersonnel(int idPersonnel, List<Motif> motifs)
        {
            string req = "SELECT id, datedebut, datefin, idmotif FROM absence WHERE idpersonnel = @idpersonnel ORDER BY datedebut DESC;";
            var parameters = new Dictionary<string, object> { { "@idpersonnel", idPersonnel } };

            DataTable table = bddManager.ExecQuery(req, parameters);
            List<Absence> absences = new List<Absence>();

            foreach (DataRow row in table.Rows)
            {
                int idmotif = row["idmotif"] == DBNull.Value ? 0 : Convert.ToInt32(row["idmotif"]);
                Motif motif = motifs.Find(m => m.Idmotif == idmotif);

                absences.Add(new Absence(
                    Convert.ToInt32(row["id"]),
                    idPersonnel,
                    Convert.ToDateTime(row["datedebut"]),
                    Convert.ToDateTime(row["datefin"]),
                    motif
                ));
            }

            return absences;
        }

        /// <summary>
        /// Adds a new absence to the database.
        /// </summary>
        /// <param name="absence">The absence to add.</param>
        public void Add(Absence absence)
        {
            string req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";
            var parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.Motif?.Idmotif ?? (object)DBNull.Value }
                };

            bddManager.ExecCommand(req, parameters);
        }

        /// <summary>
        /// Updates an existing absence in the database.
        /// </summary>
        /// <param name="absence">The absence to update.</param>
        public void Update(Absence absence)
        {
            string req = "UPDATE absence SET datedebut=@datedebut, datefin=@datefin, idmotif=@idmotif WHERE id=@id;";
            var parameters = new Dictionary<string, object>
                {
                    { "@id", absence.Id },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.Motif?.Idmotif ?? (object)DBNull.Value }
                };

            bddManager.ExecCommand(req, parameters);
        }

        /// <summary>
        /// Deletes an absence from the database.
        /// </summary>
        /// <param name="id">The ID of the absence to delete.</param>
        public void Delete(int id)
        {
            string req = "DELETE FROM absence WHERE id=@id;";
            var parameters = new Dictionary<string, object> { { "@id", id } };
            bddManager.ExecCommand(req, parameters);
        }
    }
}
