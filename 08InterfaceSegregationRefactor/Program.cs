using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08InterfaceSegregationRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Principio de segregación de Interfaz II - 8 - SOLID C#";

            /*
             * 
             * YA NO HAY CLASES QUE LE SOMBREN MÉTODOS INNECESARIOS
             * 
             */

            MultiAvanzado avanzado = new MultiAvanzado();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("------");

            Fax miFax = new Fax();
            miFax.Telefono();
            miFax.Faxear();
            //miFax.Imprimir(); Ya no existe, OK

            Console.WriteLine("------");

            MultiSencillo sencillo = new MultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
            //sencillo.Telefono(); // Ya no existe, OK
        }
    }
}
