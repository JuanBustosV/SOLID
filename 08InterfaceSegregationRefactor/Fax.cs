using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08InterfaceSegregationRefactor
{
    class Fax:IFax
    {
        // Ahora solo implementamos los métodos que son necesarios
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
