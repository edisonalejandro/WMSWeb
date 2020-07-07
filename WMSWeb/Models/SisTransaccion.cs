using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class SisTransaccion
    {
        public SisTransaccion()
        {
            MovtoTransaccional = new HashSet<MovtoTransaccional>();
        }

        public string CodTransaccion { get; set; }
        public string NomTransaccion { get; set; }

        public virtual ICollection<MovtoTransaccional> MovtoTransaccional { get; set; }
    }
}
