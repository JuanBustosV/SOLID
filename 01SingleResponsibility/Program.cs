﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Principio de responsabilidad única I";

            CEmpleado empleado = new CEmpleado("Juan", "Programador", 38, 18000);
            Console.WriteLine(empleado);
            Console.WriteLine(empleado.CalcularImpuesto());
            empleado.PagarImpuesto();
        }
    }
}
