using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    internal class Articulo
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public String ImagenUrl { get; set; }
        public decimal Precio { get; set; }

    }
}
