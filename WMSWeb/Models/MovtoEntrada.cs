using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class MovtoEntrada
    {
        public int IdMovtoEntrada { get; set; }
        public string CodAlmacen { get; set; }
        public int NroEntrada { get; set; }
        public short NroLinea { get; set; }
        public string CodLpn { get; set; }
        public int Cantidad { get; set; }
        public string CodProducto { get; set; }
        public string Lote { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public DateTime FechaMovto { get; set; }

        public virtual DocumentoEntrada DocumentoEntrada { get; set; }
    }
}
