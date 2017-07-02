using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockKuder.Models
{
    [Table("Articulos")]
    public class Articulo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El Campo de usuario no debe estar vacío")]
        [DisplayName("Nombre del Articulo")]
        [StringLength(50)]
        [Key]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Campo de usuario no debe estar vacío")]
        [StringLength(300)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Required]  
        public Marca Marca { get; set;}
        [Required]
        public string ImagenUrl { get; set; }
    }
}