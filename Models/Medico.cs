using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCRUD_MDC.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos de {2} y máximo {1} caracteres", MinimumLength =  3)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos de {2} y máximo {1} caracteres", MinimumLength =  3)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "La Especialidad es obligatoria")]
        public String Especialidad { get; set; }

        [Required(ErrorMessage = "El Salario es obligatorio")]
        public int Salario { get; set; }
    }
}