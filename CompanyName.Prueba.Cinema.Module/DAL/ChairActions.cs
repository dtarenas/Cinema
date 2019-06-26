/// <summary>
/// Chair actions class
/// </summary>
namespace CompanyName.Prueba.Cinema.Module.DAL
{
    using CompanyName.Prueba.Cinema.Module.Business.DTO;
    using CompanyName.Prueba.Cinema.Module.Business.DTO.Entities;
    using Dapper;
    using System;

    /// <summary>
    /// Chair database DML
    /// </summary>
    public class ChairActions
    {
        /// <summary>
        /// Inserts the chair.
        /// </summary>
        /// <param name="ActionType">Type of the action.</param>
        /// <param name="chair">The chair.</param>
        /// <returns></returns>
        public bool InsertChair(int ActionType, Chair chair)
        {
            var control = true;
            using (var dbContext = new GlobalConfiguration().DbConnection())
            {
                try
                {
                    var insert = dbContext.Query("SP_ActionsSillas",
                                            new { QueHace = ActionType, CodSilla = chair.ChairCode, Ubicacion = chair.Ubication },
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
