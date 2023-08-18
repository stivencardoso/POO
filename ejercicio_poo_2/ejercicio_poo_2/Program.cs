using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_poo_2 
{
    class program
    { 
        static void Main(string[] args)
        {
            bar obar = new bar();
            persona omesero = new mesero("carlos");
            persona ocantinero = new cantinero("Juan");
            persona ocliente = new cliente("manuel");

            obar.entrar(omesero);
            obar.entrar(ocantinero);
            obar.entrar(ocliente);

        }
        
    }
}
