using System;
using System.Collections.Generic;

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

        public string CodAlmacen { get; set; }
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
