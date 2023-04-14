using System;
using System.Collections.Generic;

namespace EJERCICIO_1
{
    class Estatica
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Producto> productos = new List<Producto>();

        public static void CragarProductos()
        {
            productos.Add(new Producto("Galletas", "Saladas", new DateTime(2021, 12, 10), 2));
            productos.Add(new Producto("Leche", "Entera", new DateTime(2021, 12, 10), 3.5));
            productos.Add(new Producto("Pan", "Integral", new DateTime(2021, 12, 10), 2.5));
            productos.Add(new Producto("Cerveza", "Rubia", new DateTime(2021, 12, 10), 1.5));
            productos.Add(new Producto("Cereal", "Avena", new DateTime(2021, 12, 10), 4));
            productos.Add(new Producto("Queso", "Cheddar", new DateTime(2021, 12, 10), 5));
            productos.Add(new Producto("Jugo", "Naranja", new DateTime(2021, 12, 10), 2.75));
            productos.Add(new Producto("Carne", "Res", new DateTime(2021, 12, 10), 10));
            productos.Add(new Producto("Yogurt", "Natural", new DateTime(2021, 12, 10), 2.25));
            productos.Add(new Producto("Agua", "Mineral", new DateTime(2021, 12, 10), 1));
            productos.Add(new Producto("Café", "Molido", new DateTime(2021, 12, 10), 7));
        }
        public static void cargarcliente()
        {
            clientes.Add(new Cliente("Juan", "González", "Ciudad de México"));
            clientes.Add(new Cliente("María", "López", "Guadalajara"));
            clientes.Add(new Cliente("Pedro", "Ramírez", "Monterrey"));
            clientes.Add(new Cliente("Ana", "Martínez", "Puebla"));
            clientes.Add(new Cliente("Luis", "García", "Tijuana"));
            clientes.Add(new Cliente("Sofía", "Hernández", "Cancún"));
            clientes.Add(new Cliente("Diego", "Sánchez", "Veracruz"));
            clientes.Add(new Cliente("Fernanda", "Gómez", "Mérida"));
            clientes.Add(new Cliente("Carlos", "Pérez", "Querétaro"));
            clientes.Add(new Cliente("Alejandra", "Díaz", "Chihuahua"));
            clientes.Add(new Cliente("Jorge", "Castro", "Ciudad Juárez"));
            clientes.Add(new Cliente("Patricia", "Vázquez", "Toluca"));
            clientes.Add(new Cliente("Ricardo", "Álvarez", "Cuernavaca"));
            clientes.Add(new Cliente("Gabriela", "Fernández", "Oaxaca"));
            clientes.Add(new Cliente("Andrés", "Mendoza", "Acapulco"));
            clientes.Add(new Cliente("Mariana", "Herrera", "Morelia"));
            clientes.Add(new Cliente("Gustavo", "Rojas", "Tepic"));
            clientes.Add(new Cliente("Renata", "Núñez", "Zacatecas"));
            clientes.Add(new Cliente("Manuel", "Ruiz", "San Luis Potosí"));
            clientes.Add(new Cliente("Laura", "Cervantes", "Ciudad Obregón"));
            clientes.Add(new Cliente("Héctor", "Dominguez", "Hermosillo"));
            clientes.Add(new Cliente("Isabel", "Vega", "Campeche"));
            clientes.Add(new Cliente("David", "Ortiz", "Ciudad Victoria"));
            clientes.Add(new Cliente("Carmen", "Flores", "Tapachula"));
            clientes.Add(new Cliente("Roberto", "Luna", "Saltillo"));
            clientes.Add(new Cliente("Valeria", "Galván", "Pachuca"));
            clientes.Add(new Cliente("Emilio", "Ramos", "La Paz"));
            clientes.Add(new Cliente("Ana Sofía", "Márquez", "Aguascalientes"));
            clientes.Add(new Cliente("Francisco", "Mejía", "Coatzacoalcos"));
            clientes.Add(new Cliente("Verónica", "León", "Matamoros"));
            clientes.Add(new Cliente("Miguel", "Villalobos", "Chetumal"));
            clientes.Add(new Cliente("Marisol", "Jiménez", "Tuxpan"));
            clientes.Add(new Cliente("Javier", "Guzmán", "Ciudad del Carmen"));
            clientes.Add(new Cliente("Paulina", "Navarro", "Culiacán"));
            clientes.Add(new Cliente("Eduardo", "Castañeda", "Piedras Negras"));
            clientes.Add(new Cliente("Daniela", "Maldonado", "Tampico"));
        }
    }
}
