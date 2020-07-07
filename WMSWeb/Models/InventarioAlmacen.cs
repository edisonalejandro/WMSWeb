using System;

namespace WMSWeb.Models
{
    public partial class InventarioAlmacen
    {
        public string CodAlmacen { get; set; }
        public string CodUbicacion { get; set; }
        public string CodProducto { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string Lote { get; set; }
        public string NroSerie { get; set; }
        public short CantidadDisponible { get; set; }
        public short CantidadNoDisponible { get; set; }
        public string CodEstado { get; set; }
        public string TipoInventario { get; set; }
        public int? CodTipoBloqueo { get; set; }

        public virtual Producto Cod { get; set; }
        public virtual Almacen CodAlmacenNavigation { get; set; }
        public virtual UbicacionFisica CodNavigation { get; set; }
    }
}
