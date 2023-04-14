using System;

namespace EJERCICIO_1
{
    //objet clase principal
    public class Programa

    {
        static void Main(string[] args)
        {
            Estatica.cargarcliente();
            Estatica.CragarProductos();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("|                MENU                 |");
                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Mostrar cliente");
                Console.WriteLine("3. Registrar producto");
                Console.WriteLine("4. Mostrar Prodcutos");
                Console.WriteLine("5. Agregar producto a cliente");
                Console.WriteLine("6. Mostrar clientes y sus productos");
                Console.WriteLine("7. Salir");
                Console.WriteLine("|                                     |");
                Console.WriteLine("=======================================");
                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarCliente();
                        break;
                    case "2":
                        MostraCliente();
                        break;
                    case "3":
                        RegistrarProducto();
                        break;
                    case "4":
                        MostrarProducto();
                        break;
                    case "5":
                        AgregarProductoACliente();
                        break;
                    case "6":
                        MostrarClientesYProductos();
                        break;
                    case "7":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void RegistrarCliente()
        {
            Console.Clear();
            Console.WriteLine("Registro de cliente");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();
            Cliente cliente = new Cliente(nombre, apellido, direccion);
            Estatica.clientes.Add(cliente);
            Console.WriteLine("Cliente registrado con éxito");
            Console.ReadLine();
            Console.Clear();
        }
        static void MostraCliente()
        {
            Console.Clear();
            Console.WriteLine("Lista de clientes");

            for (int i = 0; i < Estatica.clientes.Count; i++)
            {
                Console.WriteLine($" * {Estatica.clientes[i].Nombre} {Estatica.clientes[i].Apellido} ({Estatica.clientes[i].Direccion})");
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void RegistrarProducto()
        {
            Console.Clear();
            Console.WriteLine("Registro de producto");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Descripción: ");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha en formato yyyy-MM-dd:");
            string fechaStr = Console.ReadLine();
            DateTime fecha = DateTime.Parse(fechaStr);
            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());
            Producto producto = new Producto(nombre, descripcion, fecha, precio);
            Estatica.productos.Add(producto);
            Console.WriteLine("Producto registrado con éxito");
            Console.ReadLine();
            Console.Clear();
        }

        static void MostrarProducto()
        {
            Console.Clear();
            Console.WriteLine("Lista de clientes");

            for (int i = 0; i < Estatica.productos.Count; i++)
            {
                Console.WriteLine($" * {Estatica.productos[i].Nombre} {Estatica.productos[i].Descripcion} VENCIMIENTO: {Estatica.productos[i].Fecha} [ Bs {Estatica.productos[i].Precio}]");
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void AgregarProductoACliente()
        {
            Console.Clear();
            Console.WriteLine("Agregar producto a cliente");
            Console.Write("Ingrese el nombre del cliente: ");
            string nombreCliente = Console.ReadLine();
            Cliente cliente = Estatica.clientes.Find(c => c.Nombre == nombreCliente);
            if (cliente == null)
            {
                Console.WriteLine("Cliente no encontrado");
                return;
            }
            Console.Write("Ingrese el nombre del producto: ");
            string nombreProducto = Console.ReadLine();
            Producto producto = Estatica.productos.Find(p => p.Nombre == nombreProducto);
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                return;
            }
            cliente.AgregarProducto(producto);
            Console.WriteLine("Producto agregado al cliente con éxito");
            Console.ReadLine();
            Console.Clear();
        }
     
        static void MostrarClientesYProductos()
        {
            Console.Clear();
            Console.WriteLine("******Detalle de Clientes y Productos*****");
            foreach (Cliente cliente in Estatica.clientes)
            {
                if (cliente.Productos.Count > 0)
                {
                    Console.WriteLine($" -NOMBRE DE CLIENTE:{cliente.Nombre} {cliente.Apellido} ({cliente.Direccion})");
                    Console.WriteLine(" -PRODUCTOS");
                    foreach (Producto producto in cliente.Productos)
                    {
                        Console.WriteLine($"- {producto.Nombre}: {producto.Descripcion} (Bs {producto.Precio})");
                    }
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
