namespace WMSWeb.Models
{
    public partial class VePermisosUsuario
    {
        public string CodUsuario { get; set; }
        public string Estado { get; set; }
        public short CodPerfilPermisos { get; set; }
        public string NomPerfilPermisos { get; set; }
        public string NomAplicacion { get; set; }
        public bool TienePermisoApp { get; set; }
        public string NomMenu { get; set; }
        public bool TienePermisoMenu { get; set; }
        public string NomSubMenu { get; set; }
        public bool TienePermisoSubMenu { get; set; }
    }
}
