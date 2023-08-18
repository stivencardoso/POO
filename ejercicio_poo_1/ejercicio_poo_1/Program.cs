using System;
namespace ejercicio_poo_1 
{
    class program
    {
        static void Main(string[] args)
        {
            cerveza ocerveza = new cerveza(5, 6.5M, 30);
            ocerveza.fermentacion();
        }
    }
}
