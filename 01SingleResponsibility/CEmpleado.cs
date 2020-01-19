using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsibility
{
    class CEmpleado
    {
        // Atributos
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        // Constructor
        public CEmpleado(string pNombre, string pPuesto, int pEdad, double pSueldo)
        {
            nombre = pNombre;
            puesto = pPuesto;
            edad = pEdad;
            sueldo = pSueldo;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", nombre, puesto, edad, sueldo);
        }

        // Otros métodos propios del empleado
        // AsignarHorario
        // ProyectoActual

        // Ahora colocamos algo que no es responsabilidad del empleado
        // Tenemos dos razones para cambiar la clase
        // Cuando cambia algo del empleado y
        // Cuando cambia algo relacionado con los impuestos

        public double CalcularImpuesto()
        {
            return sueldo * 0.35;
        }

        public void PagarImpuesto()
        {
            double imp = CalcularImpuesto();
            Console.WriteLine("Se pagó {0} en impuestos por parte de {1}", imp, nombre);
        }
    }
}
