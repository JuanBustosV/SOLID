using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08InterfaceSegregationRefactor
{
    class MultiAvanzado: IMultiCompleto
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte");
        }

        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento");
        }

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
