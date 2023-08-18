using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_poo_1
{
    internal class cerveza
    {
        public int amargor { get; set; }
        public decimal alcohol { get; set; }
        public int tiempodefermentacion { get; set; }
        public cerveza(int amargor, decimal alcohol, int tiempodefermentacion)
        {
            this.amargor = amargor;
            this.alcohol = alcohol;
            this.tiempodefermentacion = tiempodefermentacion;
        }
        public void fermentacion()
        {
            for (int i = 0; i < tiempodefermentacion; i++) ;
            Console.WriteLine("se fermento");
        }
    }
}
