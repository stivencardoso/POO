using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_poo_2
{
    internal class cantinero : persona
    {
        public cantinero(string nombre) : base(nombre) { }
        public override void accion()
        {
            Console.WriteLine("tomarse las bebidas");
        }
    }
}
