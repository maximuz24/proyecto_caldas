using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rincon.Models;

namespace rincon.Services
{
    public interface IUsuarioservice
    {
        Task CrearUsuario(usuarioModel usuario);
    }
}