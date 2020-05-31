using System;
using System.Collections.Generic;

namespace WMSWeb.Models
{
    public partial class PreparacionSalida
    {
        public int IdPreparaSalida { get; set; }
        public string CodAlmacen { get; set; }
        public int NroSalida { get; set; }
        public short NroRuta { get; set; }
        public short NroLinea { get; set; }
        public string CodProducto { get; set; }
        public string CodUbicacion { get; set; }
        public short Hilera { get; set; }
        public short Columna { get; set; }
        public short Nivel { get; set; }
        public string CodLpn { get; set; }
        public string Lote { get; set; }
        public bool Preparada { get; set; }
        public DateTime? FechaElaboracion { get; set; }
    }
}
