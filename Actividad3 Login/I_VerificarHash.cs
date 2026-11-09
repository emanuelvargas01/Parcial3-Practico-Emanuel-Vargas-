using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3_Login
{
    public interface I_VerificarHash
    {
        bool Verificar(string contraseña, string hash);

    }
}
