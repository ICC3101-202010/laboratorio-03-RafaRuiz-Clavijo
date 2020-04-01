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

        public int GetMoney()
        {
            return this.sueldo;
        }

        public string GetStartWork()
        {
            return this.horainicio;
        }

        public string GetFinishWork()
        {
            return this.horafinal;
        }

        public string GetSector()
        {
            return this.sector;
        }

        public void CambioSueldo(int newsueldo)
        {
            sueldo = newsueldo;
        }

        public void CambioPuesto(string newpuesto)
        {
            sector = newpuesto;
        }

        public void CambioHoraTrabajo(string nuevahorainicio, string nuevahorafinal)
        {
            horainicio = nuevahorainicio;
            horafinal = nuevahorafinal;
        }
    }
}
