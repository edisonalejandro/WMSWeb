using System;

namespace WMSWeb.Models
{
    public partial class DetalleDocSalida
    {
        public int NroSalida { get; set; }
        public short NroLinea { get; set; }
        public int? IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string CodAlmacen { get; set; }
        public int Cantidad { get; set; }
        public int? CantidadDespachada { get; set; }
        public string Lote { get; set; }
        public bool? FuePreparada { get; set; }
        public string CodEstado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual DocumentoSalida NroSalidaNavigation { get; set; }
    }
}
