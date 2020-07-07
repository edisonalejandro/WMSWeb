using System;

namespace WMSWeb.Models
{
    public partial class VeSisParametros
    {
        public string NomParametro { get; set; }
        public short CodParametro { get; set; }
        public string NomParamTipo { get; set; }
        public string ValorActual { get; set; }
        public string TipoDato { get; set; }
        public string ValorMinimo { get; set; }
        public string ValorMaximo { get; set; }
        public string RequiereReIniciarApp { get; set; }
        public DateTime FecActualizacion { get; set; }
        public string Descripcion { get; set; }
    }
}
