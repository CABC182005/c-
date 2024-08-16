using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    public class Empleado : Persona ,ICalculable
    {
        public decimal salario { get; set; } 
        public int diasTrabajados { get; set; } 
        public string cargo { get; set; }

       
        public Empleado(string nombre, int edad, string direccion, decimal salario, int diasTrabajados)
            : base(nombre, edad, direccion)
        {
            this.salario = salario; 
            this.diasTrabajados = diasTrabajados; 
        }

       
        public Empleado()
            : base()
        {
            salario = 0;
            diasTrabajados = 0;
        }

        
        public override void mostrarPersona()
        {
            base.mostrarPersona();
            Console.WriteLine($"Salario: {salario}");   
            Console.WriteLine($"Días trabajados: {diasTrabajados}");
            Console.WriteLine($"Salario diario: {calcularSalario()}");
        }

    

       
        public void SolicitarDatosEmpleado()
        {
            Console.Write("Ingrese el salario: ");
            salario = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese los días trabajados: ");
            diasTrabajados = int.Parse(Console.ReadLine());
        }

        public decimal calcularSalario()
        {

            decimal valorDia = salario / 31;
            decimal totalPagar = valorDia * diasTrabajados;
            return totalPagar;



        }
    }
}
