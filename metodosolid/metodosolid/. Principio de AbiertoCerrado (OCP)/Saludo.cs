using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosolid.NewFolder1
{
    public class Saludo
    {
        public virtual string ObtenerMensaje()
        {
            return "¡Hola!";
        }
    }

    public class SaludoIngles : Saludo
    {
        public override string ObtenerMensaje()
        {
            return "Hello!";
        }
    }
}
