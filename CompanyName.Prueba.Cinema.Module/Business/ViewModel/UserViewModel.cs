/// <summary>
/// 
/// </summary>
namespace CompanyName.Prueba.Cinema.Module.Business.ViewModel
{
    using CompanyName.Prueba.Cinema.Module.Business.DTO.Entities;
    
    /// <summary>
    /// Model and view connection
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// The user
        /// </summary>
        User user;

        /// <summary>
        /// Gets or sets the user code.
        /// </summary>
        /// <value>
        /// The user code.
        /// </value>
        public string UserCode
        {
            get { return user.UserCode; }
            set { user.UserCode = value; }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get { return user.Password; }
            set { user.Password = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is admin.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is admin; otherwise, <c>false</c>.
        /// </value>
        public bool IsAdmin
        {
            get { return user.IsAdmin; }
            set { user.IsAdmin = value; }
        }

        /// <summary>
        /// Informations the valitaion.
        /// </summary>
        /// <returns></returns>
        public bool InfoValitaion()
        {
            if (this.UserCode.Equals(string.Empty) || this.Password.Equals(string.Empty))
            {
                return false;
            }
            return true;
        }

    }
}
