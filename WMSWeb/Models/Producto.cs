using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleDocEntrada = new HashSet<DetalleDocEntrada>();
            DetalleDocSalida = new HashSet<DetalleDocSalida>();
            InventarioAlmacen = new HashSet<InventarioAlmacen>();
            MovtoTransaccional = new HashSet<MovtoTransaccional>();
            UnidadMedida = new HashSet<UnidadMedida>();
        }

        public int IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string DescripcionCorta { get; set; }
        public string DescripcionLarga { get; set; }
        public string CodAlmacen { get; set; }
        public string CodUnidadMedida { get; set; }
        public int? DiasVencimiento { get; set; }
        public decimal? ValorReferencia { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Alto { get; set; }
        public decimal? Volumen { get; set; }
        public decimal? PesoUnidad { get; set; }
        public decimal? PesoTara { get; set; }
        public string ControlSerie { get; set; }
        public string ControlLote { get; set; }
        public DateTime? FechaUltimoConteo { get; set; }
        public string ProductoPeligroso { get; set; }
        public string Rotacion { get; set; }

        public virtual Almacen CodAlmacenNavigation { get; set; }
        public virtual ICollection<DetalleDocEntrada> DetalleDocEntrada { get; set; }
        public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; }
        public virtual ICollection<InventarioAlmacen> InventarioAlmacen { get; set; }
        public virtual ICollection<MovtoTransaccional> MovtoTransaccional { get; set; }
        public virtual ICollection<UnidadMedida> UnidadMedida { get; set; }
    }
}
