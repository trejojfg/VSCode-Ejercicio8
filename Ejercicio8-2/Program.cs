using System;

namespace Ejercicio8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8-2

            // Hacer una función llamada “par” que reciba un número entero 
            // y devuelva 1 si es par o cero si no lo es. 
            // Hacer un programa para ingresar 10 números y mostrar por pantalla cuántos son pares.
        
            int n1, nPar, acuPar=0;

            for (int x = 0; x < 10; x++){
                Console.WriteLine("Introduce un numero");
                n1 = int.Parse(Console.ReadLine());
                // nPar = par(n1);
                // if (nPar == 1){
                //     acuPar++;
                // }
                if(par(n1))
                    acuPar++;
            }

            Console.WriteLine("El total de pares introducidos es: " + acuPar);        
            Console.WriteLine("Fin del programa!!!!!!!!!");
        }
        static bool par (int n1){
            if (n1%2 == 0)
                return true;
            else
                return false;
        }

        // static int par(int n1){
        //     if (n1 % 2 == 0){
        //         return 1;
        //     }else{
        //         return 0;
        //     }
        // }
    }
}
