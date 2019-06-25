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
    public partial class FrmDetallePelicula : Form
    {
        public FrmDetallePelicula()
        {
            InitializeComponent();
        }

        private void FrmDetallePelicula_Load(object sender, EventArgs e)
        {
            var detalle = new DetalleActions().GetDetallePeliculas();
            this.grid.DataSource = detalle;

        }
    }
}
