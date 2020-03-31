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
            while (opt != 3)
            {
                Console.WriteLine("MENU SUPERMERCADO JUMBO SHARP");
                Console.WriteLine("1) Agregar persona");
                Console.WriteLine("2) Agregar producto");
                Console.WriteLine("3) Salir del supermercado");
                opt = Convert.ToInt32(Console.ReadLine());

                if (opt == 1)
                {
                    Console.WriteLine("Indique el nombre de la persona: ");
                    string no = Console.ReadLine();
                    Console.WriteLine("Indique el apellido de la persona: ");
                    string ap = Console.ReadLine();
                    Console.WriteLine("Indique el RUT: ");
                    string rut = Console.ReadLine();
                    Console.WriteLine("Indique el dia de nacimiento: ");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique el mes (en numero) de nacimiento: ");
                    int mes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique el año de nacimiento: ");
                    int ano = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique la nacionalidad de la persona: ");
                    string nac = Console.ReadLine();
                    Persona tipo = new Persona(no, ap, rut, dia, mes, ano, nac);
                    Console.WriteLine("Persona creada con exito!!!");

                }

                else if (opt == 2)
                {
                    Console.WriteLine("Indique el nombre del producto: ");
                    string no = Console.ReadLine();
                    Console.WriteLine("Indique el precio del producto: ");
                    int pr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique la marca del producto: ");
                    string mar = Console.ReadLine();
                    Console.WriteLine("Indique las unidades disponibles del producto");
                    int unid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique el tipo de producto (Alimento, Limpieza, Juguete, etc): ");
                    string tipo = Console.ReadLine();
                    Producto mercancia = new Producto(no, pr, mar, unid, tipo);
                    Console.WriteLine("Producto creado con exito!!!");

                }

            }
        }
    }
}
