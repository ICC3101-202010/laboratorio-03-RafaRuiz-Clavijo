using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Individuos
{
    public class Cliente: Persona
    {
        protected int dinero;

        public Cliente(string nombre, string apellido, string RUT, int diadenacimiento, int mesdenacimiento, int anodenacimiento, string nacionalidad, int dinero) : base(nombre, apellido, RUT, diadenacimiento, mesdenacimiento, anodenacimiento, nacionalidad)
        {
            this.dinero = dinero;
        }
    }
}
