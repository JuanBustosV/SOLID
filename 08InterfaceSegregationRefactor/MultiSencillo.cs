using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08InterfaceSegregationRefactor
{
    class MultiSencillo:IMultiBasico
    {
        // Solo implementamos los métodos que necesitamos
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento");
        }

        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando una fotografía");
        }
    }
}
