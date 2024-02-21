using System;

namespace project_u5.model
{
    public class CLSInventario
    {
        // Propiedades
        public int ID { get; set; }
        public String AreaNombre
        {
            get { return Area.Nombre; }
        }
        public CLSArea Area { get; set; }
        public String NombreCorto { get; set; }
        public String Descripcion { get; set; }
        public String Serie { get; set; }
        public String Color {  get; set; } 
        public String FechaAdquision {  get; set; } 
        public String TipoAdquision {  get; set; } 
        public String Observaciones {  get; set; } 


        // Constructor con parámetros
        public CLSInventario(int id, CLSArea area, String nombreCorto, String descripcion, String serie, String color,
            String fechaAdquision, String tipoAdquision, String observaciones)
        {
            ID = id;
            Area = area;
            NombreCorto = nombreCorto;
            Descripcion = descripcion;
            Serie = serie;
            Color = color;
            FechaAdquision = fechaAdquision;
            TipoAdquision = tipoAdquision;
            Observaciones = observaciones;
        }

        // Constructor vacío
        public CLSInventario()
        {
        }
    }
}
