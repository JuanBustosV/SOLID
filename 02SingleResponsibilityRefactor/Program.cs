using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SingleResponsibilityRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Principio de responsabilidad única II";

            CEmpleado empleado = new CEmpleado("Juan", "Programador", 38, 18000);
            Console.WriteLine(empleado);

            Console.WriteLine(CHacienda.CalcularImpuesto(empleado));
            CHacienda.PagarImpuesto(empleado);
        }
    }
}
