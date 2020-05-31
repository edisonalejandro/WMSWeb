using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class Lpn
    {
        public Lpn()
        {
            DetalleLpn = new HashSet<DetalleLpn>();
        }

        public string CodLpn { get; set; }
        public string CodAlmacen { get; set; }
        public string CodEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string CodUserCreador { get; set; }
        public string CodUbicacion { get; set; }
        public decimal? TaraLpn { get; set; }
        public bool EsIngresoManual { get; set; }
        public DateTime? FecAlmacenaje { get; set; }
        public string NroDocEntrada { get; set; }
        public string CodProveedor { get; set; }

        public virtual UbicacionFisica Cod { get; set; }
        public virtual ICollection<DetalleLpn> DetalleLpn { get; set; }
    }
}
