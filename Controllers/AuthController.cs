using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using rincon.Models;

namespace rincon.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        [HttpGet]
    [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

         [HttpPost]
    [Route("login")]
        public IActionResult Login(LoginModel login)
        {
            return View();
        }
    }
}