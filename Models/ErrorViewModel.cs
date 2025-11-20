using System.ComponentModel.DataAnnotations;

namespace rincon.Models;

public class usuarioModel
{
    public int userId { get; set; }
    [Required(ErrorMessage = "El Nombre es obligatorio.")]
    public required string Usuario_nombre { get; set; }
    [Required(ErrorMessage = "El Apellido es obligatorio.")]
    public required string Usuario_apellido { get; set; }
    [Required(ErrorMessage = "El Correo es obligatorio.")]
    public required string Usuario_correo { get; set; }
    [Required(ErrorMessage = "La Contraseña es obligatoria.")]
    [MinLength(6, ErrorMessage = "La Contraeña debe tener al menos 6 caracteres.")]
public required string Usuario_contraseña { get; set;}
public required string Usuario_Salt { get; set;}


}

