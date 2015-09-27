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
    public partial class NuevaPelicula : Form
    {
        public NuevaPelicula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider erro = new ErrorProvider();
            if(TitulotextBox.Text.Length == 0 || DescripcionrichTextBox.Text.Length == 0)
            {
                erro.SetError(TitulotextBox,"No puede dejar este campo vacio");
                erro.SetError(DescripcionrichTextBox,"Debe llenar este campo");
            }
            else
            {
                Pelicula p = new Pelicula();
                p.Titulo = TitulotextBox.Text;
                p.Descripcion = DescripcionrichTextBox.Text;

                int resultado = PeliculaConexion.Agregar(p);

                if(resultado > 0)
                {
                    MessageBox.Show("Se guardo la Pelicula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TitulotextBox.Text = "";
                    DescripcionrichTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la pelicula", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
