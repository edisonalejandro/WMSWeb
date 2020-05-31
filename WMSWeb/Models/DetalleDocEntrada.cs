using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class DetalleDocEntrada
    {
        public int NroEntrada { get; set; }
        public short NroLinea { get; set; }
        public int? IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string CodAlmacen { get; set; }
        public int Cantidad { get; set; }
        public string Lote { get; set; }
        public string CodEstado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual DocumentoEntrada DocumentoEntrada { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
