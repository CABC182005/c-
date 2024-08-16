using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosolid.Principio_de_Sustitución_de_Liskov__LSP_
{
    public  class Pajaro
    {
        public virtual string HacerSonido()
        {
            return "Pío";
        }
    }

    public class Loro : Pajaro
    {
        public override string HacerSonido()
        {
            return "Graznido";
        }
    }
}
