using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rincon.Models;

namespace rincon.services
{
    public interface ILoginServicio
    {
        Task<usuarioModel?> Login(LoginModel login);
    }
}