/// <summary>
/// Movie details class
/// </summary>
namespace CompanyName.Prueba.Cinema.Module.Business.DTO.Entities
{
    using System;
    /// <summary>
    /// Movie details entity
    /// </summary>
    public class MovieDetail
    {
        /// <summary>
        /// Gets or sets the nombre pelicula.
        /// </summary>
        /// <value>
        /// The nombre pelicula.
        /// </value>
        public string MovieName { get; set; }

        /// <summary>
        /// Gets or sets the funcion.
        /// </summary>
        /// <value>
        /// The funcion.
        /// </value>
        public DateTime Function { get; set; }
        /// <summary>
        /// Gets or sets the ubicacion.
        /// </summary>
        /// <value>
        /// The ubicacion.
        /// </value>
        public string Ubication { get; set; }

        /// <summary>
        /// Gets or sets the codigo silla.
        /// </summary>
        /// <value>
        /// The codigo silla.
        /// </value>
        public int CodigoSilla { get; set; }

        /// <summary>
        /// Gets or sets the nombre ciudad.
        /// </summary>
        /// <value>
        /// The nombre ciudad.
        /// </value>
        public string CityName { get; set; }
    }
}
