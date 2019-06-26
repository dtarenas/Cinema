/// <summary>
/// Details class
/// </summary>
namespace CompanyName.Prueba.Cinema.Module.DAL
{
    using CompanyName.Prueba.Cinema.Module.Business.DTO;
    using CompanyName.Prueba.Cinema.Module.Business.DTO.Entities;
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details data base actions
    /// </summary>
    public class DetailsActions
    {
        /// <summary>
        /// Gets the detalle peliculas.
        /// </summary>
        /// <returns></returns>
        public List<MovieDetail> GetDetallePeliculas()
        {

            var detalle = new List<MovieDetail> { };
            using (var dbContext = new GlobalConfiguration().DbConnection())
            {
                try
                {
                    detalle = dbContext.Query<MovieDetail>("SP_getDetallePelicula", new { },
                                                 commandType: System.Data.CommandType.StoredProcedure).ToList();
                }
                catch (Exception e)
                {
                    dbContext.Close();
                }
            }
            return detalle;
        }
    }
}
