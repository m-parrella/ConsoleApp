using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace ConsoleApp 
{
    class Program
    {

        enum DiasSemana
        {
            Domingo = 1,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        };

        enum color { Blanco=0, Azul, Negro };

        static void Main(string[] args)
        {
            /*
             * Trabajo Practico Nro 1
             * Generalidades
             * Grupo 3
             */
            Console.WriteLine("Trabajo Practico Nro. 1");
            SumarNumero();
            DividirCadena();
            MostrarFecha();
            EnumerarDias();
            Convertir();
            Castear();
            SentenciaSwitch();
            SentenciaIf();
            SentenciaWhile();

            /*
             * ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas?
             * La instrucción for ejecuta una instrucción o un bloque de instrucciones mientras una expresión booleana especificada se evalúa como true.
             * La instrucción foreach ejecuta una instrucción o un bloque de instrucciones para cada elemento de una instancia del tipo que implementa la 
             * interfaz System.Collections.IEnumerable o System.Collections.Generic.IEnumerable<T>
             */

        }

        static void SumarNumero()
        {
            // Crear una función que devuelva la suma de dos números recibidos por parámetros
            Console.WriteLine("\nSumarNumero()");
            double num1 = 10.5;
            double num2 = 20.3;
            double resultado = num1 + num2;
            Console.WriteLine($"La suma de {num1} y {num2} es {resultado}");
        }

        static void DividirCadena()
        {
            // Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres.
            Console.WriteLine("\nDividirCadena()");
            string inputString = "12345678";
            int length = inputString.Length;
            int partsCount = (int)Math.Ceiling((double)length / 4);
            string[] parts = new string[partsCount];
            for (int i = 0; i < partsCount; i++)
            {
                int startIndex = Math.Max(length - (i + 1) * 4, 0);
                int partLength = Math.Min(4, length - startIndex);
                parts[i] = inputString.Substring(startIndex, partLength);
            }
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }

        static void MostrarFecha()
        {
            // Crear una función que devuelva la fecha y hora actual
            Console.WriteLine("\nMostrarFecha()");
            Console.WriteLine($"La fecha actual es: {DateTime.Now}");
        }

        static void EnumerarDias()
        {
            /*
             * Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1.
             * Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana
             */
            Console.WriteLine("\nEnumerarDias()");
            Console.WriteLine((int)DiasSemana.Jueves);
        }

        static void Convertir()
        {
            /* 
             * Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. 
             * Explique cómo responde en cada caso cada uno de los métodos indicados.
             */
            Console.WriteLine("\nConvertir()");
            bool unidadt = true;
            bool unidadf = false;
            Console.WriteLine(Convert.ToInt32(unidadt));
            Console.WriteLine(Convert.ToInt32(unidadf));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("false"));
            bool result;
            bool flag;
            string value = "true";
            result = Boolean.TryParse(value, out flag);
            Console.WriteLine("{0} --> {1} ", value, result);

        }

        static void Castear()
        {
            Console.WriteLine("\nCastear()");
            int a = (int)344.4;
            Console.WriteLine(a);
            decimal b = 10;
            Console.WriteLine(b);
            int c = 443444;
            short d = (short)c;
            Console.WriteLine(d);
        }

        static void SentenciaSwitch()
        {
            /* 
             * Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro)
             * y para cada caso indicar un mensaje de cual es el color informado.
             */
            Console.WriteLine("\nSentenciaSwitch()");
            color Color;
            string eleccion = "Azul";
            bool sucess = Enum.TryParse<color>(eleccion, out Color);

            switch (Color)
            {
                case color.Blanco:
                    Console.WriteLine("El color elegido es Blanco");
                    break;
                case color.Azul:
                    Console.WriteLine("El color elegido es Azul");
                    break;
                case color.Negro:
                    Console.WriteLine("El color elegido es Negro");
                    break;
                default:
                    Console.WriteLine("El color elegido es Incorrecto");
                    break;
            }
        }

        static void SentenciaIf()
        {
            /*
             * Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10.
             * Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10. 
             * Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error.
             */
            Console.WriteLine("\nSentenciaIf()");
            int a = 5;
            if (a > 10)
            {
                Console.WriteLine("El valor ingresado es mayor a 10");
            }
            else if (a >= 10)
            {
                Console.WriteLine("El valor ingresado es mayor o igual a 10");
            }
            else
            {
                Console.WriteLine("El valor ingresado es menor a 10");
            }
        }

        static void SentenciaWhile()
        {
            /*
             * Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5.
             * Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar.
             */
            Console.WriteLine("\nSentenciaWhile()");
            int i = 0;
            while (i <= 50)
            {
                Console.WriteLine(i);
                //i=i+5;
                i += 5;
            }
        }

    }

}