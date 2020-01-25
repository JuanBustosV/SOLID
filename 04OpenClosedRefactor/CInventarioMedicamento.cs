using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04OpenClosedRefactor
{
    class CInventarioMedicamento : CBaseInventario
    {
        public CInventarioMedicamento(CProducto pProducto) : base(pProducto)
        {

        }

        // Implementación del método abstracto
        public override double CalcularProducto()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            producto.Precio *= 0.8; // descuento del 20% para los medicamentos
            return producto.Precio;
        }
    }
}
