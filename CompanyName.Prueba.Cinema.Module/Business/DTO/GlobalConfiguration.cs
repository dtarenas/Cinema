namespace CompanyName.Prueba.Cinema.Module.Business.DTO
{
    using System.Configuration;
    using System.Data.SqlClient;
    
    public class GlobalConfiguration
    {
        public SqlConnection DbConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CinemaDbContext"].ToString();
            var dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }
    }
}
