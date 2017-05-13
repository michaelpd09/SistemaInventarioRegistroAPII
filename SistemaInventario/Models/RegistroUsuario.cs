using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaInventario.Models
{
    public class RegistroUsuario
    {
        [Key]


        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Nombre Obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido Obligatorio")]
        public string Apellido { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefono Obligatorio")]
        public long Telefono { get; set; }

        [Required(ErrorMessage = "Clave Obligatoria")]
        public string Clave { get; set; }

        [Compare("Clave",ErrorMessage = "Validacion Obligatoria")]
        public string ValidaClave { get; set; }

        [Required(ErrorMessage = "Tipo Obligatorio")]
        public string Tipo { get; set; }

        public DateTime Fecha { get; set; }
    
     
    

    }
}