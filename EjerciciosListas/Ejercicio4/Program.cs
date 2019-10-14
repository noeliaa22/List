using System;
using System.Collections.Generic; //IMPORTANTE
using System.Linq; //Para usar el Element At


namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una Lista denominada ListaCantantesFamosos que disponga de objetos de la clase CantanteFamoso. 
             * Debemos crear un método que permita añadir objetos de tipo CantanteFamoso a la lista. 
             * 
             * Un objeto de tipo CantanteFamoso tendrá como atributos nombre (String) y discoConMasVentas (String), 
             * y los métodos para obtener y establecer los atributos. 
             * 
             * Desde el main que inicializa la lista ListaCantantesFamosos y añade manualmente dos objetos de 
             * tipo CantanteFamoso a la la lista. Usando iterator muestra los nombres de cada cantante y su disco con más ventas 
             * por pantalla. 
             * 
             * Se debe pedir al usuario un nombre y disco con más ventas de otro cantante famoso, 
             * y una vez introducidos los datos mostrar la lista actualizada usando iterator. 
             * 
             * Una vez mostrada la lista actualizada, se debe dar opción a elegir entre volver a 
             * introducir los datos de otro cantante o salir del programa. */

            List<CantanteFamoso> ListaCantantesFamosos = new List<CantanteFamoso>()
            {
                new CantanteFamoso("Bon Jovi","Bounce"),
                new CantanteFamoso("Aerosmith","Rocks"),
                
            };

            foreach (CantanteFamoso cantante in ListaCantantesFamosos)
            {
                Console.WriteLine(cantante.Nombre + " " + cantante.DiscoConMasVentas); //nombre del elemento + el atributo de la lista
            }

            int decision;
            do
            {
                Console.WriteLine("Introduce el nombre de un cantante");
                string nombre = Console.ReadLine();
                Console.WriteLine("Introduce el disco más vendido de ese cantante");
                string disco = Console.ReadLine();                
                Add(new CantanteFamoso(nombre, disco),ListaCantantesFamosos);
                foreach (CantanteFamoso cantante in ListaCantantesFamosos)
                {
                    Console.WriteLine(cantante.Nombre + " " + cantante.DiscoConMasVentas); 
                }
                Console.WriteLine("\n\nSi desea volver a introducir un cantante pulse 1, en caso contrario pulse cualquier tecla");
                decision = Convert.ToInt32(Console.ReadLine());

            } while (decision==1);



        }

        public static void Add(CantanteFamoso cantanteFamoso, List<CantanteFamoso> lista)
        {
            lista.Add(cantanteFamoso);
           
        }
    }
}
