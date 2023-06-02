using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Catalogo_Dominio
{
    public class Administrador
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }

        public Administrador(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }
    }
}
