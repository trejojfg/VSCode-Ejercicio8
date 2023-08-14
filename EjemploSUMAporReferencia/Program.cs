using System;

namespace EjemploSUMAporReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // n1 y n2 serían los ARGUMENTOS 
            int n1=0, n2=0, s;

            // invocando la funcion PEDIRDATOS por REFERENCIA y cambia su valor de n1 y n2 por el de j y h

            pedirDatos(ref n1, ref n2);

            // invocando la funcion SUMAR por VALOR y guardando el valor en la variable s
            s = sumar(n1, n2);

            // Resultado 1
            Console.WriteLine("El resultado es: " + s);
            // Resultado 2
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
        // las variables j y h son los PARAMETROS
        // esta sería la función PEDIRDATOS y devuelve mediante PARAMETROS POR REFERENCIA
        static void pedirDatos(ref int j, ref int h){

            Console.WriteLine("ingrese un numero");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro");
            h = int.Parse(Console.ReadLine());
        }
    }
}
