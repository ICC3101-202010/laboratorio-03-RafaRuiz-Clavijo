using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Individuos
{
    public class Jefe: Persona
    {

        protected int dinerosupermercado;

        public Jefe(string nombre, string apellido, string RUT, int diadenacimiento, int mesdenacimiento, int anodenacimiento, string nacionalidad, int dinerosupermercado) : base(nombre, apellido, RUT, diadenacimiento, mesdenacimiento, anodenacimiento, nacionalidad)
        {
            this.dinerosupermercado = dinerosupermercado;
        }
    }

}
