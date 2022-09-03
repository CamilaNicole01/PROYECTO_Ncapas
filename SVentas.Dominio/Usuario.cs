using System;
using System.Collections.Generic;
using System.Text;

namespace SVentas.Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Identificacion { get; set; }
        public string NameUser { get; set; }
        public string Clave { get; set; }
        public int IdTipoUsuario { get; set; }
        public bool Estado { get; set; }

    }
}
