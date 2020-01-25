using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04OpenClosedRefactor
{
    // Clase ABSTRACTA BaseInventario, un inventario para cada tipo de productos
    abstract class CBaseInventario
    {
        // Atributo
        protected CProducto producto;

        // Propiedad
        public CProducto Producto { get => producto; set => producto = value; }

        // Constructor
        public CBaseInventario(CProducto pProducto)
        {
            producto = pProducto;
        }

        public override string ToString()
        {
            return producto.ToString();
        }

        // Método abstracto
        public abstract double CalcularProducto();
    }
}
