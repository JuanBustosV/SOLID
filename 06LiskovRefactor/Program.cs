using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LiskovRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Principio de sustitución de Liskov II - 5 - SOLID C#";

            Principal miNoticiero = new Noticiero("Hola a todos");
            miNoticiero.Muestra();

            Principal miRadio = new Radio("Hi everybody!");
            miRadio.Muestra();

            // Relacionado con PATRON DE DISEÑO de ESTRATEGÍA

            /*
             *  Clase principal que tiene un método que el 90% de sus hijas usa
             *  y para el 10 % de otras no es necesario. ¿Copiar & Pegar el método
             *  en el 90% de las clases que si les hace falta?... ver patrón
             * 
             */
        }
    }
}
