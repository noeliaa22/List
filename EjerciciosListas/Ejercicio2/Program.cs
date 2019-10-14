using System;
using System.Collections.Generic; //IMPORTANTE
using System.Linq; //Para usar el Element At

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Lee por consola los números que introduzca el usuario. 
                Si el número introducido es decimal lo guardará en una lista de números decimales,.
                Si no es decimal entonces los guardará en una lista de ints. */
            /*El programa seguirá pidiendo al usuario que introduzca números hasta que introduzca un número negativo. Una vez haya introducido un número negativo: 
                Muestra cuántos números decimales y cuantos enteros ha creado. 
                Haz la suma de todos los números enteros introducidos.
                Saca la media de todos los números, tanto enteros como decimales JUNTOS.*/

            List<double> numerosDecimales = new List<double>();
            List<double> numerosEnteros = new List<double>();

            double numero;
            double media=0;           
            do
            {
                Console.WriteLine("Introduce un número");
                string valor = Console.ReadLine();
                numero = 0;
                if (Double.TryParse(valor, out numero))
                {

                if (numero % 1 == 0 && numero > 0)
                {
                    numerosEnteros.Add(numero);
                    Console.WriteLine($"{numero} se ha añadido a la lista de los numeros enteros");
                }
                else if (numero>0)
                {
                    numerosDecimales.Add(numero);
                    Console.WriteLine($"{numero} se ha añadido a la lista de los numeros decimales");
                }
                }
                else
                {
                    Console.WriteLine("Introduce un numero correcto");
                }

                media += numero;

            } while (numero>=0);

            foreach (double item in numerosDecimales)
            {
                Console.WriteLine(item);
            }

            foreach (double item in numerosEnteros)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine($"Se han añadido {numerosDecimales.Count} a la lista de números decimales ");
            Console.WriteLine($"Se han añadido {numerosEnteros.Count} a la lista de números enteros ");

            double suma=0;
            for (int i = 0; i < numerosEnteros.Count; i++)
            {
                suma += numerosEnteros[i];
            }

            Console.WriteLine($"La suma total de los números enteros es = {suma}");
            Console.WriteLine($"La media de los números introducidos es = {media/(numerosDecimales.Count+numerosEnteros.Count)}");


            /*OTRA OPCION:
             * 
             * double num=0;
             * int entero=0;
             * List<int> enteros=new List<int>();
             * List<double> decimales=new List<doouble>();
             * 
             * double media=0;
             * int suma=0;
             * do
             * {
             * 
             * C.W();
             * string numero= Console.ReadLine();
             * if(Int32.TryParse(numero, out entero))
             * {
             *  if(entero>=0)
             *  {
             * enteros.Add(entero);
             * suma+=entero;
             * media+=entero;
             *  }
             * }
             * else if (Double.TryParse(numero, out deci))
             * {
             * if(deci>=0)
             *  {
             * decimales.Add(deci) 
             * media+=deci;
             *  }
             * }
             * else
             * {
             * C.W("Introduce un número correcto");
             * }
             * while(deci>=0 && entero>=0)
             * 
             * 
             */


        }

    }
}
