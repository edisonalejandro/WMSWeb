using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WMSWeb.Models
{
    public partial class Almacen
    {
        public Almacen()
        {
            DocumentoEntrada = new HashSet<DocumentoEntrada>();
            InventarioAlmacen = new HashSet<InventarioAlmacen>();
            MovtoTransaccional = new HashSet<MovtoTransaccional>();
            Producto = new HashSet<Producto>();
            UbicacionFisica = new HashSet<UbicacionFisica>();
            Usuario = new HashSet<Usuario>();
        }
        [Required(ErrorMessage = "Código de Almacén es requerido")]
        [StringLength(3, ErrorMessage = "Logitud máxima 3")]
        public string CodAlmacen { get; set; }

        [Required(ErrorMessage = "Nombre de Almacén es requerido")]
        [StringLength(30, ErrorMessage = "Logitud máxima 30")]
        public string NomAlmacen { get; set; }
        public string Representante { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Fono { get; set; }

        public virtual ICollection<DocumentoEntrada> DocumentoEntrada { get; set; }
        public virtual ICollection<InventarioAlmacen> InventarioAlmacen { get; set; }
        public virtual ICollection<MovtoTransaccional> MovtoTransaccional { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
        public virtual ICollection<UbicacionFisica> UbicacionFisica { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
