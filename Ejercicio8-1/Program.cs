using System;

namespace Ejercicio8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8-1

            // Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida
            // y muestre por pantalla el monto total a pagar. Usar la función.

            int cantidad, precio, precioVenta;
            
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el precio de venta del artículo");
            precio = int.Parse(Console.ReadLine());

            precioVenta = producto(cantidad, precio);

            Console.WriteLine("El precio total a pagar es: " + precioVenta);
            Console.WriteLine("Fin del programa!!!!!");
        }
        static int producto(int cantidad, int precio){
            int venta;
            venta = cantidad * precio;
            return venta;
        }
    }
}
