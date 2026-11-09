using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3_Login
{
    public class N_RegistroUsuario
    {
        private D_Usuario datosUsuario;
        private I_HashService hashService;

        public N_RegistroUsuario()
        {
            datosUsuario = new D_Usuario();
            hashService = new BCryptService();
        }

        public int Registrar(string usuario, string nombre,
                             string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrEmpty(contraseña))
            {
                throw new System.ArgumentException(
                    "Todos los campos son obligatorios.");
            }

            E_Usuario nuevoUsuario = new E_Usuario();

            nuevoUsuario.Usuario = usuario;
            nuevoUsuario.Nombre = nombre;
            nuevoUsuario.PassHash =
                hashService.GenerarHash(contraseña);
            nuevoUsuario.Activo = true;

            return datosUsuario.RegistrarUsuario(nuevoUsuario);
        }
    }
}
