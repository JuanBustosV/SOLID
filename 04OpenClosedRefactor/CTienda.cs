using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04OpenClosedRefactor
{
    // Cerrada para modificación, abierta para extensión

    class CTienda
    {
        private List<CBaseInventario> productos;  //List<CProducto> productos;

        //polimorfismo gracias a la HERENCIA

        public CTienda(List<CBaseInventario> pProductos) //(List<CProducto> pProductos)
        {
            productos = pProductos;
        }

        public void calcularInventario()
        {
            double total = 0;

            foreach (/*CProducto*/ var producto in productos)
            {
                producto.CalcularProducto(); // Console.Foreground
                Console.WriteLine(producto);
                total += producto.Producto.Precio;
            }
            /* Antes se tenía que cambiar en Tienda
            Cambio(en la clase! evitar)
            foreach (var producto in productos) // (CProducto producto in productos)
            {
                if (producto.Categoria == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    producto.Precio *= 0.8;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
                if (producto.Categoria == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    producto.Precio *= 1.2;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
            }
            */
            Console.ResetColor();            

            Console.WriteLine("\tEl precio total en inventario es {0} €", total);
        }
    }
}
