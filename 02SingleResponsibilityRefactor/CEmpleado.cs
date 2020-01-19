using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SingleResponsibilityRefactor
{
    // REFACTOR de CEmpleado para dejar solo una responsabilidad
    class CEmpleado
    {
        // Atributos
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

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
        // ProyectoActual ...
    }
}
