using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04OpenClosedRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Principio abierto cerrado II - 4 - SOLID C#";
            Console.OutputEncoding = Encoding.UTF8;

            List<CBaseInventario> productos = new List<CBaseInventario>
            {
                new CInventarioAlimento(new CProducto("Patatas", 1, 12.5)),
                new CInventarioMedicamento(new CProducto("Analgésico", 2, 23.40)),
                new CInventarioAlimento(new CProducto("Tomate", 1, 30)),
                new CInventarioAlimento(new CProducto("Manzana", 1, 25)),
                new CInventarioMedicamento(new CProducto("Antibiótico", 2, 89)),
                new CInventarioMedicamento(new CProducto("Antiacido", 2, 43))
            };

            CTienda miTienda = new CTienda(productos);

            miTienda.calcularInventario();
        }
    }
}
