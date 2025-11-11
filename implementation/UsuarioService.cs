using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rincon.Models;
using rincon.Services;
using rincon.Views.Data;

namespace rincon.implementation


{
  public class UserService : IUsuarioservice
    {

        private readonly DBContex dBContex;
        public UserService(DBContex dBContex)
        {
            this.dBContex = dBContex;
        }

        public async Task CrearUsuario(usuarioModel usuario)
        {
            if (usuario != null)
            {
                dBContex.Usuarios.Add(usuario);
                await dBContex.SaveChangesAsync();
            }
        }
    }

}