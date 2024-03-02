using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Tarea_2._2.Model;

namespace Tarea_2._2.Data
{
    public class Conexion
    {
        public static SqlConnection connection;
        public static bool conectar()
        {
            // Establecer la cadena de conexión
            string connectionString =
                "Data Source=Windows-Server;Initial Catalog=u2p2;User ID=sa;Password=La toalla del mojado 69;";
            
            // Crear una conexión a la base de datos
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return false;
        }
    }
}