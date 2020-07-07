using System;

namespace WMSWeb.Models
{
    public partial class DetalleInventario
    {
        public long IdInventario { get; set; }
        public int NroInventario { get; set; }
        public string CodAlmacen { get; set; }
        public string CodLpn { get; set; }
        public string CodUbicacion { get; set; }
        public string CodProducto { get; set; }
        public string Lote { get; set; }
        public short CantidadSistema { get; set; }
        public short CantidadInventario { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public bool FueInventariada { get; set; }
    }
}
