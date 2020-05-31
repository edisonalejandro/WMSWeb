using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class DocumentoSalida
    {
        public DocumentoSalida()
        {
            DetalleDocSalida = new HashSet<DetalleDocSalida>();
        }

        public int NroSalida { get; set; }
        public string CodAlmacen { get; set; }
        public string NroDocSalida { get; set; }
        public string CodEstadoSalida { get; set; }
        public string NroDocReferencia { get; set; }
        public short CodDocSalida { get; set; }
        public string CodCliente { get; set; }
        public string CodDestinatario { get; set; }
        public string NomDestinatario { get; set; }
        public string DireccionDestino { get; set; }
        public string CiudadDestino { get; set; }
        public string Observaciones { get; set; }
        public string PaisDestino { get; set; }
        public string CodAlmacenDestino { get; set; }
        public DateTime? FechaEstimadaDespacho { get; set; }
        public DateTime? FechaPreparado { get; set; }
        public DateTime? FechaEmpaque { get; set; }
        public DateTime? FechaCarga { get; set; }
        public DateTime? FechaRealDespacho { get; set; }
        public string NroPatente { get; set; }
        public short Prioridad { get; set; }
        public string BackOrder { get; set; }
        public string NroDocEntrada { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; }
    }
}
