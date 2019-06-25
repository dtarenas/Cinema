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
    public class SillaActions
    {
        public bool insertSilla(int TipoAction, Silla silla)
        {
            var control = true;
            using (var dbContext = new GlobalConfiguration().DbConnection())
            {
                try
                {
                    var insert = dbContext.Query("SP_ActionsSillas",
                                            new { QueHace = TipoAction, CodSilla = silla.CodigoSilla , Ubicacion = silla.Ubicacion },
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
