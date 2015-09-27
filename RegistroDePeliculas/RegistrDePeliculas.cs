using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDePeliculas
{
    public partial class RegistrDePeliculas : Form
    {
        public RegistrDePeliculas()
        {
            InitializeComponent();
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaPelicula np = new NuevaPelicula();
            np.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPeliculas cp = new ConsultarPeliculas();
            cp.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe ad = new AcercaDe();
            ad.Show();
        }
    }
}
