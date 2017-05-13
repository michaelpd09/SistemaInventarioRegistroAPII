using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaInventario.Models
{
    public class RegistroUsuario
    {
        [Key]

        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
    }
}