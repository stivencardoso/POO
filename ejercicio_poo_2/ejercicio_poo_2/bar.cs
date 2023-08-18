using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_poo_2
{
    internal class bar
    {
        List<persona> lstpersona = new List<persona>();

        public void entrar(persona opersona)
        {
            lstpersona.Add(opersona);
            opersona.accion();
        }
    }
}
