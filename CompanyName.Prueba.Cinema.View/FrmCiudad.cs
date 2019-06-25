using CompanyName.Prueba.Cinema.Module;
using CompanyName.Prueba.Cinema.Module.Business.DTO.Entities;
using CompanyName.Prueba.Cinema.Module.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyName.Prueba.Cinema.View
{
    public partial class FrmCiudad : Form
    {
        public FrmCiudad()
        {
            InitializeComponent();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            var codCiudad = this.txtCodCiudad.Text.Trim();
            var nomCiudad = this.txtNombreCiudad.Text.Trim();

            if (codCiudad.Equals(string.Empty) || nomCiudad.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar Código y nombre de ciudad", Enumerations.GlobalInformation.CompanyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var city = new Ciudad()
            {
                CodigoCiudad = codCiudad,
                NombreCiudad = nomCiudad
            };

            var insertCity = new CiudadActions().insertCiudad((int)Enumerations.GlobalActions.Insertar, city);
            if (!insertCity)
            {
                MessageBox.Show("Se generó error al almacenar", Enumerations.GlobalInformation.CompanyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Ciudad almacenada con éxito", Enumerations.GlobalInformation.CompanyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
