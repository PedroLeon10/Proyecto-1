using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tarea_2._2.Model;
using Tarea_2._2.Data;

namespace Tarea_2._2.Data
{
    public class LibrosDAO
    {
        public void insertar(Libro l)
        {
            // Establecer la cadena de conexión
            string connectionString =
                "Data Source=DESKTOP-NO7QIT0\\MSSQLSERVER2;Initial Catalog=u2p2;User ID=sa;Password=root;";
            //string connectionString = "Data Source=Windows-Server;Initial Catalog=u2p2;User ID=sa;Password=La toalla del mojado69;";

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear una consulta SQL de inserción
                    string query = "insertar_libro";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    // Añadir parámetros a la consulta SQL
                    command.Parameters.AddWithValue("@isbn", l.Isbn);
                    command.Parameters.AddWithValue("@titulo", l.Titulo);
                    command.Parameters.AddWithValue("@numedicion", l.NumEdicion);
                    command.Parameters.AddWithValue("@aniopublicacion", l.AnioPublicacion);
                    command.Parameters.AddWithValue("@autores", l.Autores);
                    command.Parameters.AddWithValue("@paispublicacion", l.PaisPublicacion);
                    command.Parameters.AddWithValue("@sinopsis", l.Sinopsis);
                    command.Parameters.AddWithValue("@carrera", l.Carrera);
                    command.Parameters.AddWithValue("@materia", l.Material);

                    // Ejecutar la consulta SQL
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
        public List<Libro> Obtener()
        {
            string connectionString =
               "Data Source=DESKTOP-NO7QIT0\\MSSQLSERVER2;Initial Catalog=u2p2;User ID=sa;Password=root;";
            //string connectionString = "Data Source=Windows-Server;Initial Catalog=u2p2;User ID=sa;Password=La toalla del mojado69;";

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    List<Libro> libros = new List<Libro>();
                    // Abrir la conexión
                    connection.Open();

                    // Crear una consulta SQL de inserción
                    string query = "obtener_todos_los_libros";
                    SqlCommand command = new SqlCommand(query,connection);
                    command.CommandType = CommandType.StoredProcedure;
                    // Añadir parámetros a la consulta SQL
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Libro libro = new Libro();
                        libro.ID = Convert.ToInt32(sqlDataReader["id"]);
                        libro.Isbn = sqlDataReader["isbn"].ToString();
                        libro.Titulo = sqlDataReader["titulo"].ToString();
                        libro.NumEdicion = Convert.ToInt32(sqlDataReader["numEdicion"]);
                        libro.AnioPublicacion = Convert.ToInt32(sqlDataReader["anioPublicacion"]);
                        libro.Autores = sqlDataReader["autores"].ToString();
                        libro.PaisPublicacion = sqlDataReader["paisPublicacion"].ToString();
                        libro.Sinopsis = sqlDataReader["sinopsis"].ToString();
                        libro.Carrera = sqlDataReader["carrera"].ToString();
                        libro.Material = sqlDataReader["materia"].ToString();

                        libros.Add(libro);
                    }
                    return libros;                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return null;
        }
    }
}