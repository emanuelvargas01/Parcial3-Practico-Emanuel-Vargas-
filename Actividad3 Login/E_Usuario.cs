using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3_Login
{
    public class E_Usuario
    {
        public int IdUser { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }

        public string PassHash { get; set; }

        public bool Activo { get; set; }
    }
}
