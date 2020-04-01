using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Individuos.Empleados
{
    public class Cajero : Empleado
    {
        protected int caja;

        public Cajero(string nombre, string apellido, string RUT, int diadenacimiento, int mesdenacimiento, int anodenacimiento, string nacionalidad, int sueldo, string sector, int caja, string horainicio, string horafinal) : base(nombre, apellido, RUT, diadenacimiento, mesdenacimiento, anodenacimiento, nacionalidad, sueldo, sector, horainicio, horafinal)
        {
            this.caja = caja;
        }
    }
}
