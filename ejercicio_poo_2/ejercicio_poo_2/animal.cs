using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_poo_2
{
    internal class animal
    {
        public string nombre { get; set; }
        public virtual string Getnombre() 
        {
            return nombre;
        }
    }
}
