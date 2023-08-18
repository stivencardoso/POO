using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_poo_2
{
    internal class mesero : persona
    {
        public mesero(string nombre) : base(nombre) { }
        public override void accion()
        {
            Console.WriteLine("atiende mesas");
        }
    }
}
