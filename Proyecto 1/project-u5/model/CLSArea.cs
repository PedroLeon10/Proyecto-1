using System;

namespace project_u5.model
{
    public class CLSArea
    {
        // Propiedades
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Ubicacion { get; set; }

        // Constructor con parámetros
        public CLSArea(int id, String nombre, String ubicacion)
        {
            ID = id;
            Nombre = nombre;
            Ubicacion = ubicacion;
        }

        // Constructor vacío
        public CLSArea()
        {
        }
    }
}
