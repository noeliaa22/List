using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Habitaciones
    {
        private int v;
        private Func<string> toString;

        public int Id { get; set; }
        public string Estado { get; set; }

        public Habitaciones(int id, string estado)
        {
            Id = id;
            Estado = estado;
        }

        
    }
}
