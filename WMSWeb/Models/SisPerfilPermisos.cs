using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class SisPerfilPermisos
    {
        public SisPerfilPermisos()
        {
            SisPerfilesUsuario = new HashSet<SisPerfilesUsuario>();
            SisPermisoMenu = new HashSet<SisPermisoMenu>();
        }

        public short CodPerfilPermisos { get; set; }
        public string NomPerfilPermisos { get; set; }

        public virtual ICollection<SisPerfilesUsuario> SisPerfilesUsuario { get; set; }
        public virtual ICollection<SisPermisoMenu> SisPermisoMenu { get; set; }
    }
}
