using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea_2._2.Model
{
    public class Libro
    {
        public int ID { get; set; }
        public String Isbn { get; set; }
        public String Titulo { get; set; }
        public int NumEdicion { get; set; }
        public int AnioPublicacion { get; set; }
        public String Autores { get; set; }
        public String PaisPublicacion { get; set; }
        public String Sinopsis { get; set; }
        public String Carrera { get; set; }
        public String Material { get; set; }

        public Libro(int iD, string isbn, string titulo, int numEdicion, int anioPublicacion, string autores, 
            string paisPublicacion, string sinopsis, string carrera, string material)
        {
            ID = iD;
            Isbn = isbn;
            Titulo = titulo;
            NumEdicion = numEdicion;
            AnioPublicacion = anioPublicacion;
            Autores = autores;
            PaisPublicacion = paisPublicacion;
            Sinopsis = sinopsis;
            Carrera = carrera;
            Material = material;
        }
        public Libro()
        {
        }
    }
}