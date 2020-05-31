using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class MovtoTransaccional
    {
        public long IdMovtoTransaccional { get; set; }
        public string CodTransaccion { get; set; }
        public string NomTransaccion { get; set; }
        public string CodAlmacen { get; set; }
        public string NroDocumento { get; set; }
        public string CodUbicacion { get; set; }
        public string CodLpn { get; set; }
        public string CodProducto { get; set; }
        public short? NroLinea { get; set; }
        public string Lote { get; set; }
        public int Cantidad { get; set; }
        public string CodAlmacen2 { get; set; }
        public string NroDocumento2 { get; set; }
        public string CodUbicacion2 { get; set; }
        public string CodLpn2 { get; set; }
        public int? Cantidad2 { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public string Dispositivo { get; set; }
        public DateTime FechaHoraInicioTrx { get; set; }
        public DateTime FechaHoraFinalTrx { get; set; }
        public string CodUsuario { get; set; }

        public virtual Usuario Cod { get; set; }
        public virtual UbicacionFisica Cod1 { get; set; }
        public virtual Almacen CodAlmacenNavigation { get; set; }
        public virtual Producto CodNavigation { get; set; }
        public virtual SisTransaccion CodTransaccionNavigation { get; set; }
    }
}
