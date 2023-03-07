using System;

namespace VentaDeProductos
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }

    class ClsUsuario
    {
        private static string nombre = "Kevin";

        private static string contrasena = "123";

        public static bool Acceso(Usuario usuario)


        {
            if (usuario.Nombre == nombre && usuario.Contrasena == contrasena)
            {
                Console.WriteLine("Se ha iniciado sesión");
                return true;
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrecto.");
                return false;
            }
        }
    }


    class Venta
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }



        public void Cobro()
        {
            double precioTotal = Precio * Cantidad;


            if (precioTotal > 50)
            {
                double descuento = precioTotal / 10;
                double precioDescuento = precioTotal - descuento;
                Console.WriteLine("-----------------------");
                Console.WriteLine("Precio original a pagar: " + precioTotal + "$");
                Console.WriteLine("Descuento: 10% = " + descuento + "$");
                Console.WriteLine("Precio con descuento: " + precioDescuento + "$");
                Console.WriteLine("Total a pagar: " + precioDescuento + "$");
            }
            else
            {
                Console.WriteLine("Total a pagar: " + precioTotal + "$");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            Console.Write("Usuario: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Contraseña: ");
            usuario.Contrasena = Console.ReadLine();



            if (ClsUsuario.Acceso(usuario))
            {
                Venta venta = new Venta();
                Console.WriteLine("-----------------------");

                Console.Write("ID del producto: ");
                venta.IdProducto = int.Parse(Console.ReadLine());
                Console.Write("Nombre del producto: ");
                venta.NombreProducto = Console.ReadLine();
                Console.Write("Descripción del producto: ");
                venta.Descripcion = Console.ReadLine();
                Console.Write("Precio del producto: ");
                venta.Precio = double.Parse(Console.ReadLine());
                Console.Write("Cantidad de producto: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                venta.Cobro();


                Console.WriteLine("-----------------------");

                Console.WriteLine("Datos del producto:");
                Console.WriteLine("ID: " + venta.IdProducto);
                Console.WriteLine("Nombre: " + venta.NombreProducto);
                Console.WriteLine("Descripción: " + venta.Descripcion);
                Console.WriteLine("Precio: " + venta.Precio + "$");
                Console.WriteLine("Cantidad: " + venta.Cantidad);

            }
            else
            {
                Console.WriteLine("Su usuario y contraseña no son correctos.");
            }
        }
    }
}

