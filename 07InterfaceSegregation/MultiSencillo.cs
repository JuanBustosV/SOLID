using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07InterfaceSegregation
{
    class MultiSencillo:IMultifuncional
    {
        // Necesitamos estos métodos
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte");
        }

        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento");
        }


        // Estos métodos no los necesitamos
        // Si no colocamos implementación hay que lanzar excepción
        public void Telefono()
        {
            throw new NotImplementedException();
        }

        public void Faxear()
        {
            throw new NotImplementedException();
        }
    }
}
