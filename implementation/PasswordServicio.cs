using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.VisualBasic;
using proyecto_rincon.services;

namespace proyecto_rincon.implementation
{
  public class PasswordServicio : IPawordServicio
  {
    public bool CompararContraseñas(string Contraseña, string ContraseñaBD, string Salt)
    {
      byte[] SaltBytes = Convert.FromBase64String(Salt);
      string HashedPasswordToCheck = EncryptPassword(Contraseña, SaltBytes);
      return HashedPasswordToCheck == ContraseñaBD;
    }

    public string HashPassword(string Password, out string salt)
    {
      string HashedPassword;
      byte[] saltbytes = new byte[128 / 8];
      using (var rng = RandomNumberGenerator.Create())
      {
        rng.GetBytes(saltbytes);
      }
      salt = Convert.ToBase64String(saltbytes);
      HashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(password: Password, salt: saltbytes, prf: KeyDerivationPrf.HMACSHA256, iterationCount: 100000, numBytesRequested: 256 / 8)); return HashedPassword;
    }
  
private string EncryptPassword(string Contraseña, byte[] saltBites)
    {

      string HashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(password: Contraseña, salt: saltBites, prf: KeyDerivationPrf.HMACSHA256, iterationCount: 100000, numBytesRequested: 256 / 8));
      return HashedPassword;
    }
  }
}