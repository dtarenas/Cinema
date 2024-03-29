﻿/// <summary>
/// City DML
/// </summary>
namespace CompanyName.Prueba.Cinema.Module.DAL
{
    using CompanyName.Prueba.Cinema.Module.Business.DTO;
    using CompanyName.Prueba.Cinema.Module.Business.DTO.Entities;
    using Dapper;
    using System;

    /// <summary>
    /// City data base actions
    /// </summary>
    public class CityActions
    {
        /// <summary>
        /// Inserts the ciudad.
        /// </summary>
        /// <param name="ActionType">The tipo action.</param>
        /// <param name="ciudad">The ciudad.</param>
        /// <returns></returns>
        public bool InsertCity (int ActionType, City ciudad)
        {
            var control = true;
            using (var dbContext = new GlobalConfiguration().DbConnection())
            {
                try
                {
                    var insert = dbContext.Query("SP_ActionsCiudad",
                                            new { QueHace = ActionType, CodCiudad = ciudad.CityCode, Nombre = ciudad.CityName },
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
