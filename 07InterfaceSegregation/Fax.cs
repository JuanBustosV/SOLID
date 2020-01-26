using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07InterfaceSegregation
{
    class Fax:IMultifuncional
    {
        // Nos vemos forzados a implementar estos métodos
        public void Imprimir()
        {
            Console.WriteLine("No tengo este servicio");
        }

        public void Escanear()
        {
            Console.WriteLine("No tengo este servicio");
        }

        // Estos métodos si los necesitamos

        public void Telefono()
        {
            Console.WriteLine("Llamando a un teléfono");
        }

        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }
    }
}
