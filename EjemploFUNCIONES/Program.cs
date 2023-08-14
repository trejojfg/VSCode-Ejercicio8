using System;

namespace EjemploFUNCIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            // FUNCIONES
            // son miniprogramas que la FUNCION PRINCIPAL o MAIN, invoca a otra funcion para ayudarles con una
            // tarea en el programa principal. Esta es la manera con la que se MODULARIZA la programcion.

            //              static       - void      - Main   - ()
            //         palabra reservada - tipo dato - nombre - parametros

            // las PARTES de una funcion son:

            // - CABECERA : esta conpuesta por varios puntos
            //      1. TIPO DE DATO - es el tipo de dato que va a tener la funcion
            //      2. NOMBRE - es el nombre que va a tener dicha funcion
            //      3. PARAMETROS (opcional) - si va a tener algun tipo de argumento con PARAMETROS (n1, n2, 3, 8,...)

            // - CUERPO : es lo que hemos estado haciendo todo este tiempo entre las llaves {}, 
            //            funciones pequeñas con los ejercicios.
            //      1. DEFINICION / LOGIGA - es lo que se codifica para que haga la funcion.
            //      2. RETORNO VALOR / RESULTADO (opcional) - se puede devolver o no un resultado/dato (retur) al MAIN

            // Ejemplo A - por medio de una variable
            int n = devolverUno();
            Console.WriteLine("Fin del programa = " + n);
            // Ejemplo B - directamente
            Console.WriteLine("Fin del programa = " + devolverUno());

        }
        // Funcion DEVOLVERUNO - esta funcion devuelve el valor de la variables numero
        static int devolverUno(){
            int numero = 22;
            return numero;
        }
    }
}
