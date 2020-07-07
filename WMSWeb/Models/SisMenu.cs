using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class SisMenu
    {
        public SisMenu()
        {
            SisPermisoMenu = new HashSet<SisPermisoMenu>();
        }

        public string NomAplicacion { get; set; }
        public int IdMenu { get; set; }
        public string NomMenu { get; set; }
        public string DescMenu { get; set; }
        public string DescNivel { get; set; }
        public short Nivel { get; set; }

        public virtual ICollection<SisPermisoMenu> SisPermisoMenu { get; set; }
    }
}
