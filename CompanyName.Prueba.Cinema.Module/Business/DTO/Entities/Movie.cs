/// <summary>
/// Movie class
/// </summary>
namespace CompanyName.Prueba.Cinema.Module.Business.DTO.Entities
{
    using System;
    using System.Data;

    /// <summary>
    /// Movie entity
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the name of the movie.
        /// </summary>
        /// <value>
        /// The name of the movie.
        /// </value>
        public string MovieName { get; set; }

        /// <summary>
        /// Gets or sets the function.
        /// </summary>
        /// <value>
        /// The function.
        /// </value>
        public DateTime Function { get; set; }

        /// <summary>
        /// Gets or sets the cover page.
        /// </summary>
        /// <value>
        /// The cover page.
        /// </value>
        public SqlDbType CoverPage { get; set; }
    }
}
