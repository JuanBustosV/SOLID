using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04OpenClosedRefactor
{
    class CInventarioAlimento : CBaseInventario
    {
        // Constructor
        public CInventarioAlimento(CProducto pProducto) : base(pProducto)
        {

        }

        // Implementación del método abstracto de CBaseInventario (clase abstracta)
        public override double CalcularProducto()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            producto.Precio *= 1.2; // Incremento del 20% para los Alimentos
            return producto.Precio;
        }
    }
}
