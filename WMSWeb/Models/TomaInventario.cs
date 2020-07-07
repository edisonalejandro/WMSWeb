using System;

namespace WMSWeb.Models
{
    public partial class TomaInventario
    {
        public int NroInventario { get; set; }
        public string CodAlmacen { get; set; }
        public DateTime FecInventarioDesde { get; set; }
        public DateTime FecInventarioHasta { get; set; }
        public string CodEstado { get; set; }
        public string CodResponsable { get; set; }
        public string CodProducto { get; set; }
        public short? CodTipoMovto { get; set; }
        public DateTime? FecElaboracionDesde { get; set; }
        public DateTime? FecElaboracionHasta { get; set; }
        public short? CalleDesde { get; set; }
        public short? CalleHasta { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
