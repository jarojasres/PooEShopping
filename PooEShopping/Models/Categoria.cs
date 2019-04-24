using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PooEShopping.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        
        [StringLength(100, ErrorMessage = "El máximo número de caracteres permitidos es 100")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}
