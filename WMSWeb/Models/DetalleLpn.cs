using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class DetalleLpn
    {
        public string CodLpn { get; set; }
        public string CodAlmacen { get; set; }
        public string CodProducto { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Lote { get; set; }
        public short Cantidad { get; set; }
        public string CodEstado { get; set; }
        public DateTime? FecAlmacenaje { get; set; }

        public virtual Lpn Cod { get; set; }
    }
}
