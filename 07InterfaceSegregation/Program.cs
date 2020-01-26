using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Principio de segregación de Interfaz I - 7 - SOLID C#";

            MultiAvanzado avanzado = new MultiAvanzado();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("------");

            Fax miFax = new Fax();
            miFax.Telefono();
            miFax.Faxear();
            miFax.Imprimir();

            Console.WriteLine("------");

            MultiSencillo sencillo = new MultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
            sencillo.Telefono(); // lanzará la excepción
        }
    }
}
