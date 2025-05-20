using GestionPersonnelMediaTek86.bddmanager;
using GestionPersonnelMediaTek86.model;
using System;
using System.Collections.Generic;
using System.Data;

namespace GestionPersonnelMediaTek86.dal
{
    /// <summary>
    /// Provides data access methods for managing personnel records in the database.
    /// </summary>
    public class PersonnelAccess
    {
        private readonly BddManager bddManager = new BddManager();

        /// <summary>
        /// Retrieves all personnel records from the database and maps them to their respective services.
        /// </summary>
        /// <param name="services">A list of services to map personnel to.</param>
        /// <returns>A list of personnel objects.</returns>
        public List<Personnel> GetAll(List<Service> services)
        {
            string req = "SELECT id, name, phone, email, idservice FROM personnel ORDER BY name;";
            DataTable table = bddManager.ExecQuery(req);
            List<Personnel> personnels = new List<Personnel>();

            foreach (DataRow row in table.Rows)
            {
                int idservice = row["idservice"] == DBNull.Value ? 0 : Convert.ToInt32(row["idservice"]);

                Service service = services.Find(s => s.Idservice == idservice);
                personnels.Add(new Personnel(
                    Convert.ToInt32(row["id"]),
                    row["name"].ToString(),
                    row["phone"].ToString(),
                    row["email"].ToString(),
                    service
                ));
            }

            return personnels;
        }

        /// <summary>
        /// Adds a new personnel record to the database.
        /// </summary>
        /// <param name="personnel">The personnel object to add.</param>
        public void Add(Personnel personnel)
        {
            string req = "INSERT INTO personnel (name, phone, email, idservice) VALUES (@name, @phone, @email, @idservice);";
            var parameters = new Dictionary<string, object>
                {
                    { "@name", personnel.Name },
                    { "@phone", personnel.Phone },
                    { "@email", personnel.Email },
                    { "@idservice", personnel.Service?.Idservice ?? (object)DBNull.Value }
                };

            bddManager.ExecCommand(req, parameters);
        }

        /// <summary>
        /// Updates an existing personnel record in the database.
        /// </summary>
        /// <param name="personnel">The personnel object with updated information.</param>
        public void Update(Personnel personnel)
        {
            string req = "UPDATE personnel SET name=@name, phone=@phone, email=@email, idservice=@idservice WHERE id=@id;";
            var parameters = new Dictionary<string, object>
                {
                    { "@id", personnel.Id },
                    { "@name", personnel.Name },
                    { "@phone", personnel.Phone },
                    { "@email", personnel.Email },
                    { "@idservice", personnel.Service?.Idservice ?? (object)DBNull.Value }
                };

            bddManager.ExecCommand(req, parameters);
        }

        /// <summary>
        /// Deletes a personnel record from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the personnel to delete.</param>
        public void Delete(int id)
        {
            string req = "DELETE FROM personnel WHERE id=@id;";
            var parameters = new Dictionary<string, object>
                {
                    { "@id", id }
                };

            bddManager.ExecCommand(req, parameters);
        }
    }
}
