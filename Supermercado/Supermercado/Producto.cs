using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public class Producto
    {
        private string nombre;
        private int precio;
        private string marca;
        private int cantidad;
        private string tipo;

        public Producto(string nombre, int precio, string marca, int cantidad, string tipo)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.cantidad = cantidad;
            this.tipo = tipo;
        }

        public string GetName()
        {
            return this.nombre;
        }

        public int GetPrice()
        {
            return this.precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public int GetCantidad()
        {
            return this.cantidad;
        }

        public string GetClass()
        {
            return this.tipo;
        }

        public void CambiarCantidad(int cantidadcomprada)
        {
            cantidad -= cantidadcomprada;
        }

    }
}
