using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class SisAplicacion
    {
        public SisAplicacion()
        {
            SisPermisoMenu = new HashSet<SisPermisoMenu>();
        }

        public string NomAplicacion { get; set; }
        public string DescAplicacion { get; set; }

        public virtual ICollection<SisPermisoMenu> SisPermisoMenu { get; set; }
    }
}
