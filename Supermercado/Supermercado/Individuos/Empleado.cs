using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Individuos
{
    public class Empleado: Persona
    {
        protected int sueldo;
        protected string horainicio;
        protected string horafinal;
        protected string sector;

        public Empleado(string nombre, string apellido, string RUT, int diadenacimiento, int mesdenacimiento, int anodenacimiento, string nacionalidad, int sueldo, string sector, string horainicio, string horafinal) : base(nombre, apellido, RUT, diadenacimiento, mesdenacimiento, anodenacimiento, nacionalidad)
        {
            this.sueldo = sueldo;
            this.sector = sector;
            this.horainicio = horainicio;
            this.horafinal = horafinal;
        }
    }
}
