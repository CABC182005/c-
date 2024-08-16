using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosolid
{
    public class Usuario
    {
        public string Name { get; set; }

        public void Save()
        {
            // Guardar el usuario en la base de datos
        }
    }

    public class UserPrinter
    {
        public void Print(Usuario usuario)
        {
            // Imprimir la información del usuario
            Console.WriteLine(usuario.Name);
        }
    }
}
