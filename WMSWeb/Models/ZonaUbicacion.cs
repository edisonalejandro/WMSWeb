using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class ZonaUbicacion
    {
        public ZonaUbicacion()
        {
            UbicacionFisica = new HashSet<UbicacionFisica>();
        }

        public string CodZona { get; set; }
        public string DescZona { get; set; }
        public string CodAlmacen { get; set; }
        public string EstadoZona { get; set; }

        public virtual ICollection<UbicacionFisica> UbicacionFisica { get; set; }
    }
}
