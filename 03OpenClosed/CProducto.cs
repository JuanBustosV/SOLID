using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03OpenClosed
{
    class CProducto
    {
        // Atributos
        private string nombre;
        private int categoria;
        private double precio;

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }

        // Constructor
        public CProducto(string pNombre, int pCategoria, double pPrecio)
        {
            nombre = pNombre;
            categoria = pCategoria;
            precio = pPrecio;
        }

        public override string ToString()
        {
            return String.Format("El producto {0} cuesta {1} €", nombre, precio);
        }
    }
}
