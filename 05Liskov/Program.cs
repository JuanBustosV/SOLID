using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Principio de sustitución de Liskov I - 5 - SOLID C#";

            // Primera prueba con NEW
            Noticiero miNoticiero = new Noticiero("Hola a todos");
            miNoticiero.Muestra();

            Radio miRadio = new Radio("Hi everybody!");
            miRadio.Muestra();

            Console.WriteLine("------");

            // Sustituimos la clase hija y vemos como se comportan

            Noticiero sustitucion = new Radio("Estamos probando");
            sustitucion.Muestra();

            // Probamos el mismo código con la segunda versión VIRTUAL y OVERRIDE
        }
    }
}
