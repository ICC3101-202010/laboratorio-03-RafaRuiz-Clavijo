using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class Persona
    {
        string nombre;
        string apellido;
        string RUT;
        int diadenacimiento;
        int mesdenacimiento;
        int anodenacimiento;
        string nacionalidad;

        public Persona(string nombre, string apellido, string RUT, int diadenacimiento, int mesdenacimiento, int anodenacimiento, string nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.RUT = RUT;
            this.diadenacimiento = diadenacimiento;
            this.mesdenacimiento = mesdenacimiento;
            this.anodenacimiento = anodenacimiento;
            this.nacionalidad = nacionalidad;
        }


    }
}
