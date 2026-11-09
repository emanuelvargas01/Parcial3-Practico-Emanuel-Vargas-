using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3_Login
{
    public class N_Login
    {
        private D_Usuario datosUsuario;
        private D_IntentoLog datosIntento;
        private I_VerificarHash verificador;

        public N_Login()
        {
            datosUsuario = new D_Usuario();
            datosIntento = new D_IntentoLog();
            verificador = new BCryptService();
        }

        public E_Usuario Autenticar(string usuario, string contraseña)
        {
            E_Usuario usuarioEncontrado =
                datosUsuario.ObtenerUsuario(usuario);

            // Usuario inexistente
            if (usuarioEncontrado == null)
            {
                datosIntento.RegistrarIntento(
                    null, usuario, false);

                return null;
            }

            // Usuario desactivado o contraseña incorrecta
            if (!usuarioEncontrado.Activo ||
                !verificador.Verificar(
                    contraseña, usuarioEncontrado.PassHash))
            {
                datosIntento.RegistrarIntento(
                    usuarioEncontrado.IdUser, usuario, false);

                return null;
            }

            // Acceso correcto
            datosIntento.RegistrarIntento(
                usuarioEncontrado.IdUser, usuario, true);

            return usuarioEncontrado;
        }
    }
}
