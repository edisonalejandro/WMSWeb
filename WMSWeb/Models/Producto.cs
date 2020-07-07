using System;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


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

        [Required(ErrorMessage = "ID es requerido")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "Código de Producto es requerido")]
        [StringLength(30, ErrorMessage = "Logitud máxima 30")]
        public string CodProducto { get; set; }

        [Required(ErrorMessage = "Descripción Corta es requerida")]
        [StringLength(30, ErrorMessage = "Logitud máxima 30")]
        public string DescripcionCorta { get; set; }

        [Required(ErrorMessage = "Descripción Larga es requerida")]
        [StringLength(60, ErrorMessage = "Logitud máxima 60")]
        public string DescripcionLarga { get; set; }

        [Required(ErrorMessage = "Código de Almacén es requerido")]
        [StringLength(30, ErrorMessage = "Logitud máxima 30")]
        public string CodAlmacen { get; set; }

        [Required(ErrorMessage = "Únidad de Medida es requerida")]
        [StringLength(30, ErrorMessage = "Logitud máxima 30")]
        public string CodUnidadMedida { get; set; }
        public int? DiasVencimiento { get; set; }
        public decimal? ValorReferencia { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Alto { get; set; }
        public decimal? Volumen { get; set; }
        public decimal? PesoUnidad { get; set; }
        public decimal? PesoTara { get; set; }

        [Required(ErrorMessage = "Control/Serie es requerido")]
        [StringLength(1, ErrorMessage = "Logitud máxima 1")]
        public string ControlSerie { get; set; }

        [Required(ErrorMessage = "Control/Lote es requerido")]
        [StringLength(1, ErrorMessage = "Logitud máxima 1")]
        public string ControlLote { get; set; }
        public DateTime? FechaUltimoConteo { get; set; }

        [Required(ErrorMessage = "Producto Peligroso")]
        [StringLength(1, ErrorMessage = "Logitud máxima 1")]
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
