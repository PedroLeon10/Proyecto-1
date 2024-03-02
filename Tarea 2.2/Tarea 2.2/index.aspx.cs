using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea_2._2.Data;

namespace Tarea_2._2.Model
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        public void CargarTabla()
        {
            TableLibros.CellPadding = 10;
            TableHeaderRow table = new TableHeaderRow();
            TableHeaderCell isbn = new TableHeaderCell();
            TableHeaderCell titulo = new TableHeaderCell();
            TableHeaderCell numEdicion = new TableHeaderCell();
            TableHeaderCell anioPublicacion = new TableHeaderCell();
            TableHeaderCell autores = new TableHeaderCell();
            TableHeaderCell paisPublicacion= new TableHeaderCell();
            TableHeaderCell sinopsis = new TableHeaderCell();
            TableHeaderCell carrera = new TableHeaderCell();
            TableHeaderCell materia = new TableHeaderCell();

            isbn.Text = "Isbn";
            table.Cells.Add(isbn);
            
            titulo.Text = "Titulo";
            table.Cells.Add(titulo);
            
            numEdicion.Text = "Número de Edición";
            table.Cells.Add(numEdicion);

            anioPublicacion.Text = "Año de publicación";
            table.Cells.Add(anioPublicacion);

            autores.Text = "Autores";
            table.Cells.Add(autores);

            paisPublicacion.Text = "Pais de Publicación";
            table.Cells.Add(paisPublicacion);

            sinopsis.Text = "Sinopsis";
            table.Cells.Add(sinopsis);

            carrera.Text = "Carrera";
            table.Cells.Add(carrera);

            materia.Text = "Materia";
            table.Cells.Add(materia);

            TableLibros.Rows.Add(table);

            LibrosDAO librosDAO = new LibrosDAO();
            List<Libro> libros = new List<Libro>();
            libros = librosDAO.Obtener();
            if (libros != null)
            {
                TableRow fila = new TableRow();
                TableCell columna1 = new TableCell();
                TableCell columna2 = new TableCell();
                TableCell columna3 = new TableCell();
                TableCell columna4 = new TableCell();
                TableCell columna5 = new TableCell();
                TableCell columna6 = new TableCell();
                TableCell columna7 = new TableCell();
                TableCell columna8 = new TableCell();
                TableCell columna9 = new TableCell();
                foreach (Libro item in libros)
                {
                    fila = new TableRow();
                    columna1 = new TableCell();
                    columna2 = new TableCell();
                    columna3 = new TableCell();
                    columna4 = new TableCell();
                    columna5 = new TableCell();
                    columna6 = new TableCell();
                    columna7 = new TableCell();
                    columna8 = new TableCell();
                    columna9 = new TableCell();

                    columna1.Text = item.Isbn;
                    fila.Cells.Add(columna1);

                    columna2.Text = item.Titulo;
                    fila.Cells.Add(columna2);

                    columna3.Text = item.NumEdicion.ToString();
                    fila.Cells.Add(columna3);

                    columna4.Text = item.AnioPublicacion.ToString();
                    fila.Cells.Add(columna4);

                    columna5.Text = item.Autores;
                    fila.Cells.Add(columna5);

                    columna6.Text = item.PaisPublicacion;
                    fila.Cells.Add(columna6);

                    columna7.Text = item.Sinopsis;
                    fila.Cells.Add(columna7);

                    columna8.Text = item.Carrera;
                    fila.Cells.Add(columna8);

                    columna9.Text = item.Material;
                    fila.Cells.Add(columna9);

                    TableLibros.Rows.Add(fila);
                }
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarLibros.aspx");
        }
    }
}