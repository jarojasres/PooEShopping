using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PooEShopping.Models
{
    public class Categoria
    {
        private int? _id;
        [Required(ErrorMessage = "El Id es obligatorio")]
        [Range(1, double.MaxValue, ErrorMessage = "El Id debe ser mayor a cero \"0\"")]
        public int? Id {
            get
            {
                return _id;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("El Id no puede ser nulo");

                if (value <= 0)
                    throw new ArgumentOutOfRangeException("El Id debe ser mayor a cero \"0\"");

                _id = value;
            }
        }

        private string _nombre = string.Empty;
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El máximo número de caracteres permitidos es 100")]
        [MinLength(3, ErrorMessage = "El número de caracteres mínimo es 3")]
        public string Nombre {
            get
            {
                return _nombre;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("El Nombre no puede ser nulo");

                if (value == string.Empty)
                    throw new ArgumentException("El nombre no puede estar vacío");

                if (value.Length < 3)
                    throw new ArgumentException("La longitud del nombre debe ser mayor a 3 caracteres");

                _nombre = value;
            }
        }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}
