using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EjerciciosListas
{
    class Pais
    {
        public string Nombre { get; set; }
        public string Capital { get; set; }
        public int Poblacion { get; set; }

        public Pais(string nombre, string capital, int poblacion)
        {
            Nombre = nombre;
            Capital = capital;
            Poblacion = poblacion;
        }

        ////Ejercicio1
        //public void CreaLista(string nombre,string capital, int poblacion)
        //{
        //    List<string> paises = new List<string>();
        //}
        //public void MostrarLista(List<string> paises)
        //{
        //    new List<string>();
        //    foreach (Pais pais in paises)
        //    {
        //        Console.WriteLine(pais.Nombre + " " + pais.Capital+ " "+ pais.Poblacion); //nombre del elemento + el atributo de la lista
        //    }
        //}
        //public void OrdenarLista()
        //{
        //    List<string> paises = new List<string>();
        //    var ordenAl = paises.OrderBy(x => x).ToList();
        //}

    }
}
