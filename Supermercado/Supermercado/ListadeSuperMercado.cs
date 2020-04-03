using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class ListadeSuperMercado
    {
        public string horacompra;
        public List<Producto> listadecompras = new List<Producto>();
        public string nombrecliente;
        public string nombrecajero;
        public int cajaatendida;

        public string GetShopHour(Individuos.Empleados.Cajero caja)
        {
            string hora1 = caja.GetStartWork();
            string hora2 = caja.GetFinishWork();
            int hora1int = Convert.ToInt32(hora1.Remove(2, 3));
            int hora2int = Convert.ToInt32(hora2.Remove(2, 3));
            Random randint = new Random();
            return randint.Next(hora1int, hora2int) + ":" + randint.Next(10, 60);
        }

    }
}
