using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockKuder.Models
{
    [Table("Marcas")]
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        [Key]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [StringLength(100)]
        public string Origen { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public int Antiguedad { get; set; }
    }
}