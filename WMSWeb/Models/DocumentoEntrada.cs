using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class DocumentoEntrada
    {
        public DocumentoEntrada()
        {
            DetalleDocEntrada = new HashSet<DetalleDocEntrada>();
            MovtoEntrada = new HashSet<MovtoEntrada>();
        }

        public int NroEntrada { get; set; }
        public string CodAlmacen { get; set; }
        public string NroDocEntrada { get; set; }
        public string CodEstado { get; set; }
        public string NroDocReferencia { get; set; }
        public short CodDocEntrada { get; set; }
        public string CodAlmacenOrigen { get; set; }
        public string CodProveedor { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FecEstimadaRecepcion { get; set; }

        public virtual Almacen CodAlmacenNavigation { get; set; }
        public virtual Proveedor CodProveedorNavigation { get; set; }
        public virtual ICollection<DetalleDocEntrada> DetalleDocEntrada { get; set; }
        public virtual ICollection<MovtoEntrada> MovtoEntrada { get; set; }
    }
}
