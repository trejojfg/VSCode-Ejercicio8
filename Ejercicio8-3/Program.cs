using System;

namespace Ejercicio8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8-3

            // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 
            // si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
            // Informar el promedio teniendo en cuenta sólo los números primos.

            int n1;
            float cont=0, acuPrimo=0, prom;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            while (n1 != 0){
                if (primo(n1)){
                    cont++;
                    acuPrimo+= n1;
                }
                Console.WriteLine("Ingrese otro numero o cero para terminar");
                n1 = int.Parse(Console.ReadLine());
            }
            prom = acuPrimo / cont;
            Console.WriteLine("El promedio de numeros primos es: " + prom.ToString("0.00"));
            Console.WriteLine("Fin del programa!!!!!");
        }
        static bool primo(int n1){
            int cont = 0;
            for (int x = 1; x <= n1; x++){
                if(n1%x == 0)
                    cont++;
            }
            if (cont == 2){
                return true;
            }else{
                return false;
            }
        }
    }
}
