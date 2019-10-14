using System;
using System.Data.SqlClient;
using System.Collections.Generic; //IMPORTANTE
using System.Linq; //Para usar el Element At

namespace Ejercicio5
{
    class Program
    {
        static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F3J0NS5\\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");
        static void Main(string[] args)
        {
            /*Mediante los datos de la BBDD del Hotel, crear una clase Habitación y especificar los atributos
             * como las columnas de esa tabla. Una vez creada la clase, en el Program crear una 
             * lista de habitaciones en las que introduzcas los registros de esa tabla */

            List<Habitaciones> habitacion = new List<Habitaciones>();

            string query = $"SELECT* from Habitaciones"; 
            SqlCommand command = new SqlCommand(query, connection); //Conectar el comando con sql, SIEMPRE TIENE QUE ESTAR
            connection.Open(); //Abrir la conexión
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Habitaciones h1 = new Habitaciones(Convert.ToInt32(reader[0].ToString()),reader[1].ToString());
                habitacion.Add(h1);
            }

           Console.WriteLine("ID Habitación\tESTADO");
           Console.WriteLine("**********************");

            foreach (Habitaciones item in habitacion)
            {
                Console.WriteLine($"\t{item.Id}\t{item.Estado}");
            }


        }
    }
}
