using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Catalogo_Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código de artículo")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public SqlMoney Precio { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
    }
}
