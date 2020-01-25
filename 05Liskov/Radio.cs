using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Liskov
{
    class Radio : Noticiero
    {
        public Radio(string pMensaje): base(pMensaje)
        {

        }

        // Para la primera prueba
        //public new void Muestra() // NEW!!!!  Creando nuestra propia versión! distinta a la de la clase padre
        //{
        //    Console.WriteLine("Desde la radio: {0}", mensaje);
        //}

        // Para la segunda prueba
        public override void Muestra()
        {
            Console.WriteLine("Desde la radio: {0}", mensaje);
        }
    }
}
