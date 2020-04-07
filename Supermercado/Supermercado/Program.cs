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
            Individuos.Cliente cl = new Individuos.Cliente("Pedro", "Sanchez", "200733095", 45, 5, 2004, "Peru", 250000);
            Individuos.Empleados.Cajero boxing = new Individuos.Empleados.Cajero("Juan", "Lopez", "134567892", 31, 2, 2000, "Espana", 300000, "Caja", 50, "08:30", "14:30");
            Producto prods = new Producto("Tomate", 500, "Soproval", 25, "Alimento");
            bdd.DummyTest(cl, boxing, prods);
            while (opt != 9)
            {
                Console.WriteLine("MENU SUPERMERCADO JUMBO SHARP");
                Console.WriteLine("Bienvenido a la simulacion de un supermercado que nunca existio, que desea hacer?");
                Console.WriteLine("");
                Console.WriteLine("1) Agregar Persona");
                Console.WriteLine("2) Agregar Producto");
                Console.WriteLine("3) Ver Personas");
                Console.WriteLine("4) Ver Productos");
                Console.WriteLine("5) Modificar Empleado");
                Console.WriteLine("6) Comprar como Cliente");
                Console.WriteLine("7) Registro de Compras");
                Console.WriteLine("8) Simulacion Aleatoria");
                Console.WriteLine("9) Salir del Supermercado");
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

                else if (opt == 6)
                {
                    bdd.Comprar();
                }

                else if (opt == 7)
                {
                    bdd.VerCompras();
                }

                else if (opt == 8)
                {
                    bdd.GeneracionAleatoria();
                }

                Console.WriteLine("_________________________________________");
                Console.WriteLine("");

            }
        }
    }
}
