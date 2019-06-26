using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CompanyName.Prueba.CinemaWPF.View
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = this.txtUser.Text.Trim();
            var pass1 = this.txtPass1.Password.Trim();
            var pass2 = this.txtPass2.Password.Trim();

            if (user.Equals(string.Empty) || pass1.Equals(string.Empty) || pass2.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar todos los datos", "CompanyName", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (!pass1.Equals(pass2))
            {
                MessageBox.Show("Passwords are different, please check it.", "CompanyName", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            //TODO: Aplicar la vuelta de las capas
            //Debo hacer la etapa de las clases y validaciones
        }
    }
}
