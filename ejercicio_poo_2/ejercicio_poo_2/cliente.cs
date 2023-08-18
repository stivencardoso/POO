using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_poo_2
{
    internal class cliente : persona
    {
        public cliente(string nombre) : base(nombre){ }
        public override void accion()
        {
            Console.WriteLine("hace bebidas");
        }
    }
}
