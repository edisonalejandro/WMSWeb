using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WMSWeb.Models
{
    public partial class Cliente
    {
        [Required(ErrorMessage = "Código de Cliente es requerido")]
        [StringLength(20, ErrorMessage = "Logitud máxima 20")]
        public string CodCliente { get; set; }

        [Required(ErrorMessage = "Nombre de Cliente es requerido")]
        [StringLength(100, ErrorMessage = "Logitud máxima 100")]
        public string NomCliente { get; set; }

        [StringLength(14, ErrorMessage = "Logitud máxima 14")]
        public string Fono { get; set; }

        [StringLength(60, ErrorMessage = "Logitud máxima 60")]
        public string Direccion { get; set; }

        [StringLength(50, ErrorMessage = "Logitud máxima 50")]
        public string Ciudad { get; set; }

        [StringLength(20, ErrorMessage = "Logitud máxima 20")]
        public string Comuna { get; set; }

        [StringLength(30, ErrorMessage = "Logitud máxima 30")]
        public string Telefono { get; set; }

        [StringLength(30, ErrorMessage = "Logitud máxima 30")]
        public string Email { get; set; }
        
        [StringLength(20, ErrorMessage = "Logitud máxima 20")]
        public string Ruta { get; set; }

        public int? Prioridad { get; set; }
    }
}
