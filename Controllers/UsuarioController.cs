using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql.Replication;
using rincon.Models;
using rincon.Services;

namespace rincon.Controllers
{
    [Route("user")]
    
    public class UsuarioController : Controller
    {
        private readonly IUsuarioservice usuarioservice;


        public UsuarioController(IUsuarioservice usuarioservice)

        {
            this.usuarioservice = usuarioservice;
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(usuarioModel usuario)
        {
            if (usuario != null)
            {
                await usuarioservice.CrearUsuario(usuario);
                return Ok("usuario creado");
            }
            else
            {
                return BadRequest("Usuario no puede ser null");
            }
        }
        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }
    }
}










