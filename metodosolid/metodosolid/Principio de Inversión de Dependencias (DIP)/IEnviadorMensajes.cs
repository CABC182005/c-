using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosolid.Principio_de_Inversión_de_Dependencias__DIP_
{
    public interface IEnviadorMensajes
    {
        void EnviarMensaje(string mensaje);
    }

    public class EnviadorEmail : IEnviadorMensajes
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando email: " + mensaje);
        }
    }

    public class Notificacion
    {
        private readonly IEnviadorMensajes _enviadorMensajes;

        public Notificacion(IEnviadorMensajes enviadorMensajes)
        {
            _enviadorMensajes = enviadorMensajes;
        }

        public void Enviar(string mensaje)
        {
            _enviadorMensajes.EnviarMensaje(mensaje);
        }
    }
}
