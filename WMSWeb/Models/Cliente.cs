using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class Cliente
    {
        public string CodCliente { get; set; }
        public string NomCliente { get; set; }
        public string Fono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Comuna { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Ruta { get; set; }
        public int? Prioridad { get; set; }
    }
}
