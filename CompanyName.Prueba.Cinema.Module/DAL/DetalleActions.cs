using CompanyName.Prueba.Cinema.Module.Business.DTO;
using CompanyName.Prueba.Cinema.Module.Business.DTO.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.Prueba.Cinema.Module.DAL
{
    public class DetalleActions
    {
        public List<DetallePelicula> GetDetallePeliculas()
        {

            var detalle = new List<DetallePelicula> { };
            using (var dbContext = new GlobalConfiguration().DbConnection())
            {
                try
                {
                    detalle = dbContext.Query<DetallePelicula>("SP_getDetallePelicula", new { },
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
