using System;
using System.Collections.Generic; //IMPORTANTE
using System.Linq; //Para usar el Element At


namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Hay que crear 5 funciones:
                 Método CreaLista:                   
                 Método MostrarLista:                    
                 Crea un método OrdenarLista:                   
                 Crea un método BorrarDeLaLista:                    
                 Crea un método ContarElementos:*/

            List<string> frutas = new List<string>();

            frutas = CrearLista(frutas);
            //MostrarLista(frutas);
            //OrdenarLista(frutas);
            BorrarDeLaLista("Pera",frutas);
            BorrarDeLaLista("Pera",frutas);
            //Console.WriteLine(ContarElementos(frutas));
            
        }

        //Esta función recibirá por parámetro la lista que crearemos en el programa y 
        //la devolverá con datos.
        public static List<string> CrearLista(List<string> frutas)
        {
            frutas.Add("Manzana");
            frutas.Add("Pera");
            frutas.Add("Melocoton");
            return frutas;
        }

        //Esta función simplemente recibirá la lista por parámetro y la mostrará en pantalla.
        public static void MostrarLista(List<string> lista) //no tiene poqrque tener el mismo nombre que la lista
        {
            foreach (string elemento in lista)
            {
                Console.WriteLine(elemento); //nombre del elemento + el atributo de la lista
            }
        }

        // Ordena alfabéticamente la lista que reciba por parámetro.
        public static void OrdenarLista(List<string> lista)
        {
            //var ordenAl = lista.OrderBy(x => x).ToList();
            lista.Sort();
            MostrarLista(lista); //para que cuando llames al metodo te la muestre

        }

        //Recibirá un elemento y una lista por parámetro. Si encuentra el 
        //elemento en la lista lo borrara.
        public static void BorrarDeLaLista(string elemento, List<string> lista)
        {
            if (lista.Remove(elemento))
            {
                Console.WriteLine($"{elemento} borrado");
            }
            else
            {
                Console.WriteLine($"No se ha encontrado {elemento} en la lista");
            }
        }

        // Recibe una lista por parámetro y devuelve la cantidad de elementos en ella.
        public static int ContarElementos(List<string> frutas)
        {
            return frutas.Count;
        }


    }
}
