using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            BasedeDatosSuperMercado bdd = new BasedeDatosSuperMercado();
            while (opt != 3)
            {
                Console.WriteLine("MENU SUPERMERCADO JUMBO SHARP");
                Console.WriteLine("Bienvenido a la simulacion de un supermercado que nunca existio, que desea hacer?");
                Console.WriteLine("");
                Console.WriteLine("1) Agregar persona");
                Console.WriteLine("2) Agregar producto");
                Console.WriteLine("3) Salir del supermercado");
                opt = Convert.ToInt32(Console.ReadLine());

                if (opt == 1)
                {
                    bdd.CrearPersona();
                }

                else if (opt == 2)
                {
                    bdd.CrearProducto();
                }

                Console.WriteLine("_________________________________________");
                Console.WriteLine("");

            }
        }
    }
}
