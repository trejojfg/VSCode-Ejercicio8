using System;

namespace EjemploSUMAporValor
{
    class Program
    {
        static void Main(string[] args)
        {

            // n1 y n2 serían los ARGUMENTOS 
            int n1, n2, s, resultado;

            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro");
            n2 = int.Parse(Console.ReadLine());

            // opción A - manualmente sin llamar a la funcion SUMAR mediante PARAMETROS POR VALOR
            resultado = n1 + n2;
            // opción B - invocando la funcion SUMAR y guardando el valor en la variable s
            s = sumar(n1, n2);

            // Resultado 1 - con la opción A
            Console.WriteLine("El resultado es: " + resultado);
            // Resultado 2 - con la opción B
            Console.WriteLine("El resultado es: " + s);
            // Resultado 3 - con la opción B
            Console.WriteLine("El resultado es: " + sumar(n1, n2));

            Console.WriteLine("Fin del programa!");
        }
        // las variables a y b son los PARAMETROS
        // esta sería la función SUMAR y devuelve mediante PARAMETROS POR VALOR
        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
        }
    }
}
