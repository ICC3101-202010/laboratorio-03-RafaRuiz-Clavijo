using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class BasedeDatosSuperMercado
    {
        List<Producto> prod = new List<Producto>();
        List<Individuos.Cliente> cli = new List<Individuos.Cliente>();
        List<Individuos.Empleado> emp = new List<Individuos.Empleado>();
        List<Individuos.Jefe> boss = new List<Individuos.Jefe>();
        List<Individuos.Empleados.Cajero> caja = new List<Individuos.Empleados.Cajero>();
        List<ListadeSuperMercado> compras = new List<ListadeSuperMercado>();

        public void CrearPersona()
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
            Console.WriteLine("Indique el rol de la nueva persona: ");
            Console.WriteLine("1) Cliente");
            Console.WriteLine("2) Jefe");
            Console.WriteLine("3) Empleado");
            Console.WriteLine("Indique numero de opcion: ");
            int optionnew = Convert.ToInt32(Console.ReadLine());
            if (optionnew == 1)
            {
                Console.WriteLine("Indique el dinero que posee el cliente: ");
                int din = Convert.ToInt32(Console.ReadLine());
                Individuos.Cliente nuevocliente = new Individuos.Cliente(no, ap, rut, dia, mes, ano, nac, din);
                cli.Add(nuevocliente);
            }
            else if (optionnew == 2)
            {
                Console.WriteLine("Indique el dinero que posee el jefe: ");
                int dinboss = Convert.ToInt32(Console.ReadLine());
                Individuos.Jefe nuevojefe = new Individuos.Jefe(no, ap, rut, dia, mes, ano, nac, dinboss);
                boss.Add(nuevojefe);
            }
            else
            {
                Console.WriteLine("Es este nuevo empleado un cajero? (YES/NO)");
                string res = Console.ReadLine();
                res.ToUpper();
                if (res == "YES" || res == "SI")
                {
                    Console.WriteLine("Indique el numero de la caja del cajero");
                    int cajero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique el sueldo del cajero: ");
                    int sueldo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique la hora de inicio del cajero (XX:XX): ");
                    string horai = Console.ReadLine();
                    Console.WriteLine("Indique la hora de termino del cajero (XX:XX): ");
                    string horaf = Console.ReadLine();
                    Individuos.Empleados.Cajero newcajero = new Individuos.Empleados.Cajero(no, ap, rut, dia, mes, ano, nac, sueldo, "Caja", cajero, horai, horaf);
                    caja.Add(newcajero);
                }
                else
                {
                    Console.WriteLine("Indique el sector del trabajador (Auxiliar, Guardia, Informacion, etc): ");
                    string sector = Console.ReadLine();
                    Console.WriteLine("Indique el sueldo del empleado: ");
                    int sueldo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique la hora de inicio del empleado (XX:XX): ");
                    string horai = Console.ReadLine();
                    Console.WriteLine("Indique la hora de termino del empleado (XX:XX): ");
                    string horaf = Console.ReadLine();
                    Individuos.Empleado newempleado = new Individuos.Empleado(no, ap, rut, dia, mes, ano, nac, sueldo, sector, horai, horaf);
                    emp.Add(newempleado);
                }
            }
            Console.WriteLine("Persona agregada con exito!!!!");

        }

        public void CrearProducto()
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
            prod.Add(mercancia);
            Console.WriteLine("Producto creado con exito!!!");
        }

        public void VerPersonas()
        {
            Console.WriteLine("Nuestros Jefes: ");
            foreach (Individuos.Jefe dato in boss)
            {
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + dato.GetName() + " " + dato.GetLastName());
                Console.WriteLine("RUT: " + dato.GetRUT());
                Console.WriteLine("Fecha de Nacimiento: " + dato.GetFecha());
                Console.WriteLine("Nacionalidad: " + dato.GetNacion());
                Console.WriteLine("Dinero disponible: " + dato.GetBossMoney());
            }

            Console.WriteLine("");
            Console.WriteLine("Nuestros Empleados: ");
            foreach (Individuos.Empleado dato in emp)
            {
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + dato.GetName() + " " + dato.GetLastName());
                Console.WriteLine("RUT: " + dato.GetRUT());
                Console.WriteLine("Fecha de Nacimiento: " + dato.GetFecha());
                Console.WriteLine("Nacionalidad: " + dato.GetNacion());
                Console.WriteLine("Sueldo: " + dato.GetMoney());
                Console.WriteLine("Horario de trabajo: " + dato.GetStartWork() + " - " + dato.GetFinishWork());
                Console.WriteLine("Sector de trabajo: " + dato.GetSector());
            }
            foreach (Individuos.Empleados.Cajero dato in caja)
            {
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + dato.GetName() + " " + dato.GetLastName());
                Console.WriteLine("RUT: " + dato.GetRUT());
                Console.WriteLine("Fecha de Nacimiento: " + dato.GetFecha());
                Console.WriteLine("Nacionalidad: " + dato.GetNacion());
                Console.WriteLine("Sueldo: " + dato.GetMoney());
                Console.WriteLine("Horario de trabajo: " + dato.GetStartWork() + " - " + dato.GetFinishWork());
                Console.WriteLine("Sector de trabajo: " + dato.GetSector());
                Console.WriteLine("Caja: " + dato.GetBox());
            }

            Console.WriteLine("");
            Console.WriteLine("Nuestros Clientes: ");
            foreach(Individuos.Cliente dato in cli)
            {
                Console.WriteLine("");
                Console.WriteLine("Nombre: " + dato.GetName() + " " + dato.GetLastName());
                Console.WriteLine("RUT: " + dato.GetRUT());
                Console.WriteLine("Fecha de Nacimiento: " + dato.GetFecha());
                Console.WriteLine("Nacionalidad: " + dato.GetNacion());
                Console.WriteLine("Dinero disponible: " + dato.GetClientMoney());
            }
            
        }

        public void VerProductos()
        {
            Console.WriteLine("");
            Console.WriteLine("Nuestros Productos: ");
            foreach (Producto dato in prod)
            {
                Console.WriteLine("");
                Console.WriteLine("Nombre del producto: " + dato.GetName());
                Console.WriteLine("Tipo de Producto: " + dato.GetClass());
                Console.WriteLine("Marca del Producto: " + dato.GetMarca());
                Console.WriteLine("Precio del Producto: " + dato.GetPrice());
                Console.WriteLine("Stock Disponible: " + dato.GetCantidad());
            }
        }

        public void ModificarStaff()
        {
            Console.WriteLine("Elija la persona a modificar");
            int i = 1;
            foreach (Individuos.Empleado dato in emp)
            {
                Console.WriteLine(i + ") " + dato.GetName() + " " + dato.GetLastName() + " |Puesto: " + dato.GetSector() + " |Horario de trabajo: " + dato.GetStartWork() + " - " + dato.GetFinishWork() + " |Sueldo: " + dato.GetMoney());
                i += 1;
            }
            int empleadosnocaja = i;
            foreach (Individuos.Empleados.Cajero dato in caja)
            {
                Console.WriteLine(i + ") " + dato.GetName() + " " + dato.GetLastName() + " |Puesto: Caja"  + " |Horario de trabajo: " + dato.GetStartWork() + " - " + dato.GetFinishWork() + " |Sueldo: " + dato.GetMoney());
                i += 1;
            }
            Console.WriteLine("Indique persona a modificar: ");
            int modificar = Convert.ToInt32(Console.ReadLine());
            int punto = modificar - empleadosnocaja;
            Console.WriteLine("Indique que atributo quiere cambiar: ");
            Console.WriteLine("1) Sueldo");
            Console.WriteLine("2) Horario de trabajo");
            Console.WriteLine("3) Puesto de trabajo");
            int cambio = Convert.ToInt32(Console.ReadLine());  
            switch (cambio)
            {
                 case 1:
                    {
                          Console.WriteLine("Indique el nuevo sueldo del empleado: ");
                          int nuevosueldo = Convert.ToInt32(Console.ReadLine());
                          if (modificar < empleadosnocaja)
                          {
                            emp[modificar - 1].CambioSueldo(nuevosueldo);
                          }
                          else
                          {
                            caja[punto].CambioSueldo(nuevosueldo);
                          }
                          break;
                    }
                        
                 case 2:
                    {
                          Console.WriteLine("Indique la hora de inicio del empleado (XX:XX): ");
                          string nuevahorainicio = Console.ReadLine();
                          Console.WriteLine("Indique la hora de termino del empleado (XX:XX): ");
                          string nuevahoratermino = Console.ReadLine();
                          if (modificar < empleadosnocaja)
                          {
                            emp[modificar - 1].CambioHoraTrabajo(nuevahorainicio, nuevahoratermino);
                          }
                          else
                          {
                            caja[punto].CambioHoraTrabajo(nuevahorainicio, nuevahoratermino);
                          }
                          break;
                    }
                 case 3:
                    {

                        Console.WriteLine("Indique el nuevo puesto de trabajo: ");
                        string nuevopuesto = Console.ReadLine();
                        if (modificar < empleadosnocaja)
                        {

                            if (nuevopuesto.ToUpper() == "CAJA")
                            {
                                Console.WriteLine("Indique la nueva caja del nuevo cajero: ");
                                int nuevacaja = Convert.ToInt32(Console.ReadLine());
                                Individuos.Empleados.Cajero newbox = new Individuos.Empleados.Cajero(emp[modificar - 1].GetName(), emp[modificar - 1].GetLastName(), emp[modificar - 1].GetRUT(), emp[modificar - 1].GetDay(), emp[modificar - 1].GetMonth(), emp[modificar - 1].GetYear(), emp[modificar - 1].GetNacion(), emp[modificar - 1].GetMoney(), "CAJA", nuevacaja, emp[modificar - 1].GetStartWork(), emp[modificar - 1].GetFinishWork());
                                caja.Add(newbox);
                                emp.Remove(emp[modificar - 1]);
                            }
                            else
                            {
                                emp[modificar - 1].CambioPuesto(nuevopuesto);
                            }
                            
                        }
                        else
                        {
                            Individuos.Empleado newempleado = new Individuos.Empleado(caja[punto].GetName(), caja[punto].GetLastName(), caja[punto].GetRUT(), caja[punto].GetDay(), caja[punto].GetMonth(), caja[punto].GetYear(), caja[punto].GetNacion(), caja[punto].GetMoney(), nuevopuesto, caja[punto].GetStartWork(), caja[punto].GetFinishWork());
                            emp.Add(newempleado);
                            caja.Remove(caja[punto]);

                        }
                        break;
                    }
                    default:
                        {
                            Console.WriteLine("No existe ese criterio");
                            break;
                        }

            }

            
        }

        public void Comprar()
        {
            Console.WriteLine("Clientes disponibles: ");
            int i = 1;
            foreach (Individuos.Cliente dato in cli)
            {
                Console.WriteLine(i + ") " + dato.GetName() + " " + dato.GetLastName() + " |Dinero: "+ dato.GetClientMoney());
                i += 1;
            }
            Console.WriteLine("Elija con un numero: ");
            int option = Convert.ToInt32(Console.ReadLine());

            int dinerodisponible = cli[option - 1].GetClientMoney();
            int menucompra = 0;
            ListadeSuperMercado newlista = new ListadeSuperMercado();
            int dinerogastado = 0;
            while (menucompra != 3)
            {
                Console.WriteLine("");
                Console.WriteLine("MENU DE COMPRAS");
                Console.WriteLine("");
                Console.WriteLine("1) Elegir producto");
                Console.WriteLine("2) Ver mis productos");
                Console.WriteLine("3) Comprar");
                Console.WriteLine("");
                Console.WriteLine("Elija con un numero su opcion: ");
                menucompra = Convert.ToInt32(Console.ReadLine());
                if (menucompra == 1)
                {
                    int elegirproducto = 1;
                    foreach(Producto data in prod)
                    {
                        Console.WriteLine(elegirproducto + ")  Nombre del producto: " + data.GetName() + " |Marca: " + data.GetMarca() + " |Precio: " + data.GetPrice() + " |Tipo: " + data.GetClass() + " |Unidades Disponibles: " + data.GetCantidad());
                        elegirproducto += 1;
                    }

                    Console.WriteLine("Ingrese el producto que quiere con su numero: ");
                    int objetocomprado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de unidades que quiere: ");
                    int objetosadquiridos = Convert.ToInt32(Console.ReadLine());
                    if (objetosadquiridos <= prod[objetocomprado - 1].GetCantidad())
                    {
                        if (prod[objetocomprado-1].GetPrice()*objetosadquiridos < dinerodisponible)
                        {
                            for (int k = 0; k < objetosadquiridos; k++)
                            {
                                newlista.listadecompras.Add(prod[objetocomprado - 1]);
                            }
                            dinerogastado += prod[objetocomprado - 1].GetPrice() * objetosadquiridos;
                            prod[objetocomprado - 1].CambiarCantidad(objetosadquiridos);
                            Console.WriteLine("Productos agregados con exito!!!");
                        }
                        else
                        {
                            Console.WriteLine("Lo siento, el cliente no tiene ese dinero, intente reducir las cantidades");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lo siento, no existe la cantidad que desea");
                    }
                }
                else if (menucompra == 2)
                {
                    int obs = 1;
                    foreach(Producto data in newlista.listadecompras)
                    {
                        Console.WriteLine(obs + ")  Nombre del producto: " + data.GetName() + " |Marca: " + data.GetMarca() + " |Precio: " + data.GetPrice() + " |Tipo: " + data.GetClass());
                        obs += 1;
                    }
                }
            }

            if (dinerogastado < dinerodisponible)
            {
                cli[option - 1].ClientBuy(dinerogastado);
                Console.WriteLine("Compra realizada, al cliente le costo $" + dinerogastado);
                compras.Add(newlista);
            }
            else
            {
                Console.WriteLine("La compra no se pudo realizar, no tiene dinero suficiente");
            }

        }

        public void VerCompras()
        {
            int i = 1;
            foreach(ListadeSuperMercado data in compras)
            {
                Console.WriteLine("Compra Numero " + i);
                int a = 1;
                foreach (Producto data2 in data.listadecompras)
                {
                    Console.WriteLine(a + ")  Nombre del producto: " + data2.GetName() + " |Marca: " + data2.GetMarca() + " |Precio: " + data2.GetPrice() + " |Tipo: " + data2.GetClass());
                    a += 1
                }
            }
        }

    }
}
