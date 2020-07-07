using System;

namespace WMSWeb.Models
{
    public partial class SisPermisoMenu
    {
        public short CodPerfilPermisos { get; set; }
        public string NomAplicacion { get; set; }
        public string NomMenu { get; set; }
        public bool TienePermiso { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual SisPerfilPermisos CodPerfilPermisosNavigation { get; set; }
        public virtual SisMenu Nom { get; set; }
        public virtual SisAplicacion NomAplicacionNavigation { get; set; }
    }
}
