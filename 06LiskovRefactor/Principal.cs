using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LiskovRefactor
{
    // Clase ABSTRACTA

    abstract class Principal
    {
        protected string mensaje;

        public Principal(string pMensaje)
        {
            mensaje = pMensaje;
        }

        // Lo creamos como método abstracto para que cada versión lo implemente
        public abstract void Muestra();
    }
}
