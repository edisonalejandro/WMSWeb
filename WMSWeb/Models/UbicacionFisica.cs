using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class UbicacionFisica
    {
        public UbicacionFisica()
        {
            InventarioAlmacen = new HashSet<InventarioAlmacen>();
            Lpn = new HashSet<Lpn>();
            MovtoTransaccional = new HashSet<MovtoTransaccional>();
        }

        public string CodUbicacion { get; set; }
        public string CodAlmacen { get; set; }
        public short Hilera { get; set; }
        public short Columna { get; set; }
        public short Nivel { get; set; }
        public short? Calle { get; set; }
        public string CodEstado { get; set; }
        public string CodZona { get; set; }
        public string FlujoPicking { get; set; }
        public string TipoUm { get; set; }
        public short CapacidadUm { get; set; }
        public decimal CapacidadVolumen { get; set; }
        public string TipoUbicacion { get; set; }
        public DateTime? UltimaFechaConteo { get; set; }
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }
        public string UbicacionReposicion { get; set; }
        public string AreaPicking { get; set; }
        public string TipoLpn { get; set; }

        public virtual ZonaUbicacion Cod { get; set; }
        public virtual Almacen CodAlmacenNavigation { get; set; }
        public virtual ICollection<InventarioAlmacen> InventarioAlmacen { get; set; }
        public virtual ICollection<Lpn> Lpn { get; set; }
        public virtual ICollection<MovtoTransaccional> MovtoTransaccional { get; set; }
    }
}
