using System;
using System.Collections.Generic;
using System.Text;

namespace SVentas.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Observacion { get; set; }
        public string Ciudad { get; set; }
    
    public string NombreCompleto
    {
        get
        {
            return this.Nombres + " " + this.Apellidos;
        }
    }
}
}

