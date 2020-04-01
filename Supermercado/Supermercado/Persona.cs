using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string RUT;
        protected int diadenacimiento;
        protected int mesdenacimiento;
        protected int anodenacimiento;
        protected string nacionalidad;

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

        public string GetName()
        {
            return this.nombre;
        }

        public string GetLastName()
        {
            return this.apellido;
        }

        public string GetRUT()
        {
            return this.RUT;
        }

        public string GetFecha()
        {
            return diadenacimiento + "/" + mesdenacimiento + "/" + anodenacimiento;
        }

        public string GetNacion()
        {
            return this.nacionalidad;
        }


    }
}
