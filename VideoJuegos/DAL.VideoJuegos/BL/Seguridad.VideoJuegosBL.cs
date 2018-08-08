using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VideoJuegos
{
    public partial class VideoJuegosBL
    {
        public bool Login(string usuario, string contrasena)
        {
            var constrasenaEncryptada = EncodePassword(contrasena);
 
            var usuarioDB = _ef.Usuario
                .FirstOrDefault((r) => 
                    r.NombreUsuario == usuario
                    && r.Contrasena == constrasenaEncryptada);

            return usuarioDB != null;
        }

        public Tuple<bool, string> CrearUsuario(string Nombre, string NombreUsuario, string CorreoElectronico)
        {
            Tuple<bool, string> tuple;
            try
            {
                    if (_ef.Usuario.FirstOrDefault((r) => r.NombreUsuario == NombreUsuario) != null)
                    {
                        return tuple = new Tuple<bool, string>(false, " El nombre de Usuario escogido esta en uso\nIntente con uno diferente");
                    }
                    else
                    {
                        var contrasena = PasswordRamdon(NombreUsuario.Length);
                        var contrasenaBD = EncodePassword(contrasena);

                        var NuevoUsuario = new Usuario();
                        NuevoUsuario.Nombre = Nombre;
                        NuevoUsuario.NombreUsuario = NombreUsuario;
                        NuevoUsuario.CorreoElectronico = CorreoElectronico;
                        NuevoUsuario.Contrasena = contrasenaBD;
                        NuevoUsuario.CambioContrasena = true;

                        _ef.Usuario.Add(NuevoUsuario);
                        _ef.SaveChanges();

                        return tuple = new Tuple<bool, string>(true, contrasena);
                    }
                }
                
            catch (Exception ex)
            {
                return tuple = new Tuple<bool, string>(false, ex.Message.ToString());
            }

        }


        public string PasswordRamdon(int longitud)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder palabra = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                palabra.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return palabra.ToString();
        }

        private string EncodePassword(string pass)
        {
            var salt = "USAP";

            byte[] bIn = Encoding.Unicode.GetBytes(pass);
            byte[] bSalt = Convert.FromBase64String(salt);
            byte[] bAll = new byte[bSalt.Length + bIn.Length];

            Buffer.BlockCopy(bSalt, 0, bAll, 0, bSalt.Length);
            Buffer.BlockCopy(bIn, 0, bAll, bSalt.Length, bIn.Length);
            HashAlgorithm s = HashAlgorithm.Create("SHA512");
            byte[] bRet = s.ComputeHash(bAll);

            return Convert.ToBase64String(bRet);
        }
        
        public bool debecambiarContrasena(string usuario)
        {
            var usuariobd = _ef.Usuario.FirstOrDefault(u => u.NombreUsuario == usuario);
            //throw new otImplementedException();
            return usuariobd.CambioContrasena;
        }

        public Tuple<bool, string> resetearContrasena(string NombreUsuario)
        {
            Tuple<bool, string> tuple;
            try
            {
                var contrasena = PasswordRamdon(NombreUsuario.Length);
                var contrasenaBD = EncodePassword(contrasena);
                var usuariobd = _ef.Usuario.FirstOrDefault(u => u.NombreUsuario == NombreUsuario);
                usuariobd.Contrasena = contrasenaBD;
                usuariobd.CambioContrasena = true;
                _ef.SaveChanges();

                return tuple = new Tuple<bool, string>(true, contrasena);
            }
            catch (Exception ex)
            {
                return tuple = new Tuple<bool, string>(false, ex.Message.ToString());
            }
 
        }

        public void cambiarContrasena(string usuario, string nuevaContrasena1)
        {
            var usuariobd = _ef.Usuario.FirstOrDefault(u => u.NombreUsuario == usuario);
            usuariobd.Contrasena = EncodePassword(nuevaContrasena1);
            usuariobd.CambioContrasena = false;
            _ef.SaveChanges();
           // throw new NotImplementedException();
         }
        
        public bool existeUsuario(string usuario)
        
        {
            var usuariobd = _ef.Usuario.FirstOrDefault(u => u.NombreUsuario == usuario);
            return usuariobd != null;
        }

    }
}
