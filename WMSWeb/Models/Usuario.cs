using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            MovtoTransaccional = new HashSet<MovtoTransaccional>();
            SisPerfilesUsuario = new HashSet<SisPerfilesUsuario>();
        }

        public string CodUsuario { get; set; }
        public string CodAlmacen { get; set; }
        public string Clave { get; set; }
        public string NomUsuario { get; set; }
        public string Rut { get; set; }
        public string Estado { get; set; }
        public string CodZona { get; set; }
        public string AreaPicking { get; set; }
        public string Dispositivo { get; set; }

        public virtual Almacen CodAlmacenNavigation { get; set; }
        public virtual ICollection<MovtoTransaccional> MovtoTransaccional { get; set; }
        public virtual ICollection<SisPerfilesUsuario> SisPerfilesUsuario { get; set; }
    }
}
