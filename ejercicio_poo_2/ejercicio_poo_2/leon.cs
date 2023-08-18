using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_poo_2
{
    internal class leon : carnivoro
    {
        public string colorcabello { get; set; }
        private int velocidadefecto = 20;
        public int velocidad
        {
            get
            {
                return velocidadefecto;
            }
            set
            {
                if (value <= 0)
                    value = 1;
                velocidadefecto = value;
            }
        }
        public int velocidadenmetros
        {
            get
            {
                return velocidadefecto * 1000;
            }
        }

        public override string Getnombre()
        {
            return "soy un leon llamado: " + nombre;
        }
        public leon() 
        {
            if(this.nombre==null || this.nombre.Equals(""))
                this.nombre = "leon";
            Console.WriteLine("carga de datos de la base de dats");
        }
        public leon(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public leon(string nombre, int velocidad) : this()
        {
            this.nombre = nombre;
            this.velocidadefecto= velocidad;
        }
        public void correr()
        {
            Console.WriteLine("corriendo: "+velocidadefecto);
        }
        public void correr(int velocidad)
        {
            Console.WriteLine("corriendo: " + velocidad );

        }
        public void correr(int velocidad, string detalle)
        {
            Console.WriteLine("corriendo: " + velocidad + detalle);

        }
        public void correr( string detalle)
        {
            Console.WriteLine("corriendo: "+ detalle);

        }
    }
}
