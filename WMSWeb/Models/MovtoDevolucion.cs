using System;

namespace WMSWeb.Models
{
    public partial class MovtoDevolucion
    {
        public int IdMovtoDevolucion { get; set; }
        public string CodAlmacen { get; set; }
        public int NroEntrada { get; set; }
        public int? NroSalida { get; set; }
        public short NroLinea { get; set; }
        public string CodLpn { get; set; }
        public int Cantidad { get; set; }
        public string CodProducto { get; set; }
        public string Lote { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public DateTime FechaMovto { get; set; }
    }
}
