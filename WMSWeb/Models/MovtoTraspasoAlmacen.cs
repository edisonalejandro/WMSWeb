using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class MovtoTraspasoAlmacen
    {
        public int IdTraspasoAlmacen { get; set; }
        public string CodAlmacen { get; set; }
        public string CodTransporte { get; set; }
        public int? NroSalida { get; set; }
        public int? NroGuiaDespacho { get; set; }
        public int? NroDocEntrada { get; set; }
        public string CodAlmacenDestino { get; set; }
        public string CodLpn { get; set; }
        public string CodUsuario { get; set; }
        public string CodProducto { get; set; }
        public string Lote { get; set; }
        public int? Cantidad { get; set; }
        public string CodUbicacion { get; set; }
        public bool FueRecibido { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public DateTime FechaMovto { get; set; }
    }
}
