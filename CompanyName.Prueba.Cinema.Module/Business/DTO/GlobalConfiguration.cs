/// <summary>
/// Global configurations class
/// </summary>
namespace CompanyName.Prueba.Cinema.Module.Business.DTO
{
    using System.Configuration;
    using System.Data.SqlClient;

    /// <summary>
    /// Global configurations
    /// </summary>
    public class GlobalConfiguration
    {
        /// <summary>
        /// Databases the connection.
        /// </summary>
        /// <returns>Database context</returns>
        public SqlConnection DbConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CinemaDbContext"].ToString();
            var dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }
    }
}
