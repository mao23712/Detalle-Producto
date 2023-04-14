using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public List<Producto> Productos { get; set; }

        public Cliente(string nombre, string apellido, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Productos = new List<Producto>();
        }
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }
        
    }
}

