using System;
using System.Collections.Generic; //IMPORTANTE
using System.Linq; //Para usar el Element At

namespace EjerciciosListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> paises = new List<string>()
            //{
            //    "Francia","Holanda","Inglaterra","Polonia" //Una vez haces el inicio ya no puedes volver
            //};
            ////Añadir elementos individuales
            //paises.Add("Italia"); //Así se añade en la última posición
            
            ////Añadir en una posición
            //paises.Insert(3,"Austria"); //Si lo metes en posiciones posteriores (EJ:7) las anteriores son cadenas vacias
            
            ////Borrar desde una posición
            //paises.RemoveAt(3);
            
            ////Borrar un elemento
            //paises.Remove("Holanda");
           
            ////paises[2]
            //paises.ElementAt(2);

            //int posicion = paises.IndexOf("Francia"); // Te devuelve una posición, la primera, si no encuentra nada te devuelve -1.

            ////Recorrer una lista
            ////1º opción
            //for (int i = 0; i < paises.Count; i++)
            //{
            //    Console.WriteLine(paises[i]);
            //}
            ////2º opción: foreach
            //foreach (string elemento in paises)
            //{
            //    Console.WriteLine(elemento); //Te imprime todo, no se puede seleccionar
            //}

            //LISTAS CON OBJETOS

            //Creo los pasies
            Pais p1 = new Pais("Francia","Paris",200000);
            Pais p2 = new Pais("Italia","Roma",100000);
            Pais p3 = new Pais("Portugal","Lisboa",120000);

            //Creo una lista

            List<Pais> paises = new List<Pais>()
            {
                p1,p2,p3
            };

            ////Hacer el objeto dentro de la lista:
            List<Pais> paises2 = new List<Pais>()
            {
                new Pais("Francia","Paris",200000),
                new Pais("Italia", "Roma", 100000),
                new Pais("Portugal", "Lisboa", 120000),
            };


            //Recorrer la lista e imprimir los atributos de esa lista, con el foreach
            //No se puede imprimir un objeto, solo sus atributos

            foreach (Pais pais in paises)
            {
                Console.WriteLine(pais.Nombre+" "+pais.Capital); //nombre del elemento + el atributo de la lista
            }

            




        }
    }
}
