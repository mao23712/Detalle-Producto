using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1
{
    class Producto
    {
        private string nombre;
        private string descripcion;
        private DateTime fecha;
        private double precio;

        public Producto(string nombre, string descripcion, DateTime fecha, double precio)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.Precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
