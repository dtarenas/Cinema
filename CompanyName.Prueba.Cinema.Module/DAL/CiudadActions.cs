

namespace CompanyName.Prueba.Cinema.Module.DAL
{
    using CompanyName.Prueba.Cinema.Module.Business.DTO;
    using CompanyName.Prueba.Cinema.Module.Business.DTO.Entities;
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CiudadActions
    {
        public bool insertCiudad(int TipoAction, Ciudad ciudad)
        {
            var control = true;
            using (var dbContext = new GlobalConfiguration().DbConnection())
            {
                try
                {
                    var insert = dbContext.Query("SP_ActionsCiudad",
                                            new { QueHace = TipoAction, CodCiudad = ciudad.CodigoCiudad, Nombre = ciudad.NombreCiudad },
                                             commandType: System.Data.CommandType.StoredProcedure);
                }
                catch (Exception e)
                {
                    dbContext.Close();
                    control = false;
                }
                
            }

            return control;
        }
    }
}
