
using GestionPersonnelMediaTek86.bddmanager;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GestionPersonnelMediaTek86.dal
{
    /// <summary>
    /// Provides access to the Responsable data and handles authentication.
    /// </summary>
    public class ResponsableAccess
    {
        private readonly BddManager bddManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsableAccess"/> class.
        /// </summary>
        public ResponsableAccess()
        {
            bddManager = new BddManager();
        }

        /// <summary>
        /// Verifies the authentication of a user based on their login and password.
        /// </summary>
        /// <param name="login">The login of the user.</param>
        /// <param name="pwd">The password of the user.</param>
        /// <returns>True if the authentication is successful; otherwise, false.</returns>
        public bool ControleAuthentification(string login, string pwd)
        {
            string hash = GetSha256Hash(pwd);
            string req = "SELECT COUNT(*) FROM responsable WHERE login=@login AND pwd=@pwd;";
            var parameters = new Dictionary<string, object>
                {
                    { "@login", login },
                    { "@pwd", hash }
                };
            int count = System.Convert.ToInt32(bddManager.ExecuteScalar(req, parameters));
            return count > 0;
        }

        /// <summary>
        /// Computes the SHA-256 hash of the specified input string.
        /// </summary>
        /// <param name="input">The input string to hash.</param>
        /// <returns>The SHA-256 hash as a hexadecimal string.</returns>
        private string GetSha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
