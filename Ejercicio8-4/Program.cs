using System;

namespace Ejercicio8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8-4
            // Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
            // que reciba un número por valor y una variable por referencia. 
            // Que analice el número y escriba variable recibida por referencia con:

            //          a. 1 si el número es positivo.
            //          b. -1 si el número es negativo.
            //          c. 0 si el número es cero.

            int n1, var=9;
            
            Console.WriteLine("Introduce un numero");
            n1 = int.Parse(Console.ReadLine());
            positivoNegativoCero(n1, ref var);

            switch (var){
                case 1:
                    Console.WriteLine("El numero es positivo");
                break;
                case -1:
                    Console.WriteLine("El numero es negativo");
                break;
                case 0:
                    Console.WriteLine("El numero es cero");
                break;
                default:
                break;
            }
            Console.WriteLine("Fin del programa!!!");
        }
        static void positivoNegativoCero(int n1, ref int var){
            if(n1 == 0)
                var = 0;
            else if (n1 > 0)
                var = 1;
            else
                var = -1;
        }
    }
}
