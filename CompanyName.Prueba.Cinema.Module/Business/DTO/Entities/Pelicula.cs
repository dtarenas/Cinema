

namespace CompanyName.Prueba.Cinema.Module.Business.DTO.Entities
{
    using System;
    using System.Data;

    public class Pelicula
    {
        public string NombrePelicula { get; set; }
        public DateTime Funcion { get; set; }

        public SqlDbType Portada { get; set; }
    }
}
