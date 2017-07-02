using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockKuder.Models
{
    [Table("Marcas")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Key]
        [Required(ErrorMessage="El Campo es obligatorio")]
        [EmailAddress(ErrorMessage ="El Formato del dato no es correcto")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [MinLength(5,ErrorMessage ="El largo debe ser de al menos cinco caracteres"), MaxLength(15, ErrorMessage ="El largo debe tener como máximo 15  caracteres")]
        public string Contrasenia { get; set; }
        [Required(ErrorMessage ="Estte campo es obligatorio")]
        [MinLength(100,ErrorMessage ="El largo minimo es de 100 caracteres"),MaxLength(300, ErrorMessage ="El largo maximo es de 300 caracteres")]
        public string Descripcion { get; set; }

    }
}