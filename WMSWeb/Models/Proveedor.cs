using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            DocumentoEntrada = new HashSet<DocumentoEntrada>();
        }

        public string CodProveedor { get; set; }
        public string NomProveedor { get; set; }
        public string Fono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }

        public virtual ICollection<DocumentoEntrada> DocumentoEntrada { get; set; }
    }
}
