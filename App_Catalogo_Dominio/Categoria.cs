using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Catalogo_Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        [DisplayName("Categoría")]
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
