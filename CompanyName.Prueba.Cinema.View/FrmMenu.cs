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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cmdCiudades_Click(object sender, EventArgs e)
        {
            var frmCiudad = new FrmCiudad();
            frmCiudad.ShowDialog();
        }

        private void cmdPeliculas_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdSillas_Click(object sender, EventArgs e)
        {
            var frmCiudad = new FrmSilla();
            frmCiudad.ShowDialog();
        }

        private void cmdDetalle_Click(object sender, EventArgs e)
        {
            var frmCiudad = new FrmDetallePelicula();
            frmCiudad.ShowDialog();
        }
    }
}
