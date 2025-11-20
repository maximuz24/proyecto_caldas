using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rincon.Models
{
    public class LoginModel
    {
        public required string login_correo { get; set; }
        [Required(ErrorMessage = "La Contraseña es obligatoria.")]
        [MinLength(6, ErrorMessage = "La Contraeña debe tener al menos 6 caracteres.")]
        public required string Login_contraseña { get; set; }
    }
}