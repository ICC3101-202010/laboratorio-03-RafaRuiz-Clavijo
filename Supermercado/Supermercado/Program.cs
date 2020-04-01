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
            while (opt != 8)
            {
                Console.WriteLine("MENU SUPERMERCADO JUMBO SHARP");
                Console.WriteLine("Bienvenido a la simulacion de un supermercado que nunca existio, que desea hacer?");
                Console.WriteLine("");
                Console.WriteLine("1) Agregar persona");
                Console.WriteLine("2) Agregar producto");
                Console.WriteLine("3) Ver personas");
                Console.WriteLine("4) Ver Productos");
                Console.WriteLine("5) Modificar empleado");
                Console.WriteLine("6) Comprar como cliente");
                Console.WriteLine("7) Registro de Compras");
                Console.WriteLine("8) Salir del supermercado");
                Console.WriteLine("Escriba numero de la opcion: ");
                opt = Convert.ToInt32(Console.ReadLine());

                if (opt == 1)
                {
                    bdd.CrearPersona();
                }

                else if (opt == 2)
                {
                    bdd.CrearProducto();
                }

                else if (opt == 3)
                {
                    bdd.VerPersonas();
                }

                else if (opt == 4)
                {
                    bdd.VerProductos();
                }

                else if (opt == 5)
                {
                    bdd.ModificarStaff();
                }

                Console.WriteLine("_________________________________________");
                Console.WriteLine("");

            }
        }
    }
}
