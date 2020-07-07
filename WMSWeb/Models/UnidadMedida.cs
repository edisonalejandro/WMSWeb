namespace WMSWeb.Models
{
    public partial class UnidadMedida
    {
        public int IdUnidadMedida { get; set; }
        public int IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string CodUnidadMedida { get; set; }
        public string DescUnidadMedida { get; set; }
        public string CodBarra { get; set; }
        public string CodAlmacen { get; set; }
        public decimal FactorConversion { get; set; }
        public decimal Peso { get; set; }
        public decimal CapasPorLpn { get; set; }
        public decimal UnidadesPorCapas { get; set; }
        public string Pickiable { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Alto { get; set; }
        public string Conveyable { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
    }
}
