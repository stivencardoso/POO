using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_poo_2
{
    internal class persona
    {
        public string nombre { get; set; }

        public persona(string nombre)
        {
            this.nombre = nombre;
        }
        public virtual void accion() { }
    }
}
