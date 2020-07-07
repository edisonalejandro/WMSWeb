using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WMSWeb.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            MovtoTransaccional = new HashSet<MovtoTransaccional>();
            SisPerfilesUsuario = new HashSet<SisPerfilesUsuario>();
        }

        [Key]
        [Required(ErrorMessage = "Usuario es requerido")]
        [StringLength(20, ErrorMessage = "Logitud máxima 20")]
        public string CodUsuario { get; set; }

        [Required(ErrorMessage = "Código de Almacén es requerido")]
        public string CodAlmacen { get; set; }

        [Required(ErrorMessage = "Clave es requerida")]
        [StringLength(20, ErrorMessage = "Logitud máxima 20")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "Nombre de Usuario es requerido")]
        [StringLength(50, ErrorMessage = "Logitud máxima 50")]
        public string NomUsuario { get; set; }

        [StringLength(20, ErrorMessage = "Logitud máxima 20")]
        public string Rut { get; set; }

        [Required(ErrorMessage = "Estado es Requerido")]
        public string Estado { get; set; }
        
        [Required(ErrorMessage = "Código de Zona es Requerido")]
        [StringLength(10, ErrorMessage = "Logitud máxima 10")]
        public string CodZona { get; set; }

        [Required(ErrorMessage = "Área de Picking es Requerido")]
        [StringLength(20, ErrorMessage = "Logitud máxima 20")]
        public string AreaPicking { get; set; }

        [StringLength(30, ErrorMessage = "Logitud máxima 30")]
        public string Dispositivo { get; set; }

        public virtual Almacen CodAlmacenNavigation { get; set; }
        public virtual ICollection<MovtoTransaccional> MovtoTransaccional { get; set; }
        public virtual ICollection<SisPerfilesUsuario> SisPerfilesUsuario { get; set; }
    }
}
