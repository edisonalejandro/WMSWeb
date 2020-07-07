namespace WMSWeb.Models
{
    public partial class SisPerfilesUsuario
    {
        public string CodUsuario { get; set; }
        public string CodAlmacen { get; set; }
        public short CodPerfilPermisos { get; set; }

        public virtual Usuario Cod { get; set; }
        public virtual SisPerfilPermisos CodPerfilPermisosNavigation { get; set; }
    }
}
