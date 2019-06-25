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
    public partial class FrmSilla : Form
    {
        public FrmSilla()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSilla_Load(object sender, EventArgs e)
        {
            char[] ubicaciones = { 'A', 'B', 'C', 'D' };
            this.cmbUbicacion.DataSource = ubicaciones;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            var numeroSilla = this.txtNumeroSilla.Text;
            var ubicacionSilla = this.cmbUbicacion.SelectedValue.ToString();

            if (numeroSilla.Equals(string.Empty) || ubicacionSilla.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar # silla y ubicación", Enumerations.GlobalInformation.CompanyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var silla = new Silla()
            {
                CodigoSilla = Convert.ToInt32(numeroSilla),
                Ubicacion  =  Convert.ToChar(ubicacionSilla)
            };

            var insertCity = new SillaActions().insertSilla((int)Enumerations.GlobalActions.Insertar, silla);
            if (!insertCity)
            {
                MessageBox.Show("Se generó error al almacenar", Enumerations.GlobalInformation.CompanyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Ciudad almacenada con éxito", Enumerations.GlobalInformation.CompanyName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
