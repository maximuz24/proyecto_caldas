using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace proyecto_rincon.services
{
    public interface IPawordServicio
    {
        String HashPassword(String Password, out String salt);
        bool CompararContraseñas(String Contraseña, String ContraseñaBD, string Salt);
    }
}







