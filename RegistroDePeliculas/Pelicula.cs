using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDePeliculas
{
   public class Pelicula
   {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public Pelicula() { }

        public Pelicula(int id,string titulo,string descripcion)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
        }
   }

}
